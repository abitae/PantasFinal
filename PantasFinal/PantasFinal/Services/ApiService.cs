using Newtonsoft.Json;
using PantasFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PantasFinal.Services
{
    public class ApiService
    {
        public async Task<Response> Login(string usuario,string password)
        {
            try
            {
                var loginRequest = new LoginRequest {
                    Usuario = usuario,
                    Password= password
                };
                var request = JsonConvert.SerializeObject(loginRequest);
                var content = new StringContent(request,Encoding.UTF8,"application/json");
                var client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:62836");
                var url = "/api/usuarios";
                var response = await client.PostAsync(url,content);
                if (!response.IsSuccessStatusCode)
                {
                    return new Response
                    {
                        IsSuccess = false,
                        Message = "Incorrecto"
                        
                    };
                }
                var result = await response.Content.ReadAsStringAsync();
                var user = JsonConvert.DeserializeObject<Usuarios>(result);
                return new Response
                {
                    IsSuccess = true,
                    Message = "Correcto",
                    Result = user

                };
            }
            catch(Exception ex)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = ex.Message,

                };
            }

        }
    }
}
