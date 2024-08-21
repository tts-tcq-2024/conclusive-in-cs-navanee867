using conclusive.Tests;

namespace conclusive
{
    public class TypeWiseAlert
    {
        public static void Main(string[] args)
        {
            var test = new TypeWiseAlertTests();

            test.InferBreach_ReturnsTooLow_WhenValueIsBelowLowerLimit();
            test.InferBreach_ReturnsTooHigh_WhenValueIsAboveUpperLimit();
            test.InferBreach_ReturnsNormal_WhenValueIsWithinLimits();

            test.ClassifyTemperatureBreach_ReturnsTooLow_WhenPassiveCoolingIsLow();
            test.ClassifyTemperatureBreach_ReturnsNormal_WhenPassiveCoolingIsInControl();
            test.ClassifyTemperatureBreach_ReturnsTooHigh_WhenPassiveCoolingIsHigh();

            test.ClassifyTemperatureBreach_ReturnsTooLow_WhenMedActiveIsTooLow();
            test.ClassifyTemperatureBreach_ReturnsNormal_WhenMedActiveIsInControl();
            test.ClassifyTemperatureBreach_ReturnsTooHigh_WhenMedActiveIsHigh();

            test.ClassifyTemperatureBreach_ReturnsTooLow_WhenCoolingTypeIsHiActiveIsTooLow();
            test.ClassifyTemperatureBreach_ReturnsNormal_WhenCoolingTypeIsHiActiveIsInControl();
            test.ClassifyTemperatureBreach_ReturnsTooHigh_WhenCoolingTypeIsHiActiveIsHigh();
        }
    }
}
