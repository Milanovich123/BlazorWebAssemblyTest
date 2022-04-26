using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using BlazorProject.Shared.ResponseClasses;
using Newtonsoft.Json;

namespace BlazorProject.Client
{
    public class BimsyncService
    {
        public HttpClient httpClient { get; set; }
        private string clientId;
        private string client_secret;
        public TokenResponse tokenResponse { get; set; }
        public ViewerResponse viewerResponse { get; set; }
        public Guid ranguid { get; } = Guid.NewGuid();
        public BimsyncService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
            clientId = "uSta6pVCW8WHNKc";
            client_secret = "OltxIrZu4YI1O6H";
        }
        public async Task<string> GetTokens(string code, string verifier, string uri)
        {
            string errorMessage = null;

            string url = $"https://api.bimsync.com/oauth2/token";

            var nvc = new Dictionary<string, string>();
            nvc.Add("grant_type", "authorization_code");
            nvc.Add("code", code);
            nvc.Add("client_id", clientId);
            nvc.Add("client_secret", client_secret);
            nvc.Add("redirect_uri", uri);
            var req = new HttpRequestMessage(HttpMethod.Post, url) { Content = new FormUrlEncodedContent(nvc) };
            var response = await httpClient.SendAsync(req);

            if (!response.IsSuccessStatusCode)
            {
                errorMessage = response.ReasonPhrase;
                Console.WriteLine($"There was an error! {errorMessage}");
                return errorMessage;
            }

            tokenResponse = await response.Content.ReadFromJsonAsync<TokenResponse>();
            return tokenResponse.access_token;
        }

        public async Task<ViewerResponse> GetViewerToken(string projectId, ModelResponse model = null)
        {
            string errorMessage = null;
            string jsonModel = "";
            if (model != null)
            {
                jsonModel = JsonConvert.SerializeObject(model);
                Console.WriteLine("Json string: " + jsonModel);
            }
            string url = $"https://api.bimsync.com/v2/projects/{projectId}/viewer3d/token";
            //string url = $"https://api.bimsync.com/v2/projects/{projectId}/viewer2d/token";

            var req = new HttpRequestMessage(HttpMethod.Post, url);
            req.Content = new StringContent(jsonModel, Encoding.UTF8, "application/json");           
            
            var response = await httpClient.SendAsync(req);

            if (!response.IsSuccessStatusCode)
            {
                errorMessage = response.ReasonPhrase;
                Console.WriteLine($"There was an error! {errorMessage}");
            }

            viewerResponse = await response.Content.ReadFromJsonAsync<ViewerResponse>();
            return viewerResponse;
        }
        public async Task<List<ProjectResponse>> GetProjects()
        {
            var request = new HttpRequestMessage(HttpMethod.Get,
                "https://api.bimsync.com/v2/projects");
            httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", tokenResponse.access_token);
            HttpResponseMessage response = await httpClient.SendAsync(request);
            return await response.Content.ReadFromJsonAsync<List<ProjectResponse>>();
        }
        public async Task<UserResponse> GetUser()
        {
            var request = new HttpRequestMessage(HttpMethod.Get,
                "https://api.bimsync.com/v2/user");
            httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", tokenResponse.access_token);
            HttpResponseMessage response = await httpClient.SendAsync(request);
            return await response.Content.ReadFromJsonAsync<UserResponse>();
        }

        public async Task<List<ModelResponse>> GetModels(string projectId)
        {
            var request = new HttpRequestMessage(HttpMethod.Get,
                "https://api.bimsync.com/v2/projects/" + projectId + "/models");
            HttpResponseMessage response = await httpClient.SendAsync(request);
            return await response.Content.ReadFromJsonAsync<List<ModelResponse>>();
        }
        public async Task<EntityResponse> GetObject(string projectId, string objectId)
        {
            string errorMessage = null;
            var request = new HttpRequestMessage(HttpMethod.Get,
                "https://api.bimsync.com/v2/projects/" + projectId + "/ifc/products/" + objectId);
            HttpResponseMessage response = await httpClient.SendAsync(request);
            if (!response.IsSuccessStatusCode)
            {
                errorMessage = response.ReasonPhrase;
                Console.WriteLine($"There was an error! {errorMessage}");
            } 
            return await response.Content.ReadFromJsonAsync<EntityResponse>();
        }
    }
}