using System;
using StackExchange.Redis;

namespace AzRedisCacheApp
{
    class Program
    {
        private  static string ConnectionString = "az204rediscache1.redis.cache.windows.net:6380,password=8wHCLNFbVS+LWQBtoQvZPOT+TbJgzb+6Km02MN5OxUs=,ssl=True,abortConnect=False";
        static void Main(string[] args)
        {
            IDatabase cache = lazyConnection.Value.GetDatabase();
            Console.WriteLine($"Reading Cache: {cache.StringGet("TestKey")}");
            Console.WriteLine($"Reading Cache: {cache.StringSet("TestKey","SharmilaTaniya1")}");
            Console.WriteLine($"Reading Cache: {cache.StringGet("TestKey")}");
            cache.KeyExpire("TestKey", DateTime.Now.AddSeconds(60));
            lazyConnection.Value.Dispose();

            Console.WriteLine("Press any key...");
            Console.ReadLine();

        }
        private static Lazy<ConnectionMultiplexer> lazyConnection=new Lazy<ConnectionMultiplexer>(()=>
        {
            return  ConnectionMultiplexer.Connect(ConnectionString);
        });
    }
}
