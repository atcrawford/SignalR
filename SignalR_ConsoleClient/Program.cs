using System;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR.Client.Hubs;

namespace SignalR_ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            RunAsync().Wait();
        }

        private static async Task RunAsync()
        {
            var connection = new HubConnection("http://localhost:59535/");
            IHubProxy stall = connection.CreateHubProxy("changeState");

            Action<bool> stateChanged = b => Console.WriteLine("IsOccuppied == " + b + ". Press enter to change...");

            stall.On<bool>("stateChanged", stateChanged);

            await connection.Start();
            
            await stall.Invoke("GetState");
             
            while ((Console.ReadLine()) != null)
            {
                await stall.Invoke("changeState");
            }
        }
    }
}
