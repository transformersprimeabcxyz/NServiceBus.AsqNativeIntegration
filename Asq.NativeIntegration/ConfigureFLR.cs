using NServiceBus.Config;
using NServiceBus.Config.ConfigurationSource;

namespace Asq.NativeIntegration
{
    class ConfigureFLR : IProvideConfiguration<TransportConfig>
    {
        public TransportConfig GetConfiguration()
        {
            return new TransportConfig
            {
                MaxRetries = 3
            };
        }
    }
}