using MyShop.DTOs;
using Newtonsoft.Json;
using System.Text;

namespace MyShop.App.Controllers
{
    public class UserTypeController
    {
        // create the client
        private HttpClient _httpClient;
        private string _url = "http://localhost:5053/api/";
        public UserTypeController()
        {
            _httpClient = new HttpClient();
        }

        public async Task<List<UserTypeDTO>> GetUserTypes()
        {
            try
            {
                List<UserTypeDTO> types = new List<UserTypeDTO>();
                // send the request and save the response.
                var response = await _httpClient.GetAsync(_url+"usertype");

                // ensure a status code success.
                response.EnsureSuccessStatusCode();

                // read the response content as json string
                string responseJson = await response.Content.ReadAsStringAsync();

                // deserialize Json string to object Class.
                types = JsonConvert.DeserializeObject<List<UserTypeDTO>>(responseJson)!;

                return types;
            }
            catch (Exception ex)
            {
                return null;
                throw new Exception(ex.Message);
            }
        }

        public async Task<UserTypeDTO> GetUserTypeById(int id)
        {
            try
            {
                UserTypeDTO type = new UserTypeDTO();
                // send the request and save the response.
                var response = await _httpClient.GetAsync(_url + "usertype/"+id);

                // ensure a status code success.
                response.EnsureSuccessStatusCode();

                // read the response content as json string
                string responseJson = await response.Content.ReadAsStringAsync();

                // deserialize Json string to object Class.
                type = JsonConvert.DeserializeObject<UserTypeDTO>(responseJson);

                return type;
            }
            catch (Exception ex)
            {
                return null;
                throw new Exception(ex.Message);
            }
        }

        public async Task<UserTypeDTO> CreateType(UserTypeDTO type)
        {
            try
            {
                // convert the class in JSON
                var content = new StringContent(JsonConvert.SerializeObject(type), Encoding.UTF8, "application/json");

                // send the request and save the response.
                var response = await _httpClient.PostAsync(_url + "usertype/", content);

                // ensure a status code success.
                response.EnsureSuccessStatusCode();

                // read the response content as json string
                string responseJson = await response.Content.ReadAsStringAsync();

                // deserialize Json string to object Class.
                type = JsonConvert.DeserializeObject<UserTypeDTO>(responseJson);

                return type;
            }
            catch (Exception ex)
            {
                return null;
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> UpdateUserType(UserTypeDTO type)
        {
            try
            {
                // convert the class in JSON
                var content = new StringContent(JsonConvert.SerializeObject(type), Encoding.UTF8, "application/json");

                // send the request and save the response.
                var response = await _httpClient.PutAsync(_url + "usertype/", content);

                // ensure a status code success.
                response.EnsureSuccessStatusCode();

                // read the response content as json string
                var responseJson = await response.Content.ReadAsStringAsync();

                

                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> DeleteUserType(int id)
        {
            try
            {
                // send the request and save the response.
                var response = await _httpClient.DeleteAsync(_url + "usertype/" + id);

                // ensure a status code success.
                response.EnsureSuccessStatusCode();

                // read the response content as json string
                string responseJson = await response.Content.ReadAsStringAsync();


                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception(ex.Message);
            }
        }
    }
}
