using System.Data.SqlClient;
using System.Data;

namespace UCSY_Social
{
    class UserDAO
    {
        public string connection = new Connection().get_constr();
        public void save(User u)
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            string query = "INSERT INTO USERS (USER_NAME, USER_EMAIL, USER_PASSWORD, USER_GENDER, USER_DOB, USER_BIO, SQ_ONE, SQ_TWO, SQ_THREE) VALUES(@1, @2, @3, @4, @5, @6, @7, @8, @9)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@1", u.name);
            cmd.Parameters.AddWithValue("@2", u.email);
            cmd.Parameters.AddWithValue("@3", u.password);
            cmd.Parameters.AddWithValue("@4", u.gender);
            cmd.Parameters.AddWithValue("@5", u.dob);
            cmd.Parameters.AddWithValue("@6", u.bio);
            cmd.Parameters.AddWithValue("@7", u.one);
            cmd.Parameters.AddWithValue("@8", u.two);
            cmd.Parameters.AddWithValue("@9", u.three);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public string getPassword(string input)
        {
            string password = "";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT USER_PASSWORD FROM USERS WHERE USER_EMAIL=@1", con);
            cmd.Parameters.AddWithValue("@1", input);
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.HasRows)
            {
                dr.Read();
                password = dr.GetString(0);
            }
            else
            {
                password = "";
            }
            dr.Close();
            con.Close();
            return password;
        }
        public string getEmail(string input)
        {
            string email = "";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT USER_EMAIL FROM USERS WHERE USER_EMAIL=@1", con);
            cmd.Parameters.AddWithValue("@1", input);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                email = dr.GetString(0);
            }
            else
            {
                email = "";
            }
            dr.Close();
            con.Close();
            return email;
        }
        public User getUser(string input)
        {
            User u = null;
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM USERS WHERE USER_EMAIL=@1", con);
            cmd.Parameters.AddWithValue("@1", input);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    u = new User(dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), 
                        dr.GetDateTime(5), dr.GetString(6), dr.GetString(7), dr.GetString(8),dr.GetString(9));
                }
            }
            dr.Close();
            con.Close();
            return u;
        }
        public void update(User u)
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            string query = "UPDATE USERS SET USER_NAME=@1, USER_PASSWORD=@2, USER_BIO=@3 WHERE USER_EMAIL=@4";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@1", u.name);
            cmd.Parameters.AddWithValue("@2", u.password);
            cmd.Parameters.AddWithValue("@3", u.bio);
            cmd.Parameters.AddWithValue("@4", u.email);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void delete(string input)
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE USERS WHERE USER_EMAIL=@1", con);
            cmd.Parameters.AddWithValue("@1", input);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}