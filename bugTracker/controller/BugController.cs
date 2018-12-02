using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bugTracker.model;
using System.Windows.Forms;
using bugTracker.DAO;
using System.IO;
using System.Drawing;

namespace bugTracker.controller
{
    class BugController
    {
        Bug bug;
        FixedBug fixedBug;
        public BugController()
        {

        }

        public bool addBug(String bugName, int project_id, string packageName, String className, String methodName, int lineStart, int lineEnd, String codeBlock, byte[] image, DateTime
             bugAddedDate, bool status, int user_id)
        {
            bug = new Bug();
            bug.BugName = bugName;
            bug.Project_id = project_id;
            bug.PackageName = packageName;
            bug.ClassName = className;
            bug.MethodName = methodName;
            bug.LineStart = lineStart;
            bug.LineEnd = lineEnd;
            bug.CodeBlock = codeBlock;
            bug.Image = image;
            bug.BugAddedDate = bugAddedDate;
            bug.Status = status;
            bug.User_id = user_id;

            try
            {
                BugDao daobug = new BugDao();
                bool sts = daobug.insert(bug);
                if (sts) { return true; }

                else { return false; }



            }
            catch (Exception ex) { }

            return false;
        }


        

        public List<Bug> getAllBug()
        {
            List<Bug> allBug;
            try
            {
                BugDao daobug = new BugDao();
                allBug = daobug.getAllBug();
                return allBug;
            }
            catch (Exception ex) { }

            return null;
        }

        public Bug getBugById(int id)
        {
            BugDao daobug = new BugDao();
            try
            {
                bug = daobug.getBugById(id);
                return bug;
            }
            catch (Exception e) { }



            return null;
        }


        public FixedBug getFixedBugById(int id) {
            BugDao daobug = new BugDao();
            try
            {
                fixedBug = daobug.getFixedBugByID(id);
                return fixedBug;
            }
            catch (Exception e) { }


            return null;
        }

        public bool InsertFixedBug(int bugID,String fixedCode,String fixedBy,DateTime fixedDate) {
            BugDao daoBug = new BugDao();
            fixedBug = new FixedBug();
            fixedBug.Bug_id = bugID;
            fixedBug.FixedCode = fixedCode;
            fixedBug.BugFixedBy = fixedBy;
            fixedBug.FixedDate = fixedDate;

            bool status = daoBug.insertFixedBug(fixedBug);
            if (status == true)
                return true;
            else
                return false;

            
        }

        public List<FixedBug> getAllFixedBug()
        {
            List<FixedBug> allFixedBug;
            try
            {
                BugDao daobug = new BugDao();
                allFixedBug = daobug.getAllFixedBug();
                return allFixedBug;
            }
            catch (Exception ex) { }

            return null;
        }
    }
}
