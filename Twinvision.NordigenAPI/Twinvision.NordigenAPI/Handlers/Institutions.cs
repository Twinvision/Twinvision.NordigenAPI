using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Twinvision.NordigenAPI.Responses;

namespace Twinvision.NordigenAPI.Handlers
{
    public sealed class Institutions : NordigenApiHttpRequestHandler
    {
        public async Task<Institution[]> GetInstitutions(string countryCode)
        {
            var parameters = new Dictionary<string, string>
            {
                { "country", countryCode }
            };
            var response = await Get("/institutions/", parameters);
            return await NordigenAPIHelper.GetContentFromResponse<Institution[]>(response).ConfigureAwait(false);
        }
    }
}
