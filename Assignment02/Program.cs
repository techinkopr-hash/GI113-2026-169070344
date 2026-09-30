/*
* Student ID : 1690703044
* Name       : เตชินท์ กรอบรัมบ์
* Section    : 129c
* No.        : 26
* Course     : GI113 Computer Programming (GI)
*/

namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string MaterialName = "Crystal";
            const double SmeltRate = 0.20;
            const double SalvageRate = 0.35;
            const double MaxBatch = 300;

            Console.WriteLine("========================================");
            Console.WriteLine("          C R Y S T A L   F O R G E");
            Console.WriteLine("========================================");
            Console.WriteLine($"Material     : {MaterialName}");
            Console.WriteLine($"Smelt Rate   : {SmeltRate:F2}");
            Console.WriteLine($"Salvage Rate : {SalvageRate:F2}");
            Console.WriteLine($"Max Batch    : {MaxBatch:F2}");
            Console.WriteLine();
            Console.WriteLine("[S] Smelt       Crystal Ore -> Crystal Core");
            Console.WriteLine("[B] Breakdown   Crystal Core -> Crystal Ore");
            Console.WriteLine();

            Console.Write("Choose Menu: ");
            bool menuOk = char.TryParse(Console.ReadLine(),out char menu);

            Console.Write("How much would you like: ");
            bool amountOk = double.TryParse(Console.ReadLine(),out double amount);

            if (amountOk && amount > 0 && amount <= MaxBatch)
            {
                if (menuOk && (menu == 'S' || menu == 's'))
                {
                    double result = amount * SmeltRate;

                    Console.WriteLine($"=> {amount:F2} {MaterialName} Ore = {result:F2} {MaterialName} Core");
                }
                else if (menuOk && (menu == 'B' || menu == 'b'))
                {
                    double result = amount / SalvageRate;

                    Console.WriteLine($"=> {amount:F2} {MaterialName} Core = {result:F2} {MaterialName} Ore");
                }
                else
                {
                    Console.WriteLine("Error: invalid menu.");
                }
            }
            else
            {
                Console.WriteLine("Error: invalid amount.");
            }

            Console.ReadLine();
        }
    }
}
