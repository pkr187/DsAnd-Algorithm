namespace DsAndAlgorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Select Programs \n2.Binary search \n3.Insertion sort\n4.Bubble sort  \n6.Check string is Anagram \n7.Print prime number 0-1000 \n8. Check Prime number is Anagram and Palindrome");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 2:
                        BinarySearch binarysearch = new BinarySearch();
                        binarysearch.Search(@"C:\Users\Lenovo\Desktop\Bridgelabz\DsAndAlgorithm\DsAndAlgorithm\Word.txt");
                        break;
                }
            }
        }
    }
}