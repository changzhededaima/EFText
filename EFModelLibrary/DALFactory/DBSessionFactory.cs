using EFModelLibrary.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;

namespace EFModelLibrary.DALFactory
{
   public class DBSessionFactory
    {
        public static IDBSeesion CreateDBSession()
        {
            IDBSeesion DbSession = (IDBSeesion)CallContext.GetData("dbSession");
            if (DbSession == null)
            {
                DbSession = new DALFactory.DBSession();
                CallContext.SetData("dbSession", DbSession);
            }
            return DbSession;
        }
    }
}
