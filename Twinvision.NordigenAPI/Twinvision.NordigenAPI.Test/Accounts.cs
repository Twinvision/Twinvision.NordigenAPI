using System;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Twinvision.NordigenAPI.Test
{
    [TestClass]
    public class Accounts : TestBase
    {     
        [TestMethod]
        public async Task ListAccountsDetails()
        {
            var nac = new NordigenAPICaller(TestSecretId, TestSecretKey);
            var result = await nac.Accounts.GetAccountDetails("");

            Assert.IsTrue(result.Account != null);
        }

        [TestMethod]
        public async Task ListAccountMetaData()
        {
            var nac = new NordigenAPICaller(TestSecretId, TestSecretKey);
            var result = await nac.Accounts.GetAcountMetaData("");

        }

        [TestMethod]
        public async Task ListAccountBalances()
        {
            var nac = new NordigenAPICaller(TestSecretId, TestSecretKey);
            var result = await nac.Accounts.GetAccountBalances("");

            Assert.IsTrue(result.Balances != null);
        }

        [TestMethod]
        public async Task ListAccountTransactions()
        {
            var nac = new NordigenAPICaller(TestSecretId, TestSecretKey);
            var result = await nac.Accounts.GetAccountTransactions("nl");

            Assert.IsTrue(result.Transactions.Booked != null && result.Transactions.Booked.Count > 0);
        }     
    }
}
