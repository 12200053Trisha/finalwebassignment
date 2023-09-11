using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace group.Models
{
    public class Member
    {
        public int MemberID { get; set; }
        public string MemberName { get; set; }
        public DateTime DOB { get; set; }

        public virtual ICollection<Membership> Memberships { get; set; }
    }
}