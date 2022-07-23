using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKUWPFAppHVAC.Data.Calculations
{
    public class CalculationDucts
    {
        //Calculation Circular Duct Velocity
        public static double CalculateCircDuctVelocity(int circDuctDiameterCalc, int circDuctAirFlowCalc)
        {
            double sectionArea = 3.14 * Math.Pow(((double)circDuctDiameterCalc / 1000), 2) / 4;
            return Math.Round((circDuctAirFlowCalc / (sectionArea * 3600)), 2);
        }

        //Calculation Rectangular Duct Velocity
        public static double CalculateRectDuctVelocity(int rectDuctWidthCalc, int rectDuctHeightCalc, double rectDuctAirFlowCalc)
        {
            double equivalentDiameterRectDuct = 1.3 * (Math.Pow((rectDuctWidthCalc * rectDuctHeightCalc), 0.625) / Math.Pow((rectDuctWidthCalc + rectDuctHeightCalc), 0.25));
            double sectionAreaEquivDiam = 3.14 * Math.Pow((equivalentDiameterRectDuct / 1000), 2) / 4;
            return Math.Round((rectDuctAirFlowCalc / (sectionAreaEquivDiam * 3600)), 2);
        }

        //Calculation Duct Airflow Liter Per Second
        public static double CalculateDuctAirflowLS(int rectDuctAirflow)
        {
            return Math.Round((rectDuctAirflow / 3.6), 2);
        }

        //Calculation Duct Airflow M3 Per Hour
        public static int CalculateDuctAirflow(double rectDuctAirflowLS)
        {
            return (int)Math.Round((rectDuctAirflowLS * 3.6), 2);
        }
    }
}
