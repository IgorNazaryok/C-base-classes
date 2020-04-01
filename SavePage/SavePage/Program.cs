using System;
using System.Net.Sockets;
using System.IO;

namespace SavePage
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("tcp client staeted");
            string url = args[0];
            string serverAddress = "selin.in.ua";
            string pageAdress = "";
            string path = args[1];

           
            if (url.StartsWith("http://")) url = url.Replace("http://", "");

            if (url.Contains("/"))
            {
                serverAddress = url.Substring(0, url.IndexOf("/"));
                pageAdress= url.Substring(url.IndexOf("/"));
            }
            else 
            {
                serverAddress = url;
            }
            string massage = "GET /"+ pageAdress+" HTTP/1.0\r\nHOST: "+ serverAddress+"\r\n\r\n";
            
            try
            {
                var port = 80;                
                var client = new TcpClient(serverAddress, port);
                var data = System.Text.Encoding.ASCII.GetBytes(massage);
                NetworkStream stream = client.GetStream();
                stream.Write(data, 0, data.Length);               
                Console.WriteLine(massage);
               var responseData = new byte[10240];               
                int bytesRead = stream.Read(responseData, 0, responseData.Length);
                string responseMassage = System.Text.Encoding.ASCII.GetString(responseData, 0, bytesRead);

                responseMassage = responseMassage.Substring(responseMassage.IndexOf("Accept-Ranges: bytes") + 24);
                
                //Console.WriteLine(responseMassage);

                using (StreamWriter sw = new StreamWriter(path))
                sw.WriteLine(responseMassage);
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
