﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.PlatformAbstractions;

namespace Runtime.ApplicationEnvironment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var environment = PlatformServices.Default.Application;

            Console.WriteLine("======================================================");
            Console.WriteLine("ApplicationName: {0}", environment.ApplicationName);
            Console.WriteLine("ApplicationBasePath: {0}", environment.ApplicationBasePath);
            Console.WriteLine("TargetFramework: {0}", environment.RuntimeFramework);
            Console.WriteLine("Version: {0}", environment.ApplicationVersion);
            Console.WriteLine("======================================================");

            Console.ReadLine();
        }
    }
}
