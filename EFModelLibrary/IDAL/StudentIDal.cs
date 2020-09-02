using EFModelLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EFModelLibrary.IDAL
{
    public interface StudentIDal : IBaseDal<EFStudet>
    {
        //定义自己特有方法
        void LoadEntities<T>(Expression<Func<T, bool>> whereLambda) where T : class, new();
    }
} 
