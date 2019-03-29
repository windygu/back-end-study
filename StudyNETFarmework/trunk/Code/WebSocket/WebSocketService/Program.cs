using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WebSocketService
{
    class Program
    {
        //static HttpListener listener;
        //static IList<WebSocket> webSockets = new List<WebSocket>();
        //static string ip = "127.0.0.1", port= "8181";
       static  Core.WebSocketService service;
        static void Main(string[] args)
        {
            var serviceConfig = Config.ConfigHelper.ServiceConfig;
            Console.Title = $"WebSocket服务器【{serviceConfig.Ip}:{serviceConfig.Port}】";
            Console.WriteLine($"版本:{Environment.Version.ToString(4)}");
            ThreadPool.SetMaxThreads(serviceConfig.MaxThreadCount, serviceConfig.MaxThreadCount);
            service = new Core.WebSocketService(serviceConfig.Ip, serviceConfig.Port, serviceConfig.WebSocketSubProtocol);

            service.OnRegisterMessage += Service_OnRegisterMessage;

            service.Start();

            System.Timers.Timer timer = new System.Timers.Timer(10 * 1000);
            timer.Elapsed += Timer_Elapsed;
            timer.Enabled = true;
            timer.AutoReset = true;
            timer.Start();

            Console.ReadLine();

            //Console.WriteLine("WebSotcket 测试");
            //Console.WriteLine("开启WebSocket服务");
            //webSockets.Add(StartWebSocketAsync().Result);
            //Console.WriteLine("WebSocket服务开启成功！");

            //Console.WriteLine("接收WebSocket消息中。。。");

            //Task.Factory.StartNew(WawitGetContext);

            //Console.WriteLine("输入Exit退出服务！");
            //var key = Console.ReadLine();
            //while (!key.Equals("Exit"))
            //{
            //    key = Console.ReadLine();
            //}
        }

        private static void Service_OnRegisterMessage(Core.WebSocketContext context, string message)
        {
            var list = service.WebSocketContexts.Where(p => p.ID != context.ID);
            foreach(var item in list)
            {
                item.SendMessageAsync($"{context.ID}说：{message}").Wait();
                //ThreadPool.QueueUserWorkItem(new WaitCallback(p =>
                //{
                //    (p as Core.WebSocketContext).SendMessageAsync($"{context.ID}说：{message}").Wait();
                //}), item);
            }
        }

        private static void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine($"操作系统内存页字节数【{Environment.SystemPageSize}】");
            Console.WriteLine($"内存使用量【{Environment.WorkingSet}】");
            Console.WriteLine($"客户端连接数量【{service.WebSocketContexts.Count}】");
            int workerThreads = 0, completionPortThreads=0;
            ThreadPool.GetAvailableThreads(out workerThreads, out completionPortThreads);
            Console.WriteLine($"可用线程数量【{workerThreads},{workerThreads}】");
            ThreadPool.GetMaxThreads(out workerThreads, out completionPortThreads);
            Console.WriteLine($"最大可用线程数量【{workerThreads},{workerThreads}】");
            ThreadPool.GetMinThreads(out workerThreads, out completionPortThreads);
            Console.WriteLine($"最小可用线程数量【{workerThreads},{workerThreads}】");
        }
        

        // 开启 webSocket
        //static async Task<WebSocket> StartWebSocketAsync()
        //{
        //    listener = new HttpListener();
        //    listener.AuthenticationSchemes = AuthenticationSchemes.Anonymous;
        //    listener.Prefixes.Add($"http://{ip}:{port}/");
        //    listener.Start();
        //    // 等待连接
        //    var context = await listener.GetContextAsync();
        //    //var Name = context.Request.QueryString["Name"];
        //    //var ID = context.Request.QueryString["ID"];

        //    // 接受webSocket
        //    var wsContext = await context.AcceptWebSocketAsync(null, TimeSpan.FromSeconds(20));
        //    var WebSocket = wsContext.WebSocket;
        //    Console.WriteLine("WebSocket connect");
        //    return WebSocket;
        //}

        static void  WawitGetContext()
        {
            //var WebSocket = webSockets.FirstOrDefault();
            ////接收数据
            //ArraySegment<byte> abuf = new ArraySegment<byte>(new byte[10240]);
            //CancellationToken cancel = new CancellationToken();
            //byte[] buf = new byte[10240];

            //// 开始异步接收数据
            //var wsdata = WebSocket.ReceiveAsync(abuf, cancel).Result;
            //Console.WriteLine(wsdata.Count);
            //byte[] bRec = new byte[wsdata.Count];
            //Array.Copy(abuf.ToArray(), bRec, wsdata.Count);
            //Console.WriteLine(Encoding.UTF8.GetString(bRec));

            //string returnMessage = $"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss zzzz")}:接收到消息";
            //WebSocket.SendAsync(new ArraySegment<byte>(Encoding.UTF8.GetBytes(returnMessage)), WebSocketMessageType.Text, true, cancel).Wait();

            //WawitGetContext();
        }        
    }
}
