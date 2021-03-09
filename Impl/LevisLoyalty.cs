using LoyaltyAdaptor.Interface;
using LoyaltyAdaptor.Model;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace LoyaltyAdaptor.Impl
{
    public class LevisLoyalty : ILoyaltyProvider
    {
        private HttpClient _client;
        private readonly IConfiguration _configuration;
        private string apiurlpath;
        public LevisLoyalty(HttpClient httpClient, IConfiguration configuration)
        {
            _configuration = configuration;
            _client = httpClient;
            apiurlpath = _configuration.GetValue<string>("levisapiendpoint");// 

            //https://docs.stamps.co.id/en/latest/customer_api.html#getting-member-data

            //https://docs.stamps.co.id/en/latest/redemption_api.html#adding-voucher-redemption

            //https://docs.stamps.co.id/en/latest/reward_api.html#querying-for-available-rewards
        }
        string ILoyaltyProvider.CreateVoucher(string username, string password, string mobile, long points)
        {
            throw new NotImplementedException();
        }

        string ILoyaltyProvider.GetActivity(string username, string password, string mobile, string vouchercode)
        {
            throw new NotImplementedException();
        }

        async Task<MembershipData> ILoyaltyProvider.GetMember(string username, string password, string mobile)
        {
            MembershipData membershipData = new MembershipData();
            try
            {
                _client.DefaultRequestHeaders.Accept.Clear();
                _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                Uri uri = new Uri($"{apiurlpath}memberships/details?token=abc&user=customer@stamps.co.id&merchant=14");
               
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                using (HttpResponseMessage response = await _client.GetAsync(uri))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        membershipData = await response.Content.ReadAsAsync<MembershipData>();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return membershipData;
        }

        long ILoyaltyProvider.GetRewardPoints(string username, string password, string mobile)
        {
            throw new NotImplementedException();
        }

        string ILoyaltyProvider.RedeemVoucher(string username, string password, string mobile, string vouchercode)
        {
            throw new NotImplementedException();
        }
    }
}
        