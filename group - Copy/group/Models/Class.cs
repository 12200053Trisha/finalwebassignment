using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace group.Models
{
    public class Class
    {
       
 public int ClassID { get; set; }
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }

        public virtual ICollection<Membership> Memberships { get; set; }
       // public virtual ICollection<Session> Session { get; set; }


    }
}