using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EFText
{
    public partial class Webtest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //增
        protected void Button1_Click(object sender, EventArgs e)
        {
            EFStudet efstudet = new EFStudet();
            efstudet.Name = "许柯";
            efstudet.Age = 25;
            efstudet.Six = "男";
            EFModelEntities efmodelentities = new EFModelEntities();
            efmodelentities.EFStudet.Add(efstudet);
            int result = efmodelentities.SaveChanges();//受影响的行数
            Response.Write(efstudet.Id);
        }
        //查
        protected void Button2_Click(object sender, EventArgs e)
        {
            EFModelEntities efmodelentities = new EFModelEntities();
            //linq表达式
            //泛型集合
           var studentlist = from u in efmodelentities.EFStudet
                              where u.Id == 5
                              select u;
            //运行到in时生成sql语句,延迟加载机制,数据用时才查询
            foreach (EFStudet student in studentlist)
            {
                Response.Write(student.Name);
            }
        }
        //删
        protected void Button3_Click(object sender, EventArgs e)
        {
            EFModelEntities efmodelentities = new EFModelEntities();
            EFStudet efstudet = new EFStudet() {Id=6 };
            //确定需要处理的类
            efmodelentities.Entry<EFStudet>(efstudet).State = System.Data.Entity.EntityState.Deleted;
            efmodelentities.SaveChanges();
            //第二种方法
            //var studentlist = from u in efmodelentities.EFStudet
            //              where u.Id == 5
            //              select u;
            //EFStudet efstudet = studentlist.FirstOrDefault();//返回第一条数据,没有值返回null
            //if (efstudet != null)
            //{
            //    efmodelentities.EFStudet.Remove(efstudet);
            //    int result = efmodelentities.SaveChanges();//受影响的行数
            //}
            //else {
            //    Response.Write("不存在");
            //}
        }
        //改
        protected void Button4_Click(object sender, EventArgs e)
        {
            EFModelEntities efmodelentities = new EFModelEntities();
            var studentlist = from u in efmodelentities.EFStudet
                              where u.Id > 3
                              select u;
            //新建类需要带着主键才能更新
            EFStudet efstudet = new EFStudet();
            efstudet.Id = 2;
            efstudet.Name = "任晓东";
            efmodelentities.Entry<EFStudet>(efstudet).State = System.Data.Entity.EntityState.Modified;
            //foreach (EFStudet ss in studentlist) {
            //    ss.Name = "王梦梦";
            //    efmodelentities.Entry<EFStudet>(ss).State = System.Data.Entity.EntityState.Modified;
            //}

            //efstudet.Name = "王梦梦";
            //efmodelentities.Entry<EFStudet>(efstudet).State = System.Data.Entity.EntityState.Modified;
            efmodelentities.SaveChanges();
        }
    }
}