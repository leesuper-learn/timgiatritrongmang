using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timgiatritrongmang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] name_student = new string[10];
            name_student[0] = "Christian";
            name_student[1] = "Michael";
            name_student[2] = "Camila";
            name_student[3] = "Sienna";
            name_student[4] = "Tanya";
            name_student[5] = "Tanya";
            name_student[6] = "Zachariah";
            name_student[7] = "Mallory";
            name_student[8] = "Zoe";
            name_student[9] = "Emily";
            Console.Write("Nhap ten hoc sinh: ");
            string input_name = Console.ReadLine();
            bool check = false;
            for (int i = 0; i < name_student.Length; i++)
            {
                if (name_student[i].Equals(input_name))
                {
                    Console.WriteLine((i + 1) + ". " + input_name);
                    check = true;
                    break;
                }
            }
            if (!check)
            {
                Console.WriteLine(input_name + "khong co trong danh sach.");
            }
            Console.ReadKey();
        }
    }
}
