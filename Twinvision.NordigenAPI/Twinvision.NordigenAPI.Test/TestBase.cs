﻿using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;

namespace Twinvision.NordigenApi.Test
{
    [TestClass]
    public abstract class TestBase
    {
        public string TestSecretId = null;
        public string TestSecretKey = null;

        public IConfiguration Configuration { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            var builder = new ConfigurationBuilder()
            .AddUserSecrets<TestBase>();
            Configuration = builder.Build();

            TestSecretId = Configuration["secretId"];
            TestSecretKey = Configuration["secretKey"];
        }
    }
}
