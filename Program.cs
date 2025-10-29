using System;

namespace Povrsina_Kruga_unos
{
    internal class Program
    {

        delegate string CalculateCircleAreaDelegate(double r);


        static void Main(string[] args)
        {

            CalculateCircleAreaDelegate calculateCircleArea = r =>
            {
                double PI = 3.14;
                double area = PI * (r * r);
                return $"Povrsina kruga je: {area}";
            };


            while (true)
            {
                Console.Write("Unesite radijus kruga: ");
                string unos = Console.ReadLine();
                double r;

                if (double.TryParse(unos, out r))
                {
                    string result = calculateCircleArea(r);
                    Console.WriteLine(result);
                }

                else
                {
                    Console.WriteLine("Nevalidan unos. Molimo Vas da unesete broj!");
                }

              
            }
        }
    }
}
