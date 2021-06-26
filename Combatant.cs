using System;
using System.Collections.Generic;

namespace Combat
{
    abstract class Combatant
    {
        public string Name;
        public string Title;
        public int HP;
        public int Strength;
        public int Hardiness;
        public int Agility;

//******************************************* Attack Index *************************************************
        public int Slash()
        {
            int damage = 10;
            return damage;
        }
        public int BerserkRage()
        {
            int damage = 20;
            return damage;
        }
        public int Hex()
        {
            int damage = 10;
            return damage;
        }
        public int WretchedCurse()
        {
            int damage = 8;
            return damage;
        }
        public int Volley()
        {
            int damage = 10;
            return damage;
        }
        public int RapidFire()
        {
            int damage = 8;
            Random rand = new Random ();
            int crit = rand.Next(1,11);
            if (crit == 1 || crit == 2)
            {
                damage += 10;
                Console.WriteLine("It was a Critical Hit!");
            }
            return damage;
        }

//******************************************* Stat Methods *************************************************
        public void PrintStats()
        {
            Console.WriteLine("{0} Stats:" , Name);
            Console.WriteLine("");
            Console.WriteLine("Strength: {0}", Strength);
            Console.WriteLine("Hardiness: {0}", Hardiness);
            Console.WriteLine("Agility: {0}", Agility);
        }

        public void PrintHP()
        {
            Console.WriteLine("{0} HP:" , Name);
            Console.WriteLine("");
            Console.WriteLine("{0}", HP);
        }

        public void UseAttack(int damage, Combatant User, Combatant Target)
        {
            int totalDamage = User.Strength + damage - Target.Hardiness;
            Target.HP -= totalDamage;
            Console.WriteLine($"{Target.Name} lost {totalDamage} HP!");
        }

//******************************************* Turn Controller *************************************************
        public void Turn(int selection, Combatant User, Combatant Target)
        {
            bool choseAttack = false;
            while (!choseAttack)
            {
                if (selection == 1)
                {
                    Console.WriteLine($"{User.Name} used Slash!");
                    UseAttack(Slash(), User, Target);
                    break;
                }
                if (selection == 2)
                {
                    Console.WriteLine($"{User.Name} used Berserk Rage!");
                    UseAttack(BerserkRage(), User, Target);
                    User.HP -= 10;
                    Console.WriteLine($"{User.Name} lost 10 HP from recoil!");
                    break;
                }
                if (selection == 3)
                {
                    Console.WriteLine($"{User.Name} used Hex!");
                    UseAttack(Hex(), User, Target);
                    break;
                }
                if (selection == 4)
                {
                    Console.WriteLine($"{User.Name} used Wretched Curse!");
                    UseAttack(WretchedCurse(), User, Target);
                    Target.Strength -= 2;
                    Target.Hardiness -= 2;
                    Target.Agility -= 2;
                    Console.WriteLine($"{Target.Name}'s Strength was reduced by 2!");
                    Console.WriteLine($"{Target.Name}'s Hardiness was reduced by 2!");
                    Console.WriteLine($"{Target.Name}'s Agility was reduced by 2!");
                    break;
                }
                if (selection == 5)
                {
                    Console.WriteLine($"{User.Name} used Volley!");
                    UseAttack(Volley(), User, Target);
                    break;
                }
                if (selection == 6)
                {
                    Console.WriteLine($"{User.Name} used Rapid Fire!");
                    UseAttack(RapidFire(), User, Target);
                    break;
                }
            }
        }
    }

//******************************************* Combatant Classes *************************************************
    class Warrior : Combatant
    {
        public Warrior(string name)
        {
            Name = name;
            Title = "Warrior";
            HP = 100;
            Strength = 6;
            Hardiness = 7;
            Agility = 2;
        }
    }

    class Mage : Combatant
    {
        public Mage(string name)
        {
            Name = name;
            Title = "Mage";
            HP = 100;
            Strength = 6;
            Hardiness = 3;
            Agility = 6;
        }
    }

    class Ranger : Combatant
    {
        public Ranger(string name)
        {
            Name = name;
            Title = "Ranger";
            HP = 100;
            Strength = 5;
            Hardiness = 5;
            Agility = 5;
        }
    }
}