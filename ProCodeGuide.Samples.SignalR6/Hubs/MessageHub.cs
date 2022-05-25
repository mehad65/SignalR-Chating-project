using Microsoft.AspNetCore.SignalR;

namespace ProCodeGuide.Samples.SignalR6.Hubs
{
    public class MessageHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            string[] a = new string[] { user, "2dbafb51-ddd0-436d-90e7-1aa6ab37354f" };
            if (string.IsNullOrEmpty(user))
                await Clients.All.SendAsync("ReceiveMessageHandler", message);
            else
                await Clients.Users(a).SendAsync("ReceiveMessageHandler", message);
        }
    }
}
