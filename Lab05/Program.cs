/*
* Student ID : 1690703044
* Name       : เตชินท์ กรอบรัมบ์
* Section    : 129c
* No.        : 26
* Course     : GI113 Computer Programming (GI)
*/

namespace Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== RANGER BATTLE DAMAGE CALCULATOR ===");
            Console.WriteLine("Ranger vs Golem -- scouting the fight before it happens");

            Console.Write("Ranger HP: ");
            bool rangerHpOk = int.TryParse(Console.ReadLine(), out int rangerHp);

            Console.Write("Ranger Attack: ");
            bool rangerAttackOk = int.TryParse(Console.ReadLine(), out int rangerAttack);

            Console.Write("Ranger Defense: ");
            bool rangerDefenseOk = int.TryParse(Console.ReadLine(), out int rangerDefense);

            Console.Write("Golem HP: ");
            bool golemHpOk = int.TryParse(Console.ReadLine(), out int golemHp);

            Console.Write("Golem Attack: ");
            bool golemAttackOk = int.TryParse(Console.ReadLine(), out int golemAttack);

            Console.Write("Golem Defense: ");
            bool golemDefenseOk = int.TryParse(Console.ReadLine(), out int golemDefense);

            bool allStatsValid =
                rangerHpOk &&
                rangerAttackOk &&
                rangerDefenseOk &&
                golemHpOk &&
                golemAttackOk &&
                golemDefenseOk;

            Console.WriteLine($"All stats valid: {allStatsValid}");

            int golemMaxHp = golemHp;

            Console.WriteLine(
                $"[Ranger] HP:{rangerHp} ATK:{rangerAttack} DEF:{rangerDefense}"
            );

            Console.WriteLine(
                $"[Golem]  HP:{golemHp} ATK:{golemAttack} DEF:{golemDefense}"
            );

            // Ranger drinks a potion before scouting
            int potionHeal = 8;
            rangerHp += potionHeal;

            Console.WriteLine(
                $"Ranger drinks a potion, healing {potionHeal}. Ranger HP is now {rangerHp}."
            );

            // Normal attack damage
            int normalDamage = Math.Max(0, rangerAttack - golemDefense);

            Console.WriteLine(
                $"Normal Shot would deal: {normalDamage} damage"
            );

            // Power attack damage
            int powerDamage = Math.Max(0, rangerAttack * 2 - golemDefense);

            Console.WriteLine(
                $"Power Shot would deal: {powerDamage} damage"
            );

            // Golem counter damage
            int counterDamage = Math.Max(0, golemAttack - rangerDefense);

            Console.WriteLine(
                $"If Golem counters afterward, it would deal: {counterDamage} damage"
            );

            // Critical hit
            Random rng = new Random(14);

            int roll = rng.Next(1, 101);

            bool isCritical = roll <= 10;

            int criticalDamage =
                normalDamage +
                Convert.ToInt32(isCritical) * normalDamage;

            Console.WriteLine(
                $"Critical shot roll: {roll} (critical: {isCritical})"
            );

            Console.WriteLine(
                $"If critical, Normal Shot would instead deal: {criticalDamage} damage"
            );

            // Battle comparison
            bool rangerHitsHarder = rangerAttack > golemAttack;

            bool canDefeatWithNormal = normalDamage >= golemHp;

            bool golemCanDefeatRanger = counterDamage >= rangerHp;

            bool safeTrade =
                normalDamage > counterDamage &&
                !golemCanDefeatRanger;

            bool luckyOrLethal =
                isCritical ||
                canDefeatWithNormal;

            Console.WriteLine(
                $"Ranger attack is higher than Golem: {rangerHitsHarder}"
            );

            Console.WriteLine(
                $"Normal Shot can defeat Golem in one hit: {canDefeatWithNormal}"
            );

            Console.WriteLine(
                $"Golem could defeat Ranger in one hit back: {golemCanDefeatRanger}"
            );

            Console.WriteLine(
                $"This is a safe trade for Ranger: {safeTrade}"
            );

            Console.WriteLine(
                $"This attack is lucky or lethal: {luckyOrLethal}"
            );

            // Ranger performs the normal attack
            golemHp -= normalDamage;

            Console.WriteLine(
                $"Ranger attacks! Golem HP: {golemHp}/{golemMaxHp}"
            );

            // Final result and reward
            bool golemDefeated = golemHp <= 0;

            int goldEarned =
                (golemMaxHp - golemHp) * 2;

            Console.WriteLine($"Golem defeated: {golemDefeated}");
            Console.WriteLine($"Gold earned: {goldEarned}");
        }
    }
}
