using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");
        AllGoals allthree = new AllGoals();
        int userChoice = 0;

        Console.Clear();
        Console.WriteLine("Welcome to the Goal Tracking App!");
        Console.WriteLine();

        while (userChoice != 6)
        {
            Menu menu = new Menu();
            allthree.Points(allthree.Total());
            Console.WriteLine();
            menu.DisplayMainMenu();
            userChoice = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (userChoice)
            {
                case 1:
                    menu.DisplayNewMenu();
                    int userNewChoice = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Goal goal = null;
                    if (userNewChoice == 1)
                    {
                        goal = new SimpleGoal();
                        goal.DisplayName();
                        goal.DisplayDescription();
                        goal.DisplayPoints();
                    }
                    else if (userNewChoice == 2)
                    {
                        goal = new EternalGoal();
                        goal.DisplayName();
                        goal.DisplayDescription();
                        goal.DisplayPoints();
                    }
                    else
                    {
                        goal = new CheckListGoal();
                        goal.DisplayName();
                        goal.DisplayDescription();
                        goal.DisplayPoints();
                    }

                    if (goal != null)
                    {
                        allthree.adding(goal);
                    }
                    break;

                case 2:
                    allthree.Goals();
                    break;

                case 3:
                    allthree.Save();
                    break;

                case 4:
                    allthree.LoadGoals();
                    break;

                case 5:
                    allthree.DisplayRecordEvent();
                    break;

                case 6:
                    Console.Write("Do you want to save before you quit (y/n)? ");
                    string userInput = Console.ReadLine();
                    if (userInput == "y")
                    {
                        allthree.Save();
                    }

                    Console.WriteLine();
                    Console.WriteLine("Thank you! Goodbye. ");
                    break;

                default:
                    Console.WriteLine("Please select a valid option.");
                    break;

            }
        }
    }
    }
