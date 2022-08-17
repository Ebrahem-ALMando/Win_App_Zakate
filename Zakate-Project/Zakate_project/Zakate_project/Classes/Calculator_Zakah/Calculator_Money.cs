using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zakate_project.Classes.Calculator_Zakah
{
    class Calculator_Money
    {
        public double check=-1;//معرفة الحساب على اي نصاب 
        Calculator_Gold gold_math = new Calculator_Gold();
        Calculator_Silver Silver_math = new Calculator_Silver();
        public double math_zaka_money_gold(double amount, double caliber, double Price_gold)// دالة حساب زكاة المال حسب نصاب الذهب
        {
            if (amount >= money_gold_spotter(caliber,Price_gold))
                return amount * (2.5 / 100);
            else
                return -1;
        }
        public double math_zaka_money_Silver(double amount, double caliber, double Price_Silver)// دالة حساب زكاة المال حسب نصاب الفضة
        {
            if (amount >= money_Silver_spotter(caliber, Price_Silver))
                return amount * (2.5 / 100);
            else
                return -1;
        }
        public double math_zaka_money_Low(double amount, double caliber_gold, double caliber_Silver
            , double Price_gold, double Price_Silver)// دالة حساب زكاة المال حسب اقل النصابين
        {
            if(amount>=money_gold_spotter(caliber_gold,Price_gold)&&
                amount >= money_Silver_spotter(caliber_Silver, Price_Silver))
            {
                check= 2;
                return math_zaka_money_gold(amount, caliber_gold, Price_gold);
            }

           else if (amount >= money_Silver_spotter(caliber_Silver, Price_Silver))
            {
                check = 595;
                return math_zaka_money_Silver(amount, caliber_Silver, Price_Silver);

            }
            else if (amount>= money_gold_spotter(caliber_gold, Price_gold))
            {
                check = 85;
                return math_zaka_money_gold(amount, caliber_gold, Price_gold);
            }

            else
            {
                check = -1;
                return -1;
            }
                
        }
        //نصاب المال حساب نصاب الذهب
        public double money_gold_spotter(double caliber,double Price_gold)
        {
            double z = gold_math.gold_spotter(caliber) * Price_gold;
            return z;
        }
        //نصاب المال حساب نصاب الفضة

        public double money_Silver_spotter(double caliber, double Price_Silver)
        {
            double z = Silver_math.Nisab_silver(caliber) * Price_Silver;
            return z;
        }
    }
    
}
