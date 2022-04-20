using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ex02.ConsoleUserInterface;

namespace Ex02
{
    public class Program
    {
        public static void Main()
        {
            Controller controller = new Controller();
            controller.Run();
            Console.ReadLine();
        }
    }
}
