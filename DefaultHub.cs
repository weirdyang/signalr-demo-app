using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace SignalRDemoApp
{
    public class DefaultHub : Hub
    {
        public Task NotifyAll(object message)
        {
            return Clients.All.InvokeAsync("NotifyAll", message);
        }
    }
}