using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKUWPFAppHVAC.Data.Calculations
{
    public class CalculationRectDuctAirflowLiterPerSecond
    {
        public double RectDuctAirflowLSCalc { get; set; }

        public double CalculateRectDuctAirflowLS(double rectDuctAirflow)
        {
            RectDuctAirflowLSCalc = Math.Round((rectDuctAirflow / 3.6), 2);
            return RectDuctAirflowLSCalc;
        }
    }
}
