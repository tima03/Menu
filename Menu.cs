using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMenu
{
    internal class CMenu
    {
        private string name;
        private int pointer;
        private List<Item>? ItemMenu = new List<Item>();

        public CMenu(string Name, List<Item> ItemMenu)
        {
            this.name = Name;
            this.pointer = 0;
            this.ItemMenu = ItemMenu;
        }

        public CMenu()
        {
            this.name = "NULL";
            this.pointer = 0;
            this.ItemMenu = null;
        }

        public void SetName(string Name)
        {
            this.name = Name;
        }

        public void SetList(List<Item> List)
        {
            this.ItemMenu = List;
        }

        public string GetName()
        {
            return name;
        }

        public List<Item> GetItems()
        {
            return ItemMenu;
        }

        public void Print()
        {
            // Ещё не доделано
        }
    }
}
