﻿using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Papagaulo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .UseKestrel()
            .UseUrls("http://localhost:5100;https://hostname:5150")
                .UseStartup<Startup>();
    }
}
