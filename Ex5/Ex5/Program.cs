using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Encoding encoding = Encoding.GetEncoding(1251);
            StreamReader streamReader = new StreamReader("Input.txt", encoding); //Скорее всего компилятор будет ругаться на то, что не нашел файл

            string text = streamReader.ReadLine(); // Тут ты считываешь только одну строку
            
            streamReader.Close();

            string shiftAsText = Console.ReadLine();
            int shift = Convert.ToInt32(shiftAsText); // Int32 всегда можно заменить на int при простейших операциях
            string result = string.Empty;

            for (int i = 0; i < text.Length; i++) // А как будет шифроваться буква 'Я'? По идее буквой 'В' при сдвиге 3 шага
            {
                result += (char)(text[i] + shift); // Но тут не учтено условие (char)(text[i]+shift) > 'Я'. Погугли формулы, решение простое
            }

            StreamWriter streamWriter = new StreamWriter("Output.txt", false, encoding);

            streamWriter.WriteLine("Шифровка: " + result);

            string result2 = string.Empty;

            for (int i = 0; i < result.Length; i++)
            {
                result2 += (char)(result[i] - shift);
            }

            streamWriter.WriteLine("Дешифровка: " + result2);
            streamWriter.Close();
        }
    }
}
