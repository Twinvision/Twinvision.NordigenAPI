﻿using System;
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

            Assert.IsTrue(result.Length > 0);
        }

        [TestMethod]
        public async Task ListAccounts()
        {
            var nac = new NordigenAPICaller(TestSecretId, TestSecretKey);
            var result = await nac.Accounts.GetAccounts("");

            Assert.IsTrue(result.Length > 0);
        }

        [TestMethod]
        public async Task ListAccountBalances()
        {
            var nac = new NordigenAPICaller(TestSecretId, TestSecretKey);
            var result = await nac.Accounts.GetAccountBalances("");

            Assert.IsTrue(result.Length > 0);
        }

        [TestMethod]
        public async Task ListAccountTransactions()
        {
            var nac = new NordigenAPICaller(TestSecretId, TestSecretKey);
            var result = await nac.Accounts.GetAccountTransactions("nl");

            Assert.IsTrue(result.Length > 0);
        }     
    }
}
