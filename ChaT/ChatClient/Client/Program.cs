using System;
using System.Net.Sockets;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("tcp client staeted");
            string massage = "massage";
            try
            {
                var port = 19539;
                var serverAddress = "127.0.0.1";
                TcpClient client = new TcpClient(serverAddress, port);
                NetworkStream stream = client.GetStream(); // создание потока для передачи данных
                byte[] responseData = new byte[1024];
                int bytesRead = stream.Read(responseData, 0, responseData.Length);
                string responseMassage = System.Text.Encoding.ASCII.GetString(responseData, 0, bytesRead);
                Console.WriteLine(responseMassage);
                while (true)
                {
                    massage = Console.ReadLine();
                    var data = System.Text.Encoding.ASCII.GetBytes(massage);
                    stream.Write(data, 0, data.Length); //передача в поток
                    //Console.WriteLine("Sent {0}", massage);

                    bytesRead = stream.Read(responseData, 0, responseData.Length);
                    responseMassage = System.Text.Encoding.ASCII.GetString(responseData, 0, bytesRead);
                    Console.WriteLine("Sent server {0}", responseMassage);
                    
                }
                    stream.Close();
                    client.Close();
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception {0}", e);
            }
            
        }
    } 
}
