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
            Console.ReadLine();
        }
    }
}