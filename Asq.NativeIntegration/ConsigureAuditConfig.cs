using NServiceBus.Config;
using NServiceBus.Config.ConfigurationSource;

namespace Asq.NativeIntegration
{
    class ConsigureAuditConfig : IProvideConfiguration<AuditConfig>
    {
        public AuditConfig GetConfiguration()
        {
            return new AuditConfig
            {
                QueueName = "audit"
            };
        }
    }
}