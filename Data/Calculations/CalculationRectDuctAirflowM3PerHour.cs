using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKUWPFAppHVAC.Data.Calculations
{
    public class CalculationRectDuctAirflowM3PerHour
    {
        public double RectDuctAirflowCalc { get; set; }

        public double CalculateRectDuctAirflow(double rectDuctAirflowLS)
        {
            RectDuctAirflowCalc = Math.Round((rectDuctAirflowLS * 3.6), 2);
            return RectDuctAirflowCalc;
        }
    }
}
