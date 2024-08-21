using conclusive.Entities;
using conclusive.Helpers;
using Xunit;

namespace conclusive.Tests
{
    public class TypeWiseAlertTests
    {
        [Fact]
        public void InferBreach_ReturnsTooLow_WhenValueIsBelowLowerLimit()
        {
            Assert.Equal(BreachType.TOO_LOW, TypewiseAlertHelper.InferBreach(25, 30, 40));
        }

        [Fact]
        public void InferBreach_ReturnsTooHigh_WhenValueIsAboveUpperLimit()
        {
            Assert.Equal(BreachType.TOO_HIGH, TypewiseAlertHelper.InferBreach(45, 30, 40));
        }

        [Fact]
        public void InferBreach_ReturnsNormal_WhenValueIsWithinLimits()
        {
            Assert.Equal(BreachType.NORMAL, TypewiseAlertHelper.InferBreach(35, 30, 40));
        }

        [Fact]
        public void ClassifyTemperatureBreach_ReturnsNormal_WhenPassiveCoolingIsInControl()
        {
            Assert.Equal(BreachType.NORMAL, TypewiseAlertHelper.ClassifyTemperatureBreach(CoolingType.PASSIVE_COOLING, 25));
        }

        [Fact]
        public void ClassifyTemperatureBreach_ReturnsTooLow_WhenPassiveCoolingIsLow()
        {
            Assert.Equal(BreachType.TOO_LOW, TypewiseAlertHelper.ClassifyTemperatureBreach(CoolingType.PASSIVE_COOLING, -1));
        }

        [Fact]
        public void ClassifyTemperatureBreach_ReturnsTooHigh_WhenPassiveCoolingIsHigh()
        {
            Assert.Equal(BreachType.TOO_HIGH, TypewiseAlertHelper.ClassifyTemperatureBreach(CoolingType.PASSIVE_COOLING, 40));
        }

        [Fact]
        public void ClassifyTemperatureBreach_ReturnsTooLow_WhenMedActiveIsTooLow()
        {
            Assert.Equal(BreachType.TOO_LOW, TypewiseAlertHelper.ClassifyTemperatureBreach(CoolingType.MED_ACTIVE_COOLING, -1));
        }

        [Fact]
        public void ClassifyTemperatureBreach_ReturnsTooHigh_WhenMedActiveIsHigh()
        {
            Assert.Equal(BreachType.TOO_HIGH, TypewiseAlertHelper.ClassifyTemperatureBreach(CoolingType.MED_ACTIVE_COOLING, 45));
        }

        [Fact]
        public void ClassifyTemperatureBreach_ReturnsNormal_WhenMedActiveIsInControl()
        {
            Assert.Equal(BreachType.NORMAL, TypewiseAlertHelper.ClassifyTemperatureBreach(CoolingType.MED_ACTIVE_COOLING, 35));
        }

        [Fact]
        public void ClassifyTemperatureBreach_ReturnsTooLow_WhenCoolingTypeIsHiActiveIsTooLow()
        {
            Assert.Equal(BreachType.TOO_LOW, TypewiseAlertHelper.ClassifyTemperatureBreach(CoolingType.HI_ACTIVE_COOLING, -1));
        }

        [Fact]
        public void ClassifyTemperatureBreach_ReturnsTooHigh_WhenCoolingTypeIsHiActiveIsHigh()
        {
            Assert.Equal(BreachType.TOO_HIGH, TypewiseAlertHelper.ClassifyTemperatureBreach(CoolingType.HI_ACTIVE_COOLING, 50));
        }

        [Fact]
        public void ClassifyTemperatureBreach_ReturnsNormal_WhenCoolingTypeIsHiActiveIsInControl()
        {
            Assert.Equal(BreachType.NORMAL, TypewiseAlertHelper.ClassifyTemperatureBreach(CoolingType.HI_ACTIVE_COOLING, 45));
        }

    }
}