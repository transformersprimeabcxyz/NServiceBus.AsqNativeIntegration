using NServiceBus;
using NServiceBus.Logging;

namespace Asq.NativeIntegration
{
    class StartStopLogger : IWantToRunWhenBusStartsAndStops
    {
        private ILog logger = LogManager.GetLogger<StartStopLogger>();
        public IBus Bus { get; set; }

        public void Start()
        {
            logger.Info("Bus Started.");
        }

        public void Stop()
        {
            logger.Info("Bus Stopped.");
        }
    }
}