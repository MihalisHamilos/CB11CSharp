using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PartA
{
    public class Course
    {
        int ID;
        public string name { get; set; }
        public List<int> studentIDlist = new List<int>();
        public List<int> trainerIDlist = new List<int>();
        public List<int> assignmentIDlist = new List<int>();

        public Course(int ID, string fname)
        {
            this.ID = ID;
            name = fname;
        }
    }
}
