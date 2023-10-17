using System;

namespace Setup {
    public class mainGame {
        public static void Main() {
            Console.Clear();
            Console.WriteLine("Hello world!");
            if (!Directory.Exists("saveData"))
            {
                Directory.CreateDirectory("savedata");
            }
            Game.game.MainGame();
        }
    }
}

namespace Game {
    public class game {
        public static void MainGame() {
            Console.WriteLine("Main game!");
        }
    }
}
