using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Har.API
{
    public sealed class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseUrls("http://10.116.85.14:9997");
                    webBuilder.UseStartup<Startup>();
                });
    }
}
