using System;
using System.Net;
using System.Net.Sockets;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("tcp server staeted");
            try
            {
                int port = 19539;
                IPAddress localAddr = IPAddress.Parse("127.0.0.1"); //создания объекта слушателя 
                TcpListener server = new TcpListener(localAddr, port);
                server.Start();

                var bytes = new byte[256];
                string data = "";

                TcpClient client = null;

                NetworkStream stream;


                byte[] response;
                int bytesReadCount;
                client = server.AcceptTcpClient();
                Console.WriteLine("Accepted conection from {0}", client.Client.RemoteEndPoint);
                stream = client.GetStream();  //создаем поток 
                data = "Hello " + client.Client.RemoteEndPoint;
                response = System.Text.Encoding.ASCII.GetBytes(data);
                stream.Write(response, 0, response.Length);
                while (true)
                {
                    //if (server.AcceptTcpClient())
                    //{
                    //    Console.WriteLine("Accepted conection from {0}", client.Client.RemoteEndPoint);
                    //    stream = client.GetStream();  //создаем поток 
                    //    data = "Hello " + client.Client.RemoteEndPoint;
                    //    response = System.Text.Encoding.ASCII.GetBytes(data);
                    //    stream.Write(response, 0, response.Length);

                    //}
                    //Console.WriteLine(stream.Read(bytes, 0, bytes.Length));

                    //if (stream.Read(bytes, 0, bytes.Length) != 0)
                    //{
                    bytesReadCount = stream.Read(bytes, 0, bytes.Length);
                    data = System.Text.Encoding.ASCII.GetString(bytes, 0, bytesReadCount);
                    Console.WriteLine("Sent client {0}", data);
                    data = data.ToUpper();
                    response = System.Text.Encoding.ASCII.GetBytes(data);
                    stream.Write(response, 0, response.Length);
                    Console.WriteLine("Sent server {0}", data);
                    //}




                    //client.Close();
                    // client = null;//создание клиента

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception {0}", e);
            }

        }
    }
}
