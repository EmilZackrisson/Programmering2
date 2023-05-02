// See https://aka.ms/new-console-template for more information
using System.Net.Sockets;
using System.Net;
using System.Text;

internal class Program
{
    public static void Main(string[] args)
    {
        TcpListener server = new TcpListener(IPAddress.Any, 5000);
        server.Start();
        Console.WriteLine("Server has started on port 5000");
        TcpClient client = server.AcceptTcpClient();
        Console.WriteLine("A client connected.");
        NetworkStream stream = client.GetStream();

        stream.Write(Encoding.UTF8.GetBytes("Hello World!"));

        while (true) // här blir det fel
        {
            var buffer = new byte[1_024];
            int received = stream.Read(buffer);
            var message = Encoding.UTF8.GetString(buffer, 0, received);
            Console.WriteLine("Message: " + message);

            var message2 = Encoding.UTF8.GetBytes(message + ":tanku");
            stream.Write(message2, 0, message2.Length);
            Console.WriteLine("Responded client with: " + message2);
            if (message == "exit")
            {
                break;
            }

        }
        client.Close();
        server.Stop();
        Console.WriteLine(
            "Client disconnected. Server stopped.");

    }
}