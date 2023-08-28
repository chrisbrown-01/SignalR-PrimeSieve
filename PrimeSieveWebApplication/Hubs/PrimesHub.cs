﻿using Microsoft.AspNetCore.SignalR;

namespace PrimeSieveWebApplication.Hubs
{
    public class PrimesHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
