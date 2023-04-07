using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask.Dto
{
    public class SpezializeDto
    {
        string specialization;
        int count;
        string title;

        public string Specialization
        {
            get { return specialization; }
            set { specialization = value; }
        }

        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
    }
}
