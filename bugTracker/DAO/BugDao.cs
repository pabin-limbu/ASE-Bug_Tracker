using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bugTracker.model;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace bugTracker.DAO
{
    class BugDao
    {
        String mySqlConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=db_bug_tracker";
        MySqlConnection conn;
        Bug bug;
        public BugDao()
        {
            conn = new MySqlConnection(mySqlConnectionString);
        }

        public bool insert(Bug bug)
        {
            this.bug = bug;
            String sql = "INSERT INTO tbl_bug (name,project_id,package_name,class,method,line_start,line_end,image,code,date,status,user_id)VALUES(@name,@project_id,@package_name,@class,@method,@line_start,@line_end,@image,@code,@date,@status,@user_id)";

            try
            {
                MySqlCommand sqlCommand = new MySqlCommand(sql, conn);
                sqlCommand.Parameters.AddWithValue("@name", bug.BugName);
                sqlCommand.Parameters.AddWithValue("@project_id", bug.Project_id);
                sqlCommand.Parameters.AddWithValue("@package_name", bug.PackageName);
                sqlCommand.Parameters.AddWithValue("@class", bug.ClassName);
                sqlCommand.Parameters.AddWithValue("@method", bug.MethodName);
                sqlCommand.Parameters.AddWithValue("@line_start", bug.LineStart);
                sqlCommand.Parameters.AddWithValue("@line_end", bug.LineEnd);
                sqlCommand.Parameters.AddWithValue("@image", bug.Image);
                sqlCommand.Parameters.AddWithValue("@code", bug.CodeBlock);
                sqlCommand.Parameters.AddWithValue("@date", bug.BugAddedDate);
                sqlCommand.Parameters.AddWithValue("@status", bug.Status);
                sqlCommand.Parameters.AddWithValue("@user_id", bug.User_id);



                conn.Open();
                int rowUpdate = sqlCommand.ExecuteNonQuery();//non query is for such query which is not responsible for fetching data from database.
                conn.Close();
                if (rowUpdate > 0)
                {
                    conn.Close();
                    return true;
                }
                else
                {
                    conn.Close();

                    return false;

                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }



            return false;
        }

        public List<Bug> getAllBug() {
            String sql = "SELECT b.id,b.name,b.package_name,b.class,b.method,b.line_start,b.line_end,b.status,b.date,u.username,p.title FROM tbl_bug AS b,tbl_project AS p,tbl_user AS u WHERE b.project_id=p.id AND b.user_id=u.id";
            try
            {
                conn.Open();
                List<Bug> allBug = new List<Bug>();

                MySqlCommand sqlCommand = new MySqlCommand(sql, conn);
                MySqlDataReader result = sqlCommand.ExecuteReader();
                while (result.Read())
                {
                    bug = new Bug();
                    bug.Id = result.GetInt32(result.GetOrdinal("id"));
                    bug.BugName = result.GetString(result.GetOrdinal("name"));
                    bug.PackageName = result.GetString(result.GetOrdinal("package_name"));
                    bug.ClassName = result.GetString(result.GetOrdinal("class"));
                    bug.MethodName = result.GetString(result.GetOrdinal("method"));
                    bug.LineStart = result.GetInt32(result.GetOrdinal("line_start"));
                    bug.LineEnd = result.GetInt32(result.GetOrdinal("line_end"));
                    bug.BugAddedDate = result.GetDateTime(result.GetOrdinal("date"));
                    bug.Status = result.GetBoolean(result.GetOrdinal("status"));
                    bug.BugAuthor = result.GetString(result.GetOrdinal("username"));
                    bug.ProjectName = result.GetString(result.GetOrdinal("title"));

                    allBug.Add(bug);



                        //  project.Id = result.GetInt32(result.GetOrdinal("id"));
                }
                return allBug;


            }
            catch (Exception e)
            {
                MessageBox.Show(" project bug" + e.Message);
            }


            return null;
        }

    }

   




}
