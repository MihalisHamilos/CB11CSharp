using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PartA
{
    public static class Helper
    {
        public static List<Student> studentlist = new List<Student>();
        public static List<Course> courselist = new List<Course>();
        public static List<Assignment> assignmentlist = new List<Assignment>();
        public static List<Trainer> trainerlist = new List<Trainer>();
        public static void ShowAddMenu(bool noRecords)
        {

            int x = -1;
            do
            {
                if (noRecords)
                    Console.WriteLine("Please add Course First");
                Console.WriteLine("1.Add Student");
                Console.WriteLine("2.Add Course");
                Console.WriteLine("3.Add Trainer");
                Console.WriteLine("4.Add Assignment");
                Console.WriteLine("0.Back");
                x = Convert.ToInt32(Console.ReadLine());
                if (noRecords && x != 2)
                {
                    Console.WriteLine("Please add Course First");
                }
                else if (x == 1)
                {
                    AddStudent();
                }
                else if (x==3)
                {
                    
                }
                else if (x==4)
                {
                    Assignment.AddAssignment(assignmentlist, courselist);
                }
                if (noRecords && courselist.Count > 0)
                    noRecords = false;
            } while (x != 0);
        }

        public static void AddStudent()
        {
            Console.WriteLine("Student name");
            string sname = Console.ReadLine();
            Console.WriteLine("Student Birth Date (dd/mm/yyyy)");
            DateTime sdate = Convert.ToDateTime(Console.ReadLine());

            Student st = new Student(studentlist.Count() + 1, sname,sdate);
            if (st.CheckDoublicate())
            {
                Console.WriteLine("student already exist");
                return;
            }
            studentlist.Add(st);
            Console.WriteLine("Student Course");
            for(int i=1; i<=courselist.Count();i++)
            {
                Console.WriteLine("{0}.{1}", i, courselist[i-1].name);
            }
            int y = Convert.ToInt32(Console.ReadLine());
            y = y - 1;
            courselist[y].studentIDlist.Add(studentlist.Count());
        }



        public static void ShowDataMenu()
        {
            int x = -1;
            do
            {
                Console.WriteLine("1.Show Student list");
                Console.WriteLine("2.Show Course list");
                Console.WriteLine("3.Show Trainer list");
                Console.WriteLine("4.Show Assignment list");
                Console.WriteLine("5.Show students per Course list");
                Console.WriteLine("5.Show Assignments per Student");
                Console.WriteLine("0.Back");
                x = Convert.ToInt32(Console.ReadLine());
                if (x == 5)
                {
                    Console.WriteLine("Choose course");
                    Console.WriteLine("0.All Courses");
                    for (int i = 1; i <= courselist.Count(); i++)
                    {
                        Console.WriteLine("{0}.{1}", i, courselist[i - 1].name);
                    }
                    int y = Convert.ToInt32(Console.ReadLine());
                    y = y - 1;
                    showStudentPerCourse(y);
                }
                else if (x==6)
                {

                }
            } while (x != 0);
        }

        public static void showStudentPerCourse(int courseID)
        {
            List<int> studentsIDs = courselist[courseID].studentIDlist;
            for (int i=0; i<studentsIDs.Count();i++)
            {
                int stID = studentsIDs[i];
                Console.WriteLine("students name : {0},{1}", studentlist[stID].Fullname, studentlist[stID].BirthDate.ToString("dd/MM/yyy"));
            }
        }

        public static string greekToEnglish(string str)
        {
            str = str.Replace("ά", "a");
            str = str.Replace("α", "a");
            str = str.Replace("β", "b");
            str = str.Replace("θ", "th");

            return str;
        }
    }
}
