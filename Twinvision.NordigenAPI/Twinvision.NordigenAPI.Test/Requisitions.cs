using System;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Twinvision.NordigenApi.Requests;

namespace Twinvision.NordigenApi.Test
{
    [TestClass]
    public class Requisitions : TestBase
    {
        [TestMethod]
        public async Task ListRequisitionsAndGetRequisition()
        {
            var nac = new NordigenApiCaller(TestSecretId, TestSecretKey);
            var requisitions = await nac.Requisitions.GetRequisitions();

            Assert.IsTrue(requisitions.Results.Length > 0);

            var requisition = await nac.Requisitions.GetRequisition(requisitions.Results[0].Id);
            Assert.IsNotNull(requisition);
        }

        [TestMethod]
        public async Task CreateAndDeleteRequisition()
        {
            var nac = new NordigenApiCaller(TestSecretId, TestSecretKey);
            var requisitionRequest = new RequisitionRequest()
            {
                InstitutionId = "SANDBOXFINANCE_SFIN0000",
                Redirect = "https://www.twinvision.nl",
                Reference = Guid.NewGuid().ToString(),
                UserLanguage = "NL",
                AccountSelection = false
            };
            var requisition = await nac.Requisitions.CreateRequisition(requisitionRequest);

            Assert.IsNotNull(requisition);

            var result = await nac.Requisitions.DeleteRequisition(requisition.Id);
            Assert.IsNotNull(result);
        }
    }
}
