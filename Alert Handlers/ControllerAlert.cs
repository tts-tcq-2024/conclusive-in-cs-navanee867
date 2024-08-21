using conclusive.Entities;
using conclusive.Interfaces;

namespace conclusive
{
    public class ControllerAlert(ILogger logger) : IAlertTarget
    {
        private readonly ILogger _logger = logger;

        public void Alert(BreachType breachType)
        {
            const ushort header = 0xfeed;
            _logger.Log($"{header} : {breachType}");
        }
    }
}
