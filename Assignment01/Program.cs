/*
* Student ID : 1690703044
* Name       : เตชินท์ กรอบรัมบ์
* Section    : 129c
* No.        : 26
* Course     : GI113 Computer Programming (GI)
*/

namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string ChampionTitle = "The Unforgiven";

            var championName = "Yasuo";
            var signatureSkill = "Steel Tempest";

            int health = 590;
            char skillKey = 'Q';
            float attackSpeed = 0.697f;
            double healthRegen = 6.5;
            bool isManaless = true;

            Console.WriteLine("========================================");
            Console.WriteLine("          LEAGUE OF LEGENDS");
            Console.WriteLine("========================================");
            Console.WriteLine($"Champion        : {championName}");
            Console.WriteLine($"Title           : {ChampionTitle}");
            Console.WriteLine($"Signature Skill : {signatureSkill}");
            Console.WriteLine($"Skill Key       : {skillKey}");
            Console.WriteLine($"Health          : {health}");
            Console.WriteLine($"Attack Speed    : {attackSpeed}");
            Console.WriteLine($"Health Regen    : {healthRegen}");
            Console.WriteLine($"Manaless        : {isManaless}");
            Console.WriteLine("========================================");

            double healthAsDouble = health;

            Console.WriteLine();
            Console.WriteLine("=== TYPE CONVERSION ===");
            Console.WriteLine($"Health as double (implicit): {healthAsDouble}");

            int regenTruncated = (int)healthRegen;
            int regenRounded = Convert.ToInt32(healthRegen);

            Console.WriteLine($"Health Regen cast (truncates): {regenTruncated}");

            Console.WriteLine($"Health Regen Convert (rounds): {regenRounded}");

            Console.ReadLine();
        }
    }
}
