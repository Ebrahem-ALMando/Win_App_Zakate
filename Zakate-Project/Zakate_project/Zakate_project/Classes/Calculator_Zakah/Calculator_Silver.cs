using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zakate_project.Classes
{
    class Calculator_Silver
    {
        public double Nisab_silver(double caliber)
        {
            double z = 595 / (caliber / 1000);
            return z;
        }
        public double math_zaka_silver(double quntity_s, double caliber)// دالة حساب زكاة الفضة
        {
            if (quntity_s >= Nisab_silver(caliber))
            { 
                    return quntity_s * (2.5 / 100);
            }
            else
            {
                return -1;
            }
        }
    }
}
