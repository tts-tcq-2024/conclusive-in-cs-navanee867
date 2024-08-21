using conclusive.Entities;

namespace conclusive.Interfaces
{
    /// <summary>
    /// Represents an alert target that can receive and handle alerts.
    /// </summary>
    public interface IAlertTarget
    {
        /// <summary>
        /// Sends an alert of the specified breach type to the target.
        /// </summary>
        /// <param name="breachType">The type of breach to alert.</param>
        void Alert(BreachType breachType);
    }
}
