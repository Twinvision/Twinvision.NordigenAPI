using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Twinvision.NordigenAPI.Requests;
using Twinvision.NordigenAPI.Responses;

namespace Twinvision.NordigenAPI.Handlers
{
    public sealed class Requisitions : NordigenApiHttpRequestHandler
    {
        public async Task<PagedResponse<Requisition>> GetRequisitions(int limit = 100, int offset = 0)
        {
            var parameters = new Dictionary<string, string>
            {
                { "limit", limit.ToString() },
                { "offset", offset.ToString() }
            };
            var response = await Get("/requisitions/", parameters);
            return await NordigenAPIHelper.GetContentFromResponse<PagedResponse<Requisition>>(response).ConfigureAwait(false);
        }

        public async Task<Requisition> PostRequisition(RequisitionRequest requisition)
        {        
            var response = await Post("/requisitions/", NordigenAPIHelper.BuildContentFromObject(requisition));
            return await NordigenAPIHelper.GetContentFromResponse<Requisition>(response).ConfigureAwait(false);
        }

        public async Task<Requisition> GetRequisition(Guid id)
        {
            var response = await Get($"/requisitions/{id}/");
            return await NordigenAPIHelper.GetContentFromResponse<Requisition>(response).ConfigureAwait(false);
        }

        public async Task<ApiCallSuccess> DeleteRequisition(Guid id)
        {
            var response = await Delete($"/requisitions/{id}/");
            return await NordigenAPIHelper.GetContentFromResponse<ApiCallSuccess>(response).ConfigureAwait(false);
        }
    }
}
