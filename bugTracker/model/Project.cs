using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bugTracker.model
{
    class Project
    {
        private int id;
        private string title;
        private DateTime startDate;
        private DateTime endDate;
        private string description;
        private int user_id;

        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }
        public string Description { get => description; set => description = value; }
        public int User_id { get => user_id; set => user_id = value; }

        public override string ToString()
        {
            return this.Title;
        }
    }
}
