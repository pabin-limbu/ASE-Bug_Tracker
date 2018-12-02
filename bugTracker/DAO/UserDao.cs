using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using bugTracker.model;
using System.Windows.Forms;


namespace bugTracker.DAO
    
{
    class UserDao
    {
        String mySqlConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=db_bug_tracker";
        MySqlConnection conn;
        User user;
        public UserDao()
        {
            conn = new MySqlConnection(mySqlConnectionString);

        }

        public bool insert(User user)
        {

            return false;
        }

        public User loginUser(String username, String password)
        {
        
            String sql = "SELECT * FROM tbl_user WHERE username=@username AND password=@password";
            try {
                MySqlCommand sqlCommand = new MySqlCommand(sql, conn);
                sqlCommand.Parameters.AddWithValue("@username", username);
                sqlCommand.Parameters.AddWithValue("@password", password);

                conn.Open();
                MySqlDataReader result = sqlCommand.ExecuteReader();
                while(result.Read()){
                   user = new User();
                 user.Id = result.GetInt16(0);
                    user.Fname = result.GetString(1);
                    user.Lname = result.GetString(2);
                    user.Username = result.GetString(3);
                    user.Password = result.GetString(4);
                    user.Email = result.GetString(5);
                    user.UserType = result.GetString(6);
                    user.Gender = result.GetString(7);
                    conn.Close();
                    return user;
                    //  MessageBox.Show(result.GetString(0));
                   
                }
                return null;
              


            }
            catch (Exception e)
            {
                MessageBox.Show("no user found or error"+e.Message);
            }

            return null;
        }
    }
}
