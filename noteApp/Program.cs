using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace NoteAppConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            mainMenu();
        }
        static void mainMenu()
        {
            Console.WriteLine("This program will manage notes");
            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("enter the number of the menu and press enter:");
                    Console.WriteLine("1-show notes (includes delete too)\n2-add note\n3-exit\n=>");
                    int menuNum = int.Parse(Console.ReadLine());
                    if (menuNum >= 1 && menuNum <= 3)  // i know about == just maybe number of menu was
                                                       // more like 6 part it be easiter two just change one number
                    {
                        switch (menuNum)
                        {
                            case 1:
                                showNotesMenu();
                                break;
                            case 2:
                                addNote();
                                break;
                            case 3:
                                Environment.Exit(1);
                                break;
                        }

                        Console.WriteLine();
                    } 
                    else throw new Exception() ;
                            
                }
                catch
                {
                    Console.WriteLine("please enter just number and from (1 , 2,3) : =>");
                }
            }
            while (true);
        }
        static void showNotesMenu()
        {
            Console.Clear();
            Console.WriteLine("for going to note enter number of it and q for quit (like 6):\n=>");
            string[] titles =showTitles();
            do
            {
                try
                {

                    string inp = Console.ReadLine();
                    int menuNum;
                    if(inp=="Q" || inp=="q")
                    {
                        break;
                    }
                    else
                    {
                        menuNum = int.Parse(inp);
                    }
                    if (menuNum >= 1 && menuNum <= note.numberOfNotes)                          
                    {
                        showNote(titles[menuNum-1]);
                       
                        break;
                    } 
                    else throw new Exception() ;
                            
                }
                catch( Exception e)
                {
                    
                    Console.WriteLine("please enter just number (like 6) or q :\n =>");
                }
            }
            while (true);

        }
        static string[] showTitles()
        {
            Console.WriteLine("notes:");
            
            string[] titles = note.getTitles();
            for (int i = 0; i < titles.Length; i++)
            {
                Console.WriteLine($"{i + 1}-{titles[i]}");
            }
            Console.WriteLine("=> ");
            return titles;
        }
        static void showNote(string title)
        {
            Console.Clear();
            note n = note.getNote(title);
            Console.WriteLine($"-----------------------------------------------");
            Console.WriteLine($"title:{n.title}  |  tag:{n.tag}      | date created:{n.dateCreated}\ntext:");
            Console.WriteLine($"     {n.text}");
            Console.WriteLine("\n\n------------------------------------------------");
            Console.WriteLine("\nEnter q for going to menu d for deleting the note:\n =>");
            bool exit = false;
            do
            {
                try
                {
                    string inp = Console.ReadLine();
                    switch (inp)
                    {
                        case "q":
                        case "Q":
                            exit = true;
                            break;
                        case "d":
                        case "D":
                            if(n.delete())
                            {
                                exit = true;
                                Console.WriteLine("delete was succesfull\n");
                                Stopwatch stopwatch = Stopwatch.StartNew();
                                while (true)
                                {
                                    
                                    if (stopwatch.ElapsedMilliseconds >= 2000)
                                    {
                                        break;
                                    }
                                    
                                }
                               
                            }
                            else
                            {
                                throw new Exception();
                            }

                            
                            break;

                        default:
                            throw new Exception();
                    }
                    

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("please enter just (q,Q,d,D) :\n =>");
                }
            }
            while (!exit);

        }
        static void addNote()
        {
            Console.Clear();
            string[] titles = note.getTitles();
           

            bool exitloop = false;
            if (titles.Length == 0)
                exitloop = true;
            string title;
            string tag;
            string text;
            Console.WriteLine("--------------------------");
            do
            {
                Console.WriteLine("Enter the title:\n=>");
                title = Console.ReadLine();
                if(title=="")
                {

                    Console.WriteLine("title cannot be empty!!!!");
                    continue;
                }
                  
                foreach (string item in titles)
                {
                    if(title!=item)
                    {
                        exitloop = true;
                    }
                    else
                    {
                        exitloop = false;
                    }
                }

            } while (!exitloop);
            Console.WriteLine("Enter tag:\n=>");
            tag = Console.ReadLine();
            Console.WriteLine("Enter text:\n=>");
            text = Console.ReadLine();

            note g = new note(2,text, title, tag, "");
            note.addnote(g);
            Console.WriteLine("--------------------------\nnote Added");
            Stopwatch stopwatch = Stopwatch.StartNew();
            while (true)
            {

                if (stopwatch.ElapsedMilliseconds >= 2000)
                {
                    break;
                }

            }
        }
        static string chooseTag()
        {
            return "";
        }
        
    }
}
