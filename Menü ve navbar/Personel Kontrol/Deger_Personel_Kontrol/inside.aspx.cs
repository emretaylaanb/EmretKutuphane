
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;

namespace Deger_Personel_Kontrol
{
    public partial class inside : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["op"] == "ex")
            {
                Session.Clear();
                Response.Redirect("default.aspx");
                return;
            }
            if (Session["u"] == null)
            {
                Session.Clear();
                Response.Redirect("default.aspx");
                return;
            }
            if (!IsPostBack)
            {
                
                lbl_ToplamFormSayisi.Text = new DBOps().scs("select count(*) from FormYanitlar");
                lbl_Yanitlanan.Text = new DBOps().scs("select count(*) from FormYanitlar where Secenek Is not null ");
                lbl_GunlukCikis.Text= new DBOps().scs("select count(*) from FormYanitlar where Secenek Is null ");
            }
        }
    }
}