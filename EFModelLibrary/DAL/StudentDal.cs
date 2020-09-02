using EFModelLibrary.IDAL;
using EFModelLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EFModelLibrary.DAL
{
    public class StudentDal : BaseDal<EFStudet>, StudentIDal
    {
        public new void LoadEntities<T>(Expression<Func<T, bool>> whereLambda) where T : class, new()
        {
            throw new NotImplementedException();
        }
    }
}
