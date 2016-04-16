using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using DevExpress.DevAV.ViewModels;
using Newtonsoft.Json;

namespace DevExpress.DevAV.Helpers
{
    public class WebApiHelper
    {
        public const string ItemsFromToday = "http://192.168.192.201/MealAppWebApi/api/Providermenuitem/today";
        public static async Task<List<ProviderMenuItem>> GetAllProducts()
        {
            var client = new HttpClient();
            {
                using (var response = await client.GetAsync(ItemsFromToday))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var productJsonString = await response.Content.ReadAsStringAsync();
                        return JsonConvert.DeserializeObject<ProviderMenuItem[]>(productJsonString).ToList();
                    }
                }
            }
            return null;
        }        
    }
}
