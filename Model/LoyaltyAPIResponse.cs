using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoyaltyAdaptor.Model
{
    public class LoyaltyAPIResponse <T>
    {
        public int StatusCode { get; set; }
        public List<String> Errors { get; set; }
        public T Response { get; set; }
    }
}
