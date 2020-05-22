using System.Data.SqlClient;
using System.Data;
using System;

namespace UCSY_Social
{
    class SessionDAO
    {
        public string connection = new Connection().get_constr();
        public void preset()
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO SESSION (SESSION_NAME, LOGIN_STATUS, SAVE_LOGIN_STATUS, LOGIN_EMAIL) VALUES(@1, @2, @3, @4)", con);
            cmd.Parameters.AddWithValue("@1", "login");
            cmd.Parameters.AddWithValue("@2", 0);
            cmd.Parameters.AddWithValue("@3", 0);
            cmd.Parameters.AddWithValue("@4", "noemail");
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void update(Session s)
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE SESSION SET LOGIN_STATUS=@1, SAVE_LOGIN_STATUS=@2, LOGIN_EMAIL=@3 WHERE SESSION_NAME=@4", con);
            cmd.Parameters.AddWithValue("@1", s.login_status);
            cmd.Parameters.AddWithValue("@2", s.save_login_status);
            cmd.Parameters.AddWithValue("@3", s.login_email);
            cmd.Parameters.AddWithValue("@4", s.session_name);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public Session getSession(string input)
        {
            Session s = null;
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT LOGIN_STATUS, SAVE_LOGIN_STATUS, LOGIN_EMAIL FROM SESSION WHERE SESSION_NAME=@1", con);
            cmd.Parameters.AddWithValue("@1", input);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    s = new Session(null, dr.GetInt32(0), dr.GetInt32(1), dr.GetString(2));
                }
            }
            else
            {
                preset();
                s = new Session(null, 0, 0, null);
            }
            dr.Close();
            con.Close();
            return s;
        }
        public string login_name()
        {
            Session s = getSession("login");
            string email = s.login_email;
            string name = "";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT USER_NAME FROM USERS WHERE USER_EMAIL=@1", con);
            cmd.Parameters.AddWithValue("@1", email);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                name = dr.GetString(0);
            }
            con.Close();
            return name;
        }
        public void clear()
        {
            {
                SqlConnection con = new SqlConnection(connection);
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE SESSION SET LOGIN_STATUS=@1, SAVE_LOGIN_STATUS=@2, LOGIN_EMAIL=@3 WHERE SESSION_NAME=@4", con);
                cmd.Parameters.AddWithValue("@1", 0);
                cmd.Parameters.AddWithValue("@2", 0);
                cmd.Parameters.AddWithValue("@3", "noemail");
                cmd.Parameters.AddWithValue("@4", "login");
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}