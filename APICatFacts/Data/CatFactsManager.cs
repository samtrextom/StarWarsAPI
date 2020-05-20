using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APISample.Data
{
    public class CatFactsManager
    {
        IRestService restService;
        public CatFactsManager(IRestService service)
        {
            restService = service;
        }

		public Task<List<CatFact>> GetTasksAsync()
		{
			return restService.RefreshDataAsync();
		}

	}
}
