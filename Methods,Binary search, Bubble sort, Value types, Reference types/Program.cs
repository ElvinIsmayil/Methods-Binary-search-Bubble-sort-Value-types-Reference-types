using System;

namespace Methods_Binary_search__Bubble_sort__Value_types__Reference_types
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Task1

            //  Bir int parametr qəbul edən və o ədədə qədər bütün cüt ədədlərin cəmini ekrana yazdıran,
            //  həm return type-ı olan bir method, həm də void bir method yazırsız


            // SumOfEvenNumbers2(10);

            // Console.WriteLine(SumOfEvenNumbers(25));

            





            static int SumOfEvenNumbers(int number)
            {
                int sum = 0;

                for (int i = 0; i < number; i++)
                {
                    if (i % 2 == 0)
                    {
                        sum += i;
                    }
                }
                return sum;
            }

            static void SumOfEvenNumbers2(int number)
            {
                int sum = 0;

                for (int i = 0; i < number; i++)
                {
                    if (i % 2 == 0)
                    {
                        sum += i;
                    }
                }
                Console.WriteLine(sum);
            }

            #endregion


            #region Task2

            // Parametr olaraq 1 string dəyər qəbul edən və həmin string dəyəri icində bosluqlar qalmayacaq hala gətirən metod.
            // Misal olaraq, name = "  Code  Acacemy   " deyə bir variable-mız varsa onu yaratdigimiz
            // metoda göndərdikdə variable-daki dəyər "CodeAcademy" olmalıdır.



            // RemoveSpace("   Code    Academy    ");


            static void RemoveSpace(string word)


            {
                char[] letters = new char[word.Length];

                for (int i = 0; i < word.Length; i++)
                {
                    char c = word[i];
                    letters[i] += c;
                }


                foreach (char letter in letters)
                {
                    if (letter == ' ')
                    {
                        continue;
                    }
                    Console.Write(letter);
                }


                





            }

            #endregion


        }

    }
}
