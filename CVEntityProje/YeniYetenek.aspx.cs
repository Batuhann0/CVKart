using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CVEntityProje
{
    public partial class YeniYetenek : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        CVEntityEntities db = new CVEntityEntities();
        protected void Button1_Click(object sender, EventArgs e)
        {
            Tbl_YETENEKLER yetenek = new Tbl_YETENEKLER();
            yetenek.YETENEK = TextBox1.Text;

            db.Tbl_YETENEKLER.Add(yetenek);
            db.SaveChanges();
            Response.Redirect("Yeteneklerim.aspx");
        }
    }
}