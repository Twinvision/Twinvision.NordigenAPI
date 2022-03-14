using System;
using System.Threading.Tasks;
using Twinvision.NordigenApi.Handlers;

namespace Twinvision.NordigenApi
{
    public sealed class NordigenApiCaller
    {
        public Institutions Institutions { get; }
        public Accounts Accounts { get; }
        public Requisitions Requisitions { get; }
        public Agreements Agreements { get; }

        /// <summary>
        /// Constructor used to create an instance of the NordigenAPICaller
        /// </summary>
        /// <param name="secretId">The api secretId required for authorization, requestable from the Nordigen website.</param>
        /// <param name="secretKey">The api secretKey required for authorization, requestable from the Nordigen website .</param>
        public NordigenApiCaller(string secretId, string secretKey)
        {
            Task.Run(() => NordigenApiHttpRequestHandler.Initialize(secretId, secretKey)).Wait();

            Institutions = new Institutions();
            Requisitions = new Requisitions();
            Agreements = new Agreements();  
            Accounts = new Accounts();
        }
    }
}
