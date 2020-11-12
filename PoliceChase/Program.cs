using System;

namespace PoliceChase
{
    class Program
    {
        private static bool PoliceTurn;
        private static int Distance;
        private static string TheifChoice;
        private static string CopChoice;
        private static int TheifPoint;
        private static int CopPoint;
        static void Main(string[] args)
        {
            Console.WriteLine("Put in a, w  or d for left, straight or right. Cop has to guess the thiefs direction!");
            TheifPoint = 1;
            PoliceTurn = false;
            string text = "s";
            while (!string.IsNullOrWhiteSpace(text))
            {
                if (PoliceTurn == false)
                {
                    Console.WriteLine("Theif Turn: ");
                    var command = Console.ReadLine();
                    TheifChoice = SendInput(command);
                    PoliceTurn = true;
                    Console.Clear();
                }

                if (PoliceTurn)
                {
                    Console.WriteLine("Police Turn: ");
                    var command = Console.ReadLine();
                    CopChoice = SendInput(command);
                    PoliceTurn = false;
                    CheckPoints();
                }
            }
            Console.WriteLine("Hello World!");
        }

        private static void CheckPoints()
        {
            if (CopChoice == TheifChoice)
            {
                CopPoint++;
                Distance = TheifPoint - CopPoint;
                Console.WriteLine("Cop Won! Cop is "+Distance+" Behind, Gogogo!");
                CheckForWin();
            }
            else
            {
                TheifPoint++;
                Distance = TheifPoint - CopPoint;
                Console.WriteLine("Theif Won! Theif is " + Distance + " Ahead!");
                CheckForWin();

            }
        }

        private static void CheckForWin()
        {
            if (CopPoint == TheifPoint)
            {
                CopPoint = 0;
                TheifPoint = 1;
                Console.WriteLine("Theif Got Caught!");
                Console.WriteLine("New Round!");
            }
        }

        //static void getInput()
        //{
        //    ConsoleKeyInfo input;
        //    input = Console.ReadKey();
        //    SendInput(input.KeyChar);
        //}

        public static string SendInput(string inp)
        {
            string str = string.Empty;
            switch (inp)
            {
                case "w": 
                    str = "straigth";
                    break;
                case "a": str = "left";
                    break;
                case "d": str = "right";
                    break;
            }

            return str;
            {
                
            }
        }
    }
}
