using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFModelLibrary.IDAL
{
    //公共方法
   public interface IBaseDal<T> where T:class,new()
    {
        //查询
        IQueryable<T> LoadEntities(System.Linq.Expressions.Expression<Func<T, bool>> whereLambda);
        //分页
        IQueryable<T> LoadPageEntities<s>(int pageIndex, int pagesize, out int totalcount, System.Linq.Expressions.Expression<Func<T, bool>> whereLambda, System.Linq.Expressions.Expression<Func<T, s>> orderbyLambda,bool isAsc);
        //删除
        bool DeleteEntity(T efstudet);
        //更新 
        bool EditEntity(T efstudet);
        //新增 
        T AddEntity(T efstudet);
    }
}
