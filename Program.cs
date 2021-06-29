using System;
using System.Linq;
using System.Net;

namespace GetIpByHostname
{
    class Program
    {
        static void Main(string[] args)
        {
            string hostname = "";
            IPAddress[] listIPAddress = Dns.GetHostAddresses(hostname);
            IPAddress[] listIPV4 = listIPAddress.Where(x=>x.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork).ToArray();
            Console.WriteLine($"Input Hostname: {hostname}");
            Console.WriteLine($"IP Address: {listIPAddress[0]}");
        }
    }
}
