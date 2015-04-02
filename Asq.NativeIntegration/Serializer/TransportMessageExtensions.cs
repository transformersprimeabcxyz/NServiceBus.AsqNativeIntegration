using System.Text;
using NServiceBus;
using NServiceBus.Unicast.Messages;

namespace Asq.NativeIntegration.Serializer
{
    static class TransportMessageExtensions
    {
        public static bool IsNativeMessage(this TransportMessage transportMessage)
        {
            return transportMessage.Headers != null && !transportMessage.Headers.ContainsKey(Headers.EnclosedMessageTypes);
        }

        public static bool IsControlMessage(this TransportMessage transportMessage)
        {
            return transportMessage.Headers != null &&
                   transportMessage.Headers.ContainsKey(Headers.ControlMessageHeader);
        }


        public static bool IsControlMessage(this LogicalMessage transportMessage)
        {
            return transportMessage.Headers != null &&
                   transportMessage.Headers.ContainsKey(Headers.ControlMessageHeader);
        }
    }
}