using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKUWPFAppHVAC.Model.Calculations
{
    public class CalculationPipes
    {


        public static double[] Interp(double[] x, double[] v, double[] xq)
        {
            var stepInterp = new MathNet.Numerics.Interpolation.StepInterpolation(x, v);
            return xq.Select(q => stepInterp.Interpolate(q)).ToArray();
        }

        public static Tuple<double, double> CalculateWaterProperties(double tSupply, double tReturn)
        {

            double[] temperatures = new double[16] { 0, 5, 10, 15, 20, 30, 40, 50, 60, 70, 80, 90, 100, 110, 120, 130};
            double[] densities = new double[16] { 1000, 1000, 999.59, 999.05, 998.23, 995.67, 992.24, 988.07, 983.24, 977.81, 971.83, 965.34, 958.38, 951, 943, 934.8};
            double[] heatingCapacities = new double[16] { 4202, 4202, 4192, 4186, 4182, 4178, 4179, 4181, 4185, 4190, 4196, 4205, 4216, 4233, 943, 934.8 };

            double tMedia = (tSupply + tReturn) / 2;
            double[] tMediaArray = new double[1] { tMedia };

            double waterDensity = Interp(temperatures, densities, tMediaArray).First();
            double heatingCapacity = Interp(temperatures, heatingCapacities, tMediaArray).First();

            return Tuple.Create(waterDensity, heatingCapacity);
        }

        public static Tuple<double, double, double> CalculateFlowFromByPower(double power, double tSupply, double tReturn)
        {
            double waterDensity = CalculateWaterProperties(tSupply, tReturn).Item1;
            double heatingCapacity = CalculateWaterProperties(tSupply, tReturn).Item2;
            double flowKgH = Math.Round(power * 3600 / ((tSupply - tReturn) * heatingCapacity),1);
            double flowM3H = Math.Round(flowKgH / waterDensity,3);
            double flowLS = Math.Round(flowKgH / 3600, 3);
            return Tuple.Create(flowM3H, flowKgH, flowLS);
        }

        public static double CalculateWaterVelocity(double pipeDiameter, double flowM3H)
        {
            double pipeSectionArea = Math.PI * Math.Pow((pipeDiameter/1000), 2) / 4;
            double waterVelocity = Math.Round(flowM3H / (pipeSectionArea * 3600),2);
            return waterVelocity;
        }

        public static Tuple<double, double> CalculateFlowByKnownM3H(double flowM3H)
        {
            double flowKgH = Math.Round(flowM3H * 990, 1);
            double flowLS = Math.Round(flowKgH / 3600, 3);
            return Tuple.Create(flowKgH, flowLS);
        }

        public static Tuple<double, double> CalculateFlowByKnownKgH(double flowKgH)
        {
            double flowM3H = Math.Round(flowKgH / 990, 3);
            double flowLS = Math.Round(flowKgH / 3600, 3);
            return Tuple.Create(flowM3H, flowLS);
        }

        public static Tuple<double, double> CalculateFlowByKnownLS(double flowLS)
        {
            double flowKgH = Math.Round(flowLS * 3600, 3);
            double flowM3H = Math.Round(flowKgH / 990, 3);
            return Tuple.Create(flowM3H, flowKgH);
        }

        public static string CheckVelocityValue(double value)
        {
            bool hasValue = !Double.IsNaN(value) && !Double.IsInfinity(value);
            string comment = "";
            if (hasValue == false)
            {
                comment = "Insert power and correct temperatures or dicactivate checkbox above 'Input power'";
            }
            return comment;
        }
    }
}
