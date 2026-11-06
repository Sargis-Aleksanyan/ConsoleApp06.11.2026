namespace ConsoleApp06._11._2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuRenderer menuRenderer = new MenuRenderer(new MenuText());
            MenuController app = new MenuController(menuRenderer);
            app.Run();
        }
    }
}
