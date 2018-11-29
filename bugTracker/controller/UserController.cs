using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using bugTracker.DAO;
using bugTracker.model;



namespace bugTracker.controller
{

    class UserController
    {
        UserDao daoUser;
        User user;
        
        String mySqlConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=db_bug_tracker";
        MySqlConnection conn;
        public UserController()
        {
            conn = new MySqlConnection(mySqlConnectionString);

        }

        public bool adduser(string fname, string lname, string username, string password, string email, string type, string gender)
        {
            String sql = "INSERT INTO tbl_user(first_name,last_name,username,password,email,user_type,gender)VALUES(@fname,@lname,@username,@password,@email,@type,@gender)";
            MySqlCommand sqlCommand = new MySqlCommand(sql, conn);
            sqlCommand.Parameters.AddWithValue("@fname", fname);
            sqlCommand.Parameters.AddWithValue("@lname", lname);
            sqlCommand.Parameters.AddWithValue("@username", username);
            sqlCommand.Parameters.AddWithValue("@password", password);
            sqlCommand.Parameters.AddWithValue("@email", email);
            sqlCommand.Parameters.AddWithValue("@type", type);
            sqlCommand.Parameters.AddWithValue("@gender", gender);
            sqlCommand.CommandTimeout = 60;
            try
            {
                conn.Open();
                int rowUpdate = sqlCommand.ExecuteNonQuery();
                if (rowUpdate > 1)
                {
                    MessageBox.Show("Row updated");
                }
                else
                {
                    MessageBox.Show("Row updated");

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            return false;
        }

        public User loginUser(String username, String password)
        {
            daoUser = new UserDao();
            try
            {

                user = daoUser.loginUser(username, password);
                if (user != null)
                {
                    return user;
                }
                else { return null; }

            }
            catch (Exception e)
            {
                MessageBox.Show("user controller"+e.Message);
            }


            return null;
        }

    }


}
