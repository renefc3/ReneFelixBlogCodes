using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    class Program
    {
        public static IList<string> lista = new List<string>();
        static void Main(string[] args)
        {
            IList<Task> aa = new List<Task>();
            for (int i = 0; i < 1500; i++)
            {
                aa.Add(
                Task.Run(() =>
                {
                    WebRequest request = WebRequest.Create("http://localhost:8618/api/teste");
                    request.Credentials = CredentialCache.DefaultCredentials;
                    WebResponse response = request.GetResponse();
                    Stream dataStream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(dataStream);
                    string responseFromServer = reader.ReadToEnd();
                    lista.Add(responseFromServer);
                }));
            }
            Task.WaitAll(aa.ToArray());

            var stringteste = string.Join(Environment.NewLine, lista.ToArray());

            Console.ReadKey();
        }
    }
}
