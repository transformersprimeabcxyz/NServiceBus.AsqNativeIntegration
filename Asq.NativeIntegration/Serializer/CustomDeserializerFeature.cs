using NServiceBus.Features;
using NServiceBus.Pipeline;

namespace Asq.NativeIntegration.Serializer
{
    public class CustomDeserializerFeature : Feature
    {
        public CustomDeserializerFeature()
        {
            EnableByDefault();
        }

        protected override void Setup(FeatureConfigurationContext context)
        {
            context.Pipeline.Replace(WellKnownStep.DeserializeMessages, typeof(DeserializeBehavior));    
        }
    }
}