using EFModelLibrary.DAL;
using EFModelLibrary.IDAL;
using EFModelLibrary.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace EFModelLibrary.DALFactory
{
    //数据会话层,工厂类,完成所有数据操作类的示例,业务层通过数据会话层来回去要操作的数据类的示例.所以数据会话层将业务层将业务层与数据层解耦
   public class DBSession : IDBSeesion
    {
        //EFModelEntities efmodelentities = new EFModelEntities();
        public DbContext Db {
            get {
                return DBContextFactory.CreateDbContext();
            }
           
        }
        private StudentIDal _StudentIDal;

        public StudentIDal studentidal {
            get {
                if (_StudentIDal == null)
                {
                    _StudentIDal = AbstractFactory.CreateStudentInfoDal();//通过抽象工厂创建了类的实例
                }
                return _StudentIDal;
            }
            set {
                _StudentIDal = value;
            }
        }
        //数据会话层提供一个方法，完成所有数据的保存
        //一个业务中设计多张表操作，我们希望连接一次数据库完成多张表数据的操作，提高性能
        //工作单元模式：链接一次数据库进行多条操作 
        public bool SaveChangs() {
        //EFModelEntities efmodelentities = new EFModelEntities();
            return Db.SaveChanges()>0;
        }
    }
}
