using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace DAL
{
    public class Logs
    {
        private string _ConnStr = "";
        public Logs()
        {
            if (ConfigurationManager.ConnectionStrings["ConnStr_log"] == null)
            {
                if (ConfigurationManager.ConnectionStrings["ConnStr"] == null)
                {
                    if (ConfigurationManager.AppSettings["ConnStr_log"] == null)
                    {
                        if (ConfigurationManager.AppSettings["ConnStr"] == null)
                        {

                        }
                        else
                        {
                            _ConnStr = ConfigurationManager.AppSettings["ConnStr"];
                        }
                    }
                    else
                    {
                        _ConnStr = ConfigurationManager.AppSettings["ConnStr_log"];
                    }
                }
                else
                    _ConnStr = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            }
            else
                _ConnStr = ConfigurationManager.ConnectionStrings["ConnStr_log"].ConnectionString;

            if (_ConnStr.ToLower().Contains("data source"))
            {

            }
            else
                _ConnStr = DBOps.DF(_ConnStr);
        }
        public Logs(string ConnStr)
        {

            _ConnStr = (ConnStr.ToLower().Length <= 20 || ConnStr.ToLower().StartsWith("connstr") ?
                (ConfigurationManager.ConnectionStrings[ConnStr] == null ? ConfigurationManager.AppSettings[ConnStr] : ConfigurationManager.ConnectionStrings[ConnStr].ConnectionString) : ConnStr);
            if (ConnStr.ToLower().Contains("data source"))
                _ConnStr = ConnStr;
            else
                _ConnStr = DBOps.DF(_ConnStr);
        }

        ///<summary>
        ///Logs tablosunu katit olusturur. 
        ///<b>ConnStr_Logs</b> u kullanilmasi onerilir.
        ///</summary>
        ///<param name="firmakodu">WEB projeleri icin ConfigurationManager.AppSettings["c"] gonderilmelidir.</param>
        ///<param name="IP">WEB projeleri icin HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"] gonderilmelidir.</param>
        ///<param name="nasil">NCharVar max deger alir.</param>
        public void Logla(string IP, string kim, string ne, string nasil)
        {
            new DBOps(_ConnStr).scn("INSERT INTO Logs_" + DateTime.Now.ToString("yyMM") + " (IP,Kim,Ne,Nasil) VALUES (@P1,@P2,@P3,@P4)",
               IP, kim, ne, nasil);
        }
        public void Logla(string IP, string kim, string ne, string nasil, string P1)
        {
            new DBOps(_ConnStr).scn("INSERT INTO Logs_" + DateTime.Now.ToString("yyMM") + " (IP,Kim,Ne,Nasil,P1) VALUES (@P1,@P2,@P3,@P4,@P5)",
               IP, kim, ne, nasil, P1);
        }
        public void Logla(string IP, string kim, string ne, string nasil, string P1, string P2)
        {
            //object[] p = new object[6];
            //p[0] = IP;
            //p[1] = kim;
            //p[2] = ne;
            //p[3] = nasil;
            //p[4] = P1;
            //p[5] = P2;
            new DBOps(_ConnStr).scn("INSERT INTO Logs_" + DateTime.Now.ToString("yyMM") + " (IP,Kim,Ne,Nasil,P1,P2) VALUES (@P1,@P2,@P3,@P4,@P5,@P6)",
               IP, kim, ne, nasil, P1, P2);
        }

        public void LogTablolariOlustur(int yil)
        {
            for (int i = 0; i < 12; i++)
            {
                if (DateTime.Now.Year == yil && DateTime.Now.Month > (i + 1))
                { break; }

                new DBOps(_ConnStr).scn(@"
CREATE TABLE [dbo].[Logs_" + new DateTime(yil, i + 1, 1).ToString("yyMM") + @"](
    [LOG_ID] [int] IDENTITY(1,1) NOT NULL,
	[CDate] [datetime] NULL,
	[IP] [nvarchar](4000) NULL,
	[Kim] [nvarchar](4000) NULL,
	[Ne] [nvarchar](4000) NULL,
	[Nasil] [nvarchar](max) NULL,
	[P1] [nvarchar](4000) NULL,
	[P2] [nvarchar](4000) NULL,
	[P3] [nvarchar](4000) NULL,
 CONSTRAINT [PK_Logs_" + new DateTime(yil, i + 1, 1).ToString("yyMM") + @"] PRIMARY KEY CLUSTERED 
(
	[LOG_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY];
ALTER TABLE [dbo].[Logs_" + new DateTime(yil, i + 1, 1).ToString("yyMM") + @"] ADD  CONSTRAINT [DF_Logs_" + new DateTime(yil, i + 1, 1).ToString("yyMM") + @"_CDate]  DEFAULT (getdate()) FOR [CDate];");

            }
        }
    }
}