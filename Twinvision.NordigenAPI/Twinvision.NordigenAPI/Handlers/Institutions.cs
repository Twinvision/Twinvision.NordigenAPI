using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Twinvision.NordigenAPI.Containers;
using Newtonsoft.Json;

namespace Twinvision.NordigenAPI.Handlers
{
    public sealed class Institutions : NordigenApiHttpRequestHandler
    {
        public async Task<InstitutionContainer> GetInstitutions(string countryCode)
        {
            var parameters = new Dictionary<string, string>
            {
                { "country", countryCode }
            };
            var response = await Post("/institutions", null, parameters);
            return await NordigenAPIHelper.GetContentFromResponse<InstitutionContainer>(response).ConfigureAwait(false);
        }
    }
}
