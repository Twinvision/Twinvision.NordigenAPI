using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Twinvision.NordigenApi.Responses;

namespace Twinvision.NordigenApi.Handlers
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
            return await NordigenApiHelper.GetContentFromResponse<Institution[]>(response).ConfigureAwait(false);
        }
        public async Task<Institution> GetInstitution(string id)
        {
            var response = await Get($"/institutions/{id}/");
            return await NordigenApiHelper.GetContentFromResponse<Institution>(response).ConfigureAwait(false);
        }
    }
}
