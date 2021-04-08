using System;
using System.Collections.Generic;
using BTL_Mvc.Models.Entities;

namespace BTL_Mvc.Respository
{
    public interface IProductRespository : IRespositoryBase<HangHoa>
    {
        IEnumerable<HangHoa> getAll(String id);
        IEnumerable<HangHoa> findNewProductsByCat(String id);

    }
}
