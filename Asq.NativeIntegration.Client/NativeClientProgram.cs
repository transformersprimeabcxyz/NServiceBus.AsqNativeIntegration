using System;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Queue;

namespace Asq.NativeIntegration.Client
{
    class NativeClientProgram
    {
        static void Main(string[] args)
        {
            var account = CloudStorageAccount.DevelopmentStorageAccount;
            var queueClient = account.CreateCloudQueueClient();
            var queue = queueClient.GetQueueReference("native-queue");
            queue.CreateIfNotExists();

            Console.WriteLine("press any key to send a message, ESC to exit.");

            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                // JSON.NET
                var message = new CloudQueueMessage(@"{'$type':'NativeMessage', 'Data': 'native msg @ " + DateTime.Now.ToString("HH:mm:ss") + "'}");
                // XML
                //var message = new CloudQueueMessage(@"<NativeMessage><Data>hello from linqpad " + DateTime.Now.ToString("HH:mm:ss") + "</Data></NativeMessage>");
                queue.AddMessage(message);
                Console.WriteLine("TestIt message added to queue " + queueClient.StorageUri.PrimaryUri);
            }
        }
    }
}
