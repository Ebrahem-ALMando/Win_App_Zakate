using Zakate_project.DB;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Zakate_project.models
{
    public struct RevenueByDate
    {
        public string Date { get; set; }
        public decimal TotalAmount { get; set; }
    }

    public class Dashboard : DbConnection
    {
        //Fields & Properties
        private DateTime startDate;
        private DateTime endDate;
        private int numberDays;

        /// <summary>
       
        public int Num_mozke_in_date { get; private set; }
        public int Num_Process_in_date { get; private set; }

        public int Num_Process { get; private set; }


        public int Num_Item { get; private set; }
        public int Num_Type { get; private set; }
        /// </summary>
        public int Num_mozke { get; private set; }
        public int Num_Projects { get; private set; }//Not values Time now
        public decimal sum_Monye { get; private set; }
        /// The Query that returns more than value
        public List<KeyValuePair<string, decimal>> TopitemList { get; private set; }
        public List<KeyValuePair<string, decimal>> LowtypeList { get; private set; }
        public List<RevenueByDate> GrossRevenueList { get; private set; }
        public decimal Sum_Money { get; set; }
     

        //Constructor
        public Dashboard()
        {

        }

        //Private methods
        private void GetNumberItems()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    ///
                    //--We Used ExecuteScalar-- ==>Because it returns the first row of the first column of the query
                    command.Connection = connection;
                    //Get Total Number of Donors
                    command.CommandText = "select COUNT(Don_Id) from Donors_Tbl";
                    Num_mozke = (int)command.ExecuteScalar();

                    //Get Total Number of process
                    command.CommandText = "select count(pros_id) from proceser_Tbl";
                    Num_Process = (int)command.ExecuteScalar();

                    //Get Total Sum of Monye
                    command.CommandText = "select sum(quntity) from proceser_Tbl";
                    sum_Monye = (decimal)command.ExecuteScalar();

                    //Get Total Number of Item
                    command.CommandText = "select COUNT(Item_id) from Item_Tbl";
                    Num_Item = (int)command.ExecuteScalar();
                    // Get Total Number of Type
                    command.CommandText = "select COUNT(Type_id) from Type_zakah_Tbl";
                    Num_Type = (int)command.ExecuteScalar();

                    //Num_Process_in_date
                    command.CommandText = @"select COUNT(pros_id) from proceser_Tbl
                                            where Date_pros between @data_Start and @data_End";

                    command.Parameters.Add("@data_Start", SqlDbType.DateTime).Value = startDate;
                    command.Parameters.Add("@data_End", SqlDbType.DateTime).Value = endDate;
                    Num_Process_in_date = (int)command.ExecuteScalar();

                    //Num_mozke in date_custom
                    command.CommandText = @"select count( Donors_Tbl.Don_Id) from Donors_Tbl
                                          where Don_Id in (select proceser_Tbl.Don_id_FK from proceser_Tbl
                                          where proceser_Tbl.Date_pros between @start_date and @end_date)";
                    command.Parameters.Add("@start_date", SqlDbType.DateTime).Value = startDate;
                    command.Parameters.Add("@end_date", SqlDbType.DateTime).Value = endDate;
                    Num_mozke_in_date = (int)command.ExecuteScalar();
                }
            }
        }
        private void GetProductAnalisys()
        {
            TopitemList = new List<KeyValuePair<string, decimal>>();
            LowtypeList = new List<KeyValuePair<string, decimal>>();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    SqlDataReader reader;
                    command.Connection = connection;
                    //Get Top 5 Item
                    command.CommandText = @"  select top 5 Item_name,Sum (quntity) from Item_Tbl inner Join proceser_Tbl p
                                            	on Item_id =id_item_FK
                                            	where p.Date_Pros between @fromDate and @toDate
                                            	group by Item_name
                                            	order by Sum (quntity)desc
                                            ";
                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = startDate;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = endDate;
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        TopitemList.Add(
                            new KeyValuePair<string, decimal>(reader[0].ToString(), (decimal)reader[1]));
                    }
                    reader.Close();

                    //Lowest type of zakat income
                    command.CommandText = @"select top 5 Type_name ,Sum (quntity)from Type_zakah_Tbl t
		                                           inner join Item_Tbl i
		                                           	on i.Item_id=t.Item_id_FK
		                                           inner join proceser_Tbl p
		                                           	on t.Type_name=p.Type_id_FK
		                                           group  by Type_name
		                                           order by Sum (quntity) asc";
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        LowtypeList.Add(
                            new KeyValuePair<string, decimal>(reader[0].ToString(), (decimal)reader[1]));
                    }
                    reader.Close();
                }
            }
         }
        private void GetOrderAnalisys()
        {
            GrossRevenueList = new List<RevenueByDate>();
            Sum_Money = 0;

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"select proceser_Tbl.Date_pros ,sum(quntity) from proceser_Tbl
                                           where Date_pros between @fromDate and @toDate
                                           group by proceser_Tbl.Date_pros";
                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = startDate;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = endDate;
                    var reader = command.ExecuteReader();
                    var resultTable = new List<KeyValuePair<DateTime, decimal>>();
                    while (reader.Read())
                    {
                        resultTable.Add(
                            new KeyValuePair<DateTime, decimal>((DateTime)reader[0], (decimal)reader[1])
                            );
                        Sum_Money+= (decimal)reader[1];
                    }
                    reader.Close();

                    //Group by Hours
                    if (numberDays <= 1)
                    {
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by orderList.Key.ToString("hh tt")
                                           into order
                                            select new RevenueByDate
                                            {
                                                Date = order.Key,
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }
                    //Group by Days
                    else if (numberDays <= 30)
                    {
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by orderList.Key.ToString("dd MMM")
                                           into order
                                            select new RevenueByDate
                                            {
                                                Date = order.Key,
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }

                    //Group by Weeks
                    else if (numberDays <= 92)
                    {
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                                orderList.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                           into order
                                            select new RevenueByDate
                                            {
                                                Date = "Week " + order.Key.ToString(),
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }

                    //Group by Months
                    else if (numberDays <= (365 * 2))
                    {
                        bool isYear = numberDays <= 365 ? true : false;
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by orderList.Key.ToString("MMM yyyy")
                                           into order
                                            select new RevenueByDate
                                            {
                                                Date = isYear ? order.Key.Substring(0, order.Key.IndexOf(" ")) : order.Key,
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }

                    //Group by Years
                    else
                    {
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by orderList.Key.ToString("yyyy")
                                           into order
                                            select new RevenueByDate
                                            {
                                                Date = order.Key,
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }
                }
            }
        }

        //Public methods
        public bool LoadData(DateTime startDate, DateTime endDate)
        {
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day,
                endDate.Hour, endDate.Minute, 59);
            if (startDate != this.startDate || endDate != this.endDate)
            {
                this.startDate = startDate;
                this.endDate = endDate;
                this.numberDays = (endDate - startDate).Days;

                GetNumberItems();
                GetProductAnalisys();
                GetOrderAnalisys();
                Console.WriteLine("Refreshed data: {0} - {1}", startDate.ToString(), endDate.ToString());
                return true;
            }
            else
            {
                Console.WriteLine("Data not refreshed, same query: {0} - {1}", startDate.ToString(), endDate.ToString());
                return false;
            }
        }
    }
}



