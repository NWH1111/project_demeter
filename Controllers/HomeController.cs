using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Threading;

namespace I_Demeter.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
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

        public IActionResult iMap()
        {
            ViewData["Message"] = "Your iMap.";

            Thread T = new Thread(TTT);
            Task.Factory.StartNew(new Action(()=>
                {
                    for (int i = 0; i <= 1000; i++)
                    {
                        ViewData["Message"] = i.ToString();
                        Thread.Sleep(1000);
                    }
                }));
            
        
            return View();
        }

        private void TTT()
        {
            
        }

        public IActionResult iShop()
        {
            ViewData["Message"] = "Your iSHOP.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
