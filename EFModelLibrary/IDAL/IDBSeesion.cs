using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace EFModelLibrary.IDAL
{
    //业务层调用的是数据会话层的接口
   public interface IDBSeesion
    {
         DbContext Db{ get; }
         StudentIDal studentidal { get; set; }
         bool SaveChangs();
        

        }
}
