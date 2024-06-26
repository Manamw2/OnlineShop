using Microsoft.AspNetCore.SignalR;

namespace Server.Hubs
{
    public class ChatHub : Hub
    {
        // Method called by clients to send messages
        public async Task SendMessage(string user, string message)
        {
            // Broadcasts the received message to all connected clients
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
