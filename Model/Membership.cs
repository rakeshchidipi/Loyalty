using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoyaltyAdaptor.Model
{
    public class MembershipData
    {
        public Membership membership { get; set; }
        public User user { get; set; }
        public Errors errors { get; set; }
        public string error_message { get; set; }
        public string error_code { get; set; }
        public string detail { get; set; }
    }

    public class Errors
    {
        public string __all__ { get; set; }
    }

    public class Membership
    {
        public int status { get; set; }
        public int stamps { get; set; }
        public int balance { get; set; }
        public string start_date { get; set; }
        public string created { get; set; }
    }

    public class User
    {
        public List<object> member_ids { get; set; }
        public bool is_active { get; set; }
        public string phone { get; set; }
        public bool protected_redemption { get; set; }
        public string birthday { get; set; }
        public string address { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string gender { get; set; }
        public string picture_url { get; set; }
        public string email { get; set; }
    }
}
