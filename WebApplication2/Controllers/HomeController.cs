using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //RedisClientManagerConfig RedisConfig = new RedisClientManagerConfig();
            //RedisConfig.AutoStart = true;
            //RedisConfig.MaxReadPoolSize = 60;
            //RedisConfig.MaxWritePoolSize = 60;

            //PooledRedisClientManager prcm = new PooledRedisClientManager(new List<string>() { "127.0.0.1" }, new List<string>() { "127.0.0.1" }, RedisConfig);

            //using (IRedisClient RClient = prcm.GetClient())
            //{
            //    RClient.Add("c1", "缓存1");
            //    RClient.Set("c1", "缓存2");
            //    RClient.Replace("c1", "缓存3");
            //    Response.Write(RClient.Get<string>("c1"));
            //    RClient.Remove("c1");
            //    Response.Write(RClient.Get<string>("c1") == null);
            //}

            //return Content("");
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}
