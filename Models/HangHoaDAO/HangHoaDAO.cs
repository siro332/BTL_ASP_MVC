using System;
using System.Collections.Generic;
using System.Linq;
using BTL_Mvc.Models.Entities;

namespace BTL_Mvc.Models.HangHoaDAO
{
    public class HangHoaDAO
    {
        CosmeticDB_Context db;
        public HangHoaDAO()
        {
            db = new CosmeticDB_Context();
        }
        public IEnumerable<HangHoa> GetById(String id)
        {
            return db.HangHoa.Where(lh => lh.MaLoai.Equals(id));
        }
    }
}