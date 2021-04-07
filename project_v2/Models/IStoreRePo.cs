using System.Collections.Generic;

namespace project_v2.Models
{
    public interface IStoreRePo
    {
        IEnumerable<Store> GetAllStore();
        Store GetStoreByID(int id);
    }
}