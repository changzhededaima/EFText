using EFModelLibrary.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace EFModelLibrary.IBLL
{
   public interface IBaceService<T> where T:class,new()
    {
        IDBSeesion CurrentDBSession { get; }
        IDAL.IBaseDal<T> CurrentDal { get; set; }
        IQueryable<T> LoadEntities(Expression<Func<T, bool>> whereLambda);
        IQueryable<T> LoadPageEntities<s>(int pageIndex, int pagesize, out int totalcount, Expression<Func<T, bool>> whereLambda, Expression<Func<T, s>> orderbyLambda, bool isAsc);
        bool DeleteEntity(T efstudet);
        bool EditEntity(T efstudet);
        T AddEntity(T efstudet);
    }
}
