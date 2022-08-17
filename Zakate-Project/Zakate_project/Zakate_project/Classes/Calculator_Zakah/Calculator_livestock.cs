using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zakate_project.Classes.Calculator_Zakah
{
    class Calculator_livestock
    {
        public int mos,tab,check,Bent,Haq,Check_Ibel;//=> جلب القيم

        public int math_zaka_Sheep(int quntity_L)
        {
            if (quntity_L < 40)
            {
                return -1;
            }
            else if (quntity_L < 121)
            {
                return 1;
            }
            else if (quntity_L >= 121 && quntity_L < 201)
            {
                return 2;
            }
            else if (quntity_L >= 201 && quntity_L < 400)
            {
                return 3;
            }
            else if (quntity_L >= 400)
            {
                return 4;
            }
            else
            {
                return -1;
            }
        }
        public string math_zaka_Cows(int quntity_C)
        {
            string resolt;
            if (quntity_C < 30)
            {

                return "لم يكتمل النصاب";
            }
            else
            {
                int C = quntity_C % 10;
                C = quntity_C - C;
                if (C % 30 == 0 && C % 40 == 0)
                {
                    check = 3;

                    mos = C / 40;
                    tab = C / 30;
                  resolt = "تبيع" + "[" + C / 30 + "]" + "\n -أو-\n" + "مسنة" + "[" + C / 40 + "]";
                    return resolt;
                }
                else if (C % 30 == 0)
                {
                    check = 2;

                    tab = C / 30;
                    resolt = "تبيع" + "[" + C / 30 + "]";
                    return resolt;
                }
               else if( (C % 40 == 0))
                {
                    check = 0;

                    mos = C / 40;
                    resolt = "مسنة" + "[" + C / 40 + "]";
                    return resolt;
                }
                else if (quntity_C > 40 && quntity_C <= 59)
                {
                    check = 0;
                    mos = 1;
                    resolt = "مسنة" + "[" + 1+ "]";

                    return resolt;
                }
                else
                {
                    int s = 0;
                do
                {
                        check = 1;
                    s += 1;
                    if ((C - (30 * s)) % 40 == 0)
                    {
                           
                        int res =( C - (30 * s)) / 40;
                            mos = res;
                            tab = s;
                            resolt = "تبيع" + "[" + s + "]" + "\n -و-\n" + "مسنة" + "[" + res + "]";

                            return resolt;

                    }
                    else if ((C - (40 * s)) % 30 == 0)
                    {
                        int res = (C - (40 * s)) / 30;
                            mos = res;
                            tab = s;
                            resolt = "تبيع" + "[" + res + "]" + "\n -و-\n" + "مسنة" + "[" + s + "]";
                            return resolt;
                    }

                }
                while (true);

            }
        }
        }
        public string math_zaka_Camel(int quntity_C)
        {
          
            int C = quntity_C % 10;
            C = quntity_C - C;
            string resolt;
            int i=0;
            //Condtion :=>

            if (quntity_C < 5)
            {
                return "لم تبلغ النصاب";
            }
            else {
             if (quntity_C >= 5 && quntity_C < 10)
                {
                    return "شاة واحدة";
                }
                else if (quntity_C >= 10 && quntity_C < 15)
                {
                    return "شاتان";
                }
                else if (quntity_C >= 15 && quntity_C < 20)
                {
                    return "ثلاث شياة";
                }
                else if (quntity_C >= 20 && quntity_C < 25)
                {
                    return "أربع شياة";
                }
                else if (quntity_C >= 25 && quntity_C < 36)
                {
                    return "بنت مخاض";
                }
                else if (quntity_C >= 36 && quntity_C < 46)
                {
                    return "بنت لبون";
                }
                else if (quntity_C >= 46 && quntity_C < 61)
                {
                    return "حقة";
                }
                else if (quntity_C >= 61 && quntity_C < 76)
                {
                    return "جذعة";
                }
                else if (quntity_C >= 76 && quntity_C < 91)
                {
                    return "بنتا لبون";
                }
                else if (quntity_C >= 91 && quntity_C < 121)
                {
                    return "حقًتان";
                }
                else if (C % 40 == 0 && C % 50 == 0)
                {
                    Check_Ibel = 1;
                    Bent = quntity_C / 40;
                    Haq = quntity_C / 50;
                    resolt = "بنت لبون" + "[" + quntity_C / 40 + "]" + "\n -أو-\n" + "حقة" + "[" + quntity_C / 50 + "]";

                    return resolt;
                }
                else if (C % 40 == 0)
                {
                    Check_Ibel = 2;
                    Bent = C / 40;
                    resolt = "بنت لبون" + "[" + C / 40 + "]";

                    return resolt;
                }
                else if (C % 50 == 0)
                {
                    Check_Ibel = 3;

                    Haq = C / 50;
                    resolt = "حقة" + "[" + C / 50 + "]";

                    return resolt;
                }
                else { 
                do
                {
                    check = 1;
                    i += 1;
                    if ((C - (40 * i)) % 50 == 0)
                    {
                            Check_Ibel = 4;
                            int res = (C - (40 * i)) / 50;
                            Haq = res;
                            Bent = i;
                            resolt = "حقة" + "[" + (C - (40 * i)) / 50 + "]" + "\n -و-\n" + "بنت لبون" + "[" + i + "]";
                            return resolt;
                    }
                    else if ((C - (50 * i)) % 40 == 0)
                    {
                            Check_Ibel = 5;
                            int res = (C - (50 * i)) / 40;
                        mos = res;
                        tab = i;
                            Bent = res;
                            Haq = tab;
                            resolt = "بنت لبون" + "[" + (C - (50 * i)) / 40 + "]" + "\n -و-\n" + "حقة" + "[" + i + "]";
                            return resolt;
                    }

                }
                while (true);
             
                

         

            }
            }
            
            }

        }
    }

