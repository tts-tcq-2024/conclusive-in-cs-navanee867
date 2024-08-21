using conclusive.Entities;
using conclusive.Interfaces;

namespace conclusive
{
    public class EmailAlert : IAlertTarget
    {
        private readonly ILogger _logger;

        public EmailAlert(ILogger logger)
        {
            _logger = logger;
        }

        public void Alert(BreachType breachType)
        {
            string recepient = "a.b@c.com";

            Dictionary<BreachType, string> messages = new Dictionary<BreachType, string>
            {
                { BreachType.TOO_LOW, "Hi, the temperature is too low" },
                { BreachType.TOO_HIGH, "Hi, the temperature is too high" }
            };

            if (messages.ContainsKey(breachType))
            {
                _logger.Log($"To: {recepient}");
                _logger.Log(messages[breachType]);
            }
        }
    }
}
