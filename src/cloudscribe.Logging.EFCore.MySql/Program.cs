﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace cloudscribe.Logging.EFCore.MySql
{
    public class Program
    {
        public static void Main(string[] args)
        {
		    var host = new WebHostBuilder()
                .UseContentRoot(Directory.GetCurrentDirectory())
                //.UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
