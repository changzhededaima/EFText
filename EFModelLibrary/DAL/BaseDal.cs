using EFModelLibrary.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EFModelLibrary.DAL
{
   public class BaseDal<T>where T:class,new()
    {
        DbContext efmodelentities = DBContextFactory.CreateDbContext();
        //EFModelEntities efmodelentities = new EFModelEntities();
        //添加
        public T AddEntity(T efstudet)
        {
            efmodelentities.Set<T>().Add(efstudet);
            //efmodelentities.SaveChanges();
            return efstudet;
        }
        //删除
        public bool DeleteEntity(T efstudet)
        {
            efmodelentities.Entry<T>(efstudet).State = System.Data.Entity.EntityState.Deleted;
            //return efmodelentities.SaveChanges() > 0;
            return true;
        }
        //更新
        public bool EditEntity(T efstudet)
        {
            efmodelentities.Entry<T>(efstudet).State = System.Data.Entity.EntityState.Modified;
            //return efmodelentities.SaveChanges() > 0;
            return true;
        }
        //查询
        public IQueryable<T> LoadEntities(Expression<Func<T, bool>> whereLambda)
        {
            //.Set<T>() 创建出ef可操作的数据
            return efmodelentities.Set<T>().Where<T>(whereLambda);
        }
        //分页
        public IQueryable<T> LoadPageEntities<s>(int pageIndex, int pagesize, out int totalcount, Expression<Func<T, bool>> whereLambda, Expression<Func<T, s>> orderbyLambda, bool isAsc)
        {
            var temp = efmodelentities.Set<T>().Where<T>(whereLambda);
            totalcount = temp.Count();
            if (isAsc)//升序
            {
                temp = temp.OrderBy<T, s>(orderbyLambda).Skip<T>((pageIndex - 1) * pagesize).Take<T>(pagesize);
            }
            else
            {
                temp = temp.OrderByDescending<T, s>(orderbyLambda).Skip<T>((pageIndex - 1) * pagesize).Take<T>(pagesize);
            }
            return temp;
        }
    }
}
