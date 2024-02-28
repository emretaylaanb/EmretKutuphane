using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Collections.Generic;
using System.ComponentModel;

public class Devices : IDisposable 
{

	public void Dispose() { }
		
		
		public static DateTime dtnull=Convert.ToDateTime(ConfigurationManager.AppSettings["dtnull"]);
		public int? DVC_ID { get; set; }
		public DateTime? CDate { get; set; }
		public DateTime? UDate { get; set; }
		public DateTime? DDate { get; set; }
		public string Name { get; set; }
		public string IP { get; set; }
		public string Port { get; set; }
		public string Note { get; set; }
		public string P1 { get; set; }
		public string P2 { get; set; }
		public string P3 { get; set; }
		public string P4 { get; set; }
		public string P5 { get; set; }
		public int? Cancelled { get; set; }

		public static DataTable Hepsi()
		{
			return new DAL.DBOps().sc("SELECT * FROM Devices");
			}

		public static DataTable Ver(string wheresi, params object[] Pler)
		{
			return new DAL.DBOps().sc("SELECT * FROM Devices " + (string.IsNullOrEmpty(wheresi)?"":" WHERE "+wheresi),Pler);
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
		//		return new DAL.DBOps().scp("Select "+sel+" FROM Devices "+whe,parameters);
				
		//		}

		public static Devices Ver(string wheresi)
		{
			DataTable dt = new DataTable();
			Devices n=new Devices();
			try{
				dt = new DAL.DBOps().sc("SELECT * FROM Devices " + (string.IsNullOrEmpty(wheresi)?"":" WHERE "+wheresi));
				if(dt.Rows.Count>0)
					{
					if(dt.Rows[0]["DVC_ID"] != DBNull.Value) n.DVC_ID=(int)dt.Rows[0]["DVC_ID"];
					if(dt.Rows[0]["CDate"] != DBNull.Value) n.CDate=(DateTime)dt.Rows[0]["CDate"];
					if(dt.Rows[0]["UDate"] != DBNull.Value) n.UDate=(DateTime)dt.Rows[0]["UDate"];
					if(dt.Rows[0]["DDate"] != DBNull.Value) n.DDate=(DateTime)dt.Rows[0]["DDate"];
					if(dt.Rows[0]["Name"] != DBNull.Value) n.Name=dt.Rows[0]["Name"].ToString();
					if(dt.Rows[0]["IP"] != DBNull.Value) n.IP=dt.Rows[0]["IP"].ToString();
					if(dt.Rows[0]["Port"] != DBNull.Value) n.Port=dt.Rows[0]["Port"].ToString();
					if(dt.Rows[0]["Note"] != DBNull.Value) n.Note=dt.Rows[0]["Note"].ToString();
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


		public static Devices[] VerArr(string wheresi)
		{
			DataTable dt = new DataTable();
			Devices[] n=new Devices[0];
			try{
				dt = new DAL.DBOps().sc("SELECT * FROM Devices " +(string.IsNullOrEmpty(wheresi)?"":" WHERE "+wheresi));
				if(dt.Rows.Count>0)
					{
					n = new Devices[dt.Rows.Count];
					for (int i = 0; i < dt.Rows.Count; i++)
					{
						n[i] = new Devices();
						if(dt.Rows[i]["DVC_ID"] != DBNull.Value) n[i].DVC_ID=(int)dt.Rows[i]["DVC_ID"];
						if(dt.Rows[i]["CDate"] != DBNull.Value) n[i].CDate=(DateTime)dt.Rows[i]["CDate"];
						if(dt.Rows[i]["UDate"] != DBNull.Value) n[i].UDate=(DateTime)dt.Rows[i]["UDate"];
						if(dt.Rows[i]["DDate"] != DBNull.Value) n[i].DDate=(DateTime)dt.Rows[i]["DDate"];
						if(dt.Rows[i]["Name"] != DBNull.Value) n[i].Name=dt.Rows[i]["Name"].ToString();
						if(dt.Rows[i]["IP"] != DBNull.Value) n[i].IP=dt.Rows[i]["IP"].ToString();
						if(dt.Rows[i]["Port"] != DBNull.Value) n[i].Port=dt.Rows[i]["Port"].ToString();
						if(dt.Rows[i]["Note"] != DBNull.Value) n[i].Note=dt.Rows[i]["Note"].ToString();
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
				//new Ortak().Logla("Devices[] VerArr", wheresi, ex.Message);
				return n;}
}


		public static List<Devices> VerList(string wheresi)
		{
			List<Devices> lst = new List<Devices>();
			using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString))
{
			using (SqlCommand comm = new SqlCommand("SELECT * FROM Devices " + (string.IsNullOrEmpty(wheresi)?"":" WHERE "+wheresi) , conn))
{
			try{
				conn.Open();
				SqlDataReader r = comm.ExecuteReader();
				while (r.Read())
					{
					Devices n = new Devices();
						if( r["DVC_ID"] != DBNull.Value) n.DVC_ID=(int)r["DVC_ID"];
						if( r["CDate"] != DBNull.Value) n.CDate=(DateTime)r["CDate"];
						if( r["UDate"] != DBNull.Value) n.UDate=(DateTime)r["UDate"];
						if( r["DDate"] != DBNull.Value) n.DDate=(DateTime)r["DDate"];
						if( r["Name"] != DBNull.Value) n.Name=r["Name"].ToString();
						if( r["IP"] != DBNull.Value) n.IP=r["IP"].ToString();
						if( r["Port"] != DBNull.Value) n.Port=r["Port"].ToString();
						if( r["Note"] != DBNull.Value) n.Note=r["Note"].ToString();
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
				//new Ortak().Logla("Devices[] VerList", wheresi, ex.Message);
				return lst;
}
}

			}
		}



		public static List<Devices> VerList(string wheresi, params object[] Pler)
		{
			List<Devices> lst = new List<Devices>();
			using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString))
{
			using (SqlCommand comm = new SqlCommand("SELECT * FROM Devices " + (string.IsNullOrEmpty(wheresi)?"":" WHERE "+wheresi) , conn))
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
					Devices n = new Devices();
						if( r["DVC_ID"] != DBNull.Value) n.DVC_ID=(int)r["DVC_ID"];
						if( r["CDate"] != DBNull.Value) n.CDate=(DateTime)r["CDate"];
						if( r["UDate"] != DBNull.Value) n.UDate=(DateTime)r["UDate"];
						if( r["DDate"] != DBNull.Value) n.DDate=(DateTime)r["DDate"];
						if( r["Name"] != DBNull.Value) n.Name=r["Name"].ToString();
						if( r["IP"] != DBNull.Value) n.IP=r["IP"].ToString();
						if( r["Port"] != DBNull.Value) n.Port=r["Port"].ToString();
						if( r["Note"] != DBNull.Value) n.Note=r["Note"].ToString();
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
				//new Ortak().Logla("Devices[] VerList", wheresi, ex.Message);
				return lst;
}
}

			}
		}


		public static bool Ekle(Devices n)
		{
		try{
			string c=@"INSERT INTO Devices
			(CDate,UDate,DDate,Name,IP,Port,Note,P1,P2,P3,P4,P5,Cancelled)
			VALUES
			(@CDate,@UDate,@DDate,@Name,@IP,@Port,@Note,@P1,@P2,@P3,@P4,@P5,@Cancelled)";

			SqlParameterCollection parameters = new SqlCommand().Parameters;
			parameters.Add(new SqlParameter("CDate",(n.CDate==dtnull?SqlDateTime.Null.Value:n.CDate)));
			parameters.Add(new SqlParameter("UDate",(n.UDate==dtnull?SqlDateTime.Null.Value:n.UDate)));
			parameters.Add(new SqlParameter("DDate",(n.DDate==dtnull?SqlDateTime.Null.Value:n.DDate)));
			parameters.Add(new SqlParameter("Name",(n.Name==null?"":n.Name)));
			parameters.Add(new SqlParameter("IP",(n.IP==null?"":n.IP)));
			parameters.Add(new SqlParameter("Port",(n.Port==null?"":n.Port)));
			parameters.Add(new SqlParameter("Note",(n.Note==null?"":n.Note)));
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
		string c=@"DELETE FROM Devices WHERE ";
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
		
		public static bool Guncelle(Devices n,string[] whalan,string[] whparam)
		{
		try{
		string c=@"UPDATE Devices SET 
		(CDate=@CDate,UDate=@UDate,DDate=@DDate,Name=@Name,IP=@IP,Port=@Port,Note=@Noe,P1=@P1,P2=@P2,P3=@P3,P4=@P4,P5=@P5,Cancelled=@Cancelled,)
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
			parameters.Add(new SqlParameter("Name",n.Name));
			parameters.Add(new SqlParameter("IP",n.IP));
			parameters.Add(new SqlParameter("Port",n.Port));
			parameters.Add(new SqlParameter("Note",n.Note));
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
		
		public static bool Guncelle(Devices n,string wheresi)
		{
		try{
		string c=@"UPDATE Devices SET  ";
		string c2="";
		SqlParameterCollection parameters = new SqlCommand().Parameters;
		
			if ( n.CDate != null ) { c2 += "CDate = @CDate,";  parameters.Add(new SqlParameter("CDate",n.CDate));}
			if ( n.UDate != null ) { c2 += "UDate = @UDate,";  parameters.Add(new SqlParameter("UDate",n.UDate));}
			if ( n.DDate != null ) { c2 += "DDate = @DDate,";  parameters.Add(new SqlParameter("DDate",n.DDate));}
			if ( n.Name != null ) { c2 += "Name = @Name,";  parameters.Add(new SqlParameter("Name",n.Name));}
			if ( n.IP != null ) { c2 += "IP = @IP,";  parameters.Add(new SqlParameter("IP",n.IP));}
			if ( n.Port != null ) { c2 += "Port = @Port,";  parameters.Add(new SqlParameter("Port",n.Port));}
			if ( n.Note != null ) { c2 += "Note = @Note,";  parameters.Add(new SqlParameter("Note",n.Note));}
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
		
		public int DAL_Set_Devices(int? DVC_ID,string Name,string IP,string Port,string Note,string P1,string P2,string P3,string P4,string P5,int? Cancelled,bool Delete)
		{ 
int s=0;
try{
 using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString))
            {
                using (SqlCommand comm = new SqlCommand("", conn))
                {
                    conn.Open();
                    if (DVC_ID == null)
                    {
                        comm.CommandText = @"INSERT INTO Devices (CDate" +		
		(Name == null ? "" : ",Name") +
(IP == null ? "" : ",IP") +
(Port == null ? "" : ",Port") +
(Note == null ? "" : ",Note") +
(P1 == null ? "" : ",P1") +
(P2 == null ? "" : ",P2") +
(P3 == null ? "" : ",P3") +
(P4 == null ? "" : ",P4") +
(P5 == null ? "" : ",P5") +
(Cancelled == null ? "" : ",Cancelled") +
		@")
		 VALUES
		(getdate()" +
		(Name == null ? "" : ",@Name") +
(IP == null ? "" : ",@IP") +
(Port == null ? "" : ",@Port") +
(Note == null ? "" : ",@Note") +
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
                    comm.CommandText = @"UPDATE  Devices SET DDate=getdate(),Cancelled = 1 Where DVC_ID = " + DVC_ID;
                    }
                    else
                    { 
                    comm.CommandText = @"UPDATE  Devices SET UDate=getdate() "+
                    		(Name == null ? "" : ",Name=@Name") +
(IP == null ? "" : ",IP=@IP") +
(Port == null ? "" : ",Port=@Port") +
(Note == null ? "" : ",Note=@Note") +
(P1 == null ? "" : ",P1=@P1") +
(P2 == null ? "" : ",P2=@P2") +
(P3 == null ? "" : ",P3=@P3") +
(P4 == null ? "" : ",P4=@P4") +
(P5 == null ? "" : ",P5=@P5") +
(Cancelled == null ? "" : ",Cancelled=@Cancelled") +
		" WHERE [DVC_ID] = " + DVC_ID;		
}
}
		if (Name != null) comm.Parameters.AddWithValue("Name", Name); 
if (IP != null) comm.Parameters.AddWithValue("IP", IP); 
if (Port != null) comm.Parameters.AddWithValue("Port", Port); 
if (Note != null) comm.Parameters.AddWithValue("Note", Note); 
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
        		

public int DAL_Set(Devices n,bool Delete)
		{ 
            int s=0;
            try{
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString))
            {
                using (SqlCommand comm = new SqlCommand("", conn))
                {
                    conn.Open();
                    if (n.DVC_ID == null)
                    {
                        comm.CommandText = @"INSERT INTO Devices (CDate" +		
		(n.Name == null ? "" : ",Name") +
(n.IP == null ? "" : ",IP") +
(n.Port == null ? "" : ",Port") +
(n.Note == null ? "" : ",Note") +
(n.P1 == null ? "" : ",P1") +
(n.P2 == null ? "" : ",P2") +
(n.P3 == null ? "" : ",P3") +
(n.P4 == null ? "" : ",P4") +
(n.P5 == null ? "" : ",P5") +
(n.Cancelled == null ? "" : ",Cancelled") +
		@")
		 VALUES
		(getdate()" +
		(n.Name == null ? "" : ",@Name") +
(n.IP == null ? "" : ",@IP") +
(n.Port == null ? "" : ",@Port") +
(n.Note == null ? "" : ",@Note") +
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
                    comm.CommandText = @"UPDATE  Devices SET DDate=getdate(),Cancelled = 1 Where DVC_ID = " + n.DVC_ID;
                    }
                    else
                    { 
                    comm.CommandText = @"UPDATE  Devices SET UDate=getdate() "+
                    		(n.Name == null ? "" : ",Name=@Name") +
(n.IP == null ? "" : ",IP=@IP") +
(n.Port == null ? "" : ",Port=@Port") +
(n.Note == null ? "" : ",Note=@Note") +
(n.P1 == null ? "" : ",P1=@P1") +
(n.P2 == null ? "" : ",P2=@P2") +
(n.P3 == null ? "" : ",P3=@P3") +
(n.P4 == null ? "" : ",P4=@P4") +
(n.P5 == null ? "" : ",P5=@P5") +
(n.Cancelled == null ? "" : ",Cancelled=@Cancelled") +
		" WHERE [DVC_ID] = " + n.DVC_ID;		
}
}
		if (n.Name != null) comm.Parameters.AddWithValue("Name", n.Name); 
if (n.IP != null) comm.Parameters.AddWithValue("IP", n.IP); 
if (n.Port != null) comm.Parameters.AddWithValue("Port", n.Port); 
if (n.Note != null) comm.Parameters.AddWithValue("Note", n.Note); 
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

DevicesList:[],
DevicesModeli:{
DVC_ID:0, CDate:'', UDate:'', DDate:'', Name:'', IP:'', Port:'', Note:'', P1:'', P2:'', P3:'', P4:'', P5:'', Cancelled:0, },

*/		}

