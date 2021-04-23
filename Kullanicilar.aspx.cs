using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Proje.Personel
{
    public partial class Kullanicilar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            Proje.Is.Kullanicilar kullaniciliste = new Is.Kullanicilar();
            var sonuc = kullaniciliste.Listele();
            GridView1.DataSource = sonuc;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Proje.Is.Kullanicilar projeliste = new Is.Kullanicilar();
            var sonuc2 = projeliste.ListeleProje();
            GridView1.DataSource = sonuc2;
            GridView1.DataBind();
        }
    }
}