using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DAL
{
    ///<summary>
    ///Ilerleyen Teknoloji - itToyz v0.01 - Database Fonksiyonlari - 2020.05.02
    ///</summary>
    public class DBOps : IDisposable
    {
        private string _ConnStr = "";
        private SqlConnection _conn = null;

        public void Dispose()
        {
            if (_conn != null)
            {
                if (_conn.State == ConnectionState.Open)
                    _conn.Close();
            }
        }

        public DBOps(string ConnStr, SqlConnection Conn)
        {
            if (ConnStr.ToLower().Length <= 20)
                _ConnStr =
                (ConfigurationManager.ConnectionStrings[ConnStr] != null ? ConfigurationManager.ConnectionStrings[ConnStr].ConnectionString : ConfigurationManager.AppSettings[ConnStr]);
            else
                _ConnStr = ConnStr;

            if (_ConnStr.ToLower().Contains("data source"))
            {
                //_ConnStr = ConnStr;
            }
            else
                _ConnStr = DF(_ConnStr);

            _conn = Conn;
        }

        /// <summary>
        /// ConnStr config adi veya tam metni gerekiyor, a) ConnStr_B2B/FVDB b) Data Source=192... c)HHASNAIQK12 
        /// </summary>
        /// <param name="ConnStr"></param>
        public DBOps(string ConnStr)
        {
            if (ConnStr.ToLower().Length <= 20)
                _ConnStr =
                (ConfigurationManager.ConnectionStrings[ConnStr] != null ? ConfigurationManager.ConnectionStrings[ConnStr].ConnectionString : ConfigurationManager.AppSettings[ConnStr]);
            else
                _ConnStr = ConnStr;

            if (_ConnStr.ToLower().Contains("data source"))
            {
                //_ConnStr = ConnStr;
            }
            else
                _ConnStr = DF(_ConnStr);

        }

        /// <summary>
        /// ConnStr isimli config dosyasindan DB yi bulur
        /// </summary>
        public DBOps()
        {
            _ConnStr = ConfigurationManager.ConnectionStrings["ConnStr"] != null ? ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString : ConfigurationManager.AppSettings["ConnStr"];

            if (_ConnStr.ToLower().Contains("data source"))
            {
                //_ConnStr = _ConnStr;
            }
            else
                _ConnStr = DF(_ConnStr);
        }

        public DataTable sc(string Cumle, params object[] Pler)
        {
            string cmdlog = "";
            DataTable dt = new DataTable("sc");
            try
            {
                using (SqlConnection conn = new SqlConnection(_ConnStr))
                {
                    using (SqlDataAdapter adap = new SqlDataAdapter(Cumle, conn))
                    {
                        conn.Open();
                        adap.SelectCommand.Parameters.Clear();
                        if (Pler != null)
                            for (int i = 0; i < Pler.Length; i++)
                            {
                                //Type t = Pler[i].GetType();if (t.Equals(typeof(int))) { comm.Parameters.AddWithValue("@P" + (i + 1).ToString(), (int)Pler[i]); }else
                                if (adap.SelectCommand.CommandText.ToLower().Contains("@p" + (i + 1).ToString()))
                                    adap.SelectCommand.Parameters.AddWithValue("@P" + (i + 1).ToString(),
                                         (Pler[i] != null ? Pler[i] : DBNull.Value));
                            }
                        //cmdlog = getGeneratedSql(adap.SelectCommand);
                        adap.SelectCommand.CommandTimeout = 1360;

                        adap.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                new Logs().Logla("", "", "sc-tryc", Cumle + " : " + cmdlog, "dbops");
                return dt;
            }
            return dt;
        }

        ///<summary>
        ///Scalar sonucu String olarak doner. Hata durumunda '-' doner.
        ///</summary>
        public string scs(string Cumle, params object[] Pler)
        {
            string cmdlog = "";
            try
            {
                using (SqlConnection conn = new SqlConnection(_ConnStr))
                {
                    using (SqlCommand comm = new SqlCommand(Cumle, conn))
                    {
                        conn.Open();
                        comm.Parameters.Clear();
                        //if (_trans != null) { _trans = conn.BeginTransaction(); }
                        if (Pler != null)
                            for (int i = 0; i < Pler.Length; i++)
                            {
                                //Type t = Pler[i].GetType();if (t.Equals(typeof(int))) { comm.Parameters.AddWithValue("@P" + (i + 1).ToString(), (int)Pler[i]); }else
                                if (Cumle.ToLower().Contains("@p" + (i + 1).ToString()))
                                    comm.Parameters.AddWithValue("@P" + (i + 1).ToString(),
                                            (Pler[i] != null ? Pler[i] : DBNull.Value));
                            }
                        //cmdlog = getGeneratedSql(comm);
                        var donen = comm.ExecuteScalar();
                        return (donen == null ? null : donen.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                //new Logs().Logla("", "", "scs-tryc", Cumle + " : " + cmdlog, "dbops");
                new Logs().Logla("", "scs-tryc", Cumle, ex.Message + " " + (ex.InnerException != null ? ex.InnerException.Message : ""), "dbops");
                return "-";
            }
        }

        ///<summary>
        ///Scalar sonucu String olarak doner. Hata durumunda '-' doner.
        ///</summary>
        ///
        public string scst(string Cumle, int timeoutSN, params object[] Pler)
        {
            string cmdlog = "";
            try
            {
                using (SqlConnection conn = new SqlConnection(_ConnStr))
                {
                    using (SqlCommand comm = new SqlCommand(Cumle, conn))
                    {
                        conn.Open();
                        comm.Parameters.Clear();
                        //if (_trans != null) { _trans = conn.BeginTransaction(); }
                        if (Pler != null)
                            for (int i = 0; i < Pler.Length; i++)
                            {
                                //Type t = Pler[i].GetType();if (t.Equals(typeof(int))) { comm.Parameters.AddWithValue("@P" + (i + 1).ToString(), (int)Pler[i]); }else
                                if (Cumle.ToLower().Contains("@p" + (i + 1).ToString()))
                                    comm.Parameters.AddWithValue("@P" + (i + 1).ToString(),
                                            (Pler[i] != null ? Pler[i] : DBNull.Value));
                            }
                        //cmdlog = getGeneratedSql(comm);
                        comm.CommandTimeout = timeoutSN;
                        var donen = comm.ExecuteScalar();
                        return (donen == null ? null : donen.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                new Logs().Logla("", "", "scs-tryc", Cumle + " : " + cmdlog, "dbops");
                return "-";
            }
        }

        ///<summary>
        ///Etkilenen satir sayisi doner. Hata durumunda -1 doner.
        ///</summary>
        public int scn(string Cumle, params object[] Pler)
        {
            string cmdlog = "";
            try
            {
                using (SqlConnection conn = new SqlConnection(_ConnStr))
                {
                    using (SqlCommand comm = new SqlCommand(Cumle, conn))
                    {
                        conn.Open();
                        comm.Parameters.Clear();
                        if (Pler != null)
                            for (int i = 0; i < Pler.Length; i++)
                            {
                                //Type t = Pler[i].GetType();if (t.Equals(typeof(int))) { comm.Parameters.AddWithValue("@P" + (i + 1).ToString(), (int)Pler[i]); }else
                                if (Cumle.ToLower().Contains("@p" + (i + 1).ToString()))
                                    comm.Parameters.AddWithValue("@P" + (i + 1).ToString(),
                                            (Pler[i] != null ? Pler[i] : DBNull.Value));
                            }
                        //cmdlog = getGeneratedSql(comm);
                        int s = comm.ExecuteNonQuery();
                        return s;
                    }
                }
            }
            catch (Exception ex)
            {
                new Logs().Logla("", "scnp-tryc", Cumle, ex.Message + " " + (ex.InnerException != null ? ex.InnerException.Message : ""), "dbops");
                return -1;
            }
        }

        public int scn_withsharedconn(string Cumle, params object[] Pler)
        {
            string cmdlog = "";
            try
            {
                if (_conn == null) _conn = new SqlConnection(_ConnStr);
                using (SqlCommand comm = new SqlCommand(Cumle, _conn))
                {
                    if (_conn.State != ConnectionState.Open) _conn.Open();
                    comm.Parameters.Clear();
                    if (Pler != null)
                        for (int i = 0; i < Pler.Length; i++)
                        {
                            //Type t = Pler[i].GetType();if (t.Equals(typeof(int))) { comm.Parameters.AddWithValue("@P" + (i + 1).ToString(), (int)Pler[i]); }else
                            if (Cumle.ToLower().Contains("@p" + (i + 1).ToString()))
                                comm.Parameters.AddWithValue("@P" + (i + 1).ToString(),
                                        (Pler[i] != null ? Pler[i] : DBNull.Value));
                        }
                    //cmdlog = getGeneratedSql(comm);
                    int s = comm.ExecuteNonQuery();
                    return s;
                }

            }
            catch (Exception ex)
            {
                new Logs().Logla("", "scnp-tryc", Cumle, ex.Message + " " + (ex.InnerException != null ? ex.InnerException.Message : ""), "dbops");
                return -1;
            }
        }

        public int scnp(string Cumle, SqlParameterCollection coll)
        {
            using (SqlConnection conn = new SqlConnection(_ConnStr))
            {
                using (SqlCommand comm = new SqlCommand(Cumle, conn))
                {
                    try
                    {
                        conn.Open();
                        foreach (SqlParameter p in coll)
                        {
                            SqlParameter pp = new SqlParameter(p.ParameterName, p.SqlDbType);
                            p.IsNullable = true;
                            pp.Value = (p.Value == null ? DBNull.Value : p.Value);
                            comm.Parameters.Add(pp);
                        }
                        return comm.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        new Logs().Logla("", "scnp-tryc", Cumle, ex.Message + " " + (ex.InnerException != null ? ex.InnerException.Message : ""), "dbops");
                        return -1;
                    }
                }
            }
        }

        ///<summary>
        ///DataReader
        ///</summary>
        public SqlDataReader sci(string Cumle, SqlDataReader r, params object[] Pler)
        {
            string cmdlog = "";
            try
            {
                using (SqlConnection conn = new SqlConnection(_ConnStr))
                {
                    using (SqlCommand comm = new SqlCommand(Cumle, conn))
                    {
                        conn.Open();
                        comm.Parameters.Clear();
                        //if (_trans != null) { _trans = conn.BeginTransaction(); }
                        if (Pler != null)
                            for (int i = 0; i < Pler.Length; i++)
                            {
                                //Type t = Pler[i].GetType();if (t.Equals(typeof(int))) { comm.Parameters.AddWithValue("@P" + (i + 1).ToString(), (int)Pler[i]); }else
                                if (Cumle.ToLower().Contains("@p" + (i + 1).ToString()))
                                    comm.Parameters.AddWithValue("@P" + (i + 1).ToString(),
                                            (Pler[i] != null ? Pler[i] : DBNull.Value));
                            }
                        cmdlog = getGeneratedSql(comm);
                        r = comm.ExecuteReader();
                        return r;
                    }
                }
            }
            catch (Exception ex)
            {
                new Logs().Logla("", "", "sci-tryc", Cumle + " : " + cmdlog, "dbops");
                return null;
            }
        }

        ///<summary>
        ///Params tablosundan PValue degerini doner. 
        ///</summary>
        ///<param name="PName">PName degeri</param>
        public string ParamsVer(string PName)
        {
            string cmdlog = "";
            try
            {
                using (SqlConnection conn = new SqlConnection(_ConnStr))
                {
                    using (SqlCommand comm = new SqlCommand("select top 1 PVALUE from PArams where PNAme=@P1", conn))
                    {
                        conn.Open();
                        comm.Parameters.Clear();
                        comm.Parameters.AddWithValue("@P1", PName);
                        cmdlog = getGeneratedSql(comm);
                        return comm.ExecuteScalar().ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                new Logs().Logla("", "", "ParamsVer-tryc", PName + " : " + cmdlog, "dbops");
                return "";
            }
        }

        private string getGeneratedSql(SqlCommand cmd)
        {
            string result = cmd.CommandText.ToString();
            foreach (SqlParameter p in cmd.Parameters)
            {
                try
                {
                    string isQuted = (p.Value is string) ? "'" : "";
                    result = result.Replace('@' + p.ParameterName.ToString(), isQuted + p.Value.ToString() + isQuted);
                }
                catch (Exception)
                { }
            }
            return result;
        }

        public static string tmz(string g)
        {
            if (g != null)
            {
                return g.Replace("'", "").Replace("\"", "").Replace("DROP", "").Replace("SELECT", "").Replace("UPDATE", "").Replace("DELETE", "").Replace("INSERT", "").Replace("TRUNCATE", "").Replace("TABLE", "");
            }
            return g;
        }

        public static string GetConnStr(string ConnStr)
        {
            string s = "";

            s = (ConnStr.ToLower().Length <= 20 ?
                (ConfigurationManager.ConnectionStrings[ConnStr] == null ? ConfigurationManager.AppSettings[ConnStr] : ConfigurationManager.ConnectionStrings[ConnStr].ConnectionString) : ConnStr);
            if (ConnStr.ToLower().Contains("data source"))
                s = ConnStr;
            else
                s = DF(ConnStr);

            return s;
        }

        public static string DF(string d)
        {
            try
            {
                byte[] ea = System.Convert.FromBase64String(d.Substring(1, d.Length - 3).Replace(".", "="));
                return System.Text.ASCIIEncoding.ASCII.GetString(ea);
            }
            catch (Exception ex)
            {
                return "";
            }
        }
    }
}