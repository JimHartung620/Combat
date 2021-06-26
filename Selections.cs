using System;
using System.Collections.Generic;

namespace Combat
{
    class Selections
    {
        public static int SelectCombatant()
        {
            bool validInput = true;
            int selection = 0;
            while (validInput)
            {
                Console.WriteLine("Enter 1 for Warrior!");
                Console.WriteLine("Enter 2 for Mage!");
                Console.WriteLine("Enter 3 for Ranger!");
                bool inputTest = int.TryParse(Console.ReadLine(), out selection);
                if (!inputTest || selection > 3 || selection <= 0)
                {
                    Console.WriteLine("Please enter a valid selection!");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }
                if (selection == 1)
                {
                    Console.WriteLine("You selected Warrior!");
                    break;
                }
                else if (selection == 2)
                {
                    Console.WriteLine("You selected Mage!");
                    break;
                }
                else if (selection == 3)
                {
                    Console.WriteLine("You selected Ranger!");
                    break;
                }
            }
            return selection;
        }

        public static int SelectAttack(string title)
        {
            bool validInput = true;
            int selection = 0;
            while (validInput)
            {
                Console.WriteLine("Please select an attack!");
                if (title == "Warrior")
                {
                    Console.WriteLine("Enter 1 to use Slash!");
                    Console.WriteLine("Enter 2 to use Berserk Rage!");
                }
                if (title == "Mage")
                {
                    Console.WriteLine("Enter 1 to use Hex!");
                    Console.WriteLine("Enter 2 to use Wretched Curse!");
                }
                if (title == "Ranger")
                {
                    Console.WriteLine("Enter 1 to use Volley!");
                    Console.WriteLine("Enter 2 to use Rapid Fire!");
                }
                bool inputTest = int.TryParse(Console.ReadLine(), out selection);
                if (!inputTest || selection > 2 || selection <= 0)
                {
                    Console.WriteLine("Please enter a valid selection!");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }
                if (title == "Mage")
                {
                    if (selection == 1)
                    {
                        selection = 3;
                    }
                    if (selection == 2)
                    {
                        selection = 4;
                    }
                }
                if (title == "Ranger")
                {
                    if (selection == 1)
                    {
                        selection = 5;
                    }
                    if (selection == 2)
                    {
                        selection = 6;
                    }
                }
                if (selection >= 1 && selection <= 6)
                {
                    break;
                }
            }
            return selection;
        }
    }
}