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
        }

        public CMenu(string Name, List<Item> ItemMenu)
        {
            name = Name;
            pointer = 0;
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
                    Console.Write("->");
                }
                else
                {
                    Console.Write("  ");
                    Console.WriteLine(ItemMenu[i].GetName());
                }
            }
        }

        public void Run()
        {
            pointer = 0;
            while (true)
            {
                Console.Clear();
                Print(pointer);

                if (Console.ReadKey(false).Key == ConsoleKey.DownArrow) pointer++;
                else if (Console.ReadKey(false).Key == ConsoleKey.UpArrow) pointer--;
                else if (Console.ReadKey(false).Key == ConsoleKey.Enter)
                {
                    ItemMenu[pointer].RunCommand();
                }

                if (pointer < 0) pointer = ItemMenu.Count - 1;
                else if (pointer > (ItemMenu.Count - 1)) pointer = 0;

                if (!IsRunnig) break;

            }
        }

        public void Stop()
        {
            this.IsRunnig = false;
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