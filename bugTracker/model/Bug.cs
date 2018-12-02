using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bugTracker.model
{
 public   class Bug
    {
        private int id;
        private string bugName;
        private string projectName;
        private string packageName;
        private string className;
        private string methodName;
        private int lineStart;
        private int lineEnd;
        private string codeBlock;
        private DateTime bugAddedDate;
        private Byte[] image;
        private bool status;
        private string bugAuthor;
        private int user_id;
        private int project_id;
        

        public int Id { get => id; set => id = value; }
        public string BugName { get => bugName; set => bugName = value; }
        public string ProjectName { get => projectName; set => projectName = value; }
        public string PackageName { get => packageName; set => packageName = value; }
        public string ClassName { get => className; set => className = value; }
        public string MethodName { get => methodName; set => methodName = value; }
        public int LineStart { get => lineStart; set => lineStart = value; }
        public int LineEnd { get => lineEnd; set => lineEnd = value; }
     
        public string CodeBlock { get => codeBlock; set => codeBlock = value; }
        public DateTime BugAddedDate { get => bugAddedDate; set => bugAddedDate = value; }
        public byte[] Image { get => image; set => image = value; }
        public bool Status { get => status; set => status = value; }
        public string BugAuthor { get => bugAuthor; set => bugAuthor = value; }
        public int User_id { get => user_id; set => user_id = value; }
        public int Project_id { get => project_id; set => project_id = value; }
    }
}
