using NServiceBus.Config;
using NServiceBus.Config.ConfigurationSource;

namespace Asq.NativeIntegration
{
    class ConfigureAzureTransportConfig : IProvideConfiguration<AzureQueueConfig>
    {
        public AzureQueueConfig GetConfiguration()
        {
            return new AzureQueueConfig
            {
                ConnectionString = "UseDevelopmentStorage=true"
            };
        }
    }
}