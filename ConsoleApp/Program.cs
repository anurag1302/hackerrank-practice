namespace ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Hamming Distance Problem
            var str1 = "abcde";
            var str2 = "abcde";
            var count = 0;

            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] != str2[i])
                {
                    count++;
                }
            }
            Console.WriteLine(count);

            //Multipy by length problem
            int[] arr = { 2, 3, 1, 0 };
            var length = arr.Length;
            for (int i = 0; i < length; i++)
            {
                arr[i] = arr[i] * length;
            }
            Console.WriteLine(arr);

            //Absolute sum problem
            int[] arr1 = { 2, -1, 4, 8, 10 };
            var sum = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                sum = sum + Math.Abs(arr1[i]);
            }
            //via LINQ
            var sum1 = arr1.Sum(x => Math.Abs(x));
            Console.WriteLine(sum);
            Console.WriteLine(sum1);

            //Array of Multiples
            var num = 12;
            var length1 = 10;
            int[] arr2 = new int[length1];
            for (int i = 0; i < length1; i++)
            {
                arr2[i] = num * (i + 1);
            }
            Console.WriteLine(arr2);
            char c1 = (char)1;
            char abc = 'A';
            var abcd = ((int)'D').ToString();
            Console.WriteLine(abcd);

            Console.WriteLine(c1);

            var input = "Honesty is the best policy";
            //var arr = input.ToCharArray();
            var splittedArray = input.Split(' ');
            var reverseArry = new string[splittedArray.Length];
            //Array.Reverse(splittedArray);
            var str = string.Join(" ", splittedArray);

            //for (int i = splittedArray.Length - 1; i >= 0; i--)
            //{
            //    var temp = splittedArray[i];
            //    reverseArry[i] = temp;
            //}
            Console.WriteLine(str);
            //Console.WriteLine(reverseArry.Join(" "));

            for (int i = 0; i < splittedArray.Length; i++)
            {
                reverseArry[splittedArray.Length - i - 1] = splittedArray[i];
            }
            var str23 = string.Join(" ", reverseArry);
            Console.WriteLine(str23);

            var counter = 5;
            for (int i = 0; i < counter; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("\n");
            }
            for (int i = counter - 1; i > 0; i--)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("******************************");
            //reverse
            int[] array1 = { 23, 21, 45, 32, 99, 99, 45, 45, 23 };
            int[] array2 = new int[array1.Length];
            for (int i = array1.Length - 1; i >= 0; i--)
            {
                Console.Write(array1[i] + "\t");
            }
            Console.WriteLine();
            var sum2 = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                sum2 += array1[i];
            }
            Console.WriteLine(sum2);
            var sum3 = array1.Sum(x => x);
            Console.WriteLine(sum3);
            for (int i = 0; i < array1.Length; i++)
            {
                array2[i] = array1[i];
            }

            //Duplicates using LINQ
            var duplicates = array1
                .GroupBy(x => x)
                .Select(y => new
                {
                    num = y.Key,
                    count = y.Count()
                }).ToList();

            var maxCount = duplicates
                .Max(x => x.count);

            var maxNum = duplicates
                .Where(x => x.count == maxCount)
                .FirstOrDefault().num;

            // Duplicates using Dictionary
            var dictionary = new Dictionary<int, int>();//key - number, value - count

            for (int i = 0; i < array1.Length; i++)
            {
                if (dictionary.ContainsKey(array1[i]))
                {
                    dictionary[array1[i]]++;
                }
                else
                {
                    dictionary.Add(array1[i], 1);
                }
            }

            var maxCounter = dictionary.Max(x => x.Value);
            var maxNumber = dictionary.Where(x => x.Value == maxCount).FirstOrDefault().Key;

            //Unique Elements
            foreach (var item in dictionary)
            {
                if (item.Value == 1)
                {
                    Console.WriteLine("Unique Items - " + item.Key);
                }
            }

            //Merge 2 arrays of same length and return a sorted array
            int[] arr11 = { 1, 2, 3 };
            int[] arr12 = { 1, 2, 3 };
            int[] arr13 = new int[arr11.Length + arr12.Length];
            int a, b;
            for (a = 0; a < arr11.Length; a++)
            {
                arr13[a] = arr11[a];
            }
            for (b = 0; b < arr12.Length; b++)
            {
                arr13[a] = arr12[b];
                a++;
            }
            //Array.Sort(arr13);

            //Sort using 2 loops
            for (int i = 0; i < arr13.Length; i++)
            {
                for (int j = 0; j < arr13.Length - 1; j++)
                {
                    if (arr13[j] >= arr13[j + 1])
                    {
                        var temp = arr13[j];
                        arr13[j] = arr13[j + 1];
                        arr13[j + 1] = temp;
                    }
                }
            }
            for (int k = 0; k < arr13.Length; k++)
            {
                Console.WriteLine(arr13[k]);
            }

            int max = array1[0];
            int minm = array1[0];

            for (int i = 1; i < array1.Length; i++)
            {
                if (array1[i] > max)
                {
                    max = array1[i];
                }
                if (array1[i] < minm)
                {
                    minm = array1[i];
                }
            }

            Console.WriteLine($"Max: {max}, Min: {minm}");
            Console.ReadLine();
        }
    }
}