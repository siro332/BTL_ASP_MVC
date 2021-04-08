using System.Collections.Generic;
using System.Linq;
using BTL_Mvc.Models.Entities;

namespace BTL_Mvc.Respository.ImpRespository
{
    public class ProductRespository : RespositoryBase<HangHoa>, IProductRespository
    {
        protected CosmeticDB_Context cosmeticDB_Context;

        public ProductRespository()
        {
            cosmeticDB_Context = new CosmeticDB_Context();
        }

        public IEnumerable<HangHoa> findNewProductsByCat(string id)
        {
            return this.cosmeticDB_Context.HangHoa.Where(hh => hh.MaLoai.Equals(id)).Take(6);
        }

        public IEnumerable<HangHoa> getAll(string id)
        {
            return this.cosmeticDB_Context.HangHoa.Where(hh => hh.MaLoai.Equals(id));
        }

    }
}