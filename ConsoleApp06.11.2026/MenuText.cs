namespace ConsoleApp06._11._2026
{
    public enum MenuType
    {
        MainMenu,
        PlayMenu,
        WaitForKeyPress,
        SettingsMenu,
        AboutMenu
    }
    internal class MenuText
    {

        private readonly Dictionary<MenuType, List<string>> _allmenus = new Dictionary<MenuType, List<string>>()
        {
            [MenuType.MainMenu] = new List<string>()
            {
                "=== Main Menu ===",
                "1 - Play",
                "2 - Settings",
                "3 - About",
                "",
                "--- Navigation ---",
                "Type 'back' to go back.",
                "Type 'exit' to exit.",
                "",
                "Select option:"
            },

            [MenuType.PlayMenu] = new List<string>()
            {
                "=== Play Menu ===",
                "1 - Say Hello",
                "",
                "--- Navigation ---",
                "Type 'back' to go back.",
                "Type 'exit' to exit.",
                "",
                "Select option:"
            },

            [MenuType.WaitForKeyPress] = new List<string>()
            {
                "Waiting..., Press any key to continue..."
            },

            [MenuType.SettingsMenu] = new List<string>()
            {
                "=== Settings Menu ===",
                "1 - Audio Settings",
                "2 - Video Settings",
                "",
                "--- Navigation ---",
                "Type 'back' to go back.",
                "Type 'exit' to exit.",
                "",
                "Select option:"
            },

            [MenuType.AboutMenu] = new List<string>()
            {
                "=== About Menu ===",
                "This is a simple console application.",
                "",
                "--- Navigation ---",
                "Type 'back' to go back.",
                "Type 'exit' to exit.",
                "",
                "Select option:"
            }
        };

        public IReadOnlyList<string> AllMenu(MenuType menuType)
        {
            return _allmenus[menuType].AsReadOnly();
        }
    }
}
