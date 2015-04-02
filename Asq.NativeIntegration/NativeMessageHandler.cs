using System;
using NServiceBus;

namespace Asq.NativeIntegration
{
    public class NativeMessageHandler : IHandleMessages<NativeMessage>
    {
        public void Handle(NativeMessage message)
        {
            Console.WriteLine("Received native message: " + message.Data);
        }
    }
}