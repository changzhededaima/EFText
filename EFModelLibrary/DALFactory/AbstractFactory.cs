using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using EFModelLibrary.IDAL;
using System.Reflection;

namespace EFModelLibrary.DALFactory
{
    //抽象工厂，通过反射形式创建类的实例
   public class AbstractFactory
    {
        private static readonly string Assemblypath = ConfigurationManager.AppSettings["Assemblypath"];
        private static readonly string NameSpace = ConfigurationManager.AppSettings["NameSpace"];
        public static StudentIDal CreateStudentInfoDal() {
            string fullclassName = NameSpace + ".DAL.StudentDal";
            return CreateInstance(fullclassName) as StudentIDal;
        } 
        private static object CreateInstance(string className) {
            var assembly = Assembly.Load(Assemblypath);
            return assembly.CreateInstance(className);
        }
    }
}
