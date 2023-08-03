using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CVEntityProje
{
    public partial class YetenekGüncelle : System.Web.UI.Page
    {
        CVEntityEntities db = new CVEntityEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["ID"]);
            if (Page.IsPostBack == false)
            {
                var yt = db.Tbl_YETENEKLER.Find(id);
                TextBox1.Text = yt.YETENEK;
            }

        }

        #region Güncelle
        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["ID"]);
            var yt = db.Tbl_YETENEKLER.Find(id);

            yt.YETENEK = TextBox1.Text;
            db.SaveChanges();
            Response.Redirect("Yeteneklerim.aspx");
        }
        #endregion
    }
}