using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PartA
{
    public interface IEntity
    {
        string name { get; set; }

        void AddEntity();
         void ShowEntityData();
          bool CheckDoublicate();
    }
}
