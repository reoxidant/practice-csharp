using System;

namespace bystryj_kurs
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Я хочу изучать C#");
            Console.ReadLine();

			String a = Console.ReadLine();
			String b = Console.ReadLine();

			int num1 = int.Parse(a);
			int num2 = int.Parse(b);

			int result = num1 + num2;
			Console.WriteLine(result);
			result = num1 * num2;
			Console.WriteLine(result);

			double avegare = (num1 + num2) / 2;
			Console.WriteLine(avegare);
			Console.ReadLine();
		}
    }
}
