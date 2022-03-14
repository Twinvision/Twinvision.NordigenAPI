using System;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Twinvision.NordigenApi.Test
{
    [TestClass]
    public class CheckCredentialsSetup : TestBase
    {
        /// <summary>
        /// If this test fails (and all other tests because of it) you probably need to set the user secrets 'ClientId' and 'ClientSecret'
        /// Example of how to set one of the usersecrets: 'dotnet user-secrets set ClientSecret MySecretKeyxyz12345' ran in the testproject
        /// More information about user secrets can be found here: https://docs.microsoft.com/en-us/aspnet/core/security/app-secrets?view=aspnetcore-3.1&tabs=windows
        /// </summary>
        [TestMethod]
        public void CheckCredentialsSetupSecretsPresent()
        {
            try
            {
                TestSecretId = Configuration["secretId"];
                TestSecretKey = Configuration["secretKey"];
            }
            catch
            {
                throw new Exception("The secret Id or secret key was not set to a value");
            }
            if (string.IsNullOrWhiteSpace(TestSecretId) || string.IsNullOrWhiteSpace(TestSecretKey))
            {
                throw new Exception("The secret Id or secret key was not set to a value");
            }
        }
    }
}
