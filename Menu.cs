using System.Diagnostics.Metrics;

namespace CMenu
{
    internal class CMenu
    {
        private List<Item>? ItemMenu = new();
        private string name;
        private int pointer;
        private bool IsRunnig;
        
        public CMenu()
        {
            name = "NULL";
            pointer = 0;
            ItemMenu = null;
            IsRunnig = true;
        }

        public CMenu(string Name, List<Item> ItemMenu,bool IsRunning)
        {
            name = Name;
            pointer = 0;
            IsRunnig = IsRunning;
            this.ItemMenu = ItemMenu;
        }

        public void SetName(string Name)
        {
            name = Name;
        }

        public void SetList(List<Item> List)
        {
            ItemMenu = List;
        }

        public void Print(int pointer)
        {
            Console.WriteLine(name + " " + pointer + " " + ItemMenu.Count);
            Console.WriteLine();

            for (int i = 0; i < ItemMenu.Count; i++)
            {
                if (i == pointer)
                {
                    Console.WriteLine("->" + ItemMenu[i].GetName());
                }
                else
                {
                    Console.WriteLine("  " + ItemMenu[i].GetName());
                }
            }
        }

        public void SetIsRunning(bool IsRunning) {
        this.IsRunnig = IsRunning;
        }
        public bool GetIsRunning()
        {
            return IsRunnig;
        }

        public void Run()
        {
            ConsoleKeyInfo key = new ConsoleKeyInfo();
            pointer = 0;

            while (true)
            {
                Print(pointer);

                key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        pointer--;
                        break;
                    case ConsoleKey.DownArrow:
                        pointer++;
                        break;

                    case ConsoleKey.Escape:
                        IsRunnig = false;
                        break;

                    default:
                        break;
                }

                if (pointer < 0) pointer = ItemMenu.Count - 1;
                else if (pointer > (ItemMenu.Count - 1)) pointer = 0;

                if (!IsRunnig) break;
                Console.Clear();
            }
        }

        public string GetName()
        {
            return name;
        }

        public List<Item> GetItems()
        {
            return ItemMenu;
        }
    }
}