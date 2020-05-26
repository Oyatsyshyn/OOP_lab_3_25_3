using System;
using System.IO;

namespace OOP_lab_3_25_3
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader file = new StreamReader("input.txt");

            StreamWriter newFile = File.CreateText("output.txt");

            string sentence = file.ReadToEnd();

            string[] words = sentence.Split(new char[] { '\n', '\r', ' ', ':', ';', '.', ',', '?', '!', '(', ')', '{', '}', '[', ']', '@', '#', '№', '$', '^', '%', '&', '*', '/', '|' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; ++i)
            {
                int k = words[i].Length;
                for (int j = 0; j < words[i].Length; ++j)
                {
                    if ((words[i][j] == 'A') || (words[i][j] == 'E') || (words[i][j] == 'I') || (words[i][j] == 'O') || (words[i][j] == 'U') || (words[i][j] == 'Y')) --k;
                    if ((words[i][j] == 'a') || (words[i][j] == 'e') || (words[i][j] == 'i') || (words[i][j] == 'o') || (words[i][j] == 'u') || (words[i][j] == 'y')) --k;
                    if ((words[i][j] == 'А') || (words[i][j] == 'О') || (words[i][j] == 'У') || (words[i][j] == 'И') || (words[i][j] == 'І') || (words[i][j] == 'Е') || (words[i][j] == 'Я') || (words[i][j] == 'Ю') || (words[i][j] == 'Є') || (words[i][j] == 'Ї')) --k;
                    if ((words[i][j] == 'а') || (words[i][j] == 'о') || (words[i][j] == 'у') || (words[i][j] == 'и') || (words[i][j] == 'і') || (words[i][j] == 'е') || (words[i][j] == 'я') || (words[i][j] == 'ю') || (words[i][j] == 'є') || (words[i][j] == 'ї')) --k;
                }
                if (k % 2 != 0)
                {
                    newFile.WriteLine(words[i]);
                }
            }

            newFile.Close();
        }
    }
}
