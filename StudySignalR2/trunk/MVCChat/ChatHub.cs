using Microsoft.AspNet.SignalR;

namespace MVCChat
{
    public class ChatHub : Hub
    {
        /// <summary>
        /// 向客户端发送消息
        /// </summary>
        /// <param name="name"></param>
        /// <param name="message"></param>
        public void Send(string name, string message)
        {
            Clients.All.addNewMessageToPage(name, message);
        }
    }
}