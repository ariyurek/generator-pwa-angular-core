﻿using System.IO;
using <%= safeName %>.Server;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace <%= safeName %>
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("hosting.json", optional: true)
                        .Build();


            var host = new WebHostBuilder()
                .CaptureStartupErrors(true)
                .UseSetting("detailedErrors", "true")
                .UseKestrel()
                .UseConfiguration(config)
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
