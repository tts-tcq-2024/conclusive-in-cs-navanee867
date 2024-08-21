using conclusive.Entities;
using conclusive.Interfaces;

namespace conclusive.Helpers
{

    public class TypewiseAlertHelper
    {
        public static BreachType InferBreach(double value, double lowerLimit, double upperLimit)
        {
            if (value < lowerLimit)
            {
                return BreachType.TOO_LOW;
            }
            if (value > upperLimit)
            {
                return BreachType.TOO_HIGH;
            }
            return BreachType.NORMAL;
        }

        public static BreachType ClassifyTemperatureBreach(CoolingType coolingType, double temperatureInC)
        {
            var (lowerLimit, upperLimit) = GetTemperatureLimits(coolingType);
            return InferBreach(temperatureInC, lowerLimit, upperLimit);
        }

        private static (double lowerLimit, double upperLimit) GetTemperatureLimits(CoolingType coolingType)
        {
            return (GetLowerLimit(coolingType), GetUpperLimit(coolingType));
        }

        private static double GetUpperLimit(CoolingType coolingType)
        {
            return coolingType switch
            {
                CoolingType.PASSIVE_COOLING => 35,
                CoolingType.MED_ACTIVE_COOLING => 40,
                CoolingType.HI_ACTIVE_COOLING => 45,
                _ => throw new ArgumentException("Invalid cooling type", nameof(coolingType))
            };
        }

        private static double GetLowerLimit(CoolingType coolingType)
        {
            return 0;
        }

        public static void CheckAndAlert(IAlertTarget alertTarget, BatteryCharacter batteryChar, double temperatureInC)
        {
            BreachType breachType = ClassifyTemperatureBreach(batteryChar.coolingType, temperatureInC);
            alertTarget.Alert(breachType);
        }
    }
}
