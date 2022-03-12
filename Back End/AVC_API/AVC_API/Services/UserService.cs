using AVC_API.Interfaces;
using AVC_API.Models;
using AVC_API.Utilities;
using System.Data;
using System.Data.SqlClient;

namespace AVC_API.Services
{
    public class UserService : IUserService
    {
        SqlConnection cnn;
        SqlCommand cmd;
        public UserService()
        {
            cnn = new SqlConnection(Constants.connectionString);
        }

        public async Task<bool> AddUser(User user)
        {
            bool result = false;

            try
            {
                string commandSql = "INSERT INTO Users(ID,Name,LastName,Email,Address,Phone,Profile,Password) VALUES(" +
                    user.ID + "," +
                    user.UserName + "," +
                    user.FullName + "," +
                    user.Email + "," +
                    user.Address + "," +
                    user.Phone + "," +
                    user.Profile + "," +
                    user.Password +
                    ")";

                cnn.Open();
                cmd = new SqlCommand(commandSql, cnn);
                cmd.ExecuteNonQuery();
                cnn.Close();

                result = true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return result;
        }

        public async Task<bool> DeleteUser(User user)
        {
            bool result = false;
            try
            {
                string commandSql = "DELETE FROM Users WHERE ID = '" + user.ID + "'";

                cnn.Open();
                cmd = new SqlCommand(commandSql, cnn);
                cmd.ExecuteNonQuery();
                cnn.Close();

                result = true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return result;
        }

        public async Task<List<User>> GetAllUsers()
        {
            List<User> users = new List<User>();

            try
            {
                string commandSql = "SELECT * FROM Users";

                cnn.Open();
                cmd = new SqlCommand(commandSql, cnn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                foreach(DataRow dr in dt.Rows)
                {
                    object[] array = dr.ItemArray;
                    User user = new User();

                    user.ID = dr["ID"].ToString();
                    user.UserName = dr["Name"].ToString();
                    user.FullName = dr["LastName"].ToString();
                    user.Email = dr["Email"].ToString();
                    user.Address = dr["Address"].ToString();
                    user.Phone = long.Parse(dr["Phone"].ToString());
                    int profile = int.Parse(dr["Profile"].ToString());
                    user.Profile = (Profile)profile;
                    user.Status = bool.Parse(dr["Status"].ToString());

                    users.Add(user);
                }

                cnn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return users;
        }

        public async Task<User> GetUser(string UserID)
        {
            User _user = new User();
            try
            {
                string commandSql = "SELECT * FROM Users WHERE ID = '" + UserID + "'";

                cnn.Open();
                cmd = new SqlCommand(commandSql, cnn);
                SqlDataReader data = cmd.ExecuteReader();
                if (data.Read())
                {
                    _user.ID = data["ID"].ToString();
                    _user.UserName = data["Name"].ToString();
                    _user.FullName = data["LastName"].ToString();
                    _user.Email = data["Email"].ToString();
                    _user.Address = data["Address"].ToString();
                    _user.Phone = long.Parse(data["Phone"].ToString());
                    int profile = int.Parse(data["Profile"].ToString());
                    _user.Profile = (Profile)profile;
                    _user.Status = bool.Parse(data["Status"].ToString());
                }
                cnn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return _user;
        }

        public async Task<User> Login(string user, string pass)
        {
            User _user = new User();
            try
            {
                string commandSql = "SELECT * FROM Users WHERE Name = '" + user + "' AND Password = '" + pass + "'";

                cnn.Open();
                cmd = new SqlCommand(commandSql, cnn);
                SqlDataReader data = cmd.ExecuteReader();
                if (data.Read())
                {
                    _user.ID = data["ID"].ToString();
                    _user.UserName = data["Name"].ToString();
                    _user.FullName = data["LastName"].ToString();
                    _user.Email = data["Email"].ToString();
                    _user.Address = data["Address"].ToString();
                    _user.Phone = long.Parse(data["Phone"].ToString());
                    int profile = int.Parse(data["Profile"].ToString());
                    _user.Profile = (Profile)profile;
                    _user.Status = bool.Parse(data["Status"].ToString());
                }
                cnn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return _user;
        }

        public async Task<bool> UpdateUser(User user)
        {
            bool result = false;

            try
            {
                string commandSql = "UPDATE Users " +
                    "SET Name = '" + user.UserName + "'," +
                    "LastName = '" + user.FullName + "'," +
                    "Email = '" + user.Email + "'," +
                    "Address = '" + user.Address + "'," +
                    "Phone = " + user.Phone + "," +
                    "Profile =" + user.Profile + "," +
                    "Password = '" + user.Password + "'," +
                    " WHERE ID = '" + user.ID + "'";

                cnn.Open();
                cmd = new SqlCommand(commandSql, cnn);
                cmd.ExecuteNonQuery();
                cnn.Close();

                result = true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return result;
        }
    }
}
