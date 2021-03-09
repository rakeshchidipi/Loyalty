using LoyaltyAdaptor.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoyaltyAdaptor.Interface
{
    interface ILoyaltyProvider
    {

        Task<MembershipData> GetMember(string username, string password, string mobile);
        long GetRewardPoints(string username, string password, string mobile);
        string CreateVoucher(string username, string password, string mobile, long points);
        string RedeemVoucher(string username, string password, string mobile, string vouchercode);
        string GetActivity(string username, string password, string mobile, string vouchercode);


    }
}
