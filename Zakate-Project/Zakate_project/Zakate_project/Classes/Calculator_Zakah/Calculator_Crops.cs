using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zakate_project.Classes.Calculator_Zakah
{
    class Calculator_Crops
    {
        public double math_Crops(double quntity_C,int select)
        {
            if (select == 1)
            {
                
                if(quntity_C>=653)
                {
                    double z = quntity_C * 0.1;
                    return z;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                if (quntity_C < 653)
                {
                    return -1;
                }
                else
                {
                    double z = quntity_C * 0.05;
                    return z;
                }
            }
        }
        }
    }

