using System;
using System.Linq;
using System.Text;
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

            #region Methods
            //4, 5 == Argument
            //Console.WriteLine(Sum(4, 5));

            //Ramiz and Abbasov is argument
            //string result = Info("Ramiz", "Abbasov");
            //Console.WriteLine(result);

            //Void arguments: Ramiz and Abbasov
            //Detail("Ramiz", "Abbasov");

            //Default Value
            //Default("Ramiz");

            //Method overloading
            //Default("Ramiz", 17);

            //String array method
            //string[] str = { "Ramiz", "Abbasov" };
            //JoinString(str);

            //Params
            //Params("Ramiz", "Abbasov");

            //Console.Read();
            #endregion

            #region Ref, Out, Reference types, Value types, Heap and Stack memory
            //int a = 10;
            //int b = a; //b = 10
            //b = 100;

            //Console.WriteLine($"A = {a}");
            //Console.WriteLine($"B = {b}");

            //int[] array1 = { 100, 200, 300 };
            //int[] array2 = array1;
            //array1[0] = 1000;

            //Console.WriteLine($"Array-1 :{array1[0]}");
            //Console.WriteLine($"Array-2 :{array2[0]}");

            //int a = 10;
            //ChangeNum(a);
            //Console.WriteLine($"Deyisen = {a}");

            //int[] arr = { 10, 20, 30 };
            //Console.WriteLine($"Birinci cagirilan array: {arr[0]}");
            //ChangeIndex(arr);
            //Console.WriteLine($"Yuxarida cagirilan array: {arr[0]}");

            //A is going to change no matter it is a value type
            //int a = 10;
            //ChangeNumByRef(ref a);
            //Console.WriteLine($"Deyisen A = {a}");

            //int a;
            //ChangeNumByOut(out a);
            //Console.WriteLine($"Deyisen A = {a}");

            //string test = "123";
            //int result;
            //bool isParse = int.TryParse(test, out result);
            //Console.WriteLine($"Bool: {isParse}");
            //Console.WriteLine($"Result: {result}");

            //Console.Read();
            #endregion

            #region StringBuilder

            //string word = "Ramiz";
            //Console.WriteLine(Reverse(word));

            //StringBuilder str = new StringBuilder("Ramiz");
            //StringBuilder str2 = new StringBuilder("Abbasov");
            //bool result = StringBuilder.Equals(str, str2);
            //str.Insert(5, " ");
            //str.Append("Abbasov");
            //Console.WriteLine(str);
            //Console.WriteLine(result);
            //str.Clear();
            //Console.WriteLine(str);

            //Console.Read();
            #endregion

            #region HomeWork about methods
            //string[] arr = { "Ramiz", "Abbasov" };
            //Console.WriteLine(JoinString(arr));

            //string sentence = "Ramiz Abbasov";
            //Console.WriteLine(ReverseSentence(sentence));

            string[] arr1 = { "Ramiz", "Abbasov" };
            string[] arr2 = { "Ramiz", "Abbasov", "Krypton" };
            Console.WriteLine(SameWord(arr1, arr2));


            Console.Read();
            #endregion
        }

        static string[] SameWord(string[] arr1, string[] arr2)
        {
            string[] result = new string[0];

            foreach (string word1 in arr1)
            {
                foreach (string word2 in arr2)
                {
                    if(word1 == word2)
                    {
                        Array.Resize(ref result, result.Length + 1);
                        result[result.Length - 1] = word1;
                    }
                }
            }
            return result;
        }

        //static StringBuilder ReverseSentence(string sentence)
        //{

        //    StringBuilder result = new StringBuilder();
        //    string[] arr = sentence.Split(' ');

        //    foreach (var word in arr)
        //    {
        //        for (int i = word.Length - 1; i >= 0; i--)
        //        {
        //            result.Append(word[i]);
        //        }

        //        if (arr[arr.Length - 1] != word)
        //            result.Append(' ');
        //    }
            
        //    return result;
        //}

        //static StringBuilder JoinString(string[] arr)
        //{
        //    StringBuilder result = new StringBuilder();

        //    foreach (string item in arr)
        //    {
        //        result.Append(item);

        //        if (arr[arr.Length - 1] != item)
        //            result.Append(",");
        //    }

        //    return result;
        //}

        //static string Reverse(string str)
        //{
        //    string result = String.Empty;

        //    for (int i = str.Length-1; i >= 0; i--)
        //    {
        //        result += str[i];
        //    }

        //    return result;
        //}

        //Same thing with String, but in efficient way
        //static StringBuilder Reverse(string str)
        //{
        //    StringBuilder result = new StringBuilder();

        //    for (int i = str.Length - 1; i >= 0; i--)
        //    {
        //        result.Append(str[i]);
        //    }
        //    return result;
        //}

        //static void ChangeNumByOut(out int a)
        //{
        //    a = 100;
        //    Console.WriteLine($"A = {a}");
        //}

        //static void ChangeNumByRef(ref int a)
        //{
        //    a = 100;
        //    Console.WriteLine($"A = {a}");
        //}

        //static void ChangeIndex(int[] arr)
        //{
        //    arr[0] = 100;
        //    Console.WriteLine($"Methodun icindeki array: {arr[0]}");
        //}

        //static void ChangeNum(int a)
        //{
        //    a = 100;
        //    Console.WriteLine($"A = {a}");
        //} 

        //X, Y == Parametre
        //static int Sum(int x, int y)
        //{
        //    return x + y;
        //}

        //Name and Surname is parametre
        //static string Info(string name, string surname)
        //{
        //    return $"Name: {name} Surname: {surname}";
        //}

        //Void methods
        //static void Detail(string name, string surname)
        //{
        //    if (name == "Ramiz")
        //        Console.WriteLine($"Name: {name} Surname: {surname}");
        //    else
        //        Console.WriteLine("Ramiz deyil");
        //}

        //Default value
        //static void Default(string name, string surname = "Abbasov")
        //{
        //    Console.WriteLine($"Name: {name} Surname: {surname}");
        //}

        //Method signature :: Method name, Parametres, Parametres count, Datatypes
        //static void Default(string name, int age)
        //{
        //    Console.WriteLine($"Name: {name} Age: {age}");
        //}

        //Array method
        //static void JoinString(string[] arr)
        //{
        //    foreach (string item in arr)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}

        //Params keyword
        //static void Params(params string[] arr)
        //{
        //    foreach (string item in arr)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}


    }
}