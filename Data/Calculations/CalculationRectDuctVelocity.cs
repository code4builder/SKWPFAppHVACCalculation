using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKUWPFAppHVAC.Data.Calculations
{
    public class CalculationRectDuctVelocity
    {
        public double RectDuctVelocityCalc { get; private set; }

        public double CalculateRectDuctVelocity(int rectDuctWidthCalc, int rectDuctHeightCalc, double rectDuctAirFlowCalc)
        {
            double equivalentDiameterRectDuct = 1.3 * (Math.Pow((rectDuctWidthCalc * rectDuctHeightCalc), 0.625) / Math.Pow((rectDuctWidthCalc + rectDuctHeightCalc), 0.25));
            double sectionAreaEquivDiam = 3.14 * Math.Pow((equivalentDiameterRectDuct / 1000), 2) / 4;
            RectDuctVelocityCalc = Math.Round((rectDuctAirFlowCalc / (sectionAreaEquivDiam * 3600)), 2);
            return RectDuctVelocityCalc;

        }
    }
}
