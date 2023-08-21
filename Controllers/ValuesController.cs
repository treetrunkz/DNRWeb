﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DNR_Aquatics.Controllers
{
    [Authorize]
    public class ValuesController : ApiController
    {
        // GET api/values
        public string Get()
        {
            var userName = this.RequestContext.Principal.Identity.Name;
            return String.Format("Hello, {0}.", userName);
        }
    }
}