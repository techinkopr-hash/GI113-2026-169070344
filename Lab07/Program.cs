/*
* Student ID : 1690703044
* Name       : เตชินท์ กรอบรัมบ์
* Section    : 129c
* No.        : 26
* Course     : GI113 Computer Programming (GI)
*/

namespace Lab07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MonsterHp = 10;

            Console.Write("Monster Defense: ");
            int.TryParse(Console.ReadLine(), out int monsterDefense);

            Console.WriteLine(
                $"A Shadow Bandit appears! HP {MonsterHp}, DEF {monsterDefense}"
            );

            Console.WriteLine();
            Console.WriteLine("=== MARTIAL ARTS COMMAND ===");
            Console.WriteLine("1) Sword Slash");
            Console.WriteLine("2) Flame Technique");
            Console.WriteLine("3) Guard");
            Console.WriteLine("4) Retreat");
            Console.WriteLine("5) Dragon Palm");

            Console.Write("Choose (1-5): ");
            int.TryParse(Console.ReadLine(), out int command);

            switch (command)
            {
                case 1:
                    Console.WriteLine("The swordsman unleashes a Sword Slash!");
                    break;

                case 2:
                    Console.WriteLine("The martial artist summons a Flame Technique!");
                    break;

                case 3:
                    Console.WriteLine("The martial artist raises a guard.");
                    break;

                case 4:
                    Console.WriteLine("The martial artist prepares to retreat.");
                    break;

                case 5:
                    Console.WriteLine("The martial artist releases Dragon Palm!");
                    break;

                default:
                    Console.WriteLine("The martial artist hesitates. Invalid command!");
                    break;
            }

            int power = command switch
            {
                1 => 12,
                2 => 18,
                5 => 25,
                _ => 0
            };

            int damage = Math.Max(0, power - monsterDefense);

            Console.WriteLine($"Damage: {damage}");

            string rating = damage switch
            {
                >= 12 => "Critical strike!",
                >= 5 => "Solid strike.",
                > 0 => "Light strike.",
                _ => "No damage."
            };

            Console.WriteLine($"Rating: {rating}");

            string monsterStatus =
                damage >= MonsterHp ? "DEFEATED" : "still standing";

            Console.WriteLine($"Shadow Bandit: {monsterStatus}");

            Console.Write("Really retreat? (y/n): ");
            string answer = Console.ReadLine();

            switch (answer)
            {
                case "y":
                case "Y":
                    Console.WriteLine("You retreat from the battlefield!");
                    break;

                case "n":
                case "N":
                    Console.WriteLine("You remain in the martial arts battle.");
                    break;

                default:
                    Console.WriteLine("Please type y or n.");
                    break;
            }

            Console.ReadLine();
        }
    }
}
