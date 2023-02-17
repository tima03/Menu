using CMenu;

public delegate void exe();
class Program {
    static public void Main(string[] args) {
        exe ex1;
        List<Item> ListMain = new List<Item>();
        //ex1 = ExitExe;
        ex1 = Auth;
        ListMain.Add(new Item("Auth", ex1));
        ListMain.Add(new Item("Heh", ex1));
        ListMain.Add(new Item("Exit", ex1));
        CMenu.CMenu Menu = new CMenu.CMenu("Shop", ListMain, true);
        Menu.Run();

        void Auth()
        {
            Console.WriteLine("auth");
            Console.ReadLine();
        }

        void ExitExe()
        {
            Menu.SetIsRunning(false);
        }

        

    }
}
