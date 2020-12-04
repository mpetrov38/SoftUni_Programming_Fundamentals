using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Heroes_of_Code_and_Logic_VII
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> heroHp = new Dictionary<string, int>();
            Dictionary<string, int> heroMp = new Dictionary<string, int>();
            int maxHp = 100;
            int maxMana = 200;
            for (int i = 0; i < n; i++)
            {
                string []input = Console.ReadLine().Split();
                string heroName = input[0];
                int hp = int.Parse(input[1]);
                int mp = int.Parse(input[2]);
                if (hp>maxHp)
                {
                    hp = maxHp;
                }
                if (mp>maxMana)
                {
                    mp = maxMana;
                }
                heroHp[heroName] = hp;
                heroMp[heroName] = mp;
            }
            string[] command = Console.ReadLine().Split(" - ");
            while (command[0]!="End")
            {
                string whatToDo = command[0];
                string heroName = command[1];
                if (whatToDo=="CastSpell")
                {
                    int mpNeeded = int.Parse(command[2]);
                    string spellName = command[3];
                    if (heroMp[heroName]>=mpNeeded)
                    {
                        heroMp[heroName] -= mpNeeded;
                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroMp[heroName]} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (whatToDo=="TakeDamage")
                {
                    int damage = int.Parse(command[2]);
                    string attacker = command[3];
                    heroHp[heroName] -= damage;
                    if (heroHp[heroName]>0)
                    {
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroHp[heroName]} HP left!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                        heroHp.Remove(heroName);
                        heroMp.Remove(heroName);
                    }

                }
                else if (whatToDo=="Recharge")
                {
                    int amount = int.Parse(command[2]);
                    int total = maxMana - heroMp[heroName];
                    if (heroMp[heroName]+amount>maxMana)
                    {
                        heroMp[heroName] = maxMana;
                        Console.WriteLine($"{heroName} recharged for {total} MP!");
                    }
                    else
                    {
                        heroMp[heroName] += amount;
                        Console.WriteLine($"{heroName} recharged for {amount} MP!");
                    }
                }
                else if (whatToDo=="Heal")
                {
                    int amount = int.Parse(command[2]);
                    int total = maxHp - heroHp[heroName];
                    if (heroHp[heroName]+amount>maxHp)
                    {
                        heroHp[heroName] = maxHp;
                        Console.WriteLine($"{heroName} healed for {total} HP!");
                    }
                    else
                    {
                        heroHp[heroName] += amount;
                        Console.WriteLine($"{heroName} healed for {amount} HP!");
                    }
                }
                
                command = Console.ReadLine().Split(" - ");
            }
            foreach (var item in heroHp.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                
                Console.WriteLine($"{item.Key}");
                Console.WriteLine($"  HP: {item.Value}");
                Console.WriteLine($"  MP: {heroMp[item.Key]}");
            }
            
        }
    }
}
