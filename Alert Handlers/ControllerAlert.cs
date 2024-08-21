using conclusive.Entities;
using conclusive.Interfaces;

namespace conclusive
{
    public class ControllerAlert : IAlertTarget
    {
        private readonly ILogger _logger;

        public ControllerAlert(ILogger logger)
        {
            _logger = logger;
        }

        public void Alert(BreachType breachType)
        {
            const ushort header = 0xfeed;
            _logger.Log($"{header} : {breachType}");
        }
    }
}
