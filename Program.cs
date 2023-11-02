using System;
using tui_netcore;
using VNLib;
namespace Setup {
  public class mainGame {
    public static void Main() {
      while (true) {
        Tui window = new Tui();
        window.Title = " Hello World ";
        window.Body = "Try say hello world!";
        string answer = window.DrawInput();
        if (answer.ToLower() == "help") {
          window.Body = "Welcome to help page\nCommand:\n\thello world!\n\texit";
          window.DrawOk();
        }
        if (answer.ToLower() == "hello world!") {
          window.Body = "Hello world!";
          window.DrawOk();
        }
        else if (answer.ToLower() == "exit") {
          window.Body = "Goodbye!";
          window.DrawOk();
          break;
        }
      }
    }
  }
}