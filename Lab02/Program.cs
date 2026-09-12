/*
* Student ID : 1690703044
* Name       :  เตชินท์ กรอบรัมบ์
* Section    : 129c
* No.        :  26
 * Course     : GI113 Computer Programming (GI)
*/

namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level:{level}");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Critical Multiplier: {critMultiplier}");
            Console.WriteLine($"Is Boss: {isBoss}");
            Console.WriteLine();

            int hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");
            Console.WriteLine();
            Console.WriteLine("Kirin takes 60 damage!");
            currentHp -= 60;
            Console.WriteLine();
            Console.WriteLine($"===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");

            Console.WriteLine();
            Console.WriteLine("===== PART B : MY RPG CHARACTERS =====");
            Console.WriteLine();


            // ===== Knight =====
            string knightName = "Arthur";
            int knightLevel = 13;
            int knightHp = 350;
            float knightAttack = 51.2f;
            float knightDefense = 91.5f;
            bool knightIsTank = true;

            Console.WriteLine("KNIGHT");
            Console.WriteLine($"Name: {knightName}");
            Console.WriteLine($"Level: {knightLevel}");
            Console.WriteLine($"HP: {knightHp}");
            Console.WriteLine($"Attack Power: {knightAttack}");
            Console.WriteLine($"Defense: {knightDefense}");
            Console.WriteLine($"Is Tank: {knightIsTank}");
            Console.WriteLine();


            // ===== Mage =====
            string mageName = "Luna";
            int mageLevel = 16;
            int mageHp = 220;
            float mageMagic = 88.5f;
            double mageCrit = 2.30;
            bool mageIsBoss = false;

            Console.WriteLine("MAGE");
            Console.WriteLine($"Name: {mageName}");
            Console.WriteLine($"Level: {mageLevel}");
            Console.WriteLine($"HP: {mageHp}");
            Console.WriteLine($"Magic Power: {mageMagic}");
            Console.WriteLine($"Critical Multiplier: {mageCrit}");
            Console.WriteLine($"Is Boss: {mageIsBoss}");
            Console.WriteLine();


            // ===== Archer =====
            string archerName = "Elric";
            int archerLevel = 12;
            int archerHp = 230;
            float archerSpeed = 41.6f;
            char archerRank = 'B';
            bool archerIsHasPet = false;

            Console.WriteLine("ARCHER");
            Console.WriteLine($"Name: {archerName}");
            Console.WriteLine($"Level: {archerLevel}");
            Console.WriteLine($"HP: {archerHp}");
            Console.WriteLine($"Speed: {archerSpeed}");
            Console.WriteLine($"Rank: {archerRank}");
            Console.WriteLine($"Has Pet: {archerIsHasPet}");
            Console.WriteLine();


            // ===== Assassin =====
            string assassinName = "Shade";
            int assassinLevel = 17;
            int assassinHp = 190;
            float assassinAttack = 59.8f;
            double assassinCrit = 2.60;
            bool assassinIsStealth = true;

            Console.WriteLine("ASSASSIN");
            Console.WriteLine($"Name: {assassinName}");
            Console.WriteLine($"Level: {assassinLevel}");
            Console.WriteLine($"HP: {assassinHp}");
            Console.WriteLine($"Attack Power: {assassinAttack}");
            Console.WriteLine($"Critical Multiplier: {assassinCrit}");
            Console.WriteLine($"Is Stealth: {assassinIsStealth}");
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}