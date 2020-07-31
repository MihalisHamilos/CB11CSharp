using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PartA
{
    public class Student
    {
        int ID;
        public string Fullname { get; set; }
        public DateTime BirthDate { get; set; }

        public Student (int ID, string fname, DateTime dt)
        {
            this.ID = ID;
            Fullname = fname;
            BirthDate = dt;
        }

        public bool CheckDoublicate()
        {
            for (int i=0; i< Helper.studentlist.Count;i++)
            {
                Student currentStd = Helper.studentlist[i];
                if (this.Fullname == currentStd.Fullname && this.BirthDate == currentStd.BirthDate)
                    return true;
            }
            return false;
        }

        public static void showStudentWithAssignment(int assignID)
        {
            //search all courses
            for (int i = 0; i < Helper.courselist.Count(); i++)
            {
                //search for current course the student Ids
                for (int j = 0; j < Helper.courselist[i].assignmentIDlist.Count; j++)
                {
                    if (Helper.courselist[i].assignmentIDlist[j] == assignID)
                    {
                        //search for current course the assignment Ids
                        for (int k = 0; k < Helper.courselist[i].studentIDlist.Count; k++)
                        {
                            int stID = Helper.courselist[i].studentIDlist[k];
                            Console.WriteLine("Assignment NAme {0}", Helper.studentlist[stID].Fullname);
                        }
                    }
                }
            }
        }
    }
}
