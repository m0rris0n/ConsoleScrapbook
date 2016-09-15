using System.Net.Sockets;
using System.Net;
using System;
using System.Text;
using System.Text.RegularExpressions;

class Server
{
    public static void Main()
    {
        TcpListener server = new TcpListener(IPAddress.Parse("127.0.0.1"), 80);

        server.Start();
        Console.WriteLine("Sevrer has started on 127.0.0.1:80. {0}Waiting for a connection...", Environment.NewLine);

        TcpClient client = server.AcceptTcpClient();

        Console.WriteLine("A client connected");

        NetworkStream stream = client.GetStream();

        //enter to an infinitte cycle to be able to handle every change in stream
        while (true)
        {
            while (!stream.DataAvailable) ;

            Byte[] bytes = new Byte[client.Available];

            stream.Read(bytes, 0, bytes.Length);

            //translate bytes of request to string
            String data = Encoding.UTF8.GetString(bytes);

            if (new Regex("^GET").IsMatch(data))
            {
                Byte[] response = Encoding.UTF8.GetBytes("HTTP/1.1 101 Switiching Potocols ");
            }
            else
            {

            }
        }
    }
}