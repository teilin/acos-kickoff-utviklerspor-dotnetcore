using System;
using Microsoft.AspNetCore.Mvc;

namespace RoutingDemo
{
    public class DemoController : Controller
    {
        [Route("/")]
        public void Test()
        {
            Console.WriteLine("Hello World!");
        }

        public void Index(int id)
        {
            Console.WriteLine("Hello world, {id}");
        }
    }
}