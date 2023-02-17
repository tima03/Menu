using CMenu;


class Program {
    static public void Main(string[] args) {
        exe ex1;
        List<Item> ListMain = new List<Item>();
        CMenu.CMenu Menu = new CMenu.CMenu("Shop");
        ListMain.Add(new Item("Auth", Auth));
        ListMain.Add(new Item("Exit", ExitExe));
        Menu.SetList(ListMain);
        Menu.Run();
        

        void Auth()
        {
            Console.Clear();
            Console.WriteLine("auth");
            Console.ReadLine();
        }

        void ExitExe()
        {
            Menu.SetIsRunning(false);
            Console.ReadLine();
        }

        

    }
}
