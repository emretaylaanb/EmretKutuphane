using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Collections.Generic;
using System.ComponentModel;

public class Timetables : IDisposable
{

    public void Dispose() { }


    public static DateTime dtnull = Convert.ToDateTime(ConfigurationManager.AppSettings["dtnull"]);
    public int? DVC_ID { get; set; }
    public DateTime? CDate { get; set; }
    public DateTime? UDate { get; set; }
    public DateTime? DDate { get; set; }
    public string SpeCode { get; set; }
    public DateTime? SDate { get; set; }
    public DateTime? EDate { get; set; }
    public DateTime? _1Start { get; set; }
    public DateTime? _1End { get; set; }
    public DateTime? _2Start { get; set; }
    public DateTime? _2End { get; set; }
    public DateTime? _3Start { get; set; }
    public DateTime? _3End { get; set; }
    public DateTime? _4Start { get; set; }
    public DateTime? _4End { get; set; }
    public DateTime? _5Start { get; set; }
    public DateTime? _5End { get; set; }
    public DateTime? _6Start { get; set; }
    public DateTime? _6End { get; set; }
    public DateTime? _7Start { get; set; }
    public DateTime? _7End { get; set; }
    public string P1 { get; set; }
    public string P2 { get; set; }
    public string P3 { get; set; }
    public string P4 { get; set; }
    public string P5 { get; set; }
    public int? Cancelled { get; set; }

    public static DataTable Hepsi()
    {
        return new DAL.DBOps().sc("SELECT * FROM Timetables");
    }

    public static DataTable Ver(string wheresi, params object[] Pler)
    {
        return new DAL.DBOps().sc("SELECT * FROM Timetables " + (string.IsNullOrEmpty(wheresi) ? "" : " WHERE " + wheresi), Pler);
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
    //    return new DAL.DBOps().scp("Select " + sel + " FROM Timetables " + whe, parameters);

    //}

    public static Timetables Ver(string wheresi)
    {
        DataTable dt = new DataTable();
        Timetables n = new Timetables();
        try
        {
            dt = new DAL.DBOps().sc("SELECT * FROM Timetables " + (string.IsNullOrEmpty(wheresi) ? "" : " WHERE " + wheresi));
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["DVC_ID"] != DBNull.Value) n.DVC_ID = (int)dt.Rows[0]["DVC_ID"];
                if (dt.Rows[0]["CDate"] != DBNull.Value) n.CDate = (DateTime)dt.Rows[0]["CDate"];
                if (dt.Rows[0]["UDate"] != DBNull.Value) n.UDate = (DateTime)dt.Rows[0]["UDate"];
                if (dt.Rows[0]["DDate"] != DBNull.Value) n.DDate = (DateTime)dt.Rows[0]["DDate"];
                if (dt.Rows[0]["SpeCode"] != DBNull.Value) n.SpeCode = dt.Rows[0]["SpeCode"].ToString();
                if (dt.Rows[0]["SDate"] != DBNull.Value) n.SDate = (DateTime)dt.Rows[0]["SDate"];
                if (dt.Rows[0]["EDate"] != DBNull.Value) n.EDate = (DateTime)dt.Rows[0]["EDate"];
                if (dt.Rows[0]["_1Start"] != DBNull.Value) n._1Start = (DateTime)dt.Rows[0]["_1Start"];
                if (dt.Rows[0]["_1End"] != DBNull.Value) n._1End = (DateTime)dt.Rows[0]["_1End"];
                if (dt.Rows[0]["_2Start"] != DBNull.Value) n._2Start = (DateTime)dt.Rows[0]["_2Start"];
                if (dt.Rows[0]["_2End"] != DBNull.Value) n._2End = (DateTime)dt.Rows[0]["_2End"];
                if (dt.Rows[0]["_3Start"] != DBNull.Value) n._3Start = (DateTime)dt.Rows[0]["_3Start"];
                if (dt.Rows[0]["_3End"] != DBNull.Value) n._3End = (DateTime)dt.Rows[0]["_3End"];
                if (dt.Rows[0]["_4Start"] != DBNull.Value) n._4Start = (DateTime)dt.Rows[0]["_4Start"];
                if (dt.Rows[0]["_4End"] != DBNull.Value) n._4End = (DateTime)dt.Rows[0]["_4End"];
                if (dt.Rows[0]["_5Start"] != DBNull.Value) n._5Start = (DateTime)dt.Rows[0]["_5Start"];
                if (dt.Rows[0]["_5End"] != DBNull.Value) n._5End = (DateTime)dt.Rows[0]["_5End"];
                if (dt.Rows[0]["_6Start"] != DBNull.Value) n._6Start = (DateTime)dt.Rows[0]["_6Start"];
                if (dt.Rows[0]["_6End"] != DBNull.Value) n._6End = (DateTime)dt.Rows[0]["_6End"];
                if (dt.Rows[0]["_7Start"] != DBNull.Value) n._7Start = (DateTime)dt.Rows[0]["_7Start"];
                if (dt.Rows[0]["_7End"] != DBNull.Value) n._7End = (DateTime)dt.Rows[0]["_7End"];
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


    public static Timetables[] VerArr(string wheresi)
    {
        DataTable dt = new DataTable();
        Timetables[] n = new Timetables[0];
        try
        {
            dt = new DAL.DBOps().sc("SELECT * FROM Timetables " + (string.IsNullOrEmpty(wheresi) ? "" : " WHERE " + wheresi));
            if (dt.Rows.Count > 0)
            {
                n = new Timetables[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    n[i] = new Timetables();
                    if (dt.Rows[i]["DVC_ID"] != DBNull.Value) n[i].DVC_ID = (int)dt.Rows[i]["DVC_ID"];
                    if (dt.Rows[i]["CDate"] != DBNull.Value) n[i].CDate = (DateTime)dt.Rows[i]["CDate"];
                    if (dt.Rows[i]["UDate"] != DBNull.Value) n[i].UDate = (DateTime)dt.Rows[i]["UDate"];
                    if (dt.Rows[i]["DDate"] != DBNull.Value) n[i].DDate = (DateTime)dt.Rows[i]["DDate"];
                    if (dt.Rows[i]["SpeCode"] != DBNull.Value) n[i].SpeCode = dt.Rows[i]["SpeCode"].ToString();
                    if (dt.Rows[i]["SDate"] != DBNull.Value) n[i].SDate = (DateTime)dt.Rows[i]["SDate"];
                    if (dt.Rows[i]["EDate"] != DBNull.Value) n[i].EDate = (DateTime)dt.Rows[i]["EDate"];
                    if (dt.Rows[i]["_1Start"] != DBNull.Value) n[i]._1Start = (DateTime)dt.Rows[i]["_1Start"];
                    if (dt.Rows[i]["_1End"] != DBNull.Value) n[i]._1End = (DateTime)dt.Rows[i]["_1End"];
                    if (dt.Rows[i]["_2Start"] != DBNull.Value) n[i]._2Start = (DateTime)dt.Rows[i]["_2Start"];
                    if (dt.Rows[i]["_2End"] != DBNull.Value) n[i]._2End = (DateTime)dt.Rows[i]["_2End"];
                    if (dt.Rows[i]["_3Start"] != DBNull.Value) n[i]._3Start = (DateTime)dt.Rows[i]["_3Start"];
                    if (dt.Rows[i]["_3End"] != DBNull.Value) n[i]._3End = (DateTime)dt.Rows[i]["_3End"];
                    if (dt.Rows[i]["_4Start"] != DBNull.Value) n[i]._4Start = (DateTime)dt.Rows[i]["_4Start"];
                    if (dt.Rows[i]["_4End"] != DBNull.Value) n[i]._4End = (DateTime)dt.Rows[i]["_4End"];
                    if (dt.Rows[i]["_5Start"] != DBNull.Value) n[i]._5Start = (DateTime)dt.Rows[i]["_5Start"];
                    if (dt.Rows[i]["_5End"] != DBNull.Value) n[i]._5End = (DateTime)dt.Rows[i]["_5End"];
                    if (dt.Rows[i]["_6Start"] != DBNull.Value) n[i]._6Start = (DateTime)dt.Rows[i]["_6Start"];
                    if (dt.Rows[i]["_6End"] != DBNull.Value) n[i]._6End = (DateTime)dt.Rows[i]["_6End"];
                    if (dt.Rows[i]["_7Start"] != DBNull.Value) n[i]._7Start = (DateTime)dt.Rows[i]["_7Start"];
                    if (dt.Rows[i]["_7End"] != DBNull.Value) n[i]._7End = (DateTime)dt.Rows[i]["_7End"];
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
            //new Ortak().Logla("Timetables[] VerArr", wheresi, ex.Message);
            return n;
        }
    }


    public static List<Timetables> VerList(string wheresi)
    {
        List<Timetables> lst = new List<Timetables>();
        using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString))
        {
            using (SqlCommand comm = new SqlCommand("SELECT * FROM Timetables " + (string.IsNullOrEmpty(wheresi) ? "" : " WHERE " + wheresi), conn))
            {
                try
                {
                    conn.Open();
                    SqlDataReader r = comm.ExecuteReader();
                    while (r.Read())
                    {
                        Timetables n = new Timetables();
                        if (r["DVC_ID"] != DBNull.Value) n.DVC_ID = (int)r["DVC_ID"];
                        if (r["CDate"] != DBNull.Value) n.CDate = (DateTime)r["CDate"];
                        if (r["UDate"] != DBNull.Value) n.UDate = (DateTime)r["UDate"];
                        if (r["DDate"] != DBNull.Value) n.DDate = (DateTime)r["DDate"];
                        if (r["SpeCode"] != DBNull.Value) n.SpeCode = r["SpeCode"].ToString();
                        if (r["SDate"] != DBNull.Value) n.SDate = (DateTime)r["SDate"];
                        if (r["EDate"] != DBNull.Value) n.EDate = (DateTime)r["EDate"];
                        if (r["_1Start"] != DBNull.Value) n._1Start = (DateTime)r["_1Start"];
                        if (r["_1End"] != DBNull.Value) n._1End = (DateTime)r["_1End"];
                        if (r["_2Start"] != DBNull.Value) n._2Start = (DateTime)r["_2Start"];
                        if (r["_2End"] != DBNull.Value) n._2End = (DateTime)r["_2End"];
                        if (r["_3Start"] != DBNull.Value) n._3Start = (DateTime)r["_3Start"];
                        if (r["_3End"] != DBNull.Value) n._3End = (DateTime)r["_3End"];
                        if (r["_4Start"] != DBNull.Value) n._4Start = (DateTime)r["_4Start"];
                        if (r["_4End"] != DBNull.Value) n._4End = (DateTime)r["_4End"];
                        if (r["_5Start"] != DBNull.Value) n._5Start = (DateTime)r["_5Start"];
                        if (r["_5End"] != DBNull.Value) n._5End = (DateTime)r["_5End"];
                        if (r["_6Start"] != DBNull.Value) n._6Start = (DateTime)r["_6Start"];
                        if (r["_6End"] != DBNull.Value) n._6End = (DateTime)r["_6End"];
                        if (r["_7Start"] != DBNull.Value) n._7Start = (DateTime)r["_7Start"];
                        if (r["_7End"] != DBNull.Value) n._7End = (DateTime)r["_7End"];
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
                    //new Ortak().Logla("Timetables[] VerList", wheresi, ex.Message);
                    return lst;
                }
            }

        }
    }



    public static List<Timetables> VerList(string wheresi, params object[] Pler)
    {
        List<Timetables> lst = new List<Timetables>();
        using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString))
        {
            using (SqlCommand comm = new SqlCommand("SELECT * FROM Timetables " + (string.IsNullOrEmpty(wheresi) ? "" : " WHERE " + wheresi), conn))
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
                        Timetables n = new Timetables();
                        if (r["DVC_ID"] != DBNull.Value) n.DVC_ID = (int)r["DVC_ID"];
                        if (r["CDate"] != DBNull.Value) n.CDate = (DateTime)r["CDate"];
                        if (r["UDate"] != DBNull.Value) n.UDate = (DateTime)r["UDate"];
                        if (r["DDate"] != DBNull.Value) n.DDate = (DateTime)r["DDate"];
                        if (r["SpeCode"] != DBNull.Value) n.SpeCode = r["SpeCode"].ToString();
                        if (r["SDate"] != DBNull.Value) n.SDate = (DateTime)r["SDate"];
                        if (r["EDate"] != DBNull.Value) n.EDate = (DateTime)r["EDate"];
                        if (r["_1Start"] != DBNull.Value) n._1Start = (DateTime)r["_1Start"];
                        if (r["_1End"] != DBNull.Value) n._1End = (DateTime)r["_1End"];
                        if (r["_2Start"] != DBNull.Value) n._2Start = (DateTime)r["_2Start"];
                        if (r["_2End"] != DBNull.Value) n._2End = (DateTime)r["_2End"];
                        if (r["_3Start"] != DBNull.Value) n._3Start = (DateTime)r["_3Start"];
                        if (r["_3End"] != DBNull.Value) n._3End = (DateTime)r["_3End"];
                        if (r["_4Start"] != DBNull.Value) n._4Start = (DateTime)r["_4Start"];
                        if (r["_4End"] != DBNull.Value) n._4End = (DateTime)r["_4End"];
                        if (r["_5Start"] != DBNull.Value) n._5Start = (DateTime)r["_5Start"];
                        if (r["_5End"] != DBNull.Value) n._5End = (DateTime)r["_5End"];
                        if (r["_6Start"] != DBNull.Value) n._6Start = (DateTime)r["_6Start"];
                        if (r["_6End"] != DBNull.Value) n._6End = (DateTime)r["_6End"];
                        if (r["_7Start"] != DBNull.Value) n._7Start = (DateTime)r["_7Start"];
                        if (r["_7End"] != DBNull.Value) n._7End = (DateTime)r["_7End"];
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
                    //new Ortak().Logla("Timetables[] VerList", wheresi, ex.Message);
                    return lst;
                }
            }

        }
    }


    public static bool Ekle(Timetables n)
    {
        try
        {
            string c = @"INSERT INTO Timetables
			(CDate,UDate,DDate,SpeCode,SDate,EDate,_1Start,_1End,_2Start,_2End,_3Start,_3End,_4Start,_4End,_5Start,_5End,_6Start,_6End,_7Start,_7End,P1,P2,P3,P4,P5,Cancelled)
			VALUES
			(@CDate,@UDate,@DDate,@SpeCode,@SDate,@EDate,@_1Start,@_1End,@_2Start,@_2End,@_3Start,@_3End,@_4Start,@_4End,@_5Start,@_5End,@_6Start,@_6End,@_7Start,@_7End,@P1,@P2,@P3,@P4,@P5,@Cancelled)";

            SqlParameterCollection parameters = new SqlCommand().Parameters;
            parameters.Add(new SqlParameter("CDate", (n.CDate == dtnull ? SqlDateTime.Null.Value : n.CDate)));
            parameters.Add(new SqlParameter("UDate", (n.UDate == dtnull ? SqlDateTime.Null.Value : n.UDate)));
            parameters.Add(new SqlParameter("DDate", (n.DDate == dtnull ? SqlDateTime.Null.Value : n.DDate)));
            parameters.Add(new SqlParameter("SpeCode", (n.SpeCode == null ? "" : n.SpeCode)));
            parameters.Add(new SqlParameter("SDate", (n.SDate == dtnull ? SqlDateTime.Null.Value : n.SDate)));
            parameters.Add(new SqlParameter("EDate", (n.EDate == dtnull ? SqlDateTime.Null.Value : n.EDate)));
            parameters.Add(new SqlParameter("_1Start", (n._1Start == dtnull ? SqlDateTime.Null.Value : n._1Start)));
            parameters.Add(new SqlParameter("_1End", (n._1End == dtnull ? SqlDateTime.Null.Value : n._1End)));
            parameters.Add(new SqlParameter("_2Start", (n._2Start == dtnull ? SqlDateTime.Null.Value : n._2Start)));
            parameters.Add(new SqlParameter("_2End", (n._2End == dtnull ? SqlDateTime.Null.Value : n._2End)));
            parameters.Add(new SqlParameter("_3Start", (n._3Start == dtnull ? SqlDateTime.Null.Value : n._3Start)));
            parameters.Add(new SqlParameter("_3End", (n._3End == dtnull ? SqlDateTime.Null.Value : n._3End)));
            parameters.Add(new SqlParameter("_4Start", (n._4Start == dtnull ? SqlDateTime.Null.Value : n._4Start)));
            parameters.Add(new SqlParameter("_4End", (n._4End == dtnull ? SqlDateTime.Null.Value : n._4End)));
            parameters.Add(new SqlParameter("_5Start", (n._5Start == dtnull ? SqlDateTime.Null.Value : n._5Start)));
            parameters.Add(new SqlParameter("_5End", (n._5End == dtnull ? SqlDateTime.Null.Value : n._5End)));
            parameters.Add(new SqlParameter("_6Start", (n._6Start == dtnull ? SqlDateTime.Null.Value : n._6Start)));
            parameters.Add(new SqlParameter("_6End", (n._6End == dtnull ? SqlDateTime.Null.Value : n._6End)));
            parameters.Add(new SqlParameter("_7Start", (n._7Start == dtnull ? SqlDateTime.Null.Value : n._7Start)));
            parameters.Add(new SqlParameter("_7End", (n._7End == dtnull ? SqlDateTime.Null.Value : n._7End)));
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
            string c = @"DELETE FROM Timetables WHERE ";
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

    public static bool Guncelle(Timetables n, string[] whalan, string[] whparam)
    {
        try
        {
            string c = @"UPDATE Timetables SET 
		(CDate=@CDate,UDate=@UDate,DDate=@DDate,SpeCode=@SpeCode,SDate=@SDate,EDate=@EDate,_1Start=@_1Start,_1End=@_1End,_2Start=@_2Start,_2End=@_2End,_3Start=@_3Start,_3End=@_3End,_4Start=@_4Start,4End=@_4End,_5Start=@_5Start,_5End=@_5End,_6Start=@_6Start,_6End=@_6End,_7Start=@_7Start,_7End=@_7End,P1=@P1,P2=@P2,P3=@P3,P4=@P4,P5=@P5,Cancelled=@Cancelled,)
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
            parameters.Add(new SqlParameter("SpeCode", n.SpeCode));
            parameters.Add(new SqlParameter("SDate", n.SDate == dtnull ? SqlDateTime.Null.Value : n.SDate));
            parameters.Add(new SqlParameter("EDate", n.EDate == dtnull ? SqlDateTime.Null.Value : n.EDate));
            parameters.Add(new SqlParameter("_1Start", n._1Start == dtnull ? SqlDateTime.Null.Value : n._1Start));
            parameters.Add(new SqlParameter("_1End", n._1End == dtnull ? SqlDateTime.Null.Value : n._1End));
            parameters.Add(new SqlParameter("_2Start", n._2Start == dtnull ? SqlDateTime.Null.Value : n._2Start));
            parameters.Add(new SqlParameter("_2End", n._2End == dtnull ? SqlDateTime.Null.Value : n._2End));
            parameters.Add(new SqlParameter("_3Start", n._3Start == dtnull ? SqlDateTime.Null.Value : n._3Start));
            parameters.Add(new SqlParameter("_3End", n._3End == dtnull ? SqlDateTime.Null.Value : n._3End));
            parameters.Add(new SqlParameter("_4Start", n._4Start == dtnull ? SqlDateTime.Null.Value : n._4Start));
            parameters.Add(new SqlParameter("_4End", n._4End == dtnull ? SqlDateTime.Null.Value : n._4End));
            parameters.Add(new SqlParameter("_5Start", n._5Start == dtnull ? SqlDateTime.Null.Value : n._5Start));
            parameters.Add(new SqlParameter("_5End", n._5End == dtnull ? SqlDateTime.Null.Value : n._5End));
            parameters.Add(new SqlParameter("_6Start", n._6Start == dtnull ? SqlDateTime.Null.Value : n._6Start));
            parameters.Add(new SqlParameter("_6End", n._6End == dtnull ? SqlDateTime.Null.Value : n._6End));
            parameters.Add(new SqlParameter("_7Start", n._7Start == dtnull ? SqlDateTime.Null.Value : n._7Start));
            parameters.Add(new SqlParameter("_7End", n._7End == dtnull ? SqlDateTime.Null.Value : n._7End));
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

    public static bool Guncelle(Timetables n, string wheresi)
    {
        try
        {
            string c = @"UPDATE Timetables SET  ";
            string c2 = "";
            SqlParameterCollection parameters = new SqlCommand().Parameters;

            if (n.CDate != null) { c2 += "CDate = @CDate,"; parameters.Add(new SqlParameter("CDate", n.CDate)); }
            if (n.UDate != null) { c2 += "UDate = @UDate,"; parameters.Add(new SqlParameter("UDate", n.UDate)); }
            if (n.DDate != null) { c2 += "DDate = @DDate,"; parameters.Add(new SqlParameter("DDate", n.DDate)); }
            if (n.SpeCode != null) { c2 += "SpeCode = @SpeCode,"; parameters.Add(new SqlParameter("SpeCode", n.SpeCode)); }
            if (n.SDate != null) { c2 += "SDate = @SDate,"; parameters.Add(new SqlParameter("SDate", n.SDate)); }
            if (n.EDate != null) { c2 += "EDate = @EDate,"; parameters.Add(new SqlParameter("EDate", n.EDate)); }
            if (n._1Start != null) { c2 += "_1Start = @_1Start,"; parameters.Add(new SqlParameter("_1Start", n._1Start)); }
            if (n._1End != null) { c2 += "_1End = @_1End,"; parameters.Add(new SqlParameter("_1End", n._1End)); }
            if (n._2Start != null) { c2 += "_2Start = @_2Start,"; parameters.Add(new SqlParameter("_2Start", n._2Start)); }
            if (n._2End != null) { c2 += "_2End = @_2End,"; parameters.Add(new SqlParameter("_2End", n._2End)); }
            if (n._3Start != null) { c2 += "_3Start = @_3Start,"; parameters.Add(new SqlParameter("_3Start", n._3Start)); }
            if (n._3End != null) { c2 += "_3End = @_3End,"; parameters.Add(new SqlParameter("_3End", n._3End)); }
            if (n._4Start != null) { c2 += "_4Start = @_4Start,"; parameters.Add(new SqlParameter("_4Start", n._4Start)); }
            if (n._4End != null) { c2 += "_4End = @_4End,"; parameters.Add(new SqlParameter("_4End", n._4End)); }
            if (n._5Start != null) { c2 += "_5Start = @_5Start,"; parameters.Add(new SqlParameter("_5Start", n._5Start)); }
            if (n._5End != null) { c2 += "_5End = @_5End,"; parameters.Add(new SqlParameter("_5End", n._5End)); }
            if (n._6Start != null) { c2 += "_6Start = @_6Start,"; parameters.Add(new SqlParameter("_6Start", n._6Start)); }
            if (n._6End != null) { c2 += "_6End = @_6End,"; parameters.Add(new SqlParameter("_6End", n._6End)); }
            if (n._7Start != null) { c2 += "_7Start = @_7Start,"; parameters.Add(new SqlParameter("_7Start", n._7Start)); }
            if (n._7End != null) { c2 += "_7End = @_7End,"; parameters.Add(new SqlParameter("_7End", n._7End)); }
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

    public int DAL_Set_Timetables(int? DVC_ID, string SpeCode, DateTime? SDate, DateTime? EDate, DateTime? _1Start, DateTime? _1End, DateTime? _2Start, DateTime? _2End, DateTime? _3Start, DateTime? _3End, DateTime? _4Start, DateTime? _4End, DateTime? _5Start, DateTime? _5End, DateTime? _6Start, DateTime? _6End, DateTime? _7Start, DateTime? _7End, string P1, string P2, string P3, string P4, string P5, int? Cancelled, bool Delete)
    {
        int s = 0;
        try
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString))
            {
                using (SqlCommand comm = new SqlCommand("", conn))
                {
                    conn.Open();
                    if (DVC_ID == null)
                    {
                        comm.CommandText = @"INSERT INTO Timetables (CDate" +
        (SpeCode == null ? "" : ",SpeCode") +
(SDate == null ? "" : ",SDate") +
(EDate == null ? "" : ",EDate") +
(_1Start == null ? "" : ",_1Start") +
(_1End == null ? "" : ",_1End") +
(_2Start == null ? "" : ",_2Start") +
(_2End == null ? "" : ",_2End") +
(_3Start == null ? "" : ",_3Start") +
(_3End == null ? "" : ",_3End") +
(_4Start == null ? "" : ",_4Start") +
(_4End == null ? "" : ",_4End") +
(_5Start == null ? "" : ",_5Start") +
(_5End == null ? "" : ",_5End") +
(_6Start == null ? "" : ",_6Start") +
(_6End == null ? "" : ",_6End") +
(_7Start == null ? "" : ",_7Start") +
(_7End == null ? "" : ",_7End") +
(P1 == null ? "" : ",P1") +
(P2 == null ? "" : ",P2") +
(P3 == null ? "" : ",P3") +
(P4 == null ? "" : ",P4") +
(P5 == null ? "" : ",P5") +
(Cancelled == null ? "" : ",Cancelled") +
        @")
		 VALUES
		(getdate()" +
        (SpeCode == null ? "" : ",@SpeCode") +
(SDate == null ? "" : ",@SDate") +
(EDate == null ? "" : ",@EDate") +
(_1Start == null ? "" : ",@_1Start") +
(_1End == null ? "" : ",@_1End") +
(_2Start == null ? "" : ",@_2Start") +
(_2End == null ? "" : ",@_2End") +
(_3Start == null ? "" : ",@_3Start") +
(_3End == null ? "" : ",@_3End") +
(_4Start == null ? "" : ",@_4Start") +
(_4End == null ? "" : ",@_4End") +
(_5Start == null ? "" : ",@_5Start") +
(_5End == null ? "" : ",@_5End") +
(_6Start == null ? "" : ",@_6Start") +
(_6End == null ? "" : ",@_6End") +
(_7Start == null ? "" : ",@_7Start") +
(_7End == null ? "" : ",@_7End") +
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
                            comm.CommandText = @"UPDATE  Timetables SET DDate=getdate(),Cancelled = 1 Where DVC_ID = " + DVC_ID;
                        }
                        else
                        {
                            comm.CommandText = @"UPDATE  Timetables SET UDate=getdate() " +
                                    (SpeCode == null ? "" : ",SpeCode=@SpeCode") +
        (SDate == null ? "" : ",SDate=@SDate") +
        (EDate == null ? "" : ",EDate=@EDate") +
        (_1Start == null ? "" : ",_1Start=@_1Start") +
        (_1End == null ? "" : ",_1End=@_1End") +
        (_2Start == null ? "" : ",_2Start=@_2Start") +
        (_2End == null ? "" : ",_2End=@_2End") +
        (_3Start == null ? "" : ",_3Start=@_3Start") +
        (_3End == null ? "" : ",_3End=@_3End") +
        (_4Start == null ? "" : ",_4Start=@_4Start") +
        (_4End == null ? "" : ",_4End=@_4End") +
        (_5Start == null ? "" : ",_5Start=@_5Start") +
        (_5End == null ? "" : ",_5End=@_5End") +
        (_6Start == null ? "" : ",_6Start=@_6Start") +
        (_6End == null ? "" : ",_6End=@_6End") +
        (_7Start == null ? "" : ",_7Start=@_7Start") +
        (_7End == null ? "" : ",_7End=@_7End") +
        (P1 == null ? "" : ",P1=@P1") +
        (P2 == null ? "" : ",P2=@P2") +
        (P3 == null ? "" : ",P3=@P3") +
        (P4 == null ? "" : ",P4=@P4") +
        (P5 == null ? "" : ",P5=@P5") +
        (Cancelled == null ? "" : ",Cancelled=@Cancelled") +
                " WHERE [DVC_ID] = " + DVC_ID;
                        }
                    }
                    if (SpeCode != null) comm.Parameters.AddWithValue("SpeCode", SpeCode);
                    if (SDate != null) comm.Parameters.AddWithValue("SDate", SDate);
                    if (EDate != null) comm.Parameters.AddWithValue("EDate", EDate);
                    if (_1Start != null) comm.Parameters.AddWithValue("_1Start", _1Start);
                    if (_1End != null) comm.Parameters.AddWithValue("_1End", _1End);
                    if (_2Start != null) comm.Parameters.AddWithValue("_2Start", _2Start);
                    if (_2End != null) comm.Parameters.AddWithValue("_2End", _2End);
                    if (_3Start != null) comm.Parameters.AddWithValue("_3Start", _3Start);
                    if (_3End != null) comm.Parameters.AddWithValue("_3End", _3End);
                    if (_4Start != null) comm.Parameters.AddWithValue("_4Start", _4Start);
                    if (_4End != null) comm.Parameters.AddWithValue("_4End", _4End);
                    if (_5Start != null) comm.Parameters.AddWithValue("_5Start", _5Start);
                    if (_5End != null) comm.Parameters.AddWithValue("_5End", _5End);
                    if (_6Start != null) comm.Parameters.AddWithValue("_6Start", _6Start);
                    if (_6End != null) comm.Parameters.AddWithValue("_6End", _6End);
                    if (_7Start != null) comm.Parameters.AddWithValue("_7Start", _7Start);
                    if (_7End != null) comm.Parameters.AddWithValue("_7End", _7End);
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


    public int DAL_Set(Timetables n, bool Delete)
    {
        int s = 0;
        try
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString))
            {
                using (SqlCommand comm = new SqlCommand("", conn))
                {
                    conn.Open();
                    if (n.DVC_ID == null)
                    {
                        comm.CommandText = @"INSERT INTO Timetables (CDate" +
        (n.SpeCode == null ? "" : ",SpeCode") +
(n.SDate == null ? "" : ",SDate") +
(n.EDate == null ? "" : ",EDate") +
(n._1Start == null ? "" : ",_1Start") +
(n._1End == null ? "" : ",_1End") +
(n._2Start == null ? "" : ",_2Start") +
(n._2End == null ? "" : ",_2End") +
(n._3Start == null ? "" : ",_3Start") +
(n._3End == null ? "" : ",_3End") +
(n._4Start == null ? "" : ",_4Start") +
(n._4End == null ? "" : ",_4End") +
(n._5Start == null ? "" : ",_5Start") +
(n._5End == null ? "" : ",_5End") +
(n._6Start == null ? "" : ",_6Start") +
(n._6End == null ? "" : ",_6End") +
(n._7Start == null ? "" : ",_7Start") +
(n._7End == null ? "" : ",_7End") +
(n.P1 == null ? "" : ",P1") +
(n.P2 == null ? "" : ",P2") +
(n.P3 == null ? "" : ",P3") +
(n.P4 == null ? "" : ",P4") +
(n.P5 == null ? "" : ",P5") +
(n.Cancelled == null ? "" : ",Cancelled") +
        @")
		 VALUES
		(getdate()" +
        (n.SpeCode == null ? "" : ",@SpeCode") +
(n.SDate == null ? "" : ",@SDate") +
(n.EDate == null ? "" : ",@EDate") +
(n._1Start == null ? "" : ",@_1Start") +
(n._1End == null ? "" : ",@_1End") +
(n._2Start == null ? "" : ",@_2Start") +
(n._2End == null ? "" : ",@_2End") +
(n._3Start == null ? "" : ",@_3Start") +
(n._3End == null ? "" : ",@_3End") +
(n._4Start == null ? "" : ",@_4Start") +
(n._4End == null ? "" : ",@_4End") +
(n._5Start == null ? "" : ",@_5Start") +
(n._5End == null ? "" : ",@_5End") +
(n._6Start == null ? "" : ",@_6Start") +
(n._6End == null ? "" : ",@_6End") +
(n._7Start == null ? "" : ",@_7Start") +
(n._7End == null ? "" : ",@_7End") +
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
                            comm.CommandText = @"UPDATE  Timetables SET DDate=getdate(),Cancelled = 1 Where DVC_ID = " + n.DVC_ID;
                        }
                        else
                        {
                            comm.CommandText = @"UPDATE  Timetables SET UDate=getdate() " +
                                    (n.SpeCode == null ? "" : ",SpeCode=@SpeCode") +
        (n.SDate == null ? "" : ",SDate=@SDate") +
        (n.EDate == null ? "" : ",EDate=@EDate") +
        (n._1Start == null ? "" : ",_1Start=@_1Start") +
        (n._1End == null ? "" : ",_1End=@_1End") +
        (n._2Start == null ? "" : ",_2Start=@_2Start") +
        (n._2End == null ? "" : ",_2End=@_2End") +
        (n._3Start == null ? "" : ",_3Start=@_3Start") +
        (n._3End == null ? "" : ",_3End=@_3End") +
        (n._4Start == null ? "" : ",_4Start=@_4Start") +
        (n._4End == null ? "" : ",_4End=@_4End") +
        (n._5Start == null ? "" : ",_5Start=@_5Start") +
        (n._5End == null ? "" : ",_5End=@_5End") +
        (n._6Start == null ? "" : ",_6Start=@_6Start") +
        (n._6End == null ? "" : ",_6End=@_6End") +
        (n._7Start == null ? "" : ",_7Start=@_7Start") +
        (n._7End == null ? "" : ",_7End=@_7End") +
        (n.P1 == null ? "" : ",P1=@P1") +
        (n.P2 == null ? "" : ",P2=@P2") +
        (n.P3 == null ? "" : ",P3=@P3") +
        (n.P4 == null ? "" : ",P4=@P4") +
        (n.P5 == null ? "" : ",P5=@P5") +
        (n.Cancelled == null ? "" : ",Cancelled=@Cancelled") +
                " WHERE [DVC_ID] = " + n.DVC_ID;
                        }
                    }
                    if (n.SpeCode != null) comm.Parameters.AddWithValue("SpeCode", n.SpeCode);
                    if (n.SDate != null) comm.Parameters.AddWithValue("SDate", n.SDate);
                    if (n.EDate != null) comm.Parameters.AddWithValue("EDate", n.EDate);
                    if (n._1Start != null) comm.Parameters.AddWithValue("_1Start", n._1Start);
                    if (n._1End != null) comm.Parameters.AddWithValue("_1End", n._1End);
                    if (n._2Start != null) comm.Parameters.AddWithValue("_2Start", n._2Start);
                    if (n._2End != null) comm.Parameters.AddWithValue("_2End", n._2End);
                    if (n._3Start != null) comm.Parameters.AddWithValue("_3Start", n._3Start);
                    if (n._3End != null) comm.Parameters.AddWithValue("_3End", n._3End);
                    if (n._4Start != null) comm.Parameters.AddWithValue("_4Start", n._4Start);
                    if (n._4End != null) comm.Parameters.AddWithValue("_4End", n._4End);
                    if (n._5Start != null) comm.Parameters.AddWithValue("_5Start", n._5Start);
                    if (n._5End != null) comm.Parameters.AddWithValue("_5End", n._5End);
                    if (n._6Start != null) comm.Parameters.AddWithValue("_6Start", n._6Start);
                    if (n._6End != null) comm.Parameters.AddWithValue("_6End", n._6End);
                    if (n._7Start != null) comm.Parameters.AddWithValue("_7Start", n._7Start);
                    if (n._7End != null) comm.Parameters.AddWithValue("_7End", n._7End);
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

TimetablesList:[],
TimetablesModeli:{
DVC_ID:0, CDate:'', UDate:'', DDate:'', SpeCode:'', SDate:'', EDate:'', _1Start:'', _1End:'', _2Start:'', _2End:'', _3Start:'', _3End:'', _4Start:'', _4End:'', _5Start:'', _5End:'', _6Start:'', _6End:'', _7Start:'', _7End:'', P1:'', P2:'', P3:'', P4:'', P5:'', Cancelled:0, },

*/
}

