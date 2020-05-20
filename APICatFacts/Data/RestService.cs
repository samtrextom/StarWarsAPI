using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace APISample.Data
{
    public class RestService : IRestService
    {
        HttpClient _client;

        public List<CatFact> Facts { get; private set; }

        public RestService()
        {
            _client = new HttpClient();
        }

        public async Task<List<CatFact>> RefreshDataAsync()
        {
            Facts = new List<CatFact>();

            
 
            try
            {
                for (int i=0;i<30;i++)
                {
                    var uri = new Uri(string.Format((Constants.CatFactsUrl+i+'/'), string.Empty));
                    var response = await _client.GetAsync(uri);
                    Debug.WriteLine("XXXX: " + response.ToString());
                    if (response.IsSuccessStatusCode)
                    {
                        var content = await response.Content.ReadAsStringAsync();
                        Debug.WriteLine(content);
                        CatFact catFact = JsonConvert.DeserializeObject<CatFact>(content);
                        Debug.WriteLine(catFact);
                        Facts.Add(catFact);
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }

            return Facts;
        }

        public Task SaveTodoCatFactAsync(CatFact item, bool isNewItem)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCatFactAsync(string id)
        {
            throw new NotImplementedException();
        }




        //      Task<List<CatFact>> IRestService.RefreshDataAsync()
        //      {
        //          throw new NotImplementedException();
        //      }


    }
}