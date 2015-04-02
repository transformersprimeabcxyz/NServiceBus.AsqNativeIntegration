
using System.IO;
using System.Reflection;
using NServiceBus.Features;
using NServiceBus.Logging;

namespace Asq.NativeIntegration
{
    using NServiceBus;

    public class EndpointConfig : IConfigureThisEndpoint
    {
        public void Customize(BusConfiguration configuration)
        {
            configuration.DisableFeature<TimeoutManager>();
            configuration.DisableFeature<SecondLevelRetries>();
            configuration.DisableFeature<AutoSubscribe>();

            configuration.EndpointName("native-queue");
            configuration.UsePersistence<InMemoryPersistence>();
            configuration.UseTransport<AzureStorageQueueTransport>();

            var defaultLogFactory = LogManager.Use<DefaultFactory>();
            defaultLogFactory.Level(LogLevel.Debug);
            defaultLogFactory.Directory(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));

            //configuration.EnableFeature<>();
        }
    }
}
