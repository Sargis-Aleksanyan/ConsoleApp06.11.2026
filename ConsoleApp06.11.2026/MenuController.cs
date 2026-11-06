namespace ConsoleApp06._11._2026
{
    internal class MenuController
    {
        private MenuRenderer _menuRenderer;
        public MenuController(MenuRenderer menuRenderer)
        {
            _menuRenderer = menuRenderer;
        }

        public void Run()
        {
            string Input;
            while (true)
            {
                Input = _menuRenderer.RenderMenuAndGetInput(MenuType.MainMenu);
                if (Input == "1")
                {
                    bool inPlayMenu = true;
                    while (inPlayMenu)
                    {
                        Input = _menuRenderer.RenderMenuAndGetInput(MenuType.PlayMenu);
                        if (Input == "1")
                        {
                            _menuRenderer.ShowText("Hello, World!");
                            _menuRenderer.WaitForKeyPress();
                        }
                        else if (Input == "back")
                        {
                            inPlayMenu = false;
                        }
                        else if (Input == "exit")
                        {
                            Environment.Exit(0);
                        }
                        else
                        {
                            _menuRenderer.ShowText("Invalid input. Please try again.");
                            _menuRenderer.WaitForKeyPress(); 
                        }
                    }          
                }
                else if (Input == "2")
                {
                    bool inSettingsMenu = true;
                    while (inSettingsMenu)
                    {
                        Input = _menuRenderer.RenderMenuAndGetInput(MenuType.SettingsMenu);
                        if (Input == "1")
                        {
                            _menuRenderer.ShowText("Audio Settings");
                            _menuRenderer.WaitForKeyPress();
                        }
                        else if (Input == "2")
                        {
                            _menuRenderer.ShowText("Video Settings");
                            _menuRenderer.WaitForKeyPress();
                        }
                        else if (Input == "back")
                        {
                            inSettingsMenu = false;
                        }
                        else if (Input == "exit")
                        {
                            Environment.Exit(0);
                        }               
                        else
                        {
                            _menuRenderer.ShowText("Invalid input. Please try again.");
                            _menuRenderer.WaitForKeyPress();
                        }
                    }
                }
                else if (Input == "3")
                {
                    bool inAboutMenu = true;
                    while (inAboutMenu)
                    {
                        Input = _menuRenderer.RenderMenuAndGetInput(MenuType.AboutMenu);
                        if (Input == "back")
                        {
                            inAboutMenu = false;
                        }
                        else if (Input == "exit")
                        {
                            Environment.Exit(0);
                        }
                        else
                        {
                            _menuRenderer.ShowText("Invalid input. Please try again.");
                            _menuRenderer.WaitForKeyPress();
                        }
                    }
                }
                else if (Input == "exit")
                {
                    Environment.Exit(0);
                }
                else if (Input == "back")
                {

                }
                else
                {
                    _menuRenderer.ShowText("Invalid input. Please try again.");
                    _menuRenderer.WaitForKeyPress();
                }
            }
        }
    }
}
