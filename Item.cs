using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CMenu
{
    public class Item
    {
        string name;
        ref funciton;

        public Item() {
            this.name = "NULL";
            this.funciton = "NULL";
        }
        public Item(string name,string function)
        {
            this.name = name;
            this.funciton = function;
        }

        public void SetFunction(string funciton) {
            this.funciton = funciton;
        }
        
        public void SetName(string name) {
        this.name = name;
        }

        public string GetName()
        {
            return this.name;
        }
        public string GetFunciton()
        {
            return this.funciton;
        }

        public void Print() {
        Console.WriteLine("Имя элемента меню: {0} Название выполняемой ф-ии: {1}",this.name,this.funciton);
        }
        public void PrintName()
        {
            Console.WriteLine("Имя элемента меню: {0}", this.name);
        }
        public void PrintFunction()
        {
            Console.WriteLine("Название выполняемой ф-ии: {0}", this.funciton);
        }
        public void RunCommand()
        {
            
        }

    }
}
