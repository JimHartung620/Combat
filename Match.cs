using System;
using System.Collections.Generic;

namespace Combat
{
    class Match
    {
        public static void PrintPlayerStats(Combatant Player1, Combatant Player2)
        {
            Console.WriteLine("++++++++++++++++++++++++++++++++++");
            Player1.PrintStats();
            Console.WriteLine("++++++++++++++++++++++++++++++++++");
            Player2.PrintStats();
            Console.WriteLine("++++++++++++++++++++++++++++++++++");
        }

        public static void CheckPlayerHP(Combatant Player1, Combatant Player2)
        {
            Player1.PrintHP();
            Console.WriteLine("++++++++++++++++++++++++++++++++++");
            Player2.PrintHP();
            Console.WriteLine("++++++++++++++++++++++++++++++++++");
        }

        public static void WinCondition(Combatant Player1, Combatant Player2)
        {
            if (Player2.HP <= 0)
            {
                Console.Clear();
                Console.WriteLine($"{Player2.Name} has been Obliterated!");
                Console.WriteLine($"{Player1.Name} is the Winner!");
                Environment.Exit(0);
            }
        }

        public static void Skirmish(Combatant Player1, Combatant Player2)
        {
            Console.Clear();
            while (Player1.HP > 0 && Player2.HP > 0)
            {
                Console.WriteLine("********************************************************");
                CheckPlayerHP(Player1, Player2);
                Console.WriteLine("Player 1 Turn:");
                Player1.Turn(Selections.SelectAttack(Player1.Title), Player1, Player2);
                WinCondition(Player1, Player2);
                Console.WriteLine("");
                Console.WriteLine("Player 2 Turn:");
                Player2.Turn(Selections.SelectAttack(Player2.Title), Player2, Player1);
                WinCondition(Player2, Player1);
            }
        }
    }
}