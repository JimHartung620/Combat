using System;
using System.Collections.Generic;

namespace Combat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the game!");
            Console.WriteLine("Let's begin by selecting each player's combatant!");
            Console.WriteLine("");
            List<Combatant> Players = new List<Combatant>();
            void AddCombatant(int playernumber, int selection)
            {
                if (playernumber  == 1)
                {
                    if (selection == 1)
                    {
                        Warrior Player1 = new Warrior("Player1");
                        Players.Add(Player1);
                    }
                    if (selection == 2)
                    {
                        Mage Player1 = new Mage("Player1");
                        Players.Add(Player1);
                    }
                    if (selection == 3)
                    {
                        Ranger Player1 = new Ranger("Player1");
                        Players.Add(Player1);
                    }
                }
                if (playernumber  == 2)
                {
                    if (selection == 1)
                    {
                        Warrior Player2 = new Warrior("Player2");
                        Players.Add(Player2);
                    }
                    if (selection == 2)
                    {
                        Mage Player2 = new Mage("Player2");
                        Players.Add(Player2);
                    }
                    if (selection == 3)
                    {
                        Ranger Player2 = new Ranger("Player2");
                        Players.Add(Player2);
                    }
                }
            }
            Console.WriteLine("Player 1, please select a combatant!");
            AddCombatant(1, Selections.SelectCombatant());
            Console.WriteLine("");
            Console.WriteLine("Player 2, please select a combatant!");
            AddCombatant(2, Selections.SelectCombatant());
            Console.WriteLine("Without further ado, let the battle begin!");
            Match.Skirmish(Players[0], Players[1]);
        }
    }
}