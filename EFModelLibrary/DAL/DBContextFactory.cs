using EFModelLibrary.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;

namespace EFModelLibrary.DAL
{
    //负责创建ef数据操作上下文实例,保证线程内唯一
   public class DBContextFactory
    {
        public static DbContext CreateDbContext() {
            DbContext dbcontext = (DbContext)CallContext.GetData("dbContext");
            if (dbcontext==null) {
                dbcontext = new EFModelEntities();
                CallContext.SetData("dbContext", dbcontext);
            }
            return dbcontext;
        }
    }
}
