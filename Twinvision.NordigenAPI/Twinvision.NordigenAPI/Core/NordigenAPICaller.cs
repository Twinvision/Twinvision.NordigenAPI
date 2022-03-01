using System;
using System.Threading.Tasks;
using Twinvision.NordigenAPI.Handlers;

namespace Twinvision.NordigenAPI
{
    public sealed class NordigenAPICaller
    {
        public Institutions Institutions { get; }
        public Accounts Accounts { get; }
        public Requisitions Requisitions { get; }

        /// <summary>
        /// Constructor used to create an instance of the NordigenAPICaller
        /// </summary>
        /// <param name="secretId">The api secretId required for authorization, requestable from the Nordigen website.</param>
        /// <param name="secretKey">The api secretKey required for authorization, requestable from the Nordigen website .</param>
        public NordigenAPICaller(string secretId, string secretKey)
        {
            Task.Run(() => NordigenApiHttpRequestHandler.Initialize(secretId, secretKey)).Wait();

            Institutions = new Institutions();
            Requisitions = new Requisitions();
            Accounts = new Accounts();
        }
    }
}
