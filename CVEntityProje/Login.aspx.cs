using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CVEntityProje
{
    public partial class Login : System.Web.UI.Page
    {
        CVEntityEntities DB = new CVEntityEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            var sorgu = from x in DB.Tbl_ADMİN
                        where x.KULLANICIAD == txtkullanıcı.Text && x.SIFRE == txtşifre.Text
                        select x;


            if (sorgu.Any())
            {
                Response.Redirect("İletişim.aspx");
            }
            else
            {
                Response.Write("Hatalı Kullanıcı adı veya Şifre");
            }


        }
    }
}