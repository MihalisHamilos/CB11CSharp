using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PartA
{
    public class Assignment
    {
        int ID;
        public string name { get; set; }
        public DateTime deliveryDate { get; set; }

        public Assignment(int id, string name, DateTime dDate)
        {
            ID = id;
            this.name = name;
            deliveryDate = dDate;
        }

        public static void AddAssignment(List<Assignment> assignmentlist, List<Course> courselist)
        {
            Console.WriteLine("Assignment name");
            string sname = Console.ReadLine();
            Console.WriteLine("Assigmnent Delivery Date (dd/mm/yyyy)");
            DateTime sdate = Convert.ToDateTime(Console.ReadLine());

            Assignment st = new Assignment(assignmentlist.Count() + 1, sname, sdate);
            assignmentlist.Add(st);
            Console.WriteLine("Assigmnent Course");
            for (int i = 1; i <= courselist.Count(); i++)
            {
                Console.WriteLine("{0}.{1}", i, courselist[i - 1].name);
            }
            int y = Convert.ToInt32(Console.ReadLine());
            y = y - 1;
            courselist[y].studentIDlist.Add(assignmentlist.Count());
        }

        public static void showStudentPerAssignment(List<Assignment> assignmentlist, List<Course> courselist,
            List<Student> studentlist)
        {
            Console.WriteLine("Choose student");
            Console.WriteLine("0.All Student");
            for (int i = 1; i <= studentlist.Count(); i++)
            {
                Console.WriteLine("{0}.{1}", i, studentlist[i - 1].Fullname);
            }
            int y = Convert.ToInt32(Console.ReadLine());
            y = y - 1;
            showCurrentStudentAssignment(y, assignmentlist, courselist);
        }

        public static void showCurrentStudentAssignment(int stID, List<Assignment> assignmentlist, List<Course> courselist)
        {
            //search all courses
            for (int i = 0; i < courselist.Count(); i++)
            {
                //search for current course the student Ids
                for (int j = 0; j < courselist[i].studentIDlist.Count; j++)
                {
                    if (courselist[i].studentIDlist[j] == stID)
                    {
                        //search for current course the assignment Ids
                        for (int k = 0; k < courselist[i].assignmentIDlist.Count; k++)
                        {
                            int assignID = courselist[i].assignmentIDlist[k];
                            Console.WriteLine("Assignment NAme {0}", assignmentlist[assignID].name);
                        }
                    }
                }
            }
        }

        public static void showDeliverableAssignments(DateTime dt)
        {
            if (dt.DayOfWeek == DayOfWeek.Saturday)
                dt.AddDays(2);
            else if (dt.DayOfWeek == DayOfWeek.Sunday)
                dt.AddDays(1);
            for (int i =0; i<Helper.assignmentlist.Count;i++)
            {
                if (Helper.assignmentlist[i].deliveryDate == dt)
                {
                    int assignID = Helper.assignmentlist[i].ID;
                    Student.showStudentWithAssignment(assignID);
                }
            }
        }
    }
}
