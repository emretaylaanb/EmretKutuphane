using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Collections.Generic;
using System.ComponentModel;

public class IOs : IDisposable 
{

	public void Dispose() { }
		
		
		public static DateTime dtnull=Convert.ToDateTime(ConfigurationManager.AppSettings["dtnull"]);
		public int? IOS_ID { get; set; }
		public DateTime? CDate { get; set; }
		public DateTime? UDate { get; set; }
		public DateTime? DDate { get; set; }
		public int? USR_ID { get; set; }
		public int? IDVC_ID { get; set; }
		public DateTime? IDate { get; set; }
		public int? ODVC_ID { get; set; }
		public DateTime? ODate { get; set; }
		public int? IsLate { get; set; }
		public int? IsOvertime { get; set; }
		public string P1 { get; set; }
		public string P2 { get; set; }
		public string P3 { get; set; }
		public string P4 { get; set; }
		public string P5 { get; set; }
		public int? Cancelled { get; set; }

		public static DataTable Hepsi()
		{
			return new DAL.DBOps().sc("SELECT * FROM IOs");
			}

		public static DataTable Ver(string wheresi, params object[] Pler)
		{
			return new DAL.DBOps().sc("SELECT * FROM IOs " + (string.IsNullOrEmpty(wheresi)?"":" WHERE "+wheresi),Pler);
			}

		//public static DataTable Ver(string[] istenilen,string[] alan,string[] param)
		//{
		//	DataTable dt = new DataTable();
		//		string sel=" *  ",whe=" WHERE ";
		//		if(istenilen.Length>0)
		//		{sel="";
		//		{
		//		for(int i=0;i<=istenilen.Length-1;i++){
		//		sel+=" "+istenilen[i]+",";
		//		}}}
		//		sel=sel.Remove(sel.Length-1, 1);
				
		//		for(int i=0;i<=alan.Length-1;i++){
		//			whe+=" "+alan[i]+"=@"+alan[i]+" AND ";
		//		}
		//		whe=whe.Remove(whe.Length-4, 4);
				
				
		//		SqlParameterCollection parameters = new SqlCommand().Parameters;
		//		for(int i=0;i<=alan.Length-1;i++){
		//			parameters.Add(new SqlParameter(alan[i],param[i]));
		//		}
		//		return new DAL.DBOps().scp("Select "+sel+" FROM IOs "+whe,parameters);
				
		//		}

		public static IOs Ver(string wheresi)
		{
			DataTable dt = new DataTable();
			IOs n=new IOs();
			try{
				dt = new DAL.DBOps().sc("SELECT * FROM IOs " + (string.IsNullOrEmpty(wheresi)?"":" WHERE "+wheresi));
				if(dt.Rows.Count>0)
					{
					if(dt.Rows[0]["IOS_ID"] != DBNull.Value) n.IOS_ID=(int)dt.Rows[0]["IOS_ID"];
					if(dt.Rows[0]["CDate"] != DBNull.Value) n.CDate=(DateTime)dt.Rows[0]["CDate"];
					if(dt.Rows[0]["UDate"] != DBNull.Value) n.UDate=(DateTime)dt.Rows[0]["UDate"];
					if(dt.Rows[0]["DDate"] != DBNull.Value) n.DDate=(DateTime)dt.Rows[0]["DDate"];
					if(dt.Rows[0]["USR_ID"] != DBNull.Value) n.USR_ID=(int)dt.Rows[0]["USR_ID"];
					if(dt.Rows[0]["IDVC_ID"] != DBNull.Value) n.IDVC_ID=(int)dt.Rows[0]["IDVC_ID"];
					if(dt.Rows[0]["IDate"] != DBNull.Value) n.IDate=(DateTime)dt.Rows[0]["IDate"];
					if(dt.Rows[0]["ODVC_ID"] != DBNull.Value) n.ODVC_ID=(int)dt.Rows[0]["ODVC_ID"];
					if(dt.Rows[0]["ODate"] != DBNull.Value) n.ODate=(DateTime)dt.Rows[0]["ODate"];
					if(dt.Rows[0]["IsLate"] != DBNull.Value) n.IsLate=(int)dt.Rows[0]["IsLate"];
					if(dt.Rows[0]["IsOvertime"] != DBNull.Value) n.IsOvertime=(int)dt.Rows[0]["IsOvertime"];
					if(dt.Rows[0]["P1"] != DBNull.Value) n.P1=dt.Rows[0]["P1"].ToString();
					if(dt.Rows[0]["P2"] != DBNull.Value) n.P2=dt.Rows[0]["P2"].ToString();
					if(dt.Rows[0]["P3"] != DBNull.Value) n.P3=dt.Rows[0]["P3"].ToString();
					if(dt.Rows[0]["P4"] != DBNull.Value) n.P4=dt.Rows[0]["P4"].ToString();
					if(dt.Rows[0]["P5"] != DBNull.Value) n.P5=dt.Rows[0]["P5"].ToString();
					if(dt.Rows[0]["Cancelled"] != DBNull.Value) n.Cancelled=(int)dt.Rows[0]["Cancelled"];
					
					}
				return n;
			}catch(Exception){
				return n;}
}


		public static IOs[] VerArr(string wheresi)
		{
			DataTable dt = new DataTable();
			IOs[] n=new IOs[0];
			try{
				dt = new DAL.DBOps().sc("SELECT * FROM IOs " +(string.IsNullOrEmpty(wheresi)?"":" WHERE "+wheresi));
				if(dt.Rows.Count>0)
					{
					n = new IOs[dt.Rows.Count];
					for (int i = 0; i < dt.Rows.Count; i++)
					{
						n[i] = new IOs();
						if(dt.Rows[i]["IOS_ID"] != DBNull.Value) n[i].IOS_ID=(int)dt.Rows[i]["IOS_ID"];
						if(dt.Rows[i]["CDate"] != DBNull.Value) n[i].CDate=(DateTime)dt.Rows[i]["CDate"];
						if(dt.Rows[i]["UDate"] != DBNull.Value) n[i].UDate=(DateTime)dt.Rows[i]["UDate"];
						if(dt.Rows[i]["DDate"] != DBNull.Value) n[i].DDate=(DateTime)dt.Rows[i]["DDate"];
						if(dt.Rows[i]["USR_ID"] != DBNull.Value) n[i].USR_ID=(int)dt.Rows[i]["USR_ID"];
						if(dt.Rows[i]["IDVC_ID"] != DBNull.Value) n[i].IDVC_ID=(int)dt.Rows[i]["IDVC_ID"];
						if(dt.Rows[i]["IDate"] != DBNull.Value) n[i].IDate=(DateTime)dt.Rows[i]["IDate"];
						if(dt.Rows[i]["ODVC_ID"] != DBNull.Value) n[i].ODVC_ID=(int)dt.Rows[i]["ODVC_ID"];
						if(dt.Rows[i]["ODate"] != DBNull.Value) n[i].ODate=(DateTime)dt.Rows[i]["ODate"];
						if(dt.Rows[i]["IsLate"] != DBNull.Value) n[i].IsLate=(int)dt.Rows[i]["IsLate"];
						if(dt.Rows[i]["IsOvertime"] != DBNull.Value) n[i].IsOvertime=(int)dt.Rows[i]["IsOvertime"];
						if(dt.Rows[i]["P1"] != DBNull.Value) n[i].P1=dt.Rows[i]["P1"].ToString();
						if(dt.Rows[i]["P2"] != DBNull.Value) n[i].P2=dt.Rows[i]["P2"].ToString();
						if(dt.Rows[i]["P3"] != DBNull.Value) n[i].P3=dt.Rows[i]["P3"].ToString();
						if(dt.Rows[i]["P4"] != DBNull.Value) n[i].P4=dt.Rows[i]["P4"].ToString();
						if(dt.Rows[i]["P5"] != DBNull.Value) n[i].P5=dt.Rows[i]["P5"].ToString();
						if(dt.Rows[i]["Cancelled"] != DBNull.Value) n[i].Cancelled=(int)dt.Rows[i]["Cancelled"];
					
					}
					}
				return n;
			}catch(Exception ex){
				//new Ortak().Logla("IOs[] VerArr", wheresi, ex.Message);
				return n;}
}


		public static List<IOs> VerList(string wheresi)
		{
			List<IOs> lst = new List<IOs>();
			using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString))
{
			using (SqlCommand comm = new SqlCommand("SELECT * FROM IOs " + (string.IsNullOrEmpty(wheresi)?"":" WHERE "+wheresi) , conn))
{
			try{
				conn.Open();
				SqlDataReader r = comm.ExecuteReader();
				while (r.Read())
					{
					IOs n = new IOs();
						if( r["IOS_ID"] != DBNull.Value) n.IOS_ID=(int)r["IOS_ID"];
						if( r["CDate"] != DBNull.Value) n.CDate=(DateTime)r["CDate"];
						if( r["UDate"] != DBNull.Value) n.UDate=(DateTime)r["UDate"];
						if( r["DDate"] != DBNull.Value) n.DDate=(DateTime)r["DDate"];
						if( r["USR_ID"] != DBNull.Value) n.USR_ID=(int)r["USR_ID"];
						if( r["IDVC_ID"] != DBNull.Value) n.IDVC_ID=(int)r["IDVC_ID"];
						if( r["IDate"] != DBNull.Value) n.IDate=(DateTime)r["IDate"];
						if( r["ODVC_ID"] != DBNull.Value) n.ODVC_ID=(int)r["ODVC_ID"];
						if( r["ODate"] != DBNull.Value) n.ODate=(DateTime)r["ODate"];
						if( r["IsLate"] != DBNull.Value) n.IsLate=(int)r["IsLate"];
						if( r["IsOvertime"] != DBNull.Value) n.IsOvertime=(int)r["IsOvertime"];
						if( r["P1"] != DBNull.Value) n.P1=r["P1"].ToString();
						if( r["P2"] != DBNull.Value) n.P2=r["P2"].ToString();
						if( r["P3"] != DBNull.Value) n.P3=r["P3"].ToString();
						if( r["P4"] != DBNull.Value) n.P4=r["P4"].ToString();
						if( r["P5"] != DBNull.Value) n.P5=r["P5"].ToString();
						if( r["Cancelled"] != DBNull.Value) n.Cancelled=(int)r["Cancelled"];
					lst.Add(n);
					}
					r.Close();
				return lst;
			}catch(Exception ex){
				//new Ortak().Logla("IOs[] VerList", wheresi, ex.Message);
				return lst;
}
}

			}
		}



		public static List<IOs> VerList(string wheresi, params object[] Pler)
		{
			List<IOs> lst = new List<IOs>();
			using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString))
{
			using (SqlCommand comm = new SqlCommand("SELECT * FROM IOs " + (string.IsNullOrEmpty(wheresi)?"":" WHERE "+wheresi) , conn))
{
			try{
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
					IOs n = new IOs();
						if( r["IOS_ID"] != DBNull.Value) n.IOS_ID=(int)r["IOS_ID"];
						if( r["CDate"] != DBNull.Value) n.CDate=(DateTime)r["CDate"];
						if( r["UDate"] != DBNull.Value) n.UDate=(DateTime)r["UDate"];
						if( r["DDate"] != DBNull.Value) n.DDate=(DateTime)r["DDate"];
						if( r["USR_ID"] != DBNull.Value) n.USR_ID=(int)r["USR_ID"];
						if( r["IDVC_ID"] != DBNull.Value) n.IDVC_ID=(int)r["IDVC_ID"];
						if( r["IDate"] != DBNull.Value) n.IDate=(DateTime)r["IDate"];
						if( r["ODVC_ID"] != DBNull.Value) n.ODVC_ID=(int)r["ODVC_ID"];
						if( r["ODate"] != DBNull.Value) n.ODate=(DateTime)r["ODate"];
						if( r["IsLate"] != DBNull.Value) n.IsLate=(int)r["IsLate"];
						if( r["IsOvertime"] != DBNull.Value) n.IsOvertime=(int)r["IsOvertime"];
						if( r["P1"] != DBNull.Value) n.P1=r["P1"].ToString();
						if( r["P2"] != DBNull.Value) n.P2=r["P2"].ToString();
						if( r["P3"] != DBNull.Value) n.P3=r["P3"].ToString();
						if( r["P4"] != DBNull.Value) n.P4=r["P4"].ToString();
						if( r["P5"] != DBNull.Value) n.P5=r["P5"].ToString();
						if( r["Cancelled"] != DBNull.Value) n.Cancelled=(int)r["Cancelled"];
					lst.Add(n);
					}
					r.Close();
				return lst;
			}catch(Exception ex){
				//new Ortak().Logla("IOs[] VerList", wheresi, ex.Message);
				return lst;
}
}

			}
		}


		public static bool Ekle(IOs n)
		{
		try{
			string c=@"INSERT INTO IOs
			(CDate,UDate,DDate,USR_ID,IDVC_ID,IDate,ODVC_ID,ODate,IsLate,IsOvertime,P1,P2,P3,P4,P5,Cancelled)
			VALUES
			(@CDate,@UDate,@DDate,@USR_ID,@IDVC_ID,@IDate,@ODVC_ID,@ODate,@IsLate,@IsOvertime,@P1,@P2,@P3,@P4,@P5,@Cancelled)";

			SqlParameterCollection parameters = new SqlCommand().Parameters;
			parameters.Add(new SqlParameter("CDate",(n.CDate==dtnull?SqlDateTime.Null.Value:n.CDate)));
			parameters.Add(new SqlParameter("UDate",(n.UDate==dtnull?SqlDateTime.Null.Value:n.UDate)));
			parameters.Add(new SqlParameter("DDate",(n.DDate==dtnull?SqlDateTime.Null.Value:n.DDate)));
			parameters.Add(new SqlParameter("USR_ID",(n.USR_ID==null?0:n.USR_ID)));
			parameters.Add(new SqlParameter("IDVC_ID",(n.IDVC_ID==null?0:n.IDVC_ID)));
			parameters.Add(new SqlParameter("IDate",(n.IDate==dtnull?SqlDateTime.Null.Value:n.IDate)));
			parameters.Add(new SqlParameter("ODVC_ID",(n.ODVC_ID==null?0:n.ODVC_ID)));
			parameters.Add(new SqlParameter("ODate",(n.ODate==dtnull?SqlDateTime.Null.Value:n.ODate)));
			parameters.Add(new SqlParameter("IsLate",(n.IsLate==null?0:n.IsLate)));
			parameters.Add(new SqlParameter("IsOvertime",(n.IsOvertime==null?0:n.IsOvertime)));
			parameters.Add(new SqlParameter("P1",(n.P1==null?"":n.P1)));
			parameters.Add(new SqlParameter("P2",(n.P2==null?"":n.P2)));
			parameters.Add(new SqlParameter("P3",(n.P3==null?"":n.P3)));
			parameters.Add(new SqlParameter("P4",(n.P4==null?"":n.P4)));
			parameters.Add(new SqlParameter("P5",(n.P5==null?"":n.P5)));
			parameters.Add(new SqlParameter("Cancelled",(n.Cancelled==null?0:n.Cancelled)));
			new DAL.DBOps().scnp(c,parameters);
			return true;
		}catch(Exception)
		{
			return false;}
		}
		public static bool Sil(string[] alan,string[] param)
		{
		try{
		string c=@"DELETE FROM IOs WHERE ";
		string whe="";
		for(int i=0;i<=alan.Length-1;i++){
		whe+=" "+alan[i]+"=@"+alan[i]+",";
		}
		whe=whe.Remove(whe.Length-1, 1);
		
		c+=whe;
		 SqlParameterCollection parameters = new SqlCommand().Parameters;
		for(int i=0;i<=alan.Length-1;i++){
		parameters.AddWithValue(alan[i],param[i]);
		}
		
		new DAL.DBOps().scnp(c,parameters);
		return true;
		}catch(Exception)
		{
		return false;}
		}
		
		public static bool Guncelle(IOs n,string[] whalan,string[] whparam)
		{
		try{
		string c=@"UPDATE IOs SET 
		(CDate=@CDate,UDate=@UDate,DDate=@DDate,USR_ID=@USR_ID,IDVC_ID=@IDVC_ID,IDate=@IDate,ODVC_ID=@ODVC_ID,ODate=@ODate,sLate=@IsLate,IsOvertime=@IsOvertime,P1=@P1,P2=@P2,P3=@P3,P4=@P4,P5=@P5,Cancelled=@Cancelled,)
		WHERE (";
		string whe="";
		for(int i=0;i<=whalan.Length-1;i++){
		whe+=" "+whalan[i]+"=@"+whalan[i]+",";
		}
		whe=whe.Remove(whe.Length-1, 1)+")";
		
		c+=whe;
		SqlParameterCollection parameters = new SqlCommand().Parameters;
			parameters.Add(new SqlParameter("CDate",n.CDate==dtnull?SqlDateTime.Null.Value:n.CDate));
			parameters.Add(new SqlParameter("UDate",n.UDate==dtnull?SqlDateTime.Null.Value:n.UDate));
			parameters.Add(new SqlParameter("DDate",n.DDate==dtnull?SqlDateTime.Null.Value:n.DDate));
			parameters.Add(new SqlParameter("USR_ID",n.USR_ID));
			parameters.Add(new SqlParameter("IDVC_ID",n.IDVC_ID));
			parameters.Add(new SqlParameter("IDate",n.IDate==dtnull?SqlDateTime.Null.Value:n.IDate));
			parameters.Add(new SqlParameter("ODVC_ID",n.ODVC_ID));
			parameters.Add(new SqlParameter("ODate",n.ODate==dtnull?SqlDateTime.Null.Value:n.ODate));
			parameters.Add(new SqlParameter("IsLate",n.IsLate));
			parameters.Add(new SqlParameter("IsOvertime",n.IsOvertime));
			parameters.Add(new SqlParameter("P1",n.P1));
			parameters.Add(new SqlParameter("P2",n.P2));
			parameters.Add(new SqlParameter("P3",n.P3));
			parameters.Add(new SqlParameter("P4",n.P4));
			parameters.Add(new SqlParameter("P5",n.P5));
			parameters.Add(new SqlParameter("Cancelled",n.Cancelled));
		
		
		new DAL.DBOps().scnp(c,parameters);
		return true;
		}catch(Exception)
		{
		return false;}
		}
		
		public static bool Guncelle(IOs n,string wheresi)
		{
		try{
		string c=@"UPDATE IOs SET  ";
		string c2="";
		SqlParameterCollection parameters = new SqlCommand().Parameters;
		
			if ( n.CDate != null ) { c2 += "CDate = @CDate,";  parameters.Add(new SqlParameter("CDate",n.CDate));}
			if ( n.UDate != null ) { c2 += "UDate = @UDate,";  parameters.Add(new SqlParameter("UDate",n.UDate));}
			if ( n.DDate != null ) { c2 += "DDate = @DDate,";  parameters.Add(new SqlParameter("DDate",n.DDate));}
			if ( n.USR_ID != null ) { c2 += "USR_ID = @USR_ID,";  parameters.Add(new SqlParameter("USR_ID",n.USR_ID));}
			if ( n.IDVC_ID != null ) { c2 += "IDVC_ID = @IDVC_ID,";  parameters.Add(new SqlParameter("IDVC_ID",n.IDVC_ID));}
			if ( n.IDate != null ) { c2 += "IDate = @IDate,";  parameters.Add(new SqlParameter("IDate",n.IDate));}
			if ( n.ODVC_ID != null ) { c2 += "ODVC_ID = @ODVC_ID,";  parameters.Add(new SqlParameter("ODVC_ID",n.ODVC_ID));}
			if ( n.ODate != null ) { c2 += "ODate = @ODate,";  parameters.Add(new SqlParameter("ODate",n.ODate));}
			if ( n.IsLate != null ) { c2 += "IsLate = @IsLate,";  parameters.Add(new SqlParameter("IsLate",n.IsLate));}
			if ( n.IsOvertime != null ) { c2 += "IsOvertime = @IsOvertime,";  parameters.Add(new SqlParameter("IsOvertime",n.IsOvertime));}
			if ( n.P1 != null ) { c2 += "P1 = @P1,";  parameters.Add(new SqlParameter("P1",n.P1));}
			if ( n.P2 != null ) { c2 += "P2 = @P2,";  parameters.Add(new SqlParameter("P2",n.P2));}
			if ( n.P3 != null ) { c2 += "P3 = @P3,";  parameters.Add(new SqlParameter("P3",n.P3));}
			if ( n.P4 != null ) { c2 += "P4 = @P4,";  parameters.Add(new SqlParameter("P4",n.P4));}
			if ( n.P5 != null ) { c2 += "P5 = @P5,";  parameters.Add(new SqlParameter("P5",n.P5));}
			if ( n.Cancelled != null ) { c2 += "Cancelled = @Cancelled,";  parameters.Add(new SqlParameter("Cancelled",n.Cancelled));}
		if (c2.EndsWith(",")) c2 = c2.Substring(0, c2.Length - 1);
		c += c2+" WHERE ("+wheresi+")";
		
		new DAL.DBOps().scnp(c,parameters);
		return true;
		}catch(Exception)
		{
		return false;}
		}
		
		public int DAL_Set_IOs(int? IOS_ID,int? USR_ID,int? IDVC_ID,DateTime? IDate,int? ODVC_ID,DateTime? ODate,int? IsLate,int? IsOvertime,string P1,string P2,string P3,string P4,string P5,int? Cancelled,bool Delete)
		{ 
int s=0;
try{
 using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString))
            {
                using (SqlCommand comm = new SqlCommand("", conn))
                {
                    conn.Open();
                    if (IOS_ID == null)
                    {
                        comm.CommandText = @"INSERT INTO IOs (CDate" +		
		(USR_ID == null ? "" : ",USR_ID") +
(IDVC_ID == null ? "" : ",IDVC_ID") +
(IDate == null ? "" : ",IDate") +
(ODVC_ID == null ? "" : ",ODVC_ID") +
(ODate == null ? "" : ",ODate") +
(IsLate == null ? "" : ",IsLate") +
(IsOvertime == null ? "" : ",IsOvertime") +
(P1 == null ? "" : ",P1") +
(P2 == null ? "" : ",P2") +
(P3 == null ? "" : ",P3") +
(P4 == null ? "" : ",P4") +
(P5 == null ? "" : ",P5") +
(Cancelled == null ? "" : ",Cancelled") +
		@")
		 VALUES
		(getdate()" +
		(USR_ID == null ? "" : ",@USR_ID") +
(IDVC_ID == null ? "" : ",@IDVC_ID") +
(IDate == null ? "" : ",@IDate") +
(ODVC_ID == null ? "" : ",@ODVC_ID") +
(ODate == null ? "" : ",@ODate") +
(IsLate == null ? "" : ",@IsLate") +
(IsOvertime == null ? "" : ",@IsOvertime") +
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
                    if(Delete)
                    {
                    comm.CommandText = @"UPDATE  IOs SET DDate=getdate(),Cancelled = 1 Where IOS_ID = " + IOS_ID;
                    }
                    else
                    { 
                    comm.CommandText = @"UPDATE  IOs SET UDate=getdate() "+
                    		(USR_ID == null ? "" : ",USR_ID=@USR_ID") +
(IDVC_ID == null ? "" : ",IDVC_ID=@IDVC_ID") +
(IDate == null ? "" : ",IDate=@IDate") +
(ODVC_ID == null ? "" : ",ODVC_ID=@ODVC_ID") +
(ODate == null ? "" : ",ODate=@ODate") +
(IsLate == null ? "" : ",IsLate=@IsLate") +
(IsOvertime == null ? "" : ",IsOvertime=@IsOvertime") +
(P1 == null ? "" : ",P1=@P1") +
(P2 == null ? "" : ",P2=@P2") +
(P3 == null ? "" : ",P3=@P3") +
(P4 == null ? "" : ",P4=@P4") +
(P5 == null ? "" : ",P5=@P5") +
(Cancelled == null ? "" : ",Cancelled=@Cancelled") +
		" WHERE [IOS_ID] = " + IOS_ID;		
}
}
		if (USR_ID != null) comm.Parameters.AddWithValue("USR_ID", USR_ID); 
if (IDVC_ID != null) comm.Parameters.AddWithValue("IDVC_ID", IDVC_ID); 
if (IDate != null) comm.Parameters.AddWithValue("IDate", IDate); 
if (ODVC_ID != null) comm.Parameters.AddWithValue("ODVC_ID", ODVC_ID); 
if (ODate != null) comm.Parameters.AddWithValue("ODate", ODate); 
if (IsLate != null) comm.Parameters.AddWithValue("IsLate", IsLate); 
if (IsOvertime != null) comm.Parameters.AddWithValue("IsOvertime", IsOvertime); 
if (P1 != null) comm.Parameters.AddWithValue("P1", P1); 
if (P2 != null) comm.Parameters.AddWithValue("P2", P2); 
if (P3 != null) comm.Parameters.AddWithValue("P3", P3); 
if (P4 != null) comm.Parameters.AddWithValue("P4", P4); 
if (P5 != null) comm.Parameters.AddWithValue("P5", P5); 
if (Cancelled != null) comm.Parameters.AddWithValue("Cancelled", Cancelled); 
		s = comm.ExecuteNonQuery();
                            }
                        }
                    }catch(Exception ex)
                    {}
            return s;
        }
        		

public int DAL_Set(IOs n,bool Delete)
		{ 
            int s=0;
            try{
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString))
            {
                using (SqlCommand comm = new SqlCommand("", conn))
                {
                    conn.Open();
                    if (n.IOS_ID == null)
                    {
                        comm.CommandText = @"INSERT INTO IOs (CDate" +		
		(n.USR_ID == null ? "" : ",USR_ID") +
(n.IDVC_ID == null ? "" : ",IDVC_ID") +
(n.IDate == null ? "" : ",IDate") +
(n.ODVC_ID == null ? "" : ",ODVC_ID") +
(n.ODate == null ? "" : ",ODate") +
(n.IsLate == null ? "" : ",IsLate") +
(n.IsOvertime == null ? "" : ",IsOvertime") +
(n.P1 == null ? "" : ",P1") +
(n.P2 == null ? "" : ",P2") +
(n.P3 == null ? "" : ",P3") +
(n.P4 == null ? "" : ",P4") +
(n.P5 == null ? "" : ",P5") +
(n.Cancelled == null ? "" : ",Cancelled") +
		@")
		 VALUES
		(getdate()" +
		(n.USR_ID == null ? "" : ",@USR_ID") +
(n.IDVC_ID == null ? "" : ",@IDVC_ID") +
(n.IDate == null ? "" : ",@IDate") +
(n.ODVC_ID == null ? "" : ",@ODVC_ID") +
(n.ODate == null ? "" : ",@ODate") +
(n.IsLate == null ? "" : ",@IsLate") +
(n.IsOvertime == null ? "" : ",@IsOvertime") +
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
                    if(Delete)
                    {
                    comm.CommandText = @"UPDATE  IOs SET DDate=getdate(),Cancelled = 1 Where IOS_ID = " + n.IOS_ID;
                    }
                    else
                    { 
                    comm.CommandText = @"UPDATE  IOs SET UDate=getdate() "+
                    		(n.USR_ID == null ? "" : ",USR_ID=@USR_ID") +
(n.IDVC_ID == null ? "" : ",IDVC_ID=@IDVC_ID") +
(n.IDate == null ? "" : ",IDate=@IDate") +
(n.ODVC_ID == null ? "" : ",ODVC_ID=@ODVC_ID") +
(n.ODate == null ? "" : ",ODate=@ODate") +
(n.IsLate == null ? "" : ",IsLate=@IsLate") +
(n.IsOvertime == null ? "" : ",IsOvertime=@IsOvertime") +
(n.P1 == null ? "" : ",P1=@P1") +
(n.P2 == null ? "" : ",P2=@P2") +
(n.P3 == null ? "" : ",P3=@P3") +
(n.P4 == null ? "" : ",P4=@P4") +
(n.P5 == null ? "" : ",P5=@P5") +
(n.Cancelled == null ? "" : ",Cancelled=@Cancelled") +
		" WHERE [IOS_ID] = " + n.IOS_ID;		
}
}
		if (n.USR_ID != null) comm.Parameters.AddWithValue("USR_ID", n.USR_ID); 
if (n.IDVC_ID != null) comm.Parameters.AddWithValue("IDVC_ID", n.IDVC_ID); 
if (n.IDate != null) comm.Parameters.AddWithValue("IDate", n.IDate); 
if (n.ODVC_ID != null) comm.Parameters.AddWithValue("ODVC_ID", n.ODVC_ID); 
if (n.ODate != null) comm.Parameters.AddWithValue("ODate", n.ODate); 
if (n.IsLate != null) comm.Parameters.AddWithValue("IsLate", n.IsLate); 
if (n.IsOvertime != null) comm.Parameters.AddWithValue("IsOvertime", n.IsOvertime); 
if (n.P1 != null) comm.Parameters.AddWithValue("P1", n.P1); 
if (n.P2 != null) comm.Parameters.AddWithValue("P2", n.P2); 
if (n.P3 != null) comm.Parameters.AddWithValue("P3", n.P3); 
if (n.P4 != null) comm.Parameters.AddWithValue("P4", n.P4); 
if (n.P5 != null) comm.Parameters.AddWithValue("P5", n.P5); 
if (n.Cancelled != null) comm.Parameters.AddWithValue("Cancelled", n.Cancelled); 
		s = comm.ExecuteNonQuery();
                            }
                        }
                    }catch(Exception ex)
                    {}
            return s;
        }
        /* JSModel

IOsList:[],
IOsModeli:{
IOS_ID:0, CDate:'', UDate:'', DDate:'', USR_ID:0, IDVC_ID:0, IDate:'', ODVC_ID:0, ODate:'', IsLate:0, IsOvertime:0, P1:'', P2:'', P3:'', P4:'', P5:'', Cancelled:0, },

*/		}

