using conclusive.Entities;
using conclusive.Interfaces;

namespace conclusive
{
    public class EmailAlert(ILogger logger) : IAlertTarget
    {
        private readonly ILogger _logger = logger;

        public void Alert(BreachType breachType)
        {
            string recepient = "a.b@c.com";
            switch (breachType)
            {
                case BreachType.TOO_LOW:
                    _logger.Log($"To: {recepient}");
                    _logger.Log("Hi, the temperature is too low");
                    break;
                case BreachType.TOO_HIGH:
                    _logger.Log($"To: {recepient}");
                    _logger.Log("Hi, the temperature is too high");
                    break;
                case BreachType.NORMAL:
                    break;
            }
        }
    }
}
