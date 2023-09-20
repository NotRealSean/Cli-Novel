using System;

namespace Setup {
    public class mainGame {
        public static void Main() {
            Console.Clear();
            Console.WriteLine("");
            if (!Directory.Exists("saveData"))
            {
                Directory.CreateDirectory("savedata");
            }
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