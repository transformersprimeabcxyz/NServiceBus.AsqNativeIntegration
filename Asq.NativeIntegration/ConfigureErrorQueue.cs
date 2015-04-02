using NServiceBus.Config;
using NServiceBus.Config.ConfigurationSource;

namespace Asq.NativeIntegration
{
    class ConfigureErrorQueue : IProvideConfiguration<MessageForwardingInCaseOfFaultConfig>
    {
        public MessageForwardingInCaseOfFaultConfig GetConfiguration()
        {
            return new MessageForwardingInCaseOfFaultConfig
            {
                ErrorQueue = "error"
            };
        }
    }
}