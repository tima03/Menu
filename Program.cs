using CMenu;

class Program {
static public void Main(string[] args)
    {
       List<Item> ListMain = new List<Item>();
       ListMain.Add(new Item("Auth","AuthExe"));
       ListMain.Add(new Item("Exit", "ExitExe"));
       CMenu.CMenu Menu = new CMenu.CMenu("Shop",ListMain);
       Menu.run();
    }
}
