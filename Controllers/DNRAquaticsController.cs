using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DNR_Aquatics.Controllers
{
    public class DNR_Aquatics : Controller
    {
        // GET: DNRDB
        public string Welcome(string name, int numTimes = 234)
        {
            return HttpUtility.HtmlEncode("Hello" + name + ", this is your data in the controller - " + numTimes);
        }
        public string Index()
        {
            return "Controller Test";
        }
    }
}