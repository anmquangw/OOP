using System;
namespace Lesson_22_02_2021 {
    class Ex_1 {
        public static string IsStudent() {
            Console.Write("Let me know you age: ");

            int age = int.Parse(Console.ReadLine());
            return age <= 6 ? "Chua den tuoi di hoc."
                : age <= 10 ? "La hoc sinh cap 1."
                : age <= 15 ? "La hoc sinh cap 2."
                : age <= 18 ? "La hoc sinh cap 3."
                : "Da hoc xong pho thong.";
        }
    }
}
