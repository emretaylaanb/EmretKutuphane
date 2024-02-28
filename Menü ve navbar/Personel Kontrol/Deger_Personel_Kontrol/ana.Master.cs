using BLL.OPs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Deger_Personel_Kontrol
{
    public partial class ana : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["u"] == null)
            {
                Session.Clear();
                Response.Redirect("default.aspx");
                return;
            }

            if (!IsPostBack)
            {
                if (Session["u"] != null)
                {
                    List<Users> u = ((List<Users>)Session["u"]);

                    lbl_adsoyad.Text = u[0].Uname;// u.CUnvan;
                    ltr_menumuz.Text = new OrtakOPs().MenuVer_Static(u);
                    img_avatar.ImageUrl = "img/avatars/" + (lbl_adsoyad.Text.Length > 0 ? lbl_adsoyad.Text.Substring(0, 1) : "A") + ".png";
                }
            }
        }
    }
}