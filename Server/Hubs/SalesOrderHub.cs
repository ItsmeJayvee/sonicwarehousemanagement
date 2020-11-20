using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SonicWarehouseManagement.Server.Hubs
{
    public class SalesOrderHub : Hub
    {
        public async Task SendMessage()
        {
            await Clients.All.SendAsync("ReceiveMessage");
        }
    }
}
