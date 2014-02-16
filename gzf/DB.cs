using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Xml;
using System.Data;

namespace gzf
{
    public class DB
    {
        public static SqlConnection CreatSqlConnection()
        {
            XmlDocument configXml = new XmlDocument();
            configXml.Load("config.xml");
            string conStr = configXml["config"]["DB"]["connectionStr"].InnerText;
            SqlConnection con = new SqlConnection(conStr);          
            return con;
        }

        public static int exec_NonQuery(string cmdStr)
        {
            SqlConnection con = CreatSqlConnection();
            int count = 0;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(cmdStr, con);
                count = cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();  
            }
            return count;
        }

        public static int exec_NonQuery(string cmdStr, Byte[] bytes)
        {
            SqlConnection con = CreatSqlConnection();
            int count = 0;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = cmdStr;
                cmd.Parameters.Add("@Picture", SqlDbType.Image, bytes.Length).Value = bytes;
                count = cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return count;
        }

        public static DataTable select(string cmdStr)
        {
            SqlConnection con = CreatSqlConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(cmdStr, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            return dt;
        }

        public static string selectScalar(string cmdStr)
        {
            SqlConnection con = CreatSqlConnection();
            try
            {
                con.Open();
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            SqlCommand cmd = new SqlCommand(cmdStr, con);
            string res = "";
            if (cmd.ExecuteScalar() != null)
            {
                res = cmd.ExecuteScalar().ToString();
            }
            con.Close();
            return res;
        }

        public static string exec_insertLastID(string cmdStr)
        {
            SqlConnection con = CreatSqlConnection();
            int count = 0;
            string lastid = "";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(cmdStr,con);
                count = cmd.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand("select @@IDENTITY", con);
                lastid = cmd2.ExecuteScalar().ToString();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            con.Close();
            return lastid;
        }

        public static string exec_insertLastID(string cmdStr, Byte[] bytes)
        {
            SqlConnection con = CreatSqlConnection();
            int count = 0;
            string lastid="";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = cmdStr;
                cmd.Parameters.Add("@Picture", SqlDbType.Image, bytes.Length).Value = bytes;
                count = cmd.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand("select @@IDENTITY",con);
                lastid = cmd2.ExecuteScalar().ToString();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            con.Close();
            return lastid;
        }


    }
}
