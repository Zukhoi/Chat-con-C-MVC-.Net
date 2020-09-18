using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.SignalR;

namespace Chat
{
    public class ChatHub : Hub
    {  
            public void Send(string name, string message)
            {
            Clients.All.sendChat(name,message);
            }
        
    }
}