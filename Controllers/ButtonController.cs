using Activity2Part1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Activity2Part1.Controllers
{
    public class ButtonController : Controller
    {
        static ButtonModel blue = new ButtonModel(false);
        static ButtonModel red = new ButtonModel(false);
        // GET: Button
        public ActionResult Index()
        {
            List<ButtonModel> list = new List<ButtonModel>();

            list.Add(blue);
            list.Add(red);

            return View("Button", list);
        }

        public ActionResult OnButtonClick(string mine)
        {
            List<ButtonModel> list = new List<ButtonModel>();
            if (mine.Equals("1"))
            {
                blue.State = true;
            }
            else
            {
                red.State = true;
            }

            list.Add(blue);
            list.Add(red);

            return View("Button", list);
        }
    }
}