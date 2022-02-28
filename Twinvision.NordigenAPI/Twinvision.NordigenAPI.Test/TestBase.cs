using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;
using Twinvision.NordigenAPI.Handlers;

namespace Twinvision.NordigenAPI.Test
{
    [TestClass]
    public abstract class TestBase
    {
        public string TestSecretId = null;
        public string TestSecretKey = null;

        public IConfiguration Configuration { get; set; }

        [TestInitialize]
        public async void Initialize()
        {
            await Task.Delay(500);

            var builder = new ConfigurationBuilder()
                .AddUserSecrets<TestBase>();

            Configuration = builder.Build();
        }
   
    }
}
