using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zakate_project.Classes
{
    class Calculator_Gold
    {
        //دالة حساب النصاب للذهب حسب العيار
        public double gold_spotter(double caliber)
        {
            double z = 85 / (caliber / 24); 
            return z;
                
        }
        //دالة حساب نسبة الزكاة الواجبة عند بلوغ النصاب 
        public double math_zaka_gold(double quntity_G, double caliber)
        {
            if (quntity_G >= gold_spotter(caliber))
            {
                return quntity_G * (2.5 / 100);

            }
            else
            {
                return -1;
            }
        }
    }
}
