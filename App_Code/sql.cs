using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using System.Data.SqlClient;
using System.Data;
/// <summary>
/// connectsql 的摘要说明
/// </summary>
public class sql
{
    
	public sql()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}
    

    public DataSet  Altersql(SqlConnection conn,DataSet ds,string sql,SqlDataAdapter sda)
    {
        
        
        try
        {
            
            SqlCommand cmd = new SqlCommand(sql, conn);
            sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            ds = new DataSet();
            sda.Fill(ds);
        }
        catch (Exception ex)
        {
            
            conn.Close();
        }
        return ds;
    }
}