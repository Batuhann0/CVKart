using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CVEntityProje
{
    public partial class Default : System.Web.UI.Page
    {
        CVEntityEntities Db = new CVEntityEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            //BİLGİ
            Repeater1.DataSource = Db.Tbl_HAKKIMDA.ToList();
            Repeater1.DataBind();

            //EGITIM
            Repeater2.DataSource = Db.Tbl_HAKKIMDA.ToList();
            Repeater2.DataBind();

            //IS DENEYİMLERİ
            Repeater3.DataSource = Db.Tbl_HAKKIMDA.ToList();
            Repeater3.DataBind();

            //YETENEK
            Repeater4.DataSource = Db.Tbl_YETENEKLER.ToList();
            Repeater4.DataBind();
        }

        #region GÖNDER BUTONU
        protected void Button1_Click(object sender, EventArgs e)
        {
            Tbl_ILETISIM t = new Tbl_ILETISIM();
            t.ADSOYAD = TextBox1.Text;
            t.MAIL = TextBox2.Text;
            t.KONU = TextBox3.Text;
            t.MESAJ = TextBox4.Text;

            Db.Tbl_ILETISIM.Add(t);
            Db.SaveChanges();

            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
        } 
        #endregion
    }
}