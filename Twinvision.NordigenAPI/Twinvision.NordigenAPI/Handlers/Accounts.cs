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
            var response = await Get($"/accounts/{id}");
            return await NordigenAPIHelper.GetContentFromResponse<Accounts[]>(response).ConfigureAwait(false);
        }

        public async Task<Accounts[]> GetAccountBalances(string id)
        {
            var response = await Get($"/accounts/{id}/balances/");
            return await NordigenAPIHelper.GetContentFromResponse<Accounts[]>(response).ConfigureAwait(false);
        }

        public async Task<Accounts[]> GetAccountDetails(string id)
        {
            var response = await Get($"/accounts/{id}/details/");
            return await NordigenAPIHelper.GetContentFromResponse<Accounts[]>(response).ConfigureAwait(false);
        }
        public async Task<Accounts[]> GetAccountTransactions(string id)
        {
            var response = await Get($"/accounts/{id}/transactions/");
            return await NordigenAPIHelper.GetContentFromResponse<Accounts[]>(response).ConfigureAwait(false);
        }


    }
} 
