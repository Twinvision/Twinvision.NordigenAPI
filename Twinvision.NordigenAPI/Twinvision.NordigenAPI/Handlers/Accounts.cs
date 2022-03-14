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
        public async Task<Account> GetAcountMetaData(string id)
        {
            var response = await Get($"/accounts/{id}/");
            return await NordigenAPIHelper.GetContentFromResponse<Account>(response).ConfigureAwait(false);
        }

        public async Task<Balance> GetAccountBalances(string id)
        {
            var response = await Get($"/accounts/{id}/balances/");
            return await NordigenAPIHelper.GetContentFromResponse<Balance>(response).ConfigureAwait(false);
        }

        public async Task<AccountDetail> GetAccountDetails(string id)
        {
            var response = await Get($"/accounts/{id}/details/");
            return await NordigenAPIHelper.GetContentFromResponse<AccountDetail>(response).ConfigureAwait(false);
        }
        public async Task<Transaction> GetAccountTransactions(string id)
        {
            var response = await Get($"/accounts/{id}/transactions/");
            return await NordigenAPIHelper.GetContentFromResponse<Transaction>(response).ConfigureAwait(false);
        }


    }
} 
