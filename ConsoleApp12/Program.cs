using System;
using System.Linq;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Loop
            //int i = 1;

            //while (i <= 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //Console.WriteLine(i);
            #endregion

            #region Odd
            //int m = 5;
            //int n = 10;
            //int result = 0;

            //for (int i = m; i <= n; i++)
            //{
            //    if (i % 2 == 1)
            //    {
            //        result = result + i;
            //    }
            //}

            //Console.WriteLine(result);
            #endregion

            #region Switch Case 
            //int n = 20;
            //int m = 5;
            //char process = '/';

            //switch (process)
            //{
            //    case '/': 
            //        Console.WriteLine(n / m); 
            //        break;
            //    case '*':
            //        Console.WriteLine(n * m);
            //        break;
            //    case '+':
            //        Console.WriteLine(n + m);
            //        break;
            //    case '-':
            //        Console.WriteLine(n - m);
            //        break;
            //    default:
            //        Console.WriteLine("Please enter again:");
            //        break;
            //}

            //if (process == '/')
            //{
            //    Console.WriteLine(n / m);
            //}

            //else if (process == '*')
            //{
            //    Console.WriteLine(n * m);
            //}

            //else if (process == '+')
            //{
            //    Console.WriteLine(n + m);
            //}

            //else if (process == '-')
            //{
            //    Console.WriteLine(n - m);
            //}

            //else
            //{
            //    Console.WriteLine("Please enter again");
            #endregion

            #region Array

            //int[] arr = new int[5] { 1, 2, 3, 4, 5 };

            //int[] arr = new int[5];

            //arr[0] = 5;
            //arr[1] = 1;
            //arr[2] = 8;
            //arr[3] = 98;
            //arr[4] = 7;

            //foreach (int item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //int[] arr = new int[] { 12, 24, 33 };
            //int sum = 0;
            //double result = 0;

            //foreach (int item in arr)
            //{
            //    sum += item;
            //}

            //result = sum / arr.Length;
            //Console.WriteLine(result);

            //int[] arr = new int[] { 12, 14, 15, 67 };
            //int max = arr[0];
            //int min = arr[0];

            //foreach (int item in arr)
            //{
            //    if (item > max)
            //        max = item;
            //    if (item < min)
            //        min = item;
            //}

            //Console.WriteLine(max + min);

            //int[] arr = new int[] { 1, 2, 3, 4, 5 };

            //Console.WriteLine(arr.Average());
            //Console.WriteLine(arr.Min());
            //Console.WriteLine(arr.Max());
            //Console.WriteLine(arr.Sum());
            //Array.Sort(arr);

            //foreach (int item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //bool isExist = arr.Contains(200);

            //Console.WriteLine(isExist);


            //string[] arr = new string[] { "Ramiz", "Abbasov" };

            //Array.Clear(arr, 0, 1);

            //foreach (string item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(arr.Rank);

            //Array.Reverse(arr);

            //foreach (string item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //string result = string.Join("-",arr);

            //Console.WriteLine(result);

            //Console.Read();

            #endregion

            #region String

            //string word = "Ramiz";
            //string word2 = "Abbasov";

            //Console.WriteLine(String.Concat(word,word2));

            //Console.WriteLine(String.Compare(word,word2));

            //Console.WriteLine(String.Equals(word,word2));

            //Console.WriteLine(String.Join(",", word, word2));

            //Console.WriteLine(word.Length);

            //Console.WriteLine(word.Contains("ye"));

            //Console.WriteLine(word2.LastIndexOf('a'));

            //Console.WriteLine($"My name is {word} and Surname is {word2}");

            //string word = "Hello";
            //char letter = 'l';
            //int count = 0;

            //foreach (char item in word)
            //{
            //    if (item == letter)
            //        count++;
            //}

            //Console.WriteLine(count);

            //Console.Read();


            //string[] names = new string[] { "Ramiz", "Abbasov", "Krypton" };
            //string maxLength = names[0];

            //foreach (string item in names)
            //{
            //    if (maxLength.Length < item.Length)
            //        maxLength = item;                    
            //}

            //Console.WriteLine(maxLength);

            //int[] numbers = new int[] { 1, 2, 43, 5, 67, 76 };
            //int maxNum = numbers[0];

            //foreach (int item in numbers)
            //{
            //    if (maxNum < item)
            //        maxNum = item;
            //}

            //Console.WriteLine(maxNum);

            //Console.Read();

            //string[] str = new string[] { "Ramiz", "Abbasov" };

            //foreach (string item in str)
            //{
            //    if (item.Contains("i"))
            //        Console.WriteLine(item);
            //}

            //Console.Read();

            //string[] str = new string[] { "Ramiz", "Abbasov" };
            //string letter = "a";

            //foreach (string item in str)
            //{
            //    if (item.ToLower().Contains(letter))
            //        Console.WriteLine(item);
            //}

            //Console.Read();

            #endregion

            #region Try-Catch

            //Console.Write("Enter a number:");
            //string num = Console.ReadLine();
            //bool loop = true;

            //while (loop)
            //{
            //    try
            //    {
            //        int result = int.Parse(num);
            //        Console.WriteLine($"Your result is {num}");
            //        loop = false;
            //    }
            //    catch (Exception)
            //    {
            //        Console.Write("Please enter again");
            //        num = Console.ReadLine();
            //    }
            //}

            //Console.Read();

            #endregion

        }
    }
}