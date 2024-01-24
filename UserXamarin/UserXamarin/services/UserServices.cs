using System;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Threading.Tasks;
using UserXamarin.Models;
using Newtonsoft.Json;

namespace UserXamarin.services
{
	public class UserServices: IUserService
	{
		
        async Task<Root> IUserService.getUsers(int page)
        {
            string url = "https://reqres.in/api/users?page={page}";

            HttpClient client = new HttpClient();

            HttpResponseMessage response = await client.GetAsync(url);

            if (response.StatusCode == System.Net.HttpStatusCode.OK) {
                var result = await response.Content.ReadAsStringAsync();
                var json = JsonConvert.DeserializeObject<Root>(result);
                return json;
            }

            return null;
        }
    }
}

