using System;
using System.Collections.Generic;
using System.Text;

namespace NoteAppConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* DateTime a = new DateTime(2010,5,2,12,5,3);
            note g = new note(2, "dkfdgfgfgfhdkf", "test5", "tag0", a);
            note.addnote(g);*/
            mainMenu();
            Console.ReadKey();
        }
        static void mainMenu()
        {
            Console.WriteLine("This program will manage notes");
            do
            {
                try
                {
                    Console.WriteLine("enter the number of the menu and press enter:");
                    Console.WriteLine("1-show notes (includes delete too)\n2-add note\n=>");
                    int menuNum = int.Parse(Console.ReadLine());
                    if (menuNum >= 1 && menuNum <= 2)  // i know about == just maybe number of menu was
                                                       // more like 6 part it be easiter two just change one number
                    {
                        switch (menuNum)
                        {
                            case 1:
                                showNotesMenu();
                                break;
                        }

                        break;
                    } 
                    else throw new Exception() ;
                            
                }
                catch
                {
                    Console.WriteLine("please enter just number and from (1 , 2) : =>");
                }
            }
            while (true);
        }
        static void showNotesMenu()
        {
            Console.WriteLine("for going to note enter number of it  (like 6):\n=>");
            showTitles();
            do
            {
                try
                {
                    int menuNum = int.Parse(Console.ReadLine());
                    if (menuNum >= 1 && menuNum <= note.numberOfNotes)                          
                    {
                        
                    } 
                    else throw new Exception() ;
                            
                }
                catch
                {
                    Console.WriteLine("please enter just number (like 6) : =>");
                }
            }
            while (true);

        }
        static void showTitles()
        {
            Console.WriteLine("notes:");
            foreach (string item in note.getTitles())
            {
                Console.WriteLine(item);
            }
        }
        static void showNote()

        {

        }
        static void addNote()
        {

        }
        static string chooseTag()
        {
            return "";
        }
        
    }
}
