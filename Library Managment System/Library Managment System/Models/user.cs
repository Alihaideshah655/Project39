using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library_Managment_System.Models
{
    public class user
    {
        public String firstName {get; set;}
        public String lastName{ get; set; }
        public String regristrationNo { get; set; }
        public String mail { get; set; }
        public int contactNumber { get; set; }
        public String password { get; set; }
    }
}