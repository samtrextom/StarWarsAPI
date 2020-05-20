using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APISample.Data
{
    public interface IRestService
    {
        Task<List<CatFact>> RefreshDataAsync ();

        Task SaveTodoCatFactAsync (CatFact item, bool isNewItem);

        Task DeleteCatFactAsync (string id);
    }
}
