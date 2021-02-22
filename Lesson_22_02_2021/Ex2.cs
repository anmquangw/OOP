using System;

namespace Lesson_22_02_2021 {
    class Ex_2 {
        public static string IsLength() {
            Console.Write("Give Me Your String: ");
            string s = Console.ReadLine();

			return s.Length > 25
            ? "Chieu dai cua chuoi phai < 25 ky tu."
            : "Ban da nhap dung roi.";
        }
    }
}
