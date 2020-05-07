using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace Server
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            user = Context?.User?.Identity?.Name ?? user;
            await Clients.All.SendAsync($"ReceiveMessage", user, message);
        }
    }
}