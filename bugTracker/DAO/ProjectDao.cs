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
    class ProjectDao
    {
        String mySqlConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=db_bug_tracker";
        MySqlConnection conn;
        Project project;
        public ProjectDao()
        {
            conn = new MySqlConnection(mySqlConnectionString);

        }

        public bool insert(Project project)
        {
            this.project = project;
            String sql = "INSERT INTO tbl_project (title,start_date,end_date,description,user_id)VALUES(@title,@start_date,@end_date,@description,@user_id)";
            
            try {
                MySqlCommand sqlCommand = new MySqlCommand(sql, conn);
                sqlCommand.Parameters.AddWithValue("@title", project.Title);
                sqlCommand.Parameters.AddWithValue("@start_date", project.StartDate);
                sqlCommand.Parameters.AddWithValue("@end_date", project.EndDate);
                sqlCommand.Parameters.AddWithValue("@description", project.Description);
                sqlCommand.Parameters.AddWithValue("@user_id", project.User_id);

                conn.Open();
                int rowUpdate = sqlCommand.ExecuteNonQuery();//non query is for such query which is not responsible for fetching data from database.
                conn.Close();
                if (rowUpdate > 0)
                {
                   // conn.Close();
                    Console.WriteLine(" updated "+rowUpdate);
                    Console.Read();
                    return true;
                }
                else
                {
                   // conn.Close();
                    Console.WriteLine("not updated "+rowUpdate);
                    Console.Read();
                    return false;

                }
               
            } catch (Exception e) {
                MessageBox.Show(e.Message);
                
            }

            return false;
        }
    }
}
