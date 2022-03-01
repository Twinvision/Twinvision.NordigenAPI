﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Twinvision.NordigenAPI;
using Twinvision.NordigenAPI.Requests;
using Twinvision.NordigenAPI.Responses;

namespace Twinvision.NordigenAPI
{
    /// <summary>
    /// Class used to standardize api request calls to Nordigen.
    /// </summary>
    public abstract class NordigenApiHttpRequestHandler
    {
        /// <summary>
        /// The api base url.
        /// </summary>
        private const string ApiUrl = "https://ob.nordigen.com/api/v2";

        /// <summary>
        /// The client Id used for authentication.
        /// </summary>
        private static string ClientId;

        /// <summary>
        /// The client Server used for authentication.
        /// </summary>
        private static string ClientSecret;

        /// <summary>
        /// Object containing authorization details making it possible to reauthorize automatically when authorization is expired.
        /// </summary>
        private static AccessToken Authorization;

        /// <summary>
        /// HttpClient instance used by all HTTP requests.
        /// </summary>
        private static HttpClient httpClient { get; set; }

        /// <summary>
        /// Property facilitating singular initialization for the private httpClient
        /// </summary>
        public static HttpClient HttpClient
        {
            get
            {
                if (httpClient == null)
                {
                    httpClient = new HttpClient();
                }
                return httpClient;
            }
        }

        /// <summary>
        /// Function which initializes the httpRequestHandler
        /// </summary>
        /// <param name="clientId">The client Id used for authentication.</param>
        /// <param name="clientSecret">The client Secret used for authentication.</param>
        public static async Task Initialize(string clientId, string clientSecret)
        {
            ClientId = clientId;
            ClientSecret = clientSecret;
            Authorization = await GetAuthorization(ClientId, ClientSecret).ConfigureAwait(false);
        }

        /// <summary>
        /// Performs a post request to the Nordigen api trying to authorize with the supplied client id and secret
        /// </summary>
        /// <param name="clientId">The client Id used for authentication.</param>
        /// <param name="clientSecret">The client Secret used for authentication.</param>
        /// <returns></returns>
        private static async Task<Responses.AccessToken> GetAuthorization(string secretId, string secretKey)
        {
            var request = new UserSecret { Secret_id = secretId, Secret_key = secretKey };
            HttpClient.DefaultRequestHeaders.Accept.Clear();
            HttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(AcceptHeaders.Json));
            var htmlContent = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, AcceptHeaders.Json);
            var response = await HttpClient.PostAsync(new Uri(ApiUrl + "/token/new/"), htmlContent).ConfigureAwait(false);
            var responseContent = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            return JsonConvert.DeserializeObject<Responses.AccessToken>(responseContent);
        }

        /// <summary>
        /// Performs a post request filled with the given arguments.
        /// </summary>
        /// <param name="path">The end of the FullPath</param>
        /// <param name="content">The content which gets send</param>
        /// <param name="queryParameters">The parameters which get inserted as a query string</param>
        /// <param name="acceptHeader">The acceptheader</param>
        /// <returns>A promise of a HttpResponseMessage</returns>
        protected async Task<HttpResponseMessage> Post(string path, HttpContent content, Dictionary<string, string> queryParameters = null, string acceptHeader = AcceptHeaders.Json)
        {
            return await ApiHttpRequest(path, (uri) => { return HttpClient.PostAsync(uri, content); }, queryParameters, acceptHeader).ConfigureAwait(false);
        }

        /// <summary>
        /// Performs a get request filled with the given arguments.
        /// </summary>
        /// <param name="path">The end of the FullPath</param>
        /// <param name="queryParameters">The parameters which get inserted as a query string</param>
        /// <param name="acceptHeader">The acceptheader</param>
        /// <returns>A promise of a HttpResponseMessage</returns>
        protected async Task<HttpResponseMessage> Get(string path, Dictionary<string, string> queryParameters = null, string acceptHeader = AcceptHeaders.Json)
        {
            return await ApiHttpRequest(path, (uri) => { return HttpClient.GetAsync(uri); }, queryParameters, acceptHeader).ConfigureAwait(false);
        }

        /// <summary>
        /// Performs a put request filled with the given arguments.
        /// </summary>
        /// <param name="path">The end of the FullPath</param>
        /// <param name="content">The content which gets send</param>
        /// <param name="queryParameters">The parameters which get inserted as a query string</param>
        /// <param name="acceptHeader">The acceptheader</param>
        /// <returns>A promise of a HttpResponseMessage</returns>
        protected async Task<HttpResponseMessage> Put(string path, HttpContent content, Dictionary<string, string> queryParameters = null, string acceptHeader = AcceptHeaders.Json)
        {
            return await ApiHttpRequest(path, (uri) => { return HttpClient.PutAsync(uri, content); }, queryParameters, acceptHeader).ConfigureAwait(false);
        }

        /// <summary>
        /// Performs a delete request filled with the given arguments.
        /// </summary>
        /// <param name="path">The end of the FullPath</param>
        /// <param name="queryParameters">The parameters which get inserted as a query string</param>
        /// <param name="acceptHeader">The acceptheader</param>
        /// <returns>A promise of a HttpResponseMessage</returns>
        protected async Task<HttpResponseMessage> Delete(string path, Dictionary<string, string> queryParameters = null, string acceptHeader = AcceptHeaders.Json)
        {
            return await ApiHttpRequest(path, (uri) => { return HttpClient.DeleteAsync(uri); }, queryParameters, acceptHeader).ConfigureAwait(false);
        }

        /// <summary>
        /// Standardized function for performing HttpRequests.
        /// Allows for injection of the final request making it possible to fire 'POST','GET','PUT' and 'DELETE' requests through this one function.
        /// </summary>
        /// <param name="path">The end of the FullPath</param>
        /// <param name="httpRequest">A function requiring manual firing and returning of the prefered HttpRequest</param>
        /// <param name="queryParameters">The parameters which get inserted as a query string</param>
        /// <param name="acceptHeader">The acceptheader</param>
        /// <returns></returns>
        protected async Task<HttpResponseMessage> ApiHttpRequest(string path, Func<Uri, Task<HttpResponseMessage>> httpRequest, Dictionary<string, string> queryParameters = null, string acceptHeader = AcceptHeaders.Json)
        {
            string requestUrl = ApiUrl + path;
            var builder = new UriBuilder(requestUrl);
            if (queryParameters != null)
            {
                foreach (var kvp in queryParameters)
                {
                    if (!builder.Query.Contains("?"))
                    {
                        builder.Query = "?" + kvp.Key + "=" + kvp.Value;
                    }
                    else
                    {
                        builder.Query += "&" + kvp.Key + "=" + kvp.Value;
                    }
                }
            }
            HttpClient.DefaultRequestHeaders.Accept.Clear();
            HttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(acceptHeader));
            HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Authorization.Access);
            var response = await httpRequest(builder.Uri).ConfigureAwait(false);
            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                Authorization = await GetAuthorization(ClientId, ClientSecret).ConfigureAwait(false);
                HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Authorization.Access);
                response = await httpRequest(builder.Uri).ConfigureAwait(false);
            }
            if (!response.IsSuccessStatusCode)
            {
                var responseContentString = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                ApiCallException apiCallException = null;
                try
                {
                    apiCallException = JsonConvert.DeserializeObject<ApiCallException>(responseContentString);
                }
                catch
                {
                    throw new NordigenApiException("StatusCode: " + response.StatusCode.ToString() + " Reason: " + response.ReasonPhrase + " Content: " + response.Content.ReadAsStringAsync().Result);
                }
                throw apiCallException;
            }
            return response;
        }
    }
}
