namespace ConsoleApp06._11._2026
{
    internal class MenuRenderer
    {
        private MenuText _menutext;

        public MenuRenderer(MenuText menuText)
        {
            _menutext = menuText;
        }

        public void ShowMenu(MenuType menuType)
        {
            foreach (string line in _menutext.AllMenu(menuType))
            {
                Console.WriteLine(line);
            }
        }

        public string RenderMenuAndGetInput(MenuType menuType)
        {
            Console.Clear();
            ShowMenu(menuType);
            return Console.ReadLine();
        }

        public void WaitForKeyPress()
        {
            Console.WriteLine(_menutext.AllMenu(MenuType.WaitForKeyPress)[0]);
            Console.ReadKey(true);
        }

        public void ShowText(string text) 
        {
            Console.Clear();
            Console.WriteLine(text);
        }
    }
}
