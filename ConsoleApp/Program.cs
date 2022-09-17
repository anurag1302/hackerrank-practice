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

            Console.ReadLine();
        }
    }
}