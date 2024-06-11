using MyShop.DTOs;
using Newtonsoft.Json;
using System.Text;

namespace MyShop.App.Controllers
{
    public class SellController
    {
        // create the client
        private HttpClient _httpClient;
        private string _url = "http://localhost:5053/api/";
        public SellController()
        {
            _httpClient = new HttpClient();
        }

        public async Task<List<OrderDTO>> GetOrders()
        {
            try
            {
                List<OrderDTO> orders = new List<OrderDTO>();
                // send the request and save the response.
                var response = await _httpClient.GetAsync(_url + "order");

                // ensure a status code success.
                response.EnsureSuccessStatusCode();

                // read the response content as json string
                string responseJson = await response.Content.ReadAsStringAsync();

                // deserialize Json string to object Class.
                orders = JsonConvert.DeserializeObject<List<OrderDTO>>(responseJson)!;

                return orders;
            }
            catch (Exception ex)
            {
                //return null;
                throw new Exception(ex.Message);
            }
        }

        public async Task<OrderDTO> GetOrderById(int id)
        {
            try
            {
                OrderDTO order = new OrderDTO();
                // send the request and save the response.
                var response = await _httpClient.GetAsync(_url + "order/" + id);

                // ensure a status code success.
                response.EnsureSuccessStatusCode();

                // read the response content as json string
                string responseJson = await response.Content.ReadAsStringAsync();

                // deserialize Json string to object Class.
                order = JsonConvert.DeserializeObject<OrderDTO>(responseJson);

                return order;
            }
            catch (Exception ex)
            {
                return null;
                throw new Exception(ex.Message);
            }
        }

        public async Task<OrderDTO> CreateOrder(OrderDTO order)
        {
            try
            {
                // convert the class in JSON
                var content = new StringContent(JsonConvert.SerializeObject(order), Encoding.UTF8, "application/json");

                // send the request and save the response.
                var response = await _httpClient.PostAsync(_url + "order/", content);

                // ensure a status code success.
                response.EnsureSuccessStatusCode();

                // read the response content as json string
                string responseJson = await response.Content.ReadAsStringAsync();

                // deserialize Json string to object Class.
                order = JsonConvert.DeserializeObject<OrderDTO>(responseJson);

                return order;
            }
            catch (Exception ex)
            {
                //return null;
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> UpdateOrder(OrderDTO order)
        {
            try
            {
                // convert the class in JSON
                var content = new StringContent(JsonConvert.SerializeObject(order), Encoding.UTF8, "application/json");

                // send the request and save the response.
                var response = await _httpClient.PutAsync(_url + "order/", content);

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

        public async Task<bool> DeleteOrder(int id)
        {
            try
            {
                // send the request and save the response.
                var response = await _httpClient.DeleteAsync(_url + "order/" + id);

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
