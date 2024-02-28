using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace BLL.OPs
{
    public class OrtakOPs
    {
        public string SecilenleriVerT(ListBox lstb)
        {
            int ks = 0;
            string secilenler = "";
            for (int i = 0; i < lstb.Items.Count; i++)
            {
                if (lstb.Items[i].Selected)
                {
                    secilenler += "" + lstb.Items[i].Value + ",";
                    ks++;
                }
            }

            if (secilenler.EndsWith(",")) secilenler = secilenler.Substring(0, secilenler.Length - 1);

            return secilenler;
        }
        public void SecilenleriVar(ListBox lstb, string Secilecekler)
        {
            string[] secilenler = Secilecekler.Split(new string[1] { "," }, StringSplitOptions.RemoveEmptyEntries);
            for (int j = 0; j < secilenler.Length; j++)
            {
                for (int i = 0; i < lstb.Items.Count; i++)
                {
                    if (lstb.Items[i].Value == secilenler[j])
                    {
                        lstb.Items[i].Selected = true;
                        break;
                    }
                }
            }
        }
        public string MenuVer_Static(List<Users> u)
        {

            string m = "";

            if (u[0].Role.Contains("Kullanicilar"))
            {
                m += @"

      <li class='nav-item' id='nav-admin-Kullanicilar'>
        <a class='nav-link collapsed' href='#' data-toggle='collapse' data-target='#collapseKullanicilar' aria-expanded='true' aria-controls='collapseKullanicilar'>
          <i class='fas fa-users'></i>
          <span>Kullanicilar</span>
        </a>
        <div id='collapseKullanicilar' class='collapse' aria-labelledby='headingKullanicilar' data-parent='#accordionSidebar'>
          <div class='bg-white py-2 collapse-inner rounded'>
 <a class='collapse-item' href='sf_Kullanicilar.aspx' id='nav2-log-Kullanicilar'>Yeni Kullanici</a>
 <a class='collapse-item' href='sf_Kullanicilar.aspx?op=l' id='nav2-log-Kullanicilar?op=l'>Kullanicilar</a>
          </div>
        </div>
      </li>
      ";
            }
            if (u[0].Role.Contains("Kisiler"))
            {
                m += @"

      <li class='nav-item' id='nav-log-Kisiler'>
        <a class='nav-link collapsed' href='#' data-toggle='collapse' data-target='#collapseKisiler' aria-expanded='true' aria-controls='collapseKisiler'>
          <i class='fas fa-users'></i>
          <span>Kişiler</span>
        </a>
        <div id='collapseKisiler' class='collapse' aria-labelledby='headingKisiler' data-parent='#accordionSidebar'>
          <div class='bg-white py-2 collapse-inner rounded'>
 <a class='collapse-item' href='sf_Kisiler.aspx' id='nav2-log-Kisiler'>Yeni Kişi</a>
 <a class='collapse-item' href='sf_Kisiler.aspx?op=l' id='nav2-log-Kisilerl?op=l'>Kişiler</a>
          </div>
        </div>
      </li>
      ";
            }
            if (u[0].Role.Contains("FormTalepleri"))
            {
                m += @"

     <li class='nav-item' id='nav-log-FormTalepleri'>
        <a class='nav-link collapsed' href='#' data-toggle='collapse' data-target='#collapseFormTalepleri' aria-expanded='true' aria-controls='collapseFormTalepleri'>
          <i class='fas fa-file'></i>
          <span>Formlar</span>
        </a>
        <div id='collapseFormTalepleri' class='collapse' aria-labelledby='headingFormTalepleri' data-parent='#accordionSidebar'>
          <div class='bg-white py-2 collapse-inner rounded'>
 <a class='collapse-item' href='sf_Formlar.aspx' id='nav2-log-FormTalepleri'>Yeni Form Talebi</a>
 <a class='collapse-item' href='sf_Formlar.aspx?op=l' id='nav2-log-FormTalepleril?op=l'>Form Talepleri</a>
          </div>
        </div>
      </li>
      ";
            }
            if (u[0].Role.Contains("FormBildirimi"))
            {
                m += @"

     <li class='nav-item' id='nav-log-FormBildirimi'>
        <a class='nav-link collapsed' href='#' data-toggle='collapse' data-target='#collapseFormBildirimi' aria-expanded='true' aria-controls='collapseFormBildirimi'>
          <i class='fas fa-bell'></i>
          <span>Form Bildirimi</span>
        </a>
        <div id='collapseFormBildirimi' class='collapse' aria-labelledby='headingFormBildirimi' data-parent='#accordionSidebar'>
          <div class='bg-white py-2 collapse-inner rounded'>
 <a class='collapse-item' href='sf_FormBildirimi.aspx' id='nav2-log-FormBildirimi'>Yeni Form Bildirimi</a>
          </div>
        </div>
      </li>
      ";
            }
            if (u[0].Role.Contains("Yanıtlar"))
            {
                m += @"

        <li class='nav-item' id='nav-log-Yanitlar'>
        <a class='nav-link collapsed' href='#' data-toggle='collapse' data-target='#collapseYanitlar' aria-expanded='true' aria-controls='collapseYanitlar'>
          <i class='fas fa-tasks'></i>
          <span>Form Yanıtları</span>
        </a>
        <div id='collapseYanitlar' class='collapse' aria-labelledby='headingYanitlar' data-parent='#accordionSidebar'>
          <div class='bg-white py-2 collapse-inner rounded'>
 <a class='collapse-item' href='sf_FormYanitlar.aspx' id='nav2-log-Yanitlar'>Yeni Form Yanıtı</a>
 <a class='collapse-item' href='sf_FormYanitlar.aspx?op=l' id='nav2-log-Yanitlarl?op=l'> Form Yanıtları</a>
          </div>
        </div>
      </li>
      ";
            }
            if (u[0].Role.Contains("Raporlar"))
            {
                m += @"
        <li class='nav-item' id='nav-log-Raporlar'>
        <a class='nav-link collapsed' href='#' data-toggle='collapse' data-target='#collapseRaporlar' aria-expanded='true' aria-controls='collapseRaporlar'>
          <i class='fas fa-chart-line'></i>
          <span>Raporlar</span>
        </a>
        <div id='collapseRaporlar' class='collapse' aria-labelledby='headingRaporlar' data-parent='#accordionSidebar'>
          <div class='bg-white py-2 collapse-inner rounded'>
 <a class='collapse-item' href='sf_Raporlar.aspx' id='nav2-log-Raporlar'>Raporlar</a>
          </div>
        </div>
      </li>
      ";
            }


            return m;
        }

        public static string setofchars(char startchar, char stopchar)
        {
            string tmp = "";
            if (Convert.ToByte(startchar) < Convert.ToByte(stopchar))
                for (int i = Convert.ToByte(startchar); i <= Convert.ToByte(stopchar); i++) tmp += (char)i;
            else
                for (int i = Convert.ToByte(stopchar); i <= Convert.ToByte(startchar); i++) tmp += (char)i;
            return tmp;
        }

        public static string incStr(string ck, bool lead, int len)
        {
            int say, ln;
            string tmp = "";
            string str = setofchars('0', '9');
            while (ck != "" && (str.IndexOf(ck[ck.Length - 1]) != -1))
            {
                tmp = ck[ck.Length - 1] + tmp;
                ck = ck.Remove(ck.Length - 1, 1);
            }

            if (tmp == "") tmp = "00001";
            ln = tmp.Length;
            say = Convert.ToInt32(tmp);
            say++;
            tmp = say.ToString();
            while (tmp.Length < ln) tmp = "0" + tmp;
            tmp = ck + tmp;
            if (lead)
            {
                while (tmp.Length < len) tmp = "0" + tmp;
            }
            return tmp;
        }

        public string GetKisaKod()
        {

            string NewOrderNO = "";
            try
            {
                Random rn = new Random();
                int lenght = 6;
                StringBuilder rs = new StringBuilder();
                string chars = "ABCDEFGHIJKLMNPRSTUVYZ";
                string nums = "123456789";
                while (lenght > 0)
                {
                    if (lenght == 6 || lenght == 5 || lenght == 2 || lenght == 1)
                        rs.Append(chars[(int)(rn.NextDouble() * chars.Length)]);
                    if (lenght == 4 || lenght == 3)
                        rs.Append(nums[(int)(rn.NextDouble() * nums.Length)]);
                    lenght--;
                }
                NewOrderNO = rs.ToString();

            }
            catch
            {
            }
            return NewOrderNO;
        }
        public string KisaLinkUret(string url, string token)
        {
            string result = null;
            try
            {
                HttpWebRequest req = WebRequest.Create("https://gvn.li/getshorturl.aspx?url=" + url + "&token=2aBhD5ARIsALiRlwB6seZMAvmh") as HttpWebRequest;
                req.Method = "GET";
                req.Accept = "application/json, application/octet-stream";
                req.Headers.Add("Authorization", "Bearer  " + token);

                using (HttpWebResponse resp = req.GetResponse() as HttpWebResponse)
                {
                    StreamReader reader = new StreamReader(resp.GetResponseStream());
                    result = reader.ReadToEnd();

                }

            }
            catch (WebException webEx)
            {
                var response = ((HttpWebResponse)webEx.Response);
                StreamReader content = new StreamReader(response.GetResponseStream());
                result = content.ReadToEnd();
            }
            catch (Exception ex)
            {
                // log
            }

            return result;


        }

        public string MutluCellSendSMS(string message, string phoneNumber, string username, string password, string header)
        {
            string responseString = "";
            using (var client = new WebClient())
            {
                var values = new NameValueCollection
            {
                { "usercode", username },
                { "password", password },
                { "gsm", phoneNumber },
                { "message", message },
                { "msgheader", header }
            };

                var response = client.UploadValues("http://www.mutlucell.com/sms/v1/sendsms", values);
                responseString = Encoding.Default.GetString(response);
                // Burada isteğin yanıtını değerlendirebilirsiniz.
            }
            return responseString;
        }
    }
}
