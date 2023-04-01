using System;
using System.Collections.Generic;
using System.Text;

namespace NoteAppConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
        static void mainMenu()
        {
            Console.WriteLine("This program will manage notes");
            do
            {
                try
                {
                    Console.WriteLine("enter the number of the menu and press enter:");
                    int menuNum = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("please enter just number (like: 2 ) : ");
                }
            }
            while (true);
        }
        static void showTitles()
        {

        }
        static void showNote()

        {

        }
        static void addNote()
        {

        }
        static string chooseTag()
        {

        }
    }
}
