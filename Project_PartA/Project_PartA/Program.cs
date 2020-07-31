using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PartA
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = -1;
            bool noRecords = true;
            do
            {

                Console.WriteLine("1.Add Data");
                Console.WriteLine("2.Show Data");
                Console.WriteLine("3.Use Synthetic");
                Console.WriteLine("0.Exit");
                x = Convert.ToInt32(Console.ReadLine());
                if (x==1)
                {
                    Helper.ShowAddMenu(noRecords);
                }
                if (x == 2)
                {
                    Helper.ShowDataMenu();
                }
                if (x == 3)
                {
                   // Helper.AutoCreateData();
                }
            } while (x != 0);

            //Generic Remove
            GenericClass<Student> students = new GenericClass<Student>();
            students.genList.Add(new Student(1, "mixalis", new DateTime(2020, 5, 3)));
            SuperClass sp = new SuperClass();
            sp.add<Student>(new GenericClass<Student>());
            sp.add<Trainer>(new GenericClass<Trainer>());
        }
    }
}
