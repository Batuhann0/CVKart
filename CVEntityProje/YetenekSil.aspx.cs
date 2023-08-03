using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CVEntityProje
{
    public partial class YetenekSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CVEntityEntities db = new CVEntityEntities();

            int x = int.Parse(Request.QueryString["ID"]);

            var yetenek = db.Tbl_YETENEKLER.Find(x);
            db.Tbl_YETENEKLER.Remove(yetenek);
            db.SaveChanges();
            Response.Redirect("Yeteneklerim.aspx");
        }
    }
}