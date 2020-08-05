using Activity2Part1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity2Part1.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            List<UserModel> list = new List<UserModel>();

            for (int i = 0; i < 6; i++) 
            {
                list.Add(new UserModel("Jeff", "n@n.com", "123-456-7890"));
            }
            return View("Test", list);
        }
    }
}