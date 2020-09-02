using EFModelLibrary.DALFactory;
using EFModelLibrary.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace EFModelLibrary.BLL
{
    //抽象的
   public abstract class BaseService<T> where T:class,new ()
    {
        public IDBSeesion CurrentDBSession
        {
            get
            {
                //return new DBSession();
                return DBSessionFactory.CreateDBSession();
            }
        } 
        public IDAL.IBaseDal<T> CurrentDal { get; set; }
        //抽象方法
        public abstract void SetCurrentDal();
        public BaseService() {
            SetCurrentDal();
        }
        //查
        public IQueryable<T> LoadEntities(Expression<Func<T, bool>> whereLambda) {
            return CurrentDal.LoadEntities(whereLambda);
        }
        //分页
        public IQueryable<T> LoadPageEntities<s>(int pageIndex, int pagesize, out int totalcount, Expression<Func<T, bool>> whereLambda, Expression<Func<T, s>> orderbyLambda, bool isAsc)
        {
            return CurrentDal.LoadPageEntities<s>(pageIndex, pagesize, out totalcount, whereLambda, orderbyLambda, isAsc);
        }
        //删除
        public bool DeleteEntity(T efstudet) {
            CurrentDal.DeleteEntity(efstudet);
            return CurrentDBSession.SaveChangs();
        }
        //更新
        public bool EditEntity(T efstudet)
        {
            CurrentDal.EditEntity(efstudet);
            return CurrentDBSession.SaveChangs();
        }
        //添加
        public T AddEntity(T efstudet)
        {
            CurrentDal.AddEntity(efstudet);
            CurrentDBSession.SaveChangs();
            return efstudet;
        }
    }
}
