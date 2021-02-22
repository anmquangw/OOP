using System;
namespace Lesson_22_02_2021 {
    class Ex_3 {
		public static string LuckyNum() {
			Random random = new Random();

			int num = random.Next(minValue: -1000, maxValue: 1000);
			Console.Write("Can you lucky: ");

			int n = int.Parse(Console.ReadLine());
			return (num > n
			? "You lose!"
			: "You win. Congratulation !")+ "\n" + num;
		}
	}
}
