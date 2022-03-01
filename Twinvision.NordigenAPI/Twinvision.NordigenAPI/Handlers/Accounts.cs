using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Twinvision.NordigenAPI.Responses;

namespace Twinvision.NordigenAPI.Handlers
{
    public sealed class Accounts : NordigenApiHttpRequestHandler
    {
        public async Task<Accounts[]> GetAccounts(string id)
        {
            var parameters = new Dictionary<string, string>
            {
                { "id", id }
            };
            var response = await Get("/accounts/", parameters);
            return await NordigenAPIHelper.GetContentFromResponse<Accounts[]>(response).ConfigureAwait(false);
        }

        public async Task<Accounts[]> GetAccountBalances(string id)
        {
            var parameters = new Dictionary<string, string>
            {
                { "id", id }
            };
            var response = await Get("/accounts/{0}/balances/", null);
            return await NordigenAPIHelper.GetContentFromResponse<Accounts[]>(response).ConfigureAwait(false);
        }

        public async Task<Accounts[]> GetAccountDetails(string id)
        {
            var parameters = new Dictionary<string, string>
            {
                { "id", id }
            };
            var response = await Get("/accounts/{0}/details/", null);
            return await NordigenAPIHelper.GetContentFromResponse<Accounts[]>(response).ConfigureAwait(false);
        }
        public async Task<Accounts[]> GetAccountTransactions(string id)
        {
            var parameters = new Dictionary<string, string>
            {
                { "id", id }
            };
            var response = await Get("/accounts/{0}/transactions/", null);
            return await NordigenAPIHelper.GetContentFromResponse<Accounts[]>(response).ConfigureAwait(false);
        }


    }
} 
