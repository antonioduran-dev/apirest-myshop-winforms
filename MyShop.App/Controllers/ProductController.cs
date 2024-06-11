using MyShop.DTOs;
using Newtonsoft.Json;
using System.Text;

namespace MyShop.App.Controllers
{
    public class ProductController
    {
        // create the client
        private HttpClient _httpClient;
        private string _url = "http://localhost:5053/api/";
        public ProductController()
        {
            _httpClient = new HttpClient();
        }

        public async Task<List<ProductDTO>> GetProducts()
        {
            try
            {
                List<ProductDTO> products = new List<ProductDTO>();
                // send the request and save the response.
                var response = await _httpClient.GetAsync(_url+"product");

                // ensure a status code success.
                response.EnsureSuccessStatusCode();

                // read the response content as json string
                string responseJson = await response.Content.ReadAsStringAsync();

                // deserialize Json string to object Class.
                products = JsonConvert.DeserializeObject<List<ProductDTO>>(responseJson)!;

                return products;
            }
            catch (Exception ex)
            {
                //return null;
                throw new Exception(ex.Message);
            }
        }

        public async Task<ProductDTO> GetProductById(int id)
        {
            try
            {
                ProductDTO product = new ProductDTO();
                // send the request and save the response.
                var response = await _httpClient.GetAsync(_url + "product/"+id);

                // ensure a status code success.
                response.EnsureSuccessStatusCode();

                // read the response content as json string
                string responseJson = await response.Content.ReadAsStringAsync();

                // deserialize Json string to object Class.
                product = JsonConvert.DeserializeObject<ProductDTO>(responseJson);

                return product;
            }
            catch (Exception ex)
            {
                return null;
                throw new Exception(ex.Message);
            }
        }

        public async Task<ProductDTO> CreateProduct(ProductDTO product)
        {
            try
            {
                // convert the class in JSON
                var content = new StringContent(JsonConvert.SerializeObject(product), Encoding.UTF8, "application/json");

                // send the request and save the response.
                var response = await _httpClient.PostAsync(_url + "product/", content);

                // ensure a status code success.
                response.EnsureSuccessStatusCode();

                // read the response content as json string
                string responseJson = await response.Content.ReadAsStringAsync();

                // deserialize Json string to object Class.
                product = JsonConvert.DeserializeObject<ProductDTO>(responseJson);

                return product;
            }
            catch (Exception ex)
            {
                //return null;
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> UpdateProduct(ProductDTO product)
        {
            try
            {
                // convert the class in JSON
                var content = new StringContent(JsonConvert.SerializeObject(product), Encoding.UTF8, "application/json");

                // send the request and save the response.
                var response = await _httpClient.PutAsync(_url + "product/", content);

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

        public async Task<bool> DeleteProduct(int id)
        {
            try
            {
                // send the request and save the response.
                var response = await _httpClient.DeleteAsync(_url + "product/" + id);

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
