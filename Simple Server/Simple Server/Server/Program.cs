using System;
using System.Net;
using System.Net.Sockets;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
           
            try
            {
                var port = 21103;
                var localAddr = IPAddress.Parse("127.0.0.1");
                var server = new TcpListener(localAddr, port);
                server.Start();
                var bytes = new byte[256];
                while (true)
                {
                   // Console.WriteLine("waiting for connection");
                    var client = server.AcceptTcpClient();
                    Console.WriteLine("Accepted conection from {0}", client.Client.RemoteEndPoint);
                    NetworkStream stream = client.GetStream();
                    var bytesReadCount=stream.Read(bytes, 0, bytes.Length);
                    var data = System.Text.Encoding.ASCII.GetString(bytes , 0, bytesReadCount);
                    Console.WriteLine(data);
                    Console.WriteLine("\n\n\n\n");                  
                    data = "HTTP/1.1 200 OK\n"

                        + "Content-Language: ru\n"
                        + "Content-Type: text/html\n"
                        + "Content-Length: 366\n"
                        + "Connection: close\n"
                        + "Accept - Ranges: bytes\n"
                        + "Vary: Accept - Encoding\n"
                          + "\n\n"
                        + "<!DOCTYPE html>\n <html> <body> <h>Welcome "+ client.Client.RemoteEndPoint +" to our web server</h>\n </body>\n </html>\n";                          

                    var response = System.Text.Encoding.ASCII.GetBytes(data);
                    stream.Write(response, 0, response.Length);
                    Console.WriteLine(data);
                    client.Close();

                }    
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception {0}", e);
            }

        }
    }
}
