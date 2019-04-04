using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace UDPNumberSender
{
    public class UDPNumberSenderBroad
    {
        public void broadMain()
        {
            int number = 0;

            IPAddress ip = IPAddress.Parse("127.0.0.1");
            UdpClient udpClient = new UdpClient(0);

            IPEndPoint RemoteIpEndPoint = new IPEndPoint(ip,7000);
            udpClient.Connect(RemoteIpEndPoint);

            Console.Write("Hit enter: ");
            String name = Console.ReadLine();

            while (true)
            {
                Byte[] sendBytes = Encoding.ASCII.GetBytes("The number is: " + number);

                udpClient.Send(sendBytes, sendBytes.Length);

                number++;

                Console.WriteLine(number);

                Thread.Sleep(100);
            }
        }
       
}
}