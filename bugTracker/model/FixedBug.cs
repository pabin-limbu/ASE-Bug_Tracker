using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bugTracker.model
{
   public class FixedBug : Bug
    {
        private int fixedBugId;
        private int bug_id;
        private String fixedCode;
        private String bugFixedBy;
        private DateTime fixedDate;

        public int FixedBugId { get => fixedBugId; set => fixedBugId = value; }
        public string FixedCode { get => fixedCode; set => fixedCode = value; }
       
        public DateTime FixedDate { get => fixedDate; set => fixedDate = value; }
        public int Bug_id { get => bug_id; set => bug_id = value; }
        public string BugFixedBy { get => bugFixedBy; set => bugFixedBy = value; }
    }
}
