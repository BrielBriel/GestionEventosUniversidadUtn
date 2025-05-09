using System.Text;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace Librerria.API.Consumer
{
    public static class Crud<T>
    {
       
        private static readonly HttpClient client = new HttpClient();

        
        public static string EndPoint { get; set; }

        public static async Task<List<T>> GetAll()
        {
            try
            {
                var response = await client.GetAsync(EndPoint);
                response.EnsureSuccessStatusCode(); 
                var json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<T>>(json);
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Request failed: {ex.Message}");
            }
            catch (Exception ex)
            {
                throw new Exception($"Unexpected error: {ex.Message}");
            }
        }

        public static async Task<T> GetById(int id)
        {
            try
            {
                var response = await client.GetAsync($"{EndPoint}/{id}");
                response.EnsureSuccessStatusCode(); 
                var json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(json);
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Request failed: {ex.Message}");
            }
            catch (Exception ex)
            {
                throw new Exception($"Unexpected error: {ex.Message}");
            }
        }

        public static async Task<T> Create(T item)
        {
            try
            {
                var response = await client.PostAsync(
                    EndPoint,
                    new StringContent(
                        JsonConvert.SerializeObject(item),
                        Encoding.UTF8,
                        "application/json"
                    )
                );

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<T>(json);
                }
                else
                {
                    throw new Exception($"Error: {response.StatusCode}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Request failed: {ex.Message}");
            }
            catch (Exception ex)
            {
                throw new Exception($"Unexpected error: {ex.Message}");
            }
        }

        public static async Task<bool> Update(int id, T item)
        {
            try
            {
                var response = await client.PutAsync(
                    $"{EndPoint}/{id}",
                    new StringContent(
                        JsonConvert.SerializeObject(item),
                        Encoding.UTF8,
                        "application/json"
                    )
                );

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    throw new Exception($"Error: {response.StatusCode}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Request failed: {ex.Message}");
            }
            catch (Exception ex)
            {
                throw new Exception($"Unexpected error: {ex.Message}");
            }
        }

        public static async Task<bool> Delete(int id)
        {
            try
            {
                var response = await client.DeleteAsync($"{EndPoint}/{id}");
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    throw new Exception($"Error: {response.StatusCode}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Request failed: {ex.Message}");
            }
            catch (Exception ex)
            {
                throw new Exception($"Unexpected error: {ex.Message}");
            }
        }

        
        public static void SetAuthorizationHeader(string token)
        {
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        }
    }
}
