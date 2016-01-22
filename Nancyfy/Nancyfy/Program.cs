using Owin;
using Microsoft.Owin.Hosting;
using System;
using Nancy.Hosting.Self;

namespace Nancyfy
{
    class Program
    {
        static void Main(string[] args)
        {
            var url = "http://+:9999";

            using (var host = new NancyHost(new Uri("http://localhost:1234")))
            {
                host.Start();
                Console.ReadLine();
            }
        }
    }
}