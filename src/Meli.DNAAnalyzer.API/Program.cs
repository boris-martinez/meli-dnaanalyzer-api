using System;
using System.IO;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Formatting.Compact;

namespace Meli.DNAAnalyzer.API
{
    public class Program
    {
        public static readonly string Namespace = typeof(Program).Namespace;
        public static readonly string AppName = Namespace;

        protected Program() { }

        public static void Main(string[] args)
        {
            var host = BuildWebHost(args);
            Log.Information("Starting web host ({ApplicationContext})...", AppName);
            host.Run();
        }

        private static IWebHost BuildWebHost(string[] args) =>
              WebHost.CreateDefaultBuilder(args)
                  .UseShutdownTimeout(TimeSpan.FromSeconds(10))
                  .CaptureStartupErrors(false)
                  .ConfigureAppConfiguration((host, builder) =>
                  {
                      builder.SetBasePath(Directory.GetCurrentDirectory())
                      .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                      .AddJsonFile($"appsettings.{host.HostingEnvironment.EnvironmentName}.json", optional: true, reloadOnChange: true)
                      .AddEnvironmentVariables(prefix: "APP_")
                      .AddCommandLine(args);
                  })
                  .UseStartup<Startup>()
                  .ConfigureLogging((context, loggingBuilder) =>
                  {
                      loggingBuilder.AddConfiguration(context.Configuration.GetSection("Logging"));
                      loggingBuilder.AddApplicationInsights();

                      var serilogBuilder = new LoggerConfiguration()
                          .Enrich.WithProperty("ApplicationContext", AppName)
                          .Enrich.FromLogContext()
                          .ReadFrom.Configuration(context.Configuration)
                          .WriteTo.Console(new CompactJsonFormatter());

                      loggingBuilder.AddSerilog(serilogBuilder.CreateLogger(), true);
                  })
                  .Build();
    }
}
