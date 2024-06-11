using MyShop.DTOs;
using Newtonsoft.Json;
using System.Text;

namespace MyShop.App.Controllers
{
    public class UserController
    {
        // create the client
        private HttpClient _httpClient;
        private string _url = "http://localhost:5053/api/";
        public UserController()
        {
            _httpClient = new HttpClient();
        }

        public async Task<List<UserDTO>> GetUsers()
        {
            try
            {
                List<UserDTO> users = new List<UserDTO>();
                // send the request and save the response.
                var response = await _httpClient.GetAsync(_url+"user");

                // ensure a status code success.
                response.EnsureSuccessStatusCode();

                // read the response content as json string
                string responseJson = await response.Content.ReadAsStringAsync();

                // deserialize Json string to object Class.
                users = JsonConvert.DeserializeObject<List<UserDTO>>(responseJson)!;

                return users;
            }
            catch (Exception ex)
            {
                //return null;
                throw new Exception(ex.Message);
            }
        }

        public async Task<UserDTO> GetUserById(int id)
        {
            try
            {
                UserDTO user = new UserDTO();
                // send the request and save the response.
                var response = await _httpClient.GetAsync(_url + "user/"+id);

                // ensure a status code success.
                response.EnsureSuccessStatusCode();

                // read the response content as json string
                string responseJson = await response.Content.ReadAsStringAsync();

                // deserialize Json string to object Class.
                user = JsonConvert.DeserializeObject<UserDTO>(responseJson);

                return user;
            }
            catch (Exception ex)
            {
                return null;
                throw new Exception(ex.Message);
            }
        }

        public async Task<UserDTO> CreateUser(UserDTO user)
        {
            try
            {
                // convert the class in JSON
                var content = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");

                // send the request and save the response.
                var response = await _httpClient.PostAsync(_url + "user/", content);

                // ensure a status code success.
                response.EnsureSuccessStatusCode();

                // read the response content as json string
                string responseJson = await response.Content.ReadAsStringAsync();

                // deserialize Json string to object Class.
                user = JsonConvert.DeserializeObject<UserDTO>(responseJson);

                return user;
            }
            catch (Exception ex)
            {
                //return null;
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> UpdateUser(UserDTO user)
        {
            try
            {
                // convert the class in JSON
                var content = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");

                // send the request and save the response.
                var response = await _httpClient.PutAsync(_url + "user/", content);

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

        public async Task<bool> DeleteUser(int id)
        {
            try
            {
                // send the request and save the response.
                var response = await _httpClient.DeleteAsync(_url + "user/" + id);

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
