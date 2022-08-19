using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma_Sorulari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PrintEvenNumbers();
            //EquallyOrExactlyDivisible();
            //PrintReverse();
            PrintWordsAndLetterCount();
        }

        static void PrintEvenNumbers()
        {
            Console.WriteLine("Lütfen pozitif bir tam sayı giriniz.");
            int pozitif = int.Parse(Console.ReadLine());
            if (pozitif == 0)
            {
                Console.WriteLine("Girdiğiniz değer 0 olamaz!");
                pozitif = int.Parse(Console.ReadLine());
            }
            else if (pozitif < 0)
            {
                Console.WriteLine("Girdiğiniz değer negatif olamaz!");
                pozitif = int.Parse(Console.ReadLine());
            }
            int[] pozitifler = new int[pozitif];
            for (int i = 0; i < pozitif; i++)
            {
                Console.WriteLine("Lütfen {0}. pozitif tam sayıyı giriniz.", i + 1);
                pozitifler[i] = int.Parse(Console.ReadLine());
                if (pozitifler[i] == 0)
                {
                    Console.WriteLine("Girdiğiniz değer 0 olamaz!");
                    pozitifler[i] = int.Parse(Console.ReadLine());
                }
                else if (pozitifler[i] < 0)
                {
                    Console.WriteLine("Girdiğiniz değer negatif olamaz!");
                    pozitifler[i] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("******************* Çift sayılar *****************");
            foreach (int sayi in pozitifler)
            {
                if (sayi % 2 == 0)
                {
                    Console.WriteLine(sayi);
                }
            }
        }

        static void EquallyOrExactlyDivisible()
        {
            uint[] positives = new uint[2];
            uint[] numbers = null;
            bool check = true;
            bool checktwo = true;
            do
            {
                check = true;
                Console.WriteLine("Lütfen aralarında boşluk olacak şekilde pozitif 2 tam sayı giriniz.");
                try
                {
                    positives = Console.ReadLine().TrimEnd().Split(' ').ToArray().Select(uint.Parse).ToArray();
                    foreach (uint i in positives)
                    {
                        if(i == 0)
                        {
                            Console.WriteLine("Dikkat, 0 girdiniz!");
                            
                            check = false;
                        }
                    }
                }
                catch (Exception e )
                {
                    Console.WriteLine("Dikkat, negatif bir değer girdiniz!");
                    
                    check = false;
                }

            }while (!check);


            do
            {
                checktwo = true;
                Console.WriteLine("Lütfen aralarında boşluk olacak şekilde {0} tane pozitif tam sayı giriniz.", positives[0]);
                try
                {
                    numbers = Console.ReadLine().TrimEnd().Split(' ').ToArray().Select(uint.Parse).ToArray();
                    foreach(uint num in numbers)
                    {
                        if(num == 0)
                        {
                            Console.WriteLine("Dikkat, 0 girdiniz!");

                            checktwo = false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Dikkat, negatiif bir değer girdiniz!");
                    checktwo = false;
                }
            } while (!checktwo);

            foreach (uint sa in numbers)
            {
                if(sa == positives[1] || sa % positives[1] == 0)
                {
                    Console.WriteLine(sa);
                }
            }
        }

        static void PrintReverse()
        {
            uint positive = 1;
            bool check = true;
            do
            {
                check = true;
                Console.WriteLine("Lütfen pozitif bir tam sayı giriniz.");

                try
                {
                    positive = uint.Parse(Console.ReadLine());
                    if(positive == 0)
                    {
                        Console.WriteLine("Dikkat, 0 girdiniz!");
                        check = false;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Dikkat, negatif sayı girdiniz!");
                    check = false;
                }

            } while (!check);

            string[] words = new string[positive];
            for(int i = 0; i < positive; i++)
            {
                Console.WriteLine("Lütfen {0}. kelimeyi giriniz.",i+1);
                words[i] = Console.ReadLine();
            }

            for (int j = words.Length-1; j >= 0; j--)
            {
                if(j == 0)
                {
                    Console.Write(words[j]);
                }
                else
                {
                    Console.Write(words[j]+" ");
                }
            }

        }

        static void PrintWordsAndLetterCount()
        {
            Console.WriteLine("Lütfen bir cümle giriniz.");
            string sentence = Console.ReadLine();
            string[] strings = sentence.Split(' ').ToArray();
            int sumWords = 0;
            int sumLetters = 0;
            string liste = "aAbBCcÇçDdEeFfGgĞğHhIıİiJjKkLlMmNnOoÖöPpRrSsŞşTtUuÜüVvYyZzXxWwQq";
            foreach (string word in strings)
            {
                sumWords++;
            }

            foreach (string wo in strings)
            {
                for(int i = 0; i < wo.Length; i++)
                {
                    if (liste.Contains(wo[i]))
                    {
                        sumLetters++;
                    }

                }
            }

            Console.WriteLine("Toplam kelime sayısı: "+sumWords);
            Console.WriteLine("Toplam harf sayısı: "+sumLetters);
        }
    }
}
