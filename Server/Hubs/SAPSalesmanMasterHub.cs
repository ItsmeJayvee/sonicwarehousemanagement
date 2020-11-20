using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SonicWarehouseManagement.Server.Hubs
{
    public class SAPSalesmanMasterHub : Hub
    {
        public async Task SendMessage()
        {
            await Clients.All.SendAsync("ReceiveMessage");
        }
    }
}
