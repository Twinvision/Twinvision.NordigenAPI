﻿using System;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Twinvision.NordigenApi.Test
{
    [TestClass]
    public class Institutions : TestBase
    {
        [TestMethod]
        public async Task ListInstitutionsNL()
        {
            var nac = new NordigenApiCaller(TestSecretId, TestSecretKey);
            var result = await nac.Institutions.GetInstitutions("");

            Assert.IsTrue(result.Length > 0);
        }

        [TestMethod]
        public async Task ListInstitutionN26_NTSBDEB1()
        {
            var nac = new NordigenApiCaller(TestSecretId, TestSecretKey);
            var result = await nac.Institutions.GetInstitution("N26_NTSBDEB1");

            Assert.IsTrue(result.BIC == "NTSBDEB1");
        }
    }
}
