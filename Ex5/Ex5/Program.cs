﻿using System;
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
            StreamReader streamReader = new StreamReader("Input.txt", encoding);

            string text = streamReader.ReadLine();

            streamReader.Close();

            string shiftAsText = Console.ReadLine();
            int shift = Convert.ToInt32(shiftAsText);
            string result = string.Empty;

            for (int i = 0; i < text.Length; i++)
            {
                result += (char)(text[i] + shift);
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
