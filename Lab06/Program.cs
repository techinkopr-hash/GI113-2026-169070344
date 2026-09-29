/*
* Student ID : 1690703044
* Name       : เตชินท์ กรอบรัมบ์
* Section    : 129c
* No.        : 26
* Course     : GI113 Computer Programming (GI)
*/

namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== JIANGHU DUEL ===");
            Console.WriteLine("A martial artist enters a deadly duel.");
            Console.WriteLine();

            int swordsmanHp = 120;
            int rivalHp = 100;
            int swordDamage = 30;
            int qiPower = 45;

            Console.WriteLine($"Swordsman HP: {swordsmanHp}");
            Console.WriteLine($"Rival HP: {rivalHp}");
            Console.WriteLine();

            Console.WriteLine("[A] Sword Strike");
            Console.WriteLine("[D] Defend");
            Console.WriteLine("[Q] Qi Technique");
            Console.WriteLine();

            Console.Write("Choose your move: ");
            bool moveOk = char.TryParse(Console.ReadLine(), out char move);

            if (!moveOk)
            {
                Console.WriteLine("Invalid move. Please choose A, D or Q.");
            }
            else if (move == 'A' || move == 'a')
            {
                rivalHp -= swordDamage;

                Console.WriteLine(
                    $"Sword Strike deals {swordDamage} damage."
                );

                Console.WriteLine(
                    $"Rival HP is now {rivalHp}."
                );

                if (rivalHp <= 0)
                {
                    Console.WriteLine("The rival falls before your sword!");
                }
                else
                {
                    Console.WriteLine("The rival remains standing.");
                }
            }
            else if (move == 'D' || move == 'd')
            {
                swordsmanHp -= 10;

                Console.WriteLine(
                    "You raise your sword and take a defensive stance."
                );

                Console.WriteLine(
                    "The rival's attack is partially blocked."
                );

                Console.WriteLine(
                    $"Swordsman HP is now {swordsmanHp}."
                );
            }
            else if (move == 'Q' || move == 'q')
            {
                rivalHp -= qiPower;

                Console.WriteLine(
                    $"You unleash your Qi Technique for {qiPower} damage."
                );

                Console.WriteLine(
                    $"Rival HP is now {rivalHp}."
                );

                if (rivalHp <= 0)
                {
                    Console.WriteLine(
                        "Your Qi Technique has defeated the rival!"
                    );
                }
                else
                {
                    Console.WriteLine(
                        "The rival survives the Qi Technique."
                    );
                }
            }
            else
            {
                Console.WriteLine(
                    "Invalid move. Please choose A, D or Q."
                );
            }

            Console.WriteLine();
            Console.WriteLine("=== DUEL ENDS ===");
        }
    }
}
