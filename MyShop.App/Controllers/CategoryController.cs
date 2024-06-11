using MyShop.DTOs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.App.Controllers
{
    public class CategoryController
    {
        // create the client
        private HttpClient _httpClient;
        private string _url = "http://localhost:5053/api/";
        public CategoryController()
        {
            _httpClient = new HttpClient();
        }

        public async Task<List<CategoryDTO>> GetCategories()
        {
            try
            {
                List<CategoryDTO> categories = new List<CategoryDTO>();
                // send the request and save the response.
                var response = await _httpClient.GetAsync(_url + "category");

                // ensure a status code success.
                response.EnsureSuccessStatusCode();

                // read the response content as json string
                string responseJson = await response.Content.ReadAsStringAsync();

                // deserialize Json string to object Class.
                categories = JsonConvert.DeserializeObject<List<CategoryDTO>>(responseJson)!;

                return categories;
            }
            catch (Exception ex)
            {
                return null;
                throw new Exception(ex.Message);
            }
        }

        public async Task<CategoryDTO> GetCategoryById(int id)
        {
            try
            {
                CategoryDTO cat = new CategoryDTO();
                // send the request and save the response.
                var response = await _httpClient.GetAsync(_url + "category/" + id);

                // ensure a status code success.
                response.EnsureSuccessStatusCode();

                // read the response content as json string
                string responseJson = await response.Content.ReadAsStringAsync();

                // deserialize Json string to object Class.
                cat = JsonConvert.DeserializeObject<CategoryDTO>(responseJson);

                return cat;
            }
            catch (Exception ex)
            {
                return null;
                throw new Exception(ex.Message);
            }
        }

        public async Task<CategoryDTO> CreateCategory(CategoryDTO category)
        {
            try
            {
                // convert the class in JSON
                var content = new StringContent(JsonConvert.SerializeObject(category), Encoding.UTF8, "application/json");

                // send the request and save the response.
                var response = await _httpClient.PostAsync(_url + "category/", content);

                // ensure a status code success.
                response.EnsureSuccessStatusCode();

                // read the response content as json string
                string responseJson = await response.Content.ReadAsStringAsync();

                // deserialize Json string to object Class.
                category = JsonConvert.DeserializeObject<CategoryDTO>(responseJson);

                return category;
            }
            catch (Exception ex)
            {
                return null;
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> UpdateCategory(CategoryDTO category)
        {
            try
            {
                // convert the class in JSON
                var content = new StringContent(JsonConvert.SerializeObject(category), Encoding.UTF8, "application/json");

                // send the request and save the response.
                var response = await _httpClient.PutAsync(_url + "category/", content);

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

        public async Task<bool> DeleteCategory(int id)
        {
            try
            {
                // send the request and save the response.
                var response = await _httpClient.DeleteAsync(_url + "category/" + id);

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
