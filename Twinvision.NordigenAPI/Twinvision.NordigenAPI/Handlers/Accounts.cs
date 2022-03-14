using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Twinvision.NordigenApi.Responses;

namespace Twinvision.NordigenApi.Handlers
{
    public sealed class Accounts : NordigenApiHttpRequestHandler
    {
        public async Task<Account> GetAcountMetaData(string id)
        {
            var response = await Get($"/accounts/{id}/");
            return await NordigenApiHelper.GetContentFromResponse<Account>(response).ConfigureAwait(false);
        }

        public async Task<Balance> GetAccountBalances(string id)
        {
            var response = await Get($"/accounts/{id}/balances/");
            return await NordigenApiHelper.GetContentFromResponse<Balance>(response).ConfigureAwait(false);
        }

        public async Task<AccountDetail> GetAccountDetails(string id)
        {
            var response = await Get($"/accounts/{id}/details/");
            return await NordigenApiHelper.GetContentFromResponse<AccountDetail>(response).ConfigureAwait(false);
        }
        public async Task<Transaction> GetAccountTransactions(string id)
        {
            var response = await Get($"/accounts/{id}/transactions/");
            return await NordigenApiHelper.GetContentFromResponse<Transaction>(response).ConfigureAwait(false);
        }


    }
} 
