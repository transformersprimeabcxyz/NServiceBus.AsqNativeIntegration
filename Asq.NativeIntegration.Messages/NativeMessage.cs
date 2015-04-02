using NServiceBus;

namespace Asq.NativeIntegration.Messages
{
}

public class NativeMessage : IMessage
{
    public string Data { get; set; }
}
