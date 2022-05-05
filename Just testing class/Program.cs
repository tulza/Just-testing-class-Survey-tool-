using System;
using System.Collections.Generic;

namespace Just_testing_class
{
    internal class Program
    {
        //Town ID and Full name (read-only)
        string[] TownID = new string[]
       {
                "DUNE","AUCK","WELT",
                "CHSC","HAMT","INVC",
       };
        string[] TownName = new string[]
        {
                "Dunedin","Auckland","Wellinton",
                "Christchurch","Hamilton","Invercargill",
        };
        static void Main(string[] args)
        {
            if (OperatingSystem.IsWindows())
            {
                //Resizing Window and removing scrolling on the console
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetWindowSize(80, 20);
                Console.BufferWidth = Console.WindowWidth = 80;
                Console.BufferHeight = Console.WindowHeight;
                Console.CursorVisible = false;
                Console.Title = "Town Survey";

                //Create Text file if text file does not exist
                string Text = @"Text.txt";
                if (!File.Exists(Text))
                {
                    StreamWriter sw = File.CreateText(Text);
                    sw.Close();

                    using (StreamWriter wr = new StreamWriter(@"Text.txt", true))
                    {
                        wr.Write($"No. Surveyed [0]\tLast Updated[{DateTime.Now.ToString("yy/MM/d")}]\n");
                        wr.Write(Line('-', 50));
                    }

                }
            }

            //Town ID and Full name 
            string[] TownID = new string[]
            {
                "DUNE","AUCK","WELT",
                "CHSC","HAMT","INVC",
            };
            string[] TownName = new string[]
            {
                "Dunedin","Auckland","Wellinton",
                "Christchurch","Hamilton","Invercargill",
            };

            //Class list of surveryed NZ citizen 
            List<SurveyedCitizen> SurveyData = new List<SurveyedCitizen>();
            int TownSelect = Menu(TownName);

            Console.WriteLine(TownSelect);



            //testing
            ////SurveyData.Add(new SurveyedCitizen("hawkins", "kapo", TownID[1], 2004));
            //int a = 0;
            //Console.WriteLine($" [{SurveyData[a].TownID} {SurveyData[a].SurveyID}] {SurveyData[a].FirstName} {SurveyData[a].Surname} {SurveyData[a].BirthYear} ");


        }//End Main

        static int Menu(string[] argsTownName)
        {

            /*
             
                Note: Unreadable code because i suck at making it look easy to read + 0 comment(s)

             */
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            MakeFancySquareBox();
            LastUpdatedOn();

            Console.SetCursorPosition(6, 2);
            int Lineleft = Console.CursorLeft;

            //Writing the Menu
            Console.Write("Please select the surveyed town");
            Space(1);
            TextPaddingLeft();
            Console.Write("Arrow Key (▲/▼)");
            Space(2);
            int LineStart = Console.CursorTop;
            for (int i = 0; i < argsTownName.Length; i++)
            {
                TextPaddingLeft();
                Console.Write($"{i + 1}) {argsTownName[i]}\n");
            }

            int Sele = 0;
            int SeleMax = argsTownName.Length - 1;

            while (true)
            {
                //UI for user input selection
                Console.SetCursorPosition(Lineleft, LineStart + Sele);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($" {Sele + 1}) {argsTownName[Sele]} ");
                Console.ForegroundColor = ConsoleColor.White;

                Console.SetCursorPosition(Lineleft, LineStart + Sele);
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.UpArrow:
                        {
                            if (Sele != 0)
                            {

                                Console.Write($"{Sele + 1}) {argsTownName[Sele]} ");
                                Sele--;
                            }

                            else
                            {
                                Console.Write($"{Sele + 1}) {argsTownName[Sele]} ");
                                Sele = SeleMax;
                            }
                            break;
                        }

                    case ConsoleKey.DownArrow:
                        {
                            if (Sele != SeleMax)
                            {
                                Console.Write($"{Sele + 1}) {argsTownName[Sele]} ");
                                Sele++;
                            }

                            else
                            {
                                Console.Write($"{Sele + 1}) {argsTownName[Sele]} ");
                                Sele = 0;
                            }
                            break;
                        }
                    case ConsoleKey.Enter:
                        {
                            Console.Clear();
                            MakeFancySquareBox();
                            Console.SetCursorPosition(2,1);
                            return Sele;
                        }
                }
            }
        }//Menu method
        static void MakeFancySquareBox()
        {

            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < 20; i++)
            {
                if (i == 0 || i == 19)
                {
                    Console.Write(Line('█', 80));
                    if (i == 0)
                    {
                        Console.Write("\n");
                    }
                }
                else
                {
                    Console.WriteLine("██" + Line(' ', 76) + "██");
                }
            }
        }
        static string Line(char c, int Length)
        {
            //create a line. duh
            string a = new string(c, Length);
            return a;
        }
        static void TextPaddingLeft()
        {
            Console.SetCursorPosition(6/*padding amount*/, Console.CursorTop);
        }
        static void Space(int space)
        {
            int Curside = Console.CursorLeft;
            int Curtop = Console.CursorTop;
            Console.SetCursorPosition(Curside, Curtop + space);
        }
        static void LastUpdatedOn()
            {
                //Last Update (Manual)
                Console.SetCursorPosition(50, 18);
                Console.Write("Updated Last on:[5/05/2022]");
            }
    }
}