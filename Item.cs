using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMenu
{
    public class Item
    {
        string name;
        string Funciton;

        public Item() {
            this.name = "NULL";
            this.Funciton = "NULL";
        }
        public Item(string name,string Function)
        {
            this.name = name;
            this.Funciton = name;
        }

    }
}
