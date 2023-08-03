using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CVEntityProje
{
    public partial class İstatistik : System.Web.UI.Page
    {
        CVEntityEntities db = new CVEntityEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            lblyetenek.Text = db.Tbl_YETENEKLER.Count().ToString();
            Lblmesaj.Text = db.Tbl_ILETISIM.Count().ToString();
            lblderece.Text = db.Tbl_YETENEKLER.Average(x => x.DERECE).ToString();
            lblenyüksek.Text = db.Tbl_YETENEKLER.Max(x => x.DERECE).ToString();
            lblenyüksekyetenek.Text = db.Tbl_YETENEKLER.Max(x => x.YETENEK).ToString();
        }
    }
}