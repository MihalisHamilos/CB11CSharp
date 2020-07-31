using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PartA
{
    public class SuperClass
    {
        public void add<T>(GenericClass<T> item)
        {
            Console.WriteLine("{0} name", item.genList[0].GetType());
            string sname = Console.ReadLine();

            if (item.genList[0].GetType() == typeof(Student))
            {
                T something = (T)(object)new Student(1, sname, new DateTime(2020, 5, 3));
                item.genList.Add(something);
            }

            Console.WriteLine("{0} Course", item.genList[0].GetType());
            for (int i = 1; i <= Helper.courselist.Count(); i++)
            {
                Console.WriteLine("{0}.{1}", i, Helper.courselist[i - 1].name);
            }
            int y = Convert.ToInt32(Console.ReadLine());
            y = y - 1;
        }
    }
}
