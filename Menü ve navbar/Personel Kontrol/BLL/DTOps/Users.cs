using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Collections.Generic;
using System.ComponentModel;

public class Users : IDisposable
{

    public void Dispose() { }


    public static DateTime dtnull = Convert.ToDateTime(ConfigurationManager.AppSettings["dtnull"]);
    public int? USR_ID { get; set; }
    public DateTime? CDate { get; set; }
    public DateTime? UDate { get; set; }
    public DateTime? DDate { get; set; }
    public int? CUSR_ID { get; set; }
    public int? AUSR_ID { get; set; }
    public int? REF_ID { get; set; }
    public string Uname { get; set; }
    public string Passw { get; set; }
    public string Name { get; set; }
    public string Notes { get; set; }
    public string GSMNo { get; set; }
    public string Email { get; set; }
    public string Role { get; set; }
    public string AnaBayiKodu { get; set; }
    public string PlasiyerKodu { get; set; }
    public string GrpCode { get; set; }
    public string CypCode { get; set; }
    public string SpeCode1 { get; set; }
    public string SpeCode2 { get; set; }
    public string TCKNO { get; set; }
    public string CompanyCode { get; set; }
    public string BranchCode { get; set; }
    public string Title { get; set; }
    public string DT { get; set; }
    public string DV { get; set; }
    public string CK { get; set; }
    public string P1 { get; set; }
    public string P2 { get; set; }
    public string P3 { get; set; }
    public string P4 { get; set; }
    public string P5 { get; set; }
    public DateTime? LastLogin { get; set; }
    public int? Cancelled { get; set; }

    public static DataTable Hepsi()
    {
        return new DAL.DBOps().sc("SELECT * FROM Users");
    }

    public static DataTable Ver(string wheresi, params object[] Pler)
    {
        return new DAL.DBOps().sc("SELECT * FROM Users " + (string.IsNullOrEmpty(wheresi) ? "" : " WHERE " + wheresi), Pler);
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
    //    return new DAL.DBOps().scp("Select " + sel + " FROM Users " + whe, parameters);

    //}

    public static Users Ver(string wheresi)
    {
        DataTable dt = new DataTable();
        Users n = new Users();
        try
        {
            dt = new DAL.DBOps().sc("SELECT * FROM Users " + (string.IsNullOrEmpty(wheresi) ? "" : " WHERE " + wheresi));
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["USR_ID"] != DBNull.Value) n.USR_ID = (int)dt.Rows[0]["USR_ID"];
                if (dt.Rows[0]["CDate"] != DBNull.Value) n.CDate = (DateTime)dt.Rows[0]["CDate"];
                if (dt.Rows[0]["UDate"] != DBNull.Value) n.UDate = (DateTime)dt.Rows[0]["UDate"];
                if (dt.Rows[0]["DDate"] != DBNull.Value) n.DDate = (DateTime)dt.Rows[0]["DDate"];
                if (dt.Rows[0]["CUSR_ID"] != DBNull.Value) n.CUSR_ID = (int)dt.Rows[0]["CUSR_ID"];
                if (dt.Rows[0]["AUSR_ID"] != DBNull.Value) n.AUSR_ID = (int)dt.Rows[0]["AUSR_ID"];
                if (dt.Rows[0]["REF_ID"] != DBNull.Value) n.REF_ID = (int)dt.Rows[0]["REF_ID"];
                if (dt.Rows[0]["Uname"] != DBNull.Value) n.Uname = dt.Rows[0]["Uname"].ToString();
                if (dt.Rows[0]["Passw"] != DBNull.Value) n.Passw = dt.Rows[0]["Passw"].ToString();
                if (dt.Rows[0]["Name"] != DBNull.Value) n.Name = dt.Rows[0]["Name"].ToString();
                if (dt.Rows[0]["Notes"] != DBNull.Value) n.Notes = dt.Rows[0]["Notes"].ToString();
                if (dt.Rows[0]["GSMNo"] != DBNull.Value) n.GSMNo = dt.Rows[0]["GSMNo"].ToString();
                if (dt.Rows[0]["Email"] != DBNull.Value) n.Email = dt.Rows[0]["Email"].ToString();
                if (dt.Rows[0]["Role"] != DBNull.Value) n.Role = dt.Rows[0]["Role"].ToString();
                if (dt.Rows[0]["AnaBayiKodu"] != DBNull.Value) n.AnaBayiKodu = dt.Rows[0]["AnaBayiKodu"].ToString();
                if (dt.Rows[0]["PlasiyerKodu"] != DBNull.Value) n.PlasiyerKodu = dt.Rows[0]["PlasiyerKodu"].ToString();
                if (dt.Rows[0]["GrpCode"] != DBNull.Value) n.GrpCode = dt.Rows[0]["GrpCode"].ToString();
                if (dt.Rows[0]["CypCode"] != DBNull.Value) n.CypCode = dt.Rows[0]["CypCode"].ToString();
                if (dt.Rows[0]["SpeCode1"] != DBNull.Value) n.SpeCode1 = dt.Rows[0]["SpeCode1"].ToString();
                if (dt.Rows[0]["SpeCode2"] != DBNull.Value) n.SpeCode2 = dt.Rows[0]["SpeCode2"].ToString();
                if (dt.Rows[0]["TCKNO"] != DBNull.Value) n.TCKNO = dt.Rows[0]["TCKNO"].ToString();
                if (dt.Rows[0]["CompanyCode"] != DBNull.Value) n.CompanyCode = dt.Rows[0]["CompanyCode"].ToString();
                if (dt.Rows[0]["BranchCode"] != DBNull.Value) n.BranchCode = dt.Rows[0]["BranchCode"].ToString();
                if (dt.Rows[0]["Title"] != DBNull.Value) n.Title = dt.Rows[0]["Title"].ToString();
                if (dt.Rows[0]["DT"] != DBNull.Value) n.DT = dt.Rows[0]["DT"].ToString();
                if (dt.Rows[0]["DV"] != DBNull.Value) n.DV = dt.Rows[0]["DV"].ToString();
                if (dt.Rows[0]["CK"] != DBNull.Value) n.CK = dt.Rows[0]["CK"].ToString();
                if (dt.Rows[0]["P1"] != DBNull.Value) n.P1 = dt.Rows[0]["P1"].ToString();
                if (dt.Rows[0]["P2"] != DBNull.Value) n.P2 = dt.Rows[0]["P2"].ToString();
                if (dt.Rows[0]["P3"] != DBNull.Value) n.P3 = dt.Rows[0]["P3"].ToString();
                if (dt.Rows[0]["P4"] != DBNull.Value) n.P4 = dt.Rows[0]["P4"].ToString();
                if (dt.Rows[0]["P5"] != DBNull.Value) n.P5 = dt.Rows[0]["P5"].ToString();
                if (dt.Rows[0]["LastLogin"] != DBNull.Value) n.LastLogin = (DateTime)dt.Rows[0]["LastLogin"];
                if (dt.Rows[0]["Cancelled"] != DBNull.Value) n.Cancelled = (int)dt.Rows[0]["Cancelled"];

            }
            return n;
        }
        catch (Exception)
        {
            return n;
        }
    }


    public static Users[] VerArr(string wheresi)
    {
        DataTable dt = new DataTable();
        Users[] n = new Users[0];
        try
        {
            dt = new DAL.DBOps().sc("SELECT * FROM Users " + (string.IsNullOrEmpty(wheresi) ? "" : " WHERE " + wheresi));
            if (dt.Rows.Count > 0)
            {
                n = new Users[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    n[i] = new Users();
                    if (dt.Rows[i]["USR_ID"] != DBNull.Value) n[i].USR_ID = (int)dt.Rows[i]["USR_ID"];
                    if (dt.Rows[i]["CDate"] != DBNull.Value) n[i].CDate = (DateTime)dt.Rows[i]["CDate"];
                    if (dt.Rows[i]["UDate"] != DBNull.Value) n[i].UDate = (DateTime)dt.Rows[i]["UDate"];
                    if (dt.Rows[i]["DDate"] != DBNull.Value) n[i].DDate = (DateTime)dt.Rows[i]["DDate"];
                    if (dt.Rows[i]["CUSR_ID"] != DBNull.Value) n[i].CUSR_ID = (int)dt.Rows[i]["CUSR_ID"];
                    if (dt.Rows[i]["AUSR_ID"] != DBNull.Value) n[i].AUSR_ID = (int)dt.Rows[i]["AUSR_ID"];
                    if (dt.Rows[i]["REF_ID"] != DBNull.Value) n[i].REF_ID = (int)dt.Rows[i]["REF_ID"];
                    if (dt.Rows[i]["Uname"] != DBNull.Value) n[i].Uname = dt.Rows[i]["Uname"].ToString();
                    if (dt.Rows[i]["Passw"] != DBNull.Value) n[i].Passw = dt.Rows[i]["Passw"].ToString();
                    if (dt.Rows[i]["Name"] != DBNull.Value) n[i].Name = dt.Rows[i]["Name"].ToString();
                    if (dt.Rows[i]["Notes"] != DBNull.Value) n[i].Notes = dt.Rows[i]["Notes"].ToString();
                    if (dt.Rows[i]["GSMNo"] != DBNull.Value) n[i].GSMNo = dt.Rows[i]["GSMNo"].ToString();
                    if (dt.Rows[i]["Email"] != DBNull.Value) n[i].Email = dt.Rows[i]["Email"].ToString();
                    if (dt.Rows[i]["Role"] != DBNull.Value) n[i].Role = dt.Rows[i]["Role"].ToString();
                    if (dt.Rows[i]["AnaBayiKodu"] != DBNull.Value) n[i].AnaBayiKodu = dt.Rows[i]["AnaBayiKodu"].ToString();
                    if (dt.Rows[i]["PlasiyerKodu"] != DBNull.Value) n[i].PlasiyerKodu = dt.Rows[i]["PlasiyerKodu"].ToString();
                    if (dt.Rows[i]["GrpCode"] != DBNull.Value) n[i].GrpCode = dt.Rows[i]["GrpCode"].ToString();
                    if (dt.Rows[i]["CypCode"] != DBNull.Value) n[i].CypCode = dt.Rows[i]["CypCode"].ToString();
                    if (dt.Rows[i]["SpeCode1"] != DBNull.Value) n[i].SpeCode1 = dt.Rows[i]["SpeCode1"].ToString();
                    if (dt.Rows[i]["SpeCode2"] != DBNull.Value) n[i].SpeCode2 = dt.Rows[i]["SpeCode2"].ToString();
                    if (dt.Rows[i]["TCKNO"] != DBNull.Value) n[i].TCKNO = dt.Rows[i]["TCKNO"].ToString();
                    if (dt.Rows[i]["CompanyCode"] != DBNull.Value) n[i].CompanyCode = dt.Rows[i]["CompanyCode"].ToString();
                    if (dt.Rows[i]["BranchCode"] != DBNull.Value) n[i].BranchCode = dt.Rows[i]["BranchCode"].ToString();
                    if (dt.Rows[i]["Title"] != DBNull.Value) n[i].Title = dt.Rows[i]["Title"].ToString();
                    if (dt.Rows[i]["DT"] != DBNull.Value) n[i].DT = dt.Rows[i]["DT"].ToString();
                    if (dt.Rows[i]["DV"] != DBNull.Value) n[i].DV = dt.Rows[i]["DV"].ToString();
                    if (dt.Rows[i]["CK"] != DBNull.Value) n[i].CK = dt.Rows[i]["CK"].ToString();
                    if (dt.Rows[i]["P1"] != DBNull.Value) n[i].P1 = dt.Rows[i]["P1"].ToString();
                    if (dt.Rows[i]["P2"] != DBNull.Value) n[i].P2 = dt.Rows[i]["P2"].ToString();
                    if (dt.Rows[i]["P3"] != DBNull.Value) n[i].P3 = dt.Rows[i]["P3"].ToString();
                    if (dt.Rows[i]["P4"] != DBNull.Value) n[i].P4 = dt.Rows[i]["P4"].ToString();
                    if (dt.Rows[i]["P5"] != DBNull.Value) n[i].P5 = dt.Rows[i]["P5"].ToString();
                    if (dt.Rows[i]["LastLogin"] != DBNull.Value) n[i].LastLogin = (DateTime)dt.Rows[i]["LastLogin"];
                    if (dt.Rows[i]["Cancelled"] != DBNull.Value) n[i].Cancelled = (int)dt.Rows[i]["Cancelled"];

                }
            }
            return n;
        }
        catch (Exception ex)
        {
            //new Ortak().Logla("Users[] VerArr", wheresi, ex.Message);
            return n;
        }
    }


    public static List<Users> VerList(string wheresi)
    {
        List<Users> lst = new List<Users>();
        using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString))
        {
            using (SqlCommand comm = new SqlCommand("SELECT * FROM Users " + (string.IsNullOrEmpty(wheresi) ? "" : " WHERE " + wheresi), conn))
            {
                try
                {
                    conn.Open();
                    SqlDataReader r = comm.ExecuteReader();
                    while (r.Read())
                    {
                        Users n = new Users();
                        if (r["USR_ID"] != DBNull.Value) n.USR_ID = (int)r["USR_ID"];
                        if (r["CDate"] != DBNull.Value) n.CDate = (DateTime)r["CDate"];
                        if (r["UDate"] != DBNull.Value) n.UDate = (DateTime)r["UDate"];
                        if (r["DDate"] != DBNull.Value) n.DDate = (DateTime)r["DDate"];
                        if (r["CUSR_ID"] != DBNull.Value) n.CUSR_ID = (int)r["CUSR_ID"];
                        if (r["AUSR_ID"] != DBNull.Value) n.AUSR_ID = (int)r["AUSR_ID"];
                        if (r["REF_ID"] != DBNull.Value) n.REF_ID = (int)r["REF_ID"];
                        if (r["Uname"] != DBNull.Value) n.Uname = r["Uname"].ToString();
                        if (r["Passw"] != DBNull.Value) n.Passw = r["Passw"].ToString();
                        if (r["Name"] != DBNull.Value) n.Name = r["Name"].ToString();
                        if (r["Notes"] != DBNull.Value) n.Notes = r["Notes"].ToString();
                        if (r["GSMNo"] != DBNull.Value) n.GSMNo = r["GSMNo"].ToString();
                        if (r["Email"] != DBNull.Value) n.Email = r["Email"].ToString();
                        if (r["Role"] != DBNull.Value) n.Role = r["Role"].ToString();
                        if (r["AnaBayiKodu"] != DBNull.Value) n.AnaBayiKodu = r["AnaBayiKodu"].ToString();
                        if (r["PlasiyerKodu"] != DBNull.Value) n.PlasiyerKodu = r["PlasiyerKodu"].ToString();
                        if (r["GrpCode"] != DBNull.Value) n.GrpCode = r["GrpCode"].ToString();
                        if (r["CypCode"] != DBNull.Value) n.CypCode = r["CypCode"].ToString();
                        if (r["SpeCode1"] != DBNull.Value) n.SpeCode1 = r["SpeCode1"].ToString();
                        if (r["SpeCode2"] != DBNull.Value) n.SpeCode2 = r["SpeCode2"].ToString();
                        if (r["TCKNO"] != DBNull.Value) n.TCKNO = r["TCKNO"].ToString();
                        if (r["CompanyCode"] != DBNull.Value) n.CompanyCode = r["CompanyCode"].ToString();
                        if (r["BranchCode"] != DBNull.Value) n.BranchCode = r["BranchCode"].ToString();
                        if (r["Title"] != DBNull.Value) n.Title = r["Title"].ToString();
                        if (r["DT"] != DBNull.Value) n.DT = r["DT"].ToString();
                        if (r["DV"] != DBNull.Value) n.DV = r["DV"].ToString();
                        if (r["CK"] != DBNull.Value) n.CK = r["CK"].ToString();
                        if (r["P1"] != DBNull.Value) n.P1 = r["P1"].ToString();
                        if (r["P2"] != DBNull.Value) n.P2 = r["P2"].ToString();
                        if (r["P3"] != DBNull.Value) n.P3 = r["P3"].ToString();
                        if (r["P4"] != DBNull.Value) n.P4 = r["P4"].ToString();
                        if (r["P5"] != DBNull.Value) n.P5 = r["P5"].ToString();
                        if (r["LastLogin"] != DBNull.Value) n.LastLogin = (DateTime)r["LastLogin"];
                        if (r["Cancelled"] != DBNull.Value) n.Cancelled = (int)r["Cancelled"];
                        lst.Add(n);
                    }
                    r.Close();
                    return lst;
                }
                catch (Exception ex)
                {
                    //new Ortak().Logla("Users[] VerList", wheresi, ex.Message);
                    return lst;
                }
            }

        }
    }



    public static List<Users> VerList(string wheresi, params object[] Pler)
    {
        List<Users> lst = new List<Users>();
        using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString))
        {
            using (SqlCommand comm = new SqlCommand("SELECT * FROM Users " + (string.IsNullOrEmpty(wheresi) ? "" : " WHERE " + wheresi), conn))
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
                        Users n = new Users();
                        if (r["USR_ID"] != DBNull.Value) n.USR_ID = (int)r["USR_ID"];
                        if (r["CDate"] != DBNull.Value) n.CDate = (DateTime)r["CDate"];
                        if (r["UDate"] != DBNull.Value) n.UDate = (DateTime)r["UDate"];
                        if (r["DDate"] != DBNull.Value) n.DDate = (DateTime)r["DDate"];
                        if (r["CUSR_ID"] != DBNull.Value) n.CUSR_ID = (int)r["CUSR_ID"];
                        if (r["AUSR_ID"] != DBNull.Value) n.AUSR_ID = (int)r["AUSR_ID"];
                        if (r["REF_ID"] != DBNull.Value) n.REF_ID = (int)r["REF_ID"];
                        if (r["Uname"] != DBNull.Value) n.Uname = r["Uname"].ToString();
                        if (r["Passw"] != DBNull.Value) n.Passw = r["Passw"].ToString();
                        if (r["Name"] != DBNull.Value) n.Name = r["Name"].ToString();
                        if (r["Notes"] != DBNull.Value) n.Notes = r["Notes"].ToString();
                        if (r["GSMNo"] != DBNull.Value) n.GSMNo = r["GSMNo"].ToString();
                        if (r["Email"] != DBNull.Value) n.Email = r["Email"].ToString();
                        if (r["Role"] != DBNull.Value) n.Role = r["Role"].ToString();
                        if (r["AnaBayiKodu"] != DBNull.Value) n.AnaBayiKodu = r["AnaBayiKodu"].ToString();
                        if (r["PlasiyerKodu"] != DBNull.Value) n.PlasiyerKodu = r["PlasiyerKodu"].ToString();
                        if (r["GrpCode"] != DBNull.Value) n.GrpCode = r["GrpCode"].ToString();
                        if (r["CypCode"] != DBNull.Value) n.CypCode = r["CypCode"].ToString();
                        if (r["SpeCode1"] != DBNull.Value) n.SpeCode1 = r["SpeCode1"].ToString();
                        if (r["SpeCode2"] != DBNull.Value) n.SpeCode2 = r["SpeCode2"].ToString();
                        if (r["TCKNO"] != DBNull.Value) n.TCKNO = r["TCKNO"].ToString();
                        if (r["CompanyCode"] != DBNull.Value) n.CompanyCode = r["CompanyCode"].ToString();
                        if (r["BranchCode"] != DBNull.Value) n.BranchCode = r["BranchCode"].ToString();
                        if (r["Title"] != DBNull.Value) n.Title = r["Title"].ToString();
                        if (r["DT"] != DBNull.Value) n.DT = r["DT"].ToString();
                        if (r["DV"] != DBNull.Value) n.DV = r["DV"].ToString();
                        if (r["CK"] != DBNull.Value) n.CK = r["CK"].ToString();
                        if (r["P1"] != DBNull.Value) n.P1 = r["P1"].ToString();
                        if (r["P2"] != DBNull.Value) n.P2 = r["P2"].ToString();
                        if (r["P3"] != DBNull.Value) n.P3 = r["P3"].ToString();
                        if (r["P4"] != DBNull.Value) n.P4 = r["P4"].ToString();
                        if (r["P5"] != DBNull.Value) n.P5 = r["P5"].ToString();
                        if (r["LastLogin"] != DBNull.Value) n.LastLogin = (DateTime)r["LastLogin"];
                        if (r["Cancelled"] != DBNull.Value) n.Cancelled = (int)r["Cancelled"];
                        lst.Add(n);
                    }
                    r.Close();
                    return lst;
                }
                catch (Exception ex)
                {
                    //new Ortak().Logla("Users[] VerList", wheresi, ex.Message);
                    return lst;
                }
            }

        }
    }


    public static bool Ekle(Users n)
    {
        try
        {
            string c = @"INSERT INTO Users
			(CDate,UDate,DDate,CUSR_ID,AUSR_ID,REF_ID,Uname,Passw,Name,Notes,GSMNo,Email,Role,AnaBayiKodu,PlasiyerKodu,GrpCode,CypCode,SpeCode1,SpeCode2,TCKNO,CompanyCode,BranchCode,Title,DT,DV,CK,P1,P2,P3,P4,P5,LastLogin,Cancelled)
			VALUES
			(@CDate,@UDate,@DDate,@CUSR_ID,@AUSR_ID,@REF_ID,@Uname,@Passw,@Name,@Notes,@GSMNo,@Email,@Role,@AnaBayiKodu,@PlasiyerKodu,@GrpCode,@CypCode,@SpeCode1,@SpeCode2,@TCKNO,@CompanyCode,@BranchCode,@Title,@DT,@DV,@CK,@P1,@P2,@P3,@P4,@P5,@LastLogin,@Cancelled)";

            SqlParameterCollection parameters = new SqlCommand().Parameters;
            parameters.Add(new SqlParameter("CDate", (n.CDate == dtnull ? SqlDateTime.Null.Value : n.CDate)));
            parameters.Add(new SqlParameter("UDate", (n.UDate == dtnull ? SqlDateTime.Null.Value : n.UDate)));
            parameters.Add(new SqlParameter("DDate", (n.DDate == dtnull ? SqlDateTime.Null.Value : n.DDate)));
            parameters.Add(new SqlParameter("CUSR_ID", (n.CUSR_ID == null ? 0 : n.CUSR_ID)));
            parameters.Add(new SqlParameter("AUSR_ID", (n.AUSR_ID == null ? 0 : n.AUSR_ID)));
            parameters.Add(new SqlParameter("REF_ID", (n.REF_ID == null ? 0 : n.REF_ID)));
            parameters.Add(new SqlParameter("Uname", (n.Uname == null ? "" : n.Uname)));
            parameters.Add(new SqlParameter("Passw", (n.Passw == null ? "" : n.Passw)));
            parameters.Add(new SqlParameter("Name", (n.Name == null ? "" : n.Name)));
            parameters.Add(new SqlParameter("Notes", (n.Notes == null ? "" : n.Notes)));
            parameters.Add(new SqlParameter("GSMNo", (n.GSMNo == null ? "" : n.GSMNo)));
            parameters.Add(new SqlParameter("Email", (n.Email == null ? "" : n.Email)));
            parameters.Add(new SqlParameter("Role", (n.Role == null ? "" : n.Role)));
            parameters.Add(new SqlParameter("AnaBayiKodu", (n.AnaBayiKodu == null ? "" : n.AnaBayiKodu)));
            parameters.Add(new SqlParameter("PlasiyerKodu", (n.PlasiyerKodu == null ? "" : n.PlasiyerKodu)));
            parameters.Add(new SqlParameter("GrpCode", (n.GrpCode == null ? "" : n.GrpCode)));
            parameters.Add(new SqlParameter("CypCode", (n.CypCode == null ? "" : n.CypCode)));
            parameters.Add(new SqlParameter("SpeCode1", (n.SpeCode1 == null ? "" : n.SpeCode1)));
            parameters.Add(new SqlParameter("SpeCode2", (n.SpeCode2 == null ? "" : n.SpeCode2)));
            parameters.Add(new SqlParameter("TCKNO", (n.TCKNO == null ? "" : n.TCKNO)));
            parameters.Add(new SqlParameter("CompanyCode", (n.CompanyCode == null ? "" : n.CompanyCode)));
            parameters.Add(new SqlParameter("BranchCode", (n.BranchCode == null ? "" : n.BranchCode)));
            parameters.Add(new SqlParameter("Title", (n.Title == null ? "" : n.Title)));
            parameters.Add(new SqlParameter("DT", (n.DT == null ? "" : n.DT)));
            parameters.Add(new SqlParameter("DV", (n.DV == null ? "" : n.DV)));
            parameters.Add(new SqlParameter("CK", (n.CK == null ? "" : n.CK)));
            parameters.Add(new SqlParameter("P1", (n.P1 == null ? "" : n.P1)));
            parameters.Add(new SqlParameter("P2", (n.P2 == null ? "" : n.P2)));
            parameters.Add(new SqlParameter("P3", (n.P3 == null ? "" : n.P3)));
            parameters.Add(new SqlParameter("P4", (n.P4 == null ? "" : n.P4)));
            parameters.Add(new SqlParameter("P5", (n.P5 == null ? "" : n.P5)));
            parameters.Add(new SqlParameter("LastLogin", (n.LastLogin == dtnull ? SqlDateTime.Null.Value : n.LastLogin)));
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
            string c = @"DELETE FROM Users WHERE ";
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

    public static bool Guncelle(Users n, string[] whalan, string[] whparam)
    {
        try
        {
            string c = @"UPDATE Users SET 
		(CDate=@CDate,UDate=@UDate,DDate=@DDate,CUSR_ID=@CUSR_ID,AUSR_ID=@AUSR_ID,REF_ID=@REF_ID,Uname=@Uname,Passw=@Passw,Name=@Name,Notes=@Notes,GSMNo=@GSMNo,Email=@Email,Role=@Role,AnaBayiKodu=@AnaBayiKodu,PlasiyerKodu=@PlasiyerKodu,GrpCode=@GrpCode,CypCode=@CpCode,SpeCode1=@SpeCode1,SpeCode2=@SpeCode2,TCKNO=@TCKNO,CompanyCode=@CompanyCode,BranchCode=@BranchCode,Title=@Title,DT=@DT,DV=@DV,CK=@CK,P1=@P1,P2=@P2,P3=@P3,P4=@P4,P5=@P5,LastLogin=@LastLogin,Cancelled=@Cancelled,)
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
            parameters.Add(new SqlParameter("CUSR_ID", n.CUSR_ID));
            parameters.Add(new SqlParameter("AUSR_ID", n.AUSR_ID));
            parameters.Add(new SqlParameter("REF_ID", n.REF_ID));
            parameters.Add(new SqlParameter("Uname", n.Uname));
            parameters.Add(new SqlParameter("Passw", n.Passw));
            parameters.Add(new SqlParameter("Name", n.Name));
            parameters.Add(new SqlParameter("Notes", n.Notes));
            parameters.Add(new SqlParameter("GSMNo", n.GSMNo));
            parameters.Add(new SqlParameter("Email", n.Email));
            parameters.Add(new SqlParameter("Role", n.Role));
            parameters.Add(new SqlParameter("AnaBayiKodu", n.AnaBayiKodu));
            parameters.Add(new SqlParameter("PlasiyerKodu", n.PlasiyerKodu));
            parameters.Add(new SqlParameter("GrpCode", n.GrpCode));
            parameters.Add(new SqlParameter("CypCode", n.CypCode));
            parameters.Add(new SqlParameter("SpeCode1", n.SpeCode1));
            parameters.Add(new SqlParameter("SpeCode2", n.SpeCode2));
            parameters.Add(new SqlParameter("TCKNO", n.TCKNO));
            parameters.Add(new SqlParameter("CompanyCode", n.CompanyCode));
            parameters.Add(new SqlParameter("BranchCode", n.BranchCode));
            parameters.Add(new SqlParameter("Title", n.Title));
            parameters.Add(new SqlParameter("DT", n.DT));
            parameters.Add(new SqlParameter("DV", n.DV));
            parameters.Add(new SqlParameter("CK", n.CK));
            parameters.Add(new SqlParameter("P1", n.P1));
            parameters.Add(new SqlParameter("P2", n.P2));
            parameters.Add(new SqlParameter("P3", n.P3));
            parameters.Add(new SqlParameter("P4", n.P4));
            parameters.Add(new SqlParameter("P5", n.P5));
            parameters.Add(new SqlParameter("LastLogin", n.LastLogin == dtnull ? SqlDateTime.Null.Value : n.LastLogin));
            parameters.Add(new SqlParameter("Cancelled", n.Cancelled));


            new DAL.DBOps().scnp(c, parameters);
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public static bool Guncelle(Users n, string wheresi)
    {
        try
        {
            string c = @"UPDATE Users SET  ";
            string c2 = "";
            SqlParameterCollection parameters = new SqlCommand().Parameters;

            if (n.CDate != null) { c2 += "CDate = @CDate,"; parameters.Add(new SqlParameter("CDate", n.CDate)); }
            if (n.UDate != null) { c2 += "UDate = @UDate,"; parameters.Add(new SqlParameter("UDate", n.UDate)); }
            if (n.DDate != null) { c2 += "DDate = @DDate,"; parameters.Add(new SqlParameter("DDate", n.DDate)); }
            if (n.CUSR_ID != null) { c2 += "CUSR_ID = @CUSR_ID,"; parameters.Add(new SqlParameter("CUSR_ID", n.CUSR_ID)); }
            if (n.AUSR_ID != null) { c2 += "AUSR_ID = @AUSR_ID,"; parameters.Add(new SqlParameter("AUSR_ID", n.AUSR_ID)); }
            if (n.REF_ID != null) { c2 += "REF_ID = @REF_ID,"; parameters.Add(new SqlParameter("REF_ID", n.REF_ID)); }
            if (n.Uname != null) { c2 += "Uname = @Uname,"; parameters.Add(new SqlParameter("Uname", n.Uname)); }
            if (n.Passw != null) { c2 += "Passw = @Passw,"; parameters.Add(new SqlParameter("Passw", n.Passw)); }
            if (n.Name != null) { c2 += "Name = @Name,"; parameters.Add(new SqlParameter("Name", n.Name)); }
            if (n.Notes != null) { c2 += "Notes = @Notes,"; parameters.Add(new SqlParameter("Notes", n.Notes)); }
            if (n.GSMNo != null) { c2 += "GSMNo = @GSMNo,"; parameters.Add(new SqlParameter("GSMNo", n.GSMNo)); }
            if (n.Email != null) { c2 += "Email = @Email,"; parameters.Add(new SqlParameter("Email", n.Email)); }
            if (n.Role != null) { c2 += "Role = @Role,"; parameters.Add(new SqlParameter("Role", n.Role)); }
            if (n.AnaBayiKodu != null) { c2 += "AnaBayiKodu = @AnaBayiKodu,"; parameters.Add(new SqlParameter("AnaBayiKodu", n.AnaBayiKodu)); }
            if (n.PlasiyerKodu != null) { c2 += "PlasiyerKodu = @PlasiyerKodu,"; parameters.Add(new SqlParameter("PlasiyerKodu", n.PlasiyerKodu)); }
            if (n.GrpCode != null) { c2 += "GrpCode = @GrpCode,"; parameters.Add(new SqlParameter("GrpCode", n.GrpCode)); }
            if (n.CypCode != null) { c2 += "CypCode = @CypCode,"; parameters.Add(new SqlParameter("CypCode", n.CypCode)); }
            if (n.SpeCode1 != null) { c2 += "SpeCode1 = @SpeCode1,"; parameters.Add(new SqlParameter("SpeCode1", n.SpeCode1)); }
            if (n.SpeCode2 != null) { c2 += "SpeCode2 = @SpeCode2,"; parameters.Add(new SqlParameter("SpeCode2", n.SpeCode2)); }
            if (n.TCKNO != null) { c2 += "TCKNO = @TCKNO,"; parameters.Add(new SqlParameter("TCKNO", n.TCKNO)); }
            if (n.CompanyCode != null) { c2 += "CompanyCode = @CompanyCode,"; parameters.Add(new SqlParameter("CompanyCode", n.CompanyCode)); }
            if (n.BranchCode != null) { c2 += "BranchCode = @BranchCode,"; parameters.Add(new SqlParameter("BranchCode", n.BranchCode)); }
            if (n.Title != null) { c2 += "Title = @Title,"; parameters.Add(new SqlParameter("Title", n.Title)); }
            if (n.DT != null) { c2 += "DT = @DT,"; parameters.Add(new SqlParameter("DT", n.DT)); }
            if (n.DV != null) { c2 += "DV = @DV,"; parameters.Add(new SqlParameter("DV", n.DV)); }
            if (n.CK != null) { c2 += "CK = @CK,"; parameters.Add(new SqlParameter("CK", n.CK)); }
            if (n.P1 != null) { c2 += "P1 = @P1,"; parameters.Add(new SqlParameter("P1", n.P1)); }
            if (n.P2 != null) { c2 += "P2 = @P2,"; parameters.Add(new SqlParameter("P2", n.P2)); }
            if (n.P3 != null) { c2 += "P3 = @P3,"; parameters.Add(new SqlParameter("P3", n.P3)); }
            if (n.P4 != null) { c2 += "P4 = @P4,"; parameters.Add(new SqlParameter("P4", n.P4)); }
            if (n.P5 != null) { c2 += "P5 = @P5,"; parameters.Add(new SqlParameter("P5", n.P5)); }
            if (n.LastLogin != null) { c2 += "LastLogin = @LastLogin,"; parameters.Add(new SqlParameter("LastLogin", n.LastLogin)); }
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

    public int DAL_Set_Users(int? USR_ID, int? CUSR_ID, int? AUSR_ID, int? REF_ID, string Uname, string Passw, string Name, string Notes, string GSMNo, string Email, string Role, string AnaBayiKodu, string PlasiyerKodu, string GrpCode, string CypCode, string SpeCode1, string SpeCode2, string TCKNO, string CompanyCode, string BranchCode, string Title, string DT, string DV, string CK, string P1, string P2, string P3, string P4, string P5, DateTime? LastLogin, int? Cancelled, bool Delete)
    {
        int s = 0;
        try
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString))
            {
                using (SqlCommand comm = new SqlCommand("", conn))
                {
                    conn.Open();
                    if (USR_ID == null)
                    {
                        comm.CommandText = @"INSERT INTO Users (CDate" +
        (CUSR_ID == null ? "" : ",CUSR_ID") +
(AUSR_ID == null ? "" : ",AUSR_ID") +
(REF_ID == null ? "" : ",REF_ID") +
(Uname == null ? "" : ",Uname") +
(Passw == null ? "" : ",Passw") +
(Name == null ? "" : ",Name") +
(Notes == null ? "" : ",Notes") +
(GSMNo == null ? "" : ",GSMNo") +
(Email == null ? "" : ",Email") +
(Role == null ? "" : ",Role") +
(AnaBayiKodu == null ? "" : ",AnaBayiKodu") +
(PlasiyerKodu == null ? "" : ",PlasiyerKodu") +
(GrpCode == null ? "" : ",GrpCode") +
(CypCode == null ? "" : ",CypCode") +
(SpeCode1 == null ? "" : ",SpeCode1") +
(SpeCode2 == null ? "" : ",SpeCode2") +
(TCKNO == null ? "" : ",TCKNO") +
(CompanyCode == null ? "" : ",CompanyCode") +
(BranchCode == null ? "" : ",BranchCode") +
(Title == null ? "" : ",Title") +
(DT == null ? "" : ",DT") +
(DV == null ? "" : ",DV") +
(CK == null ? "" : ",CK") +
(P1 == null ? "" : ",P1") +
(P2 == null ? "" : ",P2") +
(P3 == null ? "" : ",P3") +
(P4 == null ? "" : ",P4") +
(P5 == null ? "" : ",P5") +
(LastLogin == null ? "" : ",LastLogin") +
(Cancelled == null ? "" : ",Cancelled") +
        @")
		 VALUES
		(getdate()" +
        (CUSR_ID == null ? "" : ",@CUSR_ID") +
(AUSR_ID == null ? "" : ",@AUSR_ID") +
(REF_ID == null ? "" : ",@REF_ID") +
(Uname == null ? "" : ",@Uname") +
(Passw == null ? "" : ",@Passw") +
(Name == null ? "" : ",@Name") +
(Notes == null ? "" : ",@Notes") +
(GSMNo == null ? "" : ",@GSMNo") +
(Email == null ? "" : ",@Email") +
(Role == null ? "" : ",@Role") +
(AnaBayiKodu == null ? "" : ",@AnaBayiKodu") +
(PlasiyerKodu == null ? "" : ",@PlasiyerKodu") +
(GrpCode == null ? "" : ",@GrpCode") +
(CypCode == null ? "" : ",@CypCode") +
(SpeCode1 == null ? "" : ",@SpeCode1") +
(SpeCode2 == null ? "" : ",@SpeCode2") +
(TCKNO == null ? "" : ",@TCKNO") +
(CompanyCode == null ? "" : ",@CompanyCode") +
(BranchCode == null ? "" : ",@BranchCode") +
(Title == null ? "" : ",@Title") +
(DT == null ? "" : ",@DT") +
(DV == null ? "" : ",@DV") +
(CK == null ? "" : ",@CK") +
(P1 == null ? "" : ",@P1") +
(P2 == null ? "" : ",@P2") +
(P3 == null ? "" : ",@P3") +
(P4 == null ? "" : ",@P4") +
(P5 == null ? "" : ",@P5") +
(LastLogin == null ? "" : ",@LastLogin") +
(Cancelled == null ? "" : ",@Cancelled") +
        ")";
                    }
                    else
                    {
                        if (Delete)
                        {
                            comm.CommandText = @"UPDATE  Users SET DDate=getdate(),Cancelled = 1 Where USR_ID = " + USR_ID;
                        }
                        else
                        {
                            comm.CommandText = @"UPDATE  Users SET UDate=getdate() " +
                                    (CUSR_ID == null ? "" : ",CUSR_ID=@CUSR_ID") +
        (AUSR_ID == null ? "" : ",AUSR_ID=@AUSR_ID") +
        (REF_ID == null ? "" : ",REF_ID=@REF_ID") +
        (Uname == null ? "" : ",Uname=@Uname") +
        (Passw == null ? "" : ",Passw=@Passw") +
        (Name == null ? "" : ",Name=@Name") +
        (Notes == null ? "" : ",Notes=@Notes") +
        (GSMNo == null ? "" : ",GSMNo=@GSMNo") +
        (Email == null ? "" : ",Email=@Email") +
        (Role == null ? "" : ",Role=@Role") +
        (AnaBayiKodu == null ? "" : ",AnaBayiKodu=@AnaBayiKodu") +
        (PlasiyerKodu == null ? "" : ",PlasiyerKodu=@PlasiyerKodu") +
        (GrpCode == null ? "" : ",GrpCode=@GrpCode") +
        (CypCode == null ? "" : ",CypCode=@CypCode") +
        (SpeCode1 == null ? "" : ",SpeCode1=@SpeCode1") +
        (SpeCode2 == null ? "" : ",SpeCode2=@SpeCode2") +
        (TCKNO == null ? "" : ",TCKNO=@TCKNO") +
        (CompanyCode == null ? "" : ",CompanyCode=@CompanyCode") +
        (BranchCode == null ? "" : ",BranchCode=@BranchCode") +
        (Title == null ? "" : ",Title=@Title") +
        (DT == null ? "" : ",DT=@DT") +
        (DV == null ? "" : ",DV=@DV") +
        (CK == null ? "" : ",CK=@CK") +
        (P1 == null ? "" : ",P1=@P1") +
        (P2 == null ? "" : ",P2=@P2") +
        (P3 == null ? "" : ",P3=@P3") +
        (P4 == null ? "" : ",P4=@P4") +
        (P5 == null ? "" : ",P5=@P5") +
        (LastLogin == null ? "" : ",LastLogin=@LastLogin") +
        (Cancelled == null ? "" : ",Cancelled=@Cancelled") +
                " WHERE [USR_ID] = " + USR_ID;
                        }
                    }
                    if (CUSR_ID != null) comm.Parameters.AddWithValue("CUSR_ID", CUSR_ID);
                    if (AUSR_ID != null) comm.Parameters.AddWithValue("AUSR_ID", AUSR_ID);
                    if (REF_ID != null) comm.Parameters.AddWithValue("REF_ID", REF_ID);
                    if (Uname != null) comm.Parameters.AddWithValue("Uname", Uname);
                    if (Passw != null) comm.Parameters.AddWithValue("Passw", Passw);
                    if (Name != null) comm.Parameters.AddWithValue("Name", Name);
                    if (Notes != null) comm.Parameters.AddWithValue("Notes", Notes);
                    if (GSMNo != null) comm.Parameters.AddWithValue("GSMNo", GSMNo);
                    if (Email != null) comm.Parameters.AddWithValue("Email", Email);
                    if (Role != null) comm.Parameters.AddWithValue("Role", Role);
                    if (AnaBayiKodu != null) comm.Parameters.AddWithValue("AnaBayiKodu", AnaBayiKodu);
                    if (PlasiyerKodu != null) comm.Parameters.AddWithValue("PlasiyerKodu", PlasiyerKodu);
                    if (GrpCode != null) comm.Parameters.AddWithValue("GrpCode", GrpCode);
                    if (CypCode != null) comm.Parameters.AddWithValue("CypCode", CypCode);
                    if (SpeCode1 != null) comm.Parameters.AddWithValue("SpeCode1", SpeCode1);
                    if (SpeCode2 != null) comm.Parameters.AddWithValue("SpeCode2", SpeCode2);
                    if (TCKNO != null) comm.Parameters.AddWithValue("TCKNO", TCKNO);
                    if (CompanyCode != null) comm.Parameters.AddWithValue("CompanyCode", CompanyCode);
                    if (BranchCode != null) comm.Parameters.AddWithValue("BranchCode", BranchCode);
                    if (Title != null) comm.Parameters.AddWithValue("Title", Title);
                    if (DT != null) comm.Parameters.AddWithValue("DT", DT);
                    if (DV != null) comm.Parameters.AddWithValue("DV", DV);
                    if (CK != null) comm.Parameters.AddWithValue("CK", CK);
                    if (P1 != null) comm.Parameters.AddWithValue("P1", P1);
                    if (P2 != null) comm.Parameters.AddWithValue("P2", P2);
                    if (P3 != null) comm.Parameters.AddWithValue("P3", P3);
                    if (P4 != null) comm.Parameters.AddWithValue("P4", P4);
                    if (P5 != null) comm.Parameters.AddWithValue("P5", P5);
                    if (LastLogin != null) comm.Parameters.AddWithValue("LastLogin", LastLogin);
                    if (Cancelled != null) comm.Parameters.AddWithValue("Cancelled", Cancelled);
                    s = comm.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        { }
        return s;
    }


    public int DAL_Set(Users n, bool Delete)
    {
        int s = 0;
        try
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString))
            {
                using (SqlCommand comm = new SqlCommand("", conn))
                {
                    conn.Open();
                    if (n.USR_ID == null)
                    {
                        comm.CommandText = @"INSERT INTO Users (CDate" +
        (n.CUSR_ID == null ? "" : ",CUSR_ID") +
(n.AUSR_ID == null ? "" : ",AUSR_ID") +
(n.REF_ID == null ? "" : ",REF_ID") +
(n.Uname == null ? "" : ",Uname") +
(n.Passw == null ? "" : ",Passw") +
(n.Name == null ? "" : ",Name") +
(n.Notes == null ? "" : ",Notes") +
(n.GSMNo == null ? "" : ",GSMNo") +
(n.Email == null ? "" : ",Email") +
(n.Role == null ? "" : ",Role") +
(n.AnaBayiKodu == null ? "" : ",AnaBayiKodu") +
(n.PlasiyerKodu == null ? "" : ",PlasiyerKodu") +
(n.GrpCode == null ? "" : ",GrpCode") +
(n.CypCode == null ? "" : ",CypCode") +
(n.SpeCode1 == null ? "" : ",SpeCode1") +
(n.SpeCode2 == null ? "" : ",SpeCode2") +
(n.TCKNO == null ? "" : ",TCKNO") +
(n.CompanyCode == null ? "" : ",CompanyCode") +
(n.BranchCode == null ? "" : ",BranchCode") +
(n.Title == null ? "" : ",Title") +
(n.DT == null ? "" : ",DT") +
(n.DV == null ? "" : ",DV") +
(n.CK == null ? "" : ",CK") +
(n.P1 == null ? "" : ",P1") +
(n.P2 == null ? "" : ",P2") +
(n.P3 == null ? "" : ",P3") +
(n.P4 == null ? "" : ",P4") +
(n.P5 == null ? "" : ",P5") +
(n.LastLogin == null ? "" : ",LastLogin") +
(n.Cancelled == null ? "" : ",Cancelled") +
        @")
		 VALUES
		(getdate()" +
        (n.CUSR_ID == null ? "" : ",@CUSR_ID") +
(n.AUSR_ID == null ? "" : ",@AUSR_ID") +
(n.REF_ID == null ? "" : ",@REF_ID") +
(n.Uname == null ? "" : ",@Uname") +
(n.Passw == null ? "" : ",@Passw") +
(n.Name == null ? "" : ",@Name") +
(n.Notes == null ? "" : ",@Notes") +
(n.GSMNo == null ? "" : ",@GSMNo") +
(n.Email == null ? "" : ",@Email") +
(n.Role == null ? "" : ",@Role") +
(n.AnaBayiKodu == null ? "" : ",@AnaBayiKodu") +
(n.PlasiyerKodu == null ? "" : ",@PlasiyerKodu") +
(n.GrpCode == null ? "" : ",@GrpCode") +
(n.CypCode == null ? "" : ",@CypCode") +
(n.SpeCode1 == null ? "" : ",@SpeCode1") +
(n.SpeCode2 == null ? "" : ",@SpeCode2") +
(n.TCKNO == null ? "" : ",@TCKNO") +
(n.CompanyCode == null ? "" : ",@CompanyCode") +
(n.BranchCode == null ? "" : ",@BranchCode") +
(n.Title == null ? "" : ",@Title") +
(n.DT == null ? "" : ",@DT") +
(n.DV == null ? "" : ",@DV") +
(n.CK == null ? "" : ",@CK") +
(n.P1 == null ? "" : ",@P1") +
(n.P2 == null ? "" : ",@P2") +
(n.P3 == null ? "" : ",@P3") +
(n.P4 == null ? "" : ",@P4") +
(n.P5 == null ? "" : ",@P5") +
(n.LastLogin == null ? "" : ",@LastLogin") +
(n.Cancelled == null ? "" : ",@Cancelled") +
        ")";
                    }
                    else
                    {
                        if (Delete)
                        {
                            comm.CommandText = @"UPDATE  Users SET DDate=getdate(),Cancelled = 1 Where USR_ID = " + n.USR_ID;
                        }
                        else
                        {
                            comm.CommandText = @"UPDATE  Users SET UDate=getdate() " +
                                    (n.CUSR_ID == null ? "" : ",CUSR_ID=@CUSR_ID") +
        (n.AUSR_ID == null ? "" : ",AUSR_ID=@AUSR_ID") +
        (n.REF_ID == null ? "" : ",REF_ID=@REF_ID") +
        (n.Uname == null ? "" : ",Uname=@Uname") +
        (n.Passw == null ? "" : ",Passw=@Passw") +
        (n.Name == null ? "" : ",Name=@Name") +
        (n.Notes == null ? "" : ",Notes=@Notes") +
        (n.GSMNo == null ? "" : ",GSMNo=@GSMNo") +
        (n.Email == null ? "" : ",Email=@Email") +
        (n.Role == null ? "" : ",Role=@Role") +
        (n.AnaBayiKodu == null ? "" : ",AnaBayiKodu=@AnaBayiKodu") +
        (n.PlasiyerKodu == null ? "" : ",PlasiyerKodu=@PlasiyerKodu") +
        (n.GrpCode == null ? "" : ",GrpCode=@GrpCode") +
        (n.CypCode == null ? "" : ",CypCode=@CypCode") +
        (n.SpeCode1 == null ? "" : ",SpeCode1=@SpeCode1") +
        (n.SpeCode2 == null ? "" : ",SpeCode2=@SpeCode2") +
        (n.TCKNO == null ? "" : ",TCKNO=@TCKNO") +
        (n.CompanyCode == null ? "" : ",CompanyCode=@CompanyCode") +
        (n.BranchCode == null ? "" : ",BranchCode=@BranchCode") +
        (n.Title == null ? "" : ",Title=@Title") +
        (n.DT == null ? "" : ",DT=@DT") +
        (n.DV == null ? "" : ",DV=@DV") +
        (n.CK == null ? "" : ",CK=@CK") +
        (n.P1 == null ? "" : ",P1=@P1") +
        (n.P2 == null ? "" : ",P2=@P2") +
        (n.P3 == null ? "" : ",P3=@P3") +
        (n.P4 == null ? "" : ",P4=@P4") +
        (n.P5 == null ? "" : ",P5=@P5") +
        (n.LastLogin == null ? "" : ",LastLogin=@LastLogin") +
        (n.Cancelled == null ? "" : ",Cancelled=@Cancelled") +
                " WHERE [USR_ID] = " + n.USR_ID;
                        }
                    }
                    if (n.CUSR_ID != null) comm.Parameters.AddWithValue("CUSR_ID", n.CUSR_ID);
                    if (n.AUSR_ID != null) comm.Parameters.AddWithValue("AUSR_ID", n.AUSR_ID);
                    if (n.REF_ID != null) comm.Parameters.AddWithValue("REF_ID", n.REF_ID);
                    if (n.Uname != null) comm.Parameters.AddWithValue("Uname", n.Uname);
                    if (n.Passw != null) comm.Parameters.AddWithValue("Passw", n.Passw);
                    if (n.Name != null) comm.Parameters.AddWithValue("Name", n.Name);
                    if (n.Notes != null) comm.Parameters.AddWithValue("Notes", n.Notes);
                    if (n.GSMNo != null) comm.Parameters.AddWithValue("GSMNo", n.GSMNo);
                    if (n.Email != null) comm.Parameters.AddWithValue("Email", n.Email);
                    if (n.Role != null) comm.Parameters.AddWithValue("Role", n.Role);
                    if (n.AnaBayiKodu != null) comm.Parameters.AddWithValue("AnaBayiKodu", n.AnaBayiKodu);
                    if (n.PlasiyerKodu != null) comm.Parameters.AddWithValue("PlasiyerKodu", n.PlasiyerKodu);
                    if (n.GrpCode != null) comm.Parameters.AddWithValue("GrpCode", n.GrpCode);
                    if (n.CypCode != null) comm.Parameters.AddWithValue("CypCode", n.CypCode);
                    if (n.SpeCode1 != null) comm.Parameters.AddWithValue("SpeCode1", n.SpeCode1);
                    if (n.SpeCode2 != null) comm.Parameters.AddWithValue("SpeCode2", n.SpeCode2);
                    if (n.TCKNO != null) comm.Parameters.AddWithValue("TCKNO", n.TCKNO);
                    if (n.CompanyCode != null) comm.Parameters.AddWithValue("CompanyCode", n.CompanyCode);
                    if (n.BranchCode != null) comm.Parameters.AddWithValue("BranchCode", n.BranchCode);
                    if (n.Title != null) comm.Parameters.AddWithValue("Title", n.Title);
                    if (n.DT != null) comm.Parameters.AddWithValue("DT", n.DT);
                    if (n.DV != null) comm.Parameters.AddWithValue("DV", n.DV);
                    if (n.CK != null) comm.Parameters.AddWithValue("CK", n.CK);
                    if (n.P1 != null) comm.Parameters.AddWithValue("P1", n.P1);
                    if (n.P2 != null) comm.Parameters.AddWithValue("P2", n.P2);
                    if (n.P3 != null) comm.Parameters.AddWithValue("P3", n.P3);
                    if (n.P4 != null) comm.Parameters.AddWithValue("P4", n.P4);
                    if (n.P5 != null) comm.Parameters.AddWithValue("P5", n.P5);
                    if (n.LastLogin != null) comm.Parameters.AddWithValue("LastLogin", n.LastLogin);
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

UsersList:[],
UsersModeli:{
USR_ID:0, CDate:'', UDate:'', DDate:'', CUSR_ID:0, AUSR_ID:0, REF_ID:0, Uname:'', Passw:'', Name:'', Notes:'', GSMNo:'', Email:'', Role:'', AnaBayiKodu:'', PlasiyerKodu:'', GrpCode:'', CypCode:'', SpeCode1:'', SpeCode2:'', TCKNO:'', CompanyCode:'', BranchCode:'', Title:'', DT:'', DV:'', CK:'', P1:'', P2:'', P3:'', P4:'', P5:'', LastLogin:'', Cancelled:0, },

*/
}

