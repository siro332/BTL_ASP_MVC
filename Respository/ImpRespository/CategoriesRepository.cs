using BTL_Mvc.Models.Entities;

namespace BTL_Mvc.Respository.ImpRespository
{
    public class CategoriesRepository : RespositoryBase<Loai>, ICategoriesRepository
    {
        CosmeticDB_Context cosmeticDB_Context;
        public CategoriesRepository()
        {
            this.cosmeticDB_Context = new CosmeticDB_Context();
        }

    }
}