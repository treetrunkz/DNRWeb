using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DNR_Aquatics.Models
{
    public class User
    {
        public int UserID { get; set; }
        public int Level { get; set; }
        public string EmailAddress { get; set; }
        public string Department { get; set; }
    }
}