using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Twinvision.NordigenApi.Requests;
using Twinvision.NordigenApi.Responses;

namespace Twinvision.NordigenApi.Handlers
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
            return await NordigenApiHelper.GetContentFromResponse<PagedResponse<Requisition>>(response).ConfigureAwait(false);
        }

        public async Task<Requisition> CreateRequisition(RequisitionRequest requisition)
        {        
            var response = await Post("/requisitions/", NordigenApiHelper.BuildContentFromObject(requisition));
            return await NordigenApiHelper.GetContentFromResponse<Requisition>(response).ConfigureAwait(false);
        }

        //public async Task<Requisition> PostRequisitionLink(string institution_id, string redirect)
        //{
        //    var parameters = new Dictionary<string, string>
        //    {
        //        { "institution_id", institution_id.ToString()},
        //        { "redirect", redirect.ToString() }
        //    };
        //    var response = await Post("/requisitions/", parameters);
        //    return await NordigenAPIHelper.GetContentFromResponse<Requisition>(response).ConfigureAwait(false);
        //}

        public async Task<Requisition> GetRequisition(Guid id)
        {
            var response = await Get($"/requisitions/{id}/");
            return await NordigenApiHelper.GetContentFromResponse<Requisition>(response).ConfigureAwait(false);
        }

        public async Task<ApiCallSuccess> DeleteRequisition(Guid id)
        {
            var response = await Delete($"/requisitions/{id}/");
            return await NordigenApiHelper.GetContentFromResponse<ApiCallSuccess>(response).ConfigureAwait(false);
        }
    }
}
