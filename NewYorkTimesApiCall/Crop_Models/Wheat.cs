using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crop_Models
{
    public class Wheat
    {
        string GrowTime;
        string SunlightExposureTime;
        string SoilConditions;
        string WaterFrequency;
        string Tools;

        double CostPerAcre;
        double YieldperAcre;
        double ReturnPerAcre;

        public Wheat()
        {
            GrowTime = "120 if planted in spring 240 if planted in fall";
            SunlightExposureTime = "full sun cycle";
            SoilConditions = "clay loam soil pH level between 6.0 and 7.0";
            WaterFrequency = "12-15 inches of rain over growing season";
            Tools = "Tools: pickaxe, hoe, and spade";
            YieldperAcre = 68.9;
            CostPerAcre = 327.16;
            ReturnPerAcre = 333.05;
        }

        public string EconInfo()
        {
            return "Cost per acre: " + CostPerAcre + "\n" + "Return per acre: " + ReturnPerAcre + "\n" +
            "Yield per acre: " + YieldperAcre + "\n";

        }

        public string PlantingInfo()
        {
            return "Grow time of crop: " + GrowTime + "\n" + "Soil conditions: " + SoilConditions + "\n" + "Sunlight needs of crop: " +
                SunlightExposureTime + "\n" + "Water frequency of crop: " + WaterFrequency + "\n" + "Tools required for crop: " + Tools + "\n";
        }

        public double CostCalculator(int _acres)
        {
            
            double product = _acres * CostPerAcre;

            return product;
        }

        public double ReturnCalculator(int _acres)
        {
            double product = _acres * ReturnPerAcre;

            return product;
        }


    }
}
