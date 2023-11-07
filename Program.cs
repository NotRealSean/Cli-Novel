using System;
using tui_netcore;
using VNLib;
namespace Setup
{
    public class mainGame
    {
        public static void Main()
        {
            Tui win = new Tui();
            win.Title = " Test game ";
            while (true)
            {
                win.Body = "Please select character story below.";
                string charSelect = win.DrawList(new List<string>() {
                    "Euna",
                    "Exit"
                });
                if (charSelect == "Exit")
                {
                    break;
                }
                switch (charSelect)
                {
                    case "Euna":
                        Game.Story.Euna();

                        break;
                }

            }
            Console.Clear();
        }
    }
}
namespace Game
{
    public class Story
    {
        public static void Euna()
        {
            Tui win = new Tui();
            win.Body = "Test text";
            win.DrawOk();

        }
    }
}
