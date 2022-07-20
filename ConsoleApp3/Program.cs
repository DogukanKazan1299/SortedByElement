using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] array = new int[] { 4, 13, 8, 9, 7, 1, 6 };
            int[] array = new int[] { 16, 23, 7, 11, 3, 14 };
            newSort(array);

        }

        public static int[] newSort(int[] array)
        {
            Array.Sort(array);
            Array.Reverse(array);

            int[] newArray= new int[array.Length];

            int k = 0;
            int length = array.Length - 1;

            for(int i=0; i<array.Length; i = i + 2, k++)
            {
                newArray[k] = array[i];
            }

            for(int j=1; j<array.Length; j = j + 2, length--)
            {
                if (newArray[length] == 0)
                    newArray[length] = array[j];
            }
            return newArray;
        }
    }
}
