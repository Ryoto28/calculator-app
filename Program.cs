using System;

namespace praktikumcalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double num1 = 0;
                double num2 = 0;
                double result = 0;

                Console.WriteLine("------------------");
                Console.WriteLine("Program Kalkulator");
                Console.WriteLine("------------------");

                Console.Write("Masukkan angka 1: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter number 2: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Opsi pilihan dalam program kalkulator: ");
                Console.WriteLine("\t+ : Penjumlahan");
                Console.WriteLine("\t- : Pengurangan");
                Console.WriteLine("\t* : Perkalian");
                Console.WriteLine("\t/ : Pembagian");
                Console.Write("Masukkan nomor opsi pilihan: ");


                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Hasil adalah: {num1} + {num2} = " + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Hasil adalah: {num1} - {num2} = " + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Hasil adalah: {num1} * {num2} = " + result);
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"Hasil adalah: {num1} / {num2} = " + result);
                        break;
                    default:
                        Console.WriteLine("Tidak terdapat opsi pilihan tersebut");
                        break;
                }
                Console.Write("Apakah anda ingin mengulanginya lagi? (Y = Yes, N = No): ");
            } while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("Terima Kasih!");
            Console.ReadKey();
        }
    }
}
