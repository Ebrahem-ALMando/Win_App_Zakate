using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;
using Zakate_project.DB;

namespace Zakate_project.Reports
{
    public struct bydatareports
    {
        public string data { get; set; }
        public int TotleAmount { get; set; }

    }
   public class dashBord_Reports : Concition_Reports
    {
        //Fildes =>
        private DateTime start_date;
        private DateTime end_date;
        private int days;
        //properts
        public int Num_mozke { get; private set; }
        public int Num_mozke_in_date { get; private set; }

        public int Num_Projects { get; private set; }//Not values Time now
        public object sum_Monye { get; private set; }
        public int Num_Process { get; private set; }
        public int Num_Process_in_date { get; private set; }

        public int Num_Item { get; private set; }
        public int Num_Type { get; private set; }
        //-----------
        /// <summary>
        /// The Query that returns more than value
        public List<KeyValuePair<string, float>> TopItemList { get; private set; }
        public List<KeyValuePair<string, int>> LowItemList { get; private set; }
        public List<bydatareports> TotalProsgerList { get; private set; }
        //عدد المزكين خلال فترة معينة 
        public List<bydatareports> Count_Mozke{ get; private set; }
        /// </summary>

        static public int Process_pro { get; private set; }
        


        public dashBord_Reports()
        {

        }
        //  The Query that Return one Value
        public void GetNumberItem()
        {
            using (var conction = GetConction())//--Get Conction-- ==> Return The Server Conction .
            {
                conction.Open();
                using (var command = new SqlCommand())
                {
          


                    command.Connection = conction;
               
                    //Num Mozke
                    command.CommandText = "select COUNT(Don_Id) from Donors_Tbl";
                    Num_mozke = (int)command.ExecuteScalar();
                    //--We Used ExecuteScalar-- ==>Because it returns the first row of the first column of the query
                    //Num Item
                    command.CommandText = "select COUNT(Item_id) from Item_Tbl";
                    Num_Item = (int)command.ExecuteScalar();
                    // Num Type
                    command.CommandText = "select COUNT(Type_id) from Type_zakah_Tbl";
                    Num_Type = (int)command.ExecuteScalar();
                    //Sum Monye
                    command.CommandText = "select sum(quntity) from proceser_Tbl";
                    sum_Monye = command.ExecuteScalar();
                    //Num Process
                    command.CommandText = "select count(pros_id) from proceser_Tbl";
                    Num_Process = (int)command.ExecuteScalar();
                    //Num_Process_in_date
                    //command.CommandText = @"select COUNT(pros_id) from proceser_Tbl
                    //                        where Date_pros between @data_Start and @data_End";

                    //command.Parameters.Add("@data_Start", SqlDbType.DateTime).Value = start_date;
                    //command.Parameters.Add("@data_End", SqlDbType.DateTime).Value = end_date;
                    //Num_Process_in_date = (int)command.ExecuteScalar();
                    //Num_mozke in date_custom
                    //command.CommandText = @"select count( Donors_Tbl.Don_Id) from Donors_Tbl
                    //                      where Don_Id in (select proceser_Tbl.Don_id_FK from proceser_Tbl
                    //                      where proceser_Tbl.Date_pros between @start_date and @end_date)";
                    //command.Parameters.Add("@start_date", SqlDbType.DateTime).Value = start_date;
                    //command.Parameters.Add("@end_date", SqlDbType.DateTime).Value = end_date;
                    //Num_mozke_in_date = (int)command.ExecuteScalar();
                }
            }

        }
        //   The Query that returns more than  value

        public void GetNumberMozake()
        {
            
            using (var conction = GetConction())
            {
                TotalProsgerList = new List<bydatareports>();
                Process_pro = 0;

                conction.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection=conction;
         

                    //Num Process in date custom
                    command.CommandText = @"select proceser_Tbl.Date_pros ,count(pros_id) from proceser_Tbl
                                           where Date_pros between @Date_start  and @Date_end
                                           group by proceser_Tbl.Date_pros";
                    command.Parameters.Add("@Date_start", SqlDbType.DateTime).Value = start_date;
                    command.Parameters.Add("@Date_end", SqlDbType.DateTime).Value = end_date;
                    var reader = command.ExecuteReader();
                    var resultTable = new List<KeyValuePair<DateTime, int>>();
                    while (reader.Read())
                    {
                        resultTable.Add(new KeyValuePair<DateTime, int>((DateTime)reader[0], (int)reader[1]));
                        Process_pro += (int)reader[1];
                    }

                    reader.Close();

                    if (days <= 30)
                    {
                        foreach (var pros in resultTable)
                        {
                            TotalProsgerList.Add(new bydatareports()
                            {
                                data = pros.Key.ToString("dd MMM"),
                                TotleAmount = pros.Value
                            });


                        }
                    }
                    else if (days <= 92)
                    {

                        TotalProsgerList = (from proceser_Tbl in resultTable
                                            group proceser_Tbl by CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                                proceser_Tbl.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                           into Proc
                                            select new bydatareports
                                            {
                                       
                                                data = "Week " + Proc.Key.ToString(),
                                                TotleAmount = Proc.Sum(pro => pro.Value)
                                            }).ToList();
                    }
                    else if (days <= (365 * 2))
                    {
                        bool isYear = days <= 365 ? true : false;
                        TotalProsgerList = (from proceser_Tbl in resultTable
                                            group proceser_Tbl by proceser_Tbl.Key.ToString("MMM yyyy")
                                           into Proc
                                            select new bydatareports
                                            {
                                                data = isYear ? Proc.Key.Substring(0, Proc.Key.IndexOf(" ")) : Proc.Key,
                                                TotleAmount = Proc.Sum(pro => pro.Value)
                                            }).ToList();
                    }
                    else
                    {
                        TotalProsgerList = (from proceser_Tbl in resultTable
                                            group proceser_Tbl by proceser_Tbl.Key.ToString("yyyy")
                                           into Proc
                                            select new bydatareports
                                            {
                                                data = Proc.Key,
                                                TotleAmount = Proc.Sum(pro => pro.Value)
                                            }).ToList();

                    }

                }

            }
        }
        private void Get_item_sum_monye()
        {
          
            TopItemList = new List<KeyValuePair<string, float>>();
            using (var connection = GetConction())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    SqlDataReader reader;
                    //2022-12-30 00:00:00.000
                    command.CommandText = @"
                                               select top 5 Type_zakah_Tbl.Type_name ,SUM(quntity) from proceser_Tbl p inner join Type_zakah_Tbl
                                               on Type_zakah_Tbl.Type_id=p.Type_id_FK
                                               where p.Type_id_FK in(select t.Type_id from Type_zakah_Tbl T
                                               where T.Item_id_FK in (select I.Item_id from Item_Tbl I))
                                               and p.Date_Pros between '@data_Start' and '@data_End'
                                               group by Type_name
                                               order by sum(quntity) desc";
                    //command.Parameters.Add("@data_Start", System.Data.SqlDbType.DateTime).Value = start_date;
                    //command.Parameters.Add("@data_End", System.Data.SqlDbType.DateTime).Value = end_date;
                    reader = command.ExecuteReader();
                    //while (reader.Read())
                    //{
                    //    //TopItemList.Add(
                    //    //    new KeyValuePair<string, float>(reader[0].ToString(), (float)reader[1]));
                    //}
                    //reader.Close();
                    //اقل دخل
                    //command.CommandText = @"
                    //                           select top 5 Type_zakah_Tbl.Type_name ,SUM(quntity) from proceser_Tbl p inner join Type_zakah_Tbl
                    //                           on Type_zakah_Tbl.Type_id=p.Type_id_FK
                    //                           where p.Type_id_FK in(select t.Type_id from Type_zakah_Tbl T
                    //                           where T.Item_id_FK in (select I.Item_id from Item_Tbl I))
                    //                           and p.Date_Pros between @data_Start and @data_End
                    //                           group by Type_name
                    //                           order by sum(quntity) asc";
                    //command.Parameters.Add("@data_Start", System.Data.SqlDbType.DateTime).Value = start_date;
                    //command.Parameters.Add("@data_End", System.Data.SqlDbType.DateTime).Value = end_date;
                    //reader = command.ExecuteReader();
                    //while (reader.Read())
                    //{
                    //    LowItemList.Add(new KeyValuePair<string, int>(reader[0].ToString(), (int)reader[1]));
                    //}
                    //reader.Close();

                }
            }
        }
   
        public bool LoadData(DateTime startDate, DateTime endDate)
        {
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day,
                endDate.Hour, endDate.Minute, 59);
            if (startDate != this.start_date|| endDate != this.end_date)
            {
                this.start_date = startDate;
                this.end_date = endDate;
                this.days = (endDate - startDate).Days;
                GetNumberItem();
                GetNumberMozake();
                Get_item_sum_monye();
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
