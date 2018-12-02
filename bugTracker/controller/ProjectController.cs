using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bugTracker.model;
using bugTracker.DAO;
using System.Windows.Forms;

namespace bugTracker.controller
{
    class ProjectController
    {
        ProjectDao daoProject;
        Project project;
        public ProjectController()
        {
            daoProject = new ProjectDao();
        }

        public bool addProject(string title,DateTime startDate,DateTime endDate,string description,int user_id)
        {
            project = new Project();
            project.Title = title;
            project.StartDate = startDate;
            project.EndDate = endDate;
            project.Description = description;
            project.User_id = user_id;

            bool status = daoProject.insert(project);
            if (status==true)
                return true;
            else
                return false;
            
        }
        public bool editProject()
        {
            return false;

        }
        public bool deleteProject()
        {
            return false;
        }

        public List<Project> getAllProject() {
            List<Project> allProject;
            try {
                daoProject = new ProjectDao();
                allProject = daoProject.getAllProject();
                return allProject;

            } catch ( Exception ex) {
                MessageBox.Show(ex.Message);
            }


            return null;
        }
    }
}
