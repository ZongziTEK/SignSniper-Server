using Microsoft.AspNetCore.SignalR;

namespace SignSniper.Server
{
    public class QrHub : Hub
    {
        public async Task SendQrCode(string channel, string qrContent)
        {
            await Clients.Group(channel).SendAsync("ReceiveQrCode", qrContent);
        }

        public async Task Subscribe(string channel)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, channel);
        }

        public async Task Unsubscribe(string channel)
        {
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, channel);
        }
    }
}
