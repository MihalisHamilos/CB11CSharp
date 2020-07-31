using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PartA
{
    public class Trainer : IEntity
    {
        int ID;
        public string name { get ; set; }

        public Trainer(int id,string tname)
        {
            name = tname;
            ID = id;
        }
        public  void AddEntity()
        {
            Console.WriteLine("Trainer name");
            string sname = Console.ReadLine();

            Trainer tr = new Trainer(Helper.trainerlist.Count() + 1, sname);
            if (tr.CheckDoublicate())
            {
                Console.WriteLine("student already exist");
                return;
            }
            Helper.trainerlist.Add(tr);
            Console.WriteLine("TRainer Course");
            for (int i = 1; i <= Helper.courselist.Count(); i++)
            {
                Console.WriteLine("{0}.{1}", i, Helper.courselist[i - 1].name);
            }
            int y = Convert.ToInt32(Console.ReadLine());
            y = y - 1;
            Helper.courselist[y].trainerIDlist.Add(Helper.trainerlist.Count());
        }

        public void ShowEntityData()
        {
            throw new NotImplementedException();
        }

        public bool CheckDoublicate()
        {
            throw new NotImplementedException();
        }
    }
}
