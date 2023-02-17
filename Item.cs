using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

public delegate void exe();

namespace CMenu
{
    public class Item
    {
        private string name;
        private exe ex1;

        public Item() {
            
            this.name = "NULL";
            this.ex1 = null;
        }
        public Item(string name,exe ex1)
        {
            this.name = name;
            this.ex1 = ex1;
        }

        public void SetFunction(exe ex1) {
            this.ex1 = ex1;
        }
        
        public void SetName(string name) {
        this.name = name;
        }

        public string GetName()
        {
            return this.name;
        }
        public exe GetFunciton()
        {
            return this.ex1;
        }

        public void Print() {
        Console.WriteLine("Имя элемента меню: {0} Название выполняемой ф-ии: {1}",this.name,this.ex1);
        }
        public void PrintName()
        {
            Console.WriteLine("Имя элемента меню: {0}", this.name);
        }
        public void PrintFunction()
        {
            Console.WriteLine("Название выполняемой ф-ии: {0}", this.ex1);
        }
        public void RunCommand()
        {
            ex1.Invoke();
        }

    }
}
