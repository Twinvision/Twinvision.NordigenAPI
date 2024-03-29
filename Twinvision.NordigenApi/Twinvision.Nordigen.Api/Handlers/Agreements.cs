﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Twinvision.NordigenApi.Requests;
using Twinvision.NordigenApi.Responses;

namespace Twinvision.NordigenApi.Handlers
{
    public sealed class Agreements : NordigenApiHttpRequestHandler
    {
        public async Task<PagedResponse<Agreement>> GetAgreements(int limit = 100, int offset = 0)
        {
            var parameters = new Dictionary<string, string>
            {
                { "limit", limit.ToString() },
                { "offset", offset.ToString() }
            };
            var response = await Get("/agreements​/enduser​/", parameters);
            return await NordigenApiHelper.GetContentFromResponse<PagedResponse<Agreement>>(response).ConfigureAwait(false);
        }

        public async Task<Agreement> CreateAgreement(AgreementRequest agreement)
        {        
            var response = await Post("/agreements​/enduser​/", NordigenApiHelper.BuildContentFromObject(agreement));
            return await NordigenApiHelper.GetContentFromResponse<Agreement>(response).ConfigureAwait(false);
        }

        public async Task<Agreement> GetAgreement(Guid id)
        {
            var response = await Get($"/agreements/enduser/{id}/");
            return await NordigenApiHelper.GetContentFromResponse<Agreement>(response).ConfigureAwait(false);
        }

        public async Task<ApiCallSuccess> DeleteAgreement(Guid id)
        {
            var response = await Delete($"/agreements/enduser/{id}/");
            return await NordigenApiHelper.GetContentFromResponse<ApiCallSuccess>(response).ConfigureAwait(false);
        }

        public async Task<Agreement> AcceptAgreement(Guid id, AgreementRequest agreement)
        {
            var response = await Put($"/agreements/enduser/{id}/accept/", NordigenApiHelper.BuildContentFromObject(agreement));
            return await NordigenApiHelper.GetContentFromResponse<Agreement>(response).ConfigureAwait(false);
        }
    }
}
