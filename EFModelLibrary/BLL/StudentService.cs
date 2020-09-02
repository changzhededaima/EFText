using EFModelLibrary.DALFactory;
using EFModelLibrary.IBLL;
using EFModelLibrary.IDAL;
using EFModelLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFModelLibrary.BLL
{
    public class StudentService : BaseService<EFStudet>, IStudentService
    {
        //重写
        public override void SetCurrentDal()
        {
            CurrentDal = this.CurrentDBSession.studentidal;
        }
    }
}
