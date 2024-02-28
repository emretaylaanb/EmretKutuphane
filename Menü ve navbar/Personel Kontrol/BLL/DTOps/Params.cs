using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Collections.Generic;
using System.ComponentModel;

public class Params : IDisposable
{

    public void Dispose() { }


    public static DateTime dtnull = Convert.ToDateTime(ConfigurationManager.AppSettings["dtnull"]);
    public int? PRM_ID { get; set; }
    public DateTime? CDate { get; set; }
    public DateTime? UDate { get; set; }
    public DateTime? DDate { get; set; }
    public string PName { get; set; }
    public string PValue { get; set; }
    public string PNote { get; set; }
    public string P1 { get; set; }
    public string P2 { get; set; }
    public string P3 { get; set; }
    public string P4 { get; set; }
    public string P5 { get; set; }
    public int? Cancelled { get; set; }

    public static DataTable Hepsi()
    {
        return new DAL.DBOps().sc("SELECT * FROM Params");
    }

    public static DataTable Ver(string wheresi, params object[] Pler)
    {
        return new DAL.DBOps().sc("SELECT * FROM Params " + (string.IsNullOrEmpty(wheresi) ? "" : " WHERE " + wheresi), Pler);
    }

    //public static DataTable Ver(string[] istenilen, string[] alan, string[] param)
    //{
    //    DataTable dt = new DataTable();
    //    string sel = " *  ", whe = " WHERE ";
    //    if (istenilen.Length > 0)
    //    {
    //        sel = "";
    //        {
    //            for (int i = 0; i <= istenilen.Length - 1; i++)
    //            {
    //                sel += " " + istenilen[i] + ",";
    //            }
    //        }
    //    }
    //    sel = sel.Remove(sel.Length - 1, 1);

    //    for (int i = 0; i <= alan.Length - 1; i++)
    //    {
    //        whe += " " + alan[i] + "=@" + alan[i] + " AND ";
    //    }
    //    whe = whe.Remove(whe.Length - 4, 4);


    //    SqlParameterCollection parameters = new SqlCommand().Parameters;
    //    for (int i = 0; i <= alan.Length - 1; i++)
    //    {
    //        parameters.Add(new SqlParameter(alan[i], param[i]));
    //    }
    //    return new DAL.DBOps().scp("Select " + sel + " FROM Params " + whe, parameters);

    //}

    public static Params Ver(string wheresi)
    {
        DataTable dt = new DataTable();
        Params n = new Params();
        try
        {
            dt = new DAL.DBOps().sc("SELECT * FROM Params " + (string.IsNullOrEmpty(wheresi) ? "" : " WHERE " + wheresi));
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["PRM_ID"] != DBNull.Value) n.PRM_ID = (int)dt.Rows[0]["PRM_ID"];
                if (dt.Rows[0]["CDate"] != DBNull.Value) n.CDate = (DateTime)dt.Rows[0]["CDate"];
                if (dt.Rows[0]["UDate"] != DBNull.Value) n.UDate = (DateTime)dt.Rows[0]["UDate"];
                if (dt.Rows[0]["DDate"] != DBNull.Value) n.DDate = (DateTime)dt.Rows[0]["DDate"];
                if (dt.Rows[0]["PName"] != DBNull.Value) n.PName = dt.Rows[0]["PName"].ToString();
                if (dt.Rows[0]["PValue"] != DBNull.Value) n.PValue = dt.Rows[0]["PValue"].ToString();
                if (dt.Rows[0]["PNote"] != DBNull.Value) n.PNote = dt.Rows[0]["PNote"].ToString();
                if (dt.Rows[0]["P1"] != DBNull.Value) n.P1 = dt.Rows[0]["P1"].ToString();
                if (dt.Rows[0]["P2"] != DBNull.Value) n.P2 = dt.Rows[0]["P2"].ToString();
                if (dt.Rows[0]["P3"] != DBNull.Value) n.P3 = dt.Rows[0]["P3"].ToString();
                if (dt.Rows[0]["P4"] != DBNull.Value) n.P4 = dt.Rows[0]["P4"].ToString();
                if (dt.Rows[0]["P5"] != DBNull.Value) n.P5 = dt.Rows[0]["P5"].ToString();
                if (dt.Rows[0]["Cancelled"] != DBNull.Value) n.Cancelled = (int)dt.Rows[0]["Cancelled"];

            }
            return n;
        }
        catch (Exception)
        {
            return n;
        }
    }


    public static Params[] VerArr(string wheresi)
    {
        DataTable dt = new DataTable();
        Params[] n = new Params[0];
        try
        {
            dt = new DAL.DBOps().sc("SELECT * FROM Params " + (string.IsNullOrEmpty(wheresi) ? "" : " WHERE " + wheresi));
            if (dt.Rows.Count > 0)
            {
                n = new Params[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    n[i] = new Params();
                    if (dt.Rows[i]["PRM_ID"] != DBNull.Value) n[i].PRM_ID = (int)dt.Rows[i]["PRM_ID"];
                    if (dt.Rows[i]["CDate"] != DBNull.Value) n[i].CDate = (DateTime)dt.Rows[i]["CDate"];
                    if (dt.Rows[i]["UDate"] != DBNull.Value) n[i].UDate = (DateTime)dt.Rows[i]["UDate"];
                    if (dt.Rows[i]["DDate"] != DBNull.Value) n[i].DDate = (DateTime)dt.Rows[i]["DDate"];
                    if (dt.Rows[i]["PName"] != DBNull.Value) n[i].PName = dt.Rows[i]["PName"].ToString();
                    if (dt.Rows[i]["PValue"] != DBNull.Value) n[i].PValue = dt.Rows[i]["PValue"].ToString();
                    if (dt.Rows[i]["PNote"] != DBNull.Value) n[i].PNote = dt.Rows[i]["PNote"].ToString();
                    if (dt.Rows[i]["P1"] != DBNull.Value) n[i].P1 = dt.Rows[i]["P1"].ToString();
                    if (dt.Rows[i]["P2"] != DBNull.Value) n[i].P2 = dt.Rows[i]["P2"].ToString();
                    if (dt.Rows[i]["P3"] != DBNull.Value) n[i].P3 = dt.Rows[i]["P3"].ToString();
                    if (dt.Rows[i]["P4"] != DBNull.Value) n[i].P4 = dt.Rows[i]["P4"].ToString();
                    if (dt.Rows[i]["P5"] != DBNull.Value) n[i].P5 = dt.Rows[i]["P5"].ToString();
                    if (dt.Rows[i]["Cancelled"] != DBNull.Value) n[i].Cancelled = (int)dt.Rows[i]["Cancelled"];

                }
            }
            return n;
        }
        catch (Exception ex)
        {
            //new Ortak().Logla("Params[] VerArr", wheresi, ex.Message);
            return n;
        }
    }


    public static List<Params> VerList(string wheresi)
    {
        List<Params> lst = new List<Params>();
        using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString))
        {
            using (SqlCommand comm = new SqlCommand("SELECT * FROM Params " + (string.IsNullOrEmpty(wheresi) ? "" : " WHERE " + wheresi), conn))
            {
                try
                {
                    conn.Open();
                    SqlDataReader r = comm.ExecuteReader();
                    while (r.Read())
                    {
                        Params n = new Params();
                        if (r["PRM_ID"] != DBNull.Value) n.PRM_ID = (int)r["PRM_ID"];
                        if (r["CDate"] != DBNull.Value) n.CDate = (DateTime)r["CDate"];
                        if (r["UDate"] != DBNull.Value) n.UDate = (DateTime)r["UDate"];
                        if (r["DDate"] != DBNull.Value) n.DDate = (DateTime)r["DDate"];
                        if (r["PName"] != DBNull.Value) n.PName = r["PName"].ToString();
                        if (r["PValue"] != DBNull.Value) n.PValue = r["PValue"].ToString();
                        if (r["PNote"] != DBNull.Value) n.PNote = r["PNote"].ToString();
                        if (r["P1"] != DBNull.Value) n.P1 = r["P1"].ToString();
                        if (r["P2"] != DBNull.Value) n.P2 = r["P2"].ToString();
                        if (r["P3"] != DBNull.Value) n.P3 = r["P3"].ToString();
                        if (r["P4"] != DBNull.Value) n.P4 = r["P4"].ToString();
                        if (r["P5"] != DBNull.Value) n.P5 = r["P5"].ToString();
                        if (r["Cancelled"] != DBNull.Value) n.Cancelled = (int)r["Cancelled"];
                        lst.Add(n);
                    }
                    r.Close();
                    return lst;
                }
                catch (Exception ex)
                {
                    //new Ortak().Logla("Params[] VerList", wheresi, ex.Message);
                    return lst;
                }
            }

        }
    }



    public static List<Params> VerList(string wheresi, params object[] Pler)
    {
        List<Params> lst = new List<Params>();
        using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString))
        {
            using (SqlCommand comm = new SqlCommand("SELECT * FROM Params " + (string.IsNullOrEmpty(wheresi) ? "" : " WHERE " + wheresi), conn))
            {
                try
                {
                    if (Pler != null)
                        for (int i = 0; i < Pler.Length; i++)
                        {
                            if (comm.CommandText.ToLower().Contains("@p" + (i + 1).ToString()))
                                comm.Parameters.AddWithValue("@P" + (i + 1).ToString(),
                                (Pler[i] != null ? Pler[i] : DBNull.Value));
                        }
                    conn.Open();
                    SqlDataReader r = comm.ExecuteReader();
                    while (r.Read())
                    {
                        Params n = new Params();
                        if (r["PRM_ID"] != DBNull.Value) n.PRM_ID = (int)r["PRM_ID"];
                        if (r["CDate"] != DBNull.Value) n.CDate = (DateTime)r["CDate"];
                        if (r["UDate"] != DBNull.Value) n.UDate = (DateTime)r["UDate"];
                        if (r["DDate"] != DBNull.Value) n.DDate = (DateTime)r["DDate"];
                        if (r["PName"] != DBNull.Value) n.PName = r["PName"].ToString();
                        if (r["PValue"] != DBNull.Value) n.PValue = r["PValue"].ToString();
                        if (r["PNote"] != DBNull.Value) n.PNote = r["PNote"].ToString();
                        if (r["P1"] != DBNull.Value) n.P1 = r["P1"].ToString();
                        if (r["P2"] != DBNull.Value) n.P2 = r["P2"].ToString();
                        if (r["P3"] != DBNull.Value) n.P3 = r["P3"].ToString();
                        if (r["P4"] != DBNull.Value) n.P4 = r["P4"].ToString();
                        if (r["P5"] != DBNull.Value) n.P5 = r["P5"].ToString();
                        if (r["Cancelled"] != DBNull.Value) n.Cancelled = (int)r["Cancelled"];
                        lst.Add(n);
                    }
                    r.Close();
                    return lst;
                }
                catch (Exception ex)
                {
                    //new Ortak().Logla("Params[] VerList", wheresi, ex.Message);
                    return lst;
                }
            }

        }
    }


    public static bool Ekle(Params n)
    {
        try
        {
            string c = @"INSERT INTO Params
			(CDate,UDate,DDate,PName,PValue,PNote,P1,P2,P3,P4,P5,Cancelled)
			VALUES
			(@CDate,@UDate,@DDate,@PName,@PValue,@PNote,@P1,@P2,@P3,@P4,@P5,@Cancelled)";

            SqlParameterCollection parameters = new SqlCommand().Parameters;
            parameters.Add(new SqlParameter("CDate", (n.CDate == dtnull ? SqlDateTime.Null.Value : n.CDate)));
            parameters.Add(new SqlParameter("UDate", (n.UDate == dtnull ? SqlDateTime.Null.Value : n.UDate)));
            parameters.Add(new SqlParameter("DDate", (n.DDate == dtnull ? SqlDateTime.Null.Value : n.DDate)));
            parameters.Add(new SqlParameter("PName", (n.PName == null ? "" : n.PName)));
            parameters.Add(new SqlParameter("PValue", (n.PValue == null ? "" : n.PValue)));
            parameters.Add(new SqlParameter("PNote", (n.PNote == null ? "" : n.PNote)));
            parameters.Add(new SqlParameter("P1", (n.P1 == null ? "" : n.P1)));
            parameters.Add(new SqlParameter("P2", (n.P2 == null ? "" : n.P2)));
            parameters.Add(new SqlParameter("P3", (n.P3 == null ? "" : n.P3)));
            parameters.Add(new SqlParameter("P4", (n.P4 == null ? "" : n.P4)));
            parameters.Add(new SqlParameter("P5", (n.P5 == null ? "" : n.P5)));
            parameters.Add(new SqlParameter("Cancelled", (n.Cancelled == null ? 0 : n.Cancelled)));
            new DAL.DBOps().scnp(c, parameters);
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
    public static bool Sil(string[] alan, string[] param)
    {
        try
        {
            string c = @"DELETE FROM Params WHERE ";
            string whe = "";
            for (int i = 0; i <= alan.Length - 1; i++)
            {
                whe += " " + alan[i] + "=@" + alan[i] + ",";
            }
            whe = whe.Remove(whe.Length - 1, 1);

            c += whe;
            SqlParameterCollection parameters = new SqlCommand().Parameters;
            for (int i = 0; i <= alan.Length - 1; i++)
            {
                parameters.AddWithValue(alan[i], param[i]);
            }

            new DAL.DBOps().scnp(c, parameters);
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public static bool Guncelle(Params n, string[] whalan, string[] whparam)
    {
        try
        {
            string c = @"UPDATE Params SET 
		(CDate=@CDate,UDate=@UDate,DDate=@DDate,PName=@PName,PValue=@PValue,PNote=@PNte,P1=@P1,P2=@P2,P3=@P3,P4=@P4,P5=@P5,Cancelled=@Cancelled,)
		WHERE (";
            string whe = "";
            for (int i = 0; i <= whalan.Length - 1; i++)
            {
                whe += " " + whalan[i] + "=@" + whalan[i] + ",";
            }
            whe = whe.Remove(whe.Length - 1, 1) + ")";

            c += whe;
            SqlParameterCollection parameters = new SqlCommand().Parameters;
            parameters.Add(new SqlParameter("CDate", n.CDate == dtnull ? SqlDateTime.Null.Value : n.CDate));
            parameters.Add(new SqlParameter("UDate", n.UDate == dtnull ? SqlDateTime.Null.Value : n.UDate));
            parameters.Add(new SqlParameter("DDate", n.DDate == dtnull ? SqlDateTime.Null.Value : n.DDate));
            parameters.Add(new SqlParameter("PName", n.PName));
            parameters.Add(new SqlParameter("PValue", n.PValue));
            parameters.Add(new SqlParameter("PNote", n.PNote));
            parameters.Add(new SqlParameter("P1", n.P1));
            parameters.Add(new SqlParameter("P2", n.P2));
            parameters.Add(new SqlParameter("P3", n.P3));
            parameters.Add(new SqlParameter("P4", n.P4));
            parameters.Add(new SqlParameter("P5", n.P5));
            parameters.Add(new SqlParameter("Cancelled", n.Cancelled));


            new DAL.DBOps().scnp(c, parameters);
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public static bool Guncelle(Params n, string wheresi)
    {
        try
        {
            string c = @"UPDATE Params SET  ";
            string c2 = "";
            SqlParameterCollection parameters = new SqlCommand().Parameters;

            if (n.CDate != null) { c2 += "CDate = @CDate,"; parameters.Add(new SqlParameter("CDate", n.CDate)); }
            if (n.UDate != null) { c2 += "UDate = @UDate,"; parameters.Add(new SqlParameter("UDate", n.UDate)); }
            if (n.DDate != null) { c2 += "DDate = @DDate,"; parameters.Add(new SqlParameter("DDate", n.DDate)); }
            if (n.PName != null) { c2 += "PName = @PName,"; parameters.Add(new SqlParameter("PName", n.PName)); }
            if (n.PValue != null) { c2 += "PValue = @PValue,"; parameters.Add(new SqlParameter("PValue", n.PValue)); }
            if (n.PNote != null) { c2 += "PNote = @PNote,"; parameters.Add(new SqlParameter("PNote", n.PNote)); }
            if (n.P1 != null) { c2 += "P1 = @P1,"; parameters.Add(new SqlParameter("P1", n.P1)); }
            if (n.P2 != null) { c2 += "P2 = @P2,"; parameters.Add(new SqlParameter("P2", n.P2)); }
            if (n.P3 != null) { c2 += "P3 = @P3,"; parameters.Add(new SqlParameter("P3", n.P3)); }
            if (n.P4 != null) { c2 += "P4 = @P4,"; parameters.Add(new SqlParameter("P4", n.P4)); }
            if (n.P5 != null) { c2 += "P5 = @P5,"; parameters.Add(new SqlParameter("P5", n.P5)); }
            if (n.Cancelled != null) { c2 += "Cancelled = @Cancelled,"; parameters.Add(new SqlParameter("Cancelled", n.Cancelled)); }
            if (c2.EndsWith(",")) c2 = c2.Substring(0, c2.Length - 1);
            c += c2 + " WHERE (" + wheresi + ")";

            new DAL.DBOps().scnp(c, parameters);
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public int DAL_Set_Params(int? PRM_ID, string PName, string PValue, string PNote, string P1, string P2, string P3, string P4, string P5, int? Cancelled, bool Delete)
    {
        int s = 0;
        try
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString))
            {
                using (SqlCommand comm = new SqlCommand("", conn))
                {
                    conn.Open();
                    if (PRM_ID == null)
                    {
                        comm.CommandText = @"INSERT INTO Params (CDate" +
        (PName == null ? "" : ",PName") +
(PValue == null ? "" : ",PValue") +
(PNote == null ? "" : ",PNote") +
(P1 == null ? "" : ",P1") +
(P2 == null ? "" : ",P2") +
(P3 == null ? "" : ",P3") +
(P4 == null ? "" : ",P4") +
(P5 == null ? "" : ",P5") +
(Cancelled == null ? "" : ",Cancelled") +
        @")
		 VALUES
		(getdate()" +
        (PName == null ? "" : ",@PName") +
(PValue == null ? "" : ",@PValue") +
(PNote == null ? "" : ",@PNote") +
(P1 == null ? "" : ",@P1") +
(P2 == null ? "" : ",@P2") +
(P3 == null ? "" : ",@P3") +
(P4 == null ? "" : ",@P4") +
(P5 == null ? "" : ",@P5") +
(Cancelled == null ? "" : ",@Cancelled") +
        ")";
                    }
                    else
                    {
                        if (Delete)
                        {
                            comm.CommandText = @"UPDATE  Params SET DDate=getdate(),Cancelled = 1 Where PRM_ID = " + PRM_ID;
                        }
                        else
                        {
                            comm.CommandText = @"UPDATE  Params SET UDate=getdate() " +
                                    (PName == null ? "" : ",PName=@PName") +
        (PValue == null ? "" : ",PValue=@PValue") +
        (PNote == null ? "" : ",PNote=@PNote") +
        (P1 == null ? "" : ",P1=@P1") +
        (P2 == null ? "" : ",P2=@P2") +
        (P3 == null ? "" : ",P3=@P3") +
        (P4 == null ? "" : ",P4=@P4") +
        (P5 == null ? "" : ",P5=@P5") +
        (Cancelled == null ? "" : ",Cancelled=@Cancelled") +
                " WHERE [PRM_ID] = " + PRM_ID;
                        }
                    }
                    if (PName != null) comm.Parameters.AddWithValue("PName", PName);
                    if (PValue != null) comm.Parameters.AddWithValue("PValue", PValue);
                    if (PNote != null) comm.Parameters.AddWithValue("PNote", PNote);
                    if (P1 != null) comm.Parameters.AddWithValue("P1", P1);
                    if (P2 != null) comm.Parameters.AddWithValue("P2", P2);
                    if (P3 != null) comm.Parameters.AddWithValue("P3", P3);
                    if (P4 != null) comm.Parameters.AddWithValue("P4", P4);
                    if (P5 != null) comm.Parameters.AddWithValue("P5", P5);
                    if (Cancelled != null) comm.Parameters.AddWithValue("Cancelled", Cancelled);
                    s = comm.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        { }
        return s;
    }


    public int DAL_Set(Params n, bool Delete)
    {
        int s = 0;
        try
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString))
            {
                using (SqlCommand comm = new SqlCommand("", conn))
                {
                    conn.Open();
                    if (n.PRM_ID == null)
                    {
                        comm.CommandText = @"INSERT INTO Params (CDate" +
        (n.PName == null ? "" : ",PName") +
(n.PValue == null ? "" : ",PValue") +
(n.PNote == null ? "" : ",PNote") +
(n.P1 == null ? "" : ",P1") +
(n.P2 == null ? "" : ",P2") +
(n.P3 == null ? "" : ",P3") +
(n.P4 == null ? "" : ",P4") +
(n.P5 == null ? "" : ",P5") +
(n.Cancelled == null ? "" : ",Cancelled") +
        @")
		 VALUES
		(getdate()" +
        (n.PName == null ? "" : ",@PName") +
(n.PValue == null ? "" : ",@PValue") +
(n.PNote == null ? "" : ",@PNote") +
(n.P1 == null ? "" : ",@P1") +
(n.P2 == null ? "" : ",@P2") +
(n.P3 == null ? "" : ",@P3") +
(n.P4 == null ? "" : ",@P4") +
(n.P5 == null ? "" : ",@P5") +
(n.Cancelled == null ? "" : ",@Cancelled") +
        ")";
                    }
                    else
                    {
                        if (Delete)
                        {
                            comm.CommandText = @"UPDATE  Params SET DDate=getdate(),Cancelled = 1 Where PRM_ID = " + n.PRM_ID;
                        }
                        else
                        {
                            comm.CommandText = @"UPDATE  Params SET UDate=getdate() " +
                                    (n.PName == null ? "" : ",PName=@PName") +
        (n.PValue == null ? "" : ",PValue=@PValue") +
        (n.PNote == null ? "" : ",PNote=@PNote") +
        (n.P1 == null ? "" : ",P1=@P1") +
        (n.P2 == null ? "" : ",P2=@P2") +
        (n.P3 == null ? "" : ",P3=@P3") +
        (n.P4 == null ? "" : ",P4=@P4") +
        (n.P5 == null ? "" : ",P5=@P5") +
        (n.Cancelled == null ? "" : ",Cancelled=@Cancelled") +
                " WHERE [PRM_ID] = " + n.PRM_ID;
                        }
                    }
                    if (n.PName != null) comm.Parameters.AddWithValue("PName", n.PName);
                    if (n.PValue != null) comm.Parameters.AddWithValue("PValue", n.PValue);
                    if (n.PNote != null) comm.Parameters.AddWithValue("PNote", n.PNote);
                    if (n.P1 != null) comm.Parameters.AddWithValue("P1", n.P1);
                    if (n.P2 != null) comm.Parameters.AddWithValue("P2", n.P2);
                    if (n.P3 != null) comm.Parameters.AddWithValue("P3", n.P3);
                    if (n.P4 != null) comm.Parameters.AddWithValue("P4", n.P4);
                    if (n.P5 != null) comm.Parameters.AddWithValue("P5", n.P5);
                    if (n.Cancelled != null) comm.Parameters.AddWithValue("Cancelled", n.Cancelled);
                    s = comm.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        { }
        return s;
    }
    /* JSModel

ParamsList:[],
ParamsModeli:{
PRM_ID:0, CDate:'', UDate:'', DDate:'', PName:'', PValue:'', PNote:'', P1:'', P2:'', P3:'', P4:'', P5:'', Cancelled:0, },

*/
}

