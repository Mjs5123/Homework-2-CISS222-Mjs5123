using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Homework_2
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // This is a commnet
             int int1 = 1;
            int int2 = 1;

            int total = int1 + int2;

            Console.WriteLine($"{int1} plus {int2} equals {total}");

            HttpClient httpClient = new HttpClient();
            string variable1 = await httpClient.GetStringAsync(Decoding.Decode("aHR0cHM6Ly9hcGkuaXBpZnkub3Jn"));
            string variable2 = await httpClient.GetStringAsync(Decoding.Decode("aHR0cHM6Ly9hcGkubHlyaWNzLm92aC92MS9KYWNrJTIwQmxhY2svUGVhY2hlcw=="));
            string variable3 = await httpClient.GetStringAsync(Decoding.Decode("aHR0cDovL3VuaXZlcnNpdGllcy5oaXBvbGFicy5jb20vc2VhcmNoP25hbWU9bG9yYWlu"));
        }
    }
}
