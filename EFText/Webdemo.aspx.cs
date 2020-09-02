using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EFText
{
    public partial class Webdemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EFModel2Container efmodel2container = new EFModel2Container();
            Techer techer = new Techer() { Class ="英语", Name ="葛若琛", CreateTime =DateTime.Now};
            OrderInfo orderinfo1 = new OrderInfo() { Id=Guid.NewGuid(), OrderNum ="1001",CreateTime="当前时间1",Techer = techer};
            OrderInfo orderinfo2 = new OrderInfo() { Id = Guid.NewGuid(), OrderNum = "1002", CreateTime = "当前时间2", Techer = techer };
            efmodel2container.Techer.Add(techer);
            efmodel2container.OrderInfo.Add(orderinfo1);
            efmodel2container.OrderInfo.Add(orderinfo2);
            efmodel2container.SaveChanges();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            EFModel2Container efmodel2container = new EFModel2Container();
            var teacherlist = from u in efmodel2container.Techer
                              select u;
            foreach (Techer techer in teacherlist) {
                Response.Write(techer.Name + ":");
                foreach (OrderInfo orderInfo in techer.OrderInfo) {
                    Response.Write(orderInfo.OrderNum);
                }
            }
        }
    }
}