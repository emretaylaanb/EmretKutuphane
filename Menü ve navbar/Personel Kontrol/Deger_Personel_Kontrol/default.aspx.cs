
using System;
using System.Collections.Generic;

namespace Deger_Personel_Kontrol
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //new DAL().OrdersGetAsHTML("26G75");
            if (!IsPostBack)
            {
                //if (Request["ck"] != null)
                //{
                //    DataTable dt = new App_Code.DAL().CihaziSor(Request["ck"], Request["dt"], Request["dv"]);
                //    if (dt.Rows.Count > 0)
                //    {
                //        Girelim(dt.Rows[0]["AdSoyad"].ToString(), dt.Rows[0]["Sifre"].ToString());
                //    }
                //}
            }
        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            // new App_Code.DAL().KurlariGetir();
            txt_passw.Value = txt_passw.Value.Replace("'", "").Replace("\"", "");
            txt_usern.Value = txt_usern.Value.Replace("'", "").Replace("\"", "");

            Girelim(txt_usern.Value, txt_passw.Value);
        }
        protected void btn_unuttum_Click(object sender, EventArgs e)
        {
            //txt_email.Value = txt_email.Value.Replace("'", "").Replace("\"", "").Replace("--", "");

            //new KullanicilarOPS().SifremiUnuttum(txt_email.Value);

            //ClientScript.RegisterStartupScript(GetType(), "YeniPencere", @"<script language='javascript'>toastr['success']('Kullanıcı adı ve şifreniz, tanımlı mail adresiniz doğru ise tarafınıza gönderilmiştir.');</script>");
            //return;
        }

        public void Girelim(string un, string pa)
        {
            List<Users> u = Users.VerList("Uname=@P1 and Passw=@P2 and Cancelled=0", un, pa);
            if (u.Count == 1)
            {
                if (u[0].USR_ID == null)
                {
                    ClientScript.RegisterStartupScript(GetType(), "YeniPencere", @"<script language='javascript'>toastr['warning']('Kullanıcı bilgileri eksik veya hatalı !');</script>");
                    return;
                }

                Session["KUL_ID"] = u[0].USR_ID;
                Session["u"] = u;
                //Session["Role"] =item.Roller;
                Response.Redirect("inside.aspx");

                if (Request["ck"] != null)
                    //    new App_Code.DAL().CihaziKaydet(u, Request["ck"], Request["dt"], Request["dv"]);

                    //new App_Code.DAL().Logla(u.KUL_ID.ToString(), "login-ok", "", "", "", "");


                    Response.Redirect("inside.aspx");
            }
        }
    }
}