using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace group.Models
{
    public class Membership
    {
        public int MembershipID { get; set; }
        public int MemberID { get; set; }
        public int ClassID { get; set; }
        public string MembershipType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public virtual Member Member { get; set; }
        public virtual Class Class { get; set; }

        //public virtual Session Session {get; set; }


        
    }
}