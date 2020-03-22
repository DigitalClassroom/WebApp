using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace DigitalClassroomWebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });


        public static string GetCurrentBuildVersionString()
        {
            Version baseVersion = Assembly.GetExecutingAssembly().GetName().Version ?? new Version(1, 0);

            DateTime buildTime = DateTime.Now;
            try
            {
                FileInfo fi = new FileInfo(Assembly.GetExecutingAssembly().Location + ".dll");
                buildTime = fi.CreationTime;
            }
            catch
            {
            }

            return new Version(baseVersion.Major, baseVersion.Minor,
                (buildTime - new DateTime(2000, 1, 1)).Days,
                ((int)new TimeSpan(buildTime.Hour, buildTime.Minute, buildTime.Second).TotalSeconds) / 2).ToString();
        }
    }
}
