using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuicksortAlgoritm
{
    public class QuicksortTest
    {
        static void Main(string[] args)
        {
            int[] sizes = new int[] {10000, 100000, 1000000, 10000000, 100000000};/*{ 7,1024,2048,4096,8192,16384,32768 };*/ 
            var test = new QuicksortTest();
            for (int i = 0; i <= sizes.Length -1; i++)
            {
                var arrayLength = sizes[i];
                int[] arr = GenerateUnsortedArray(arrayLength);
                Console.WriteLine($"Created array of size {arrayLength}");
                Stopwatch stopW = Stopwatch.StartNew();
                Quicksort(arr, 0, arr.Length - 1);
                stopW.Stop();
                string timeElapsed = stopW.ElapsedMilliseconds.ToString();
                Console.WriteLine($"Quicksorted {arrayLength} items in {timeElapsed} ms\n");
            }
        }
        public static int[] GenerateUnsortedArray(int size)
        {
            Random rnd = new Random();
            int [] intArray = new int[size];
            for (int i = 0; i < size; i++)
            {
                intArray[i] = rnd.Next(size);
            }
            return intArray;
        }

        public static void Quicksort(int[] arr, int start, int stop)
        {
            //Sätt pivot till värdet av indexet i mitten av arrayen. 
            //På så sätt blir uppdelningen av värdeområdena optimal.
            int pivot = arr[(start + stop)/2];
            int startIndex = start;
            int stopIndex = stop;

            while (startIndex < stopIndex)
            {
                //är värdet på indexet mindre/högre än pivot på vänster/höger sida, 
                //låt den ligga kvar fortsätt till nästa index. Annars stanna på indexet.
                while ((arr[startIndex] < pivot) && (startIndex <= stopIndex))
                    startIndex++; //indikerar på att värdet är mindre än pivot fortsätt därför med nästa index.
                while ((arr[stopIndex] > pivot) && (stopIndex >= startIndex))
                    stopIndex--;

                if (startIndex < stopIndex) //så länge det finns ett område att söka av.
                {
                    //Växla de två värdena som ligger på fel plats.
                    int temp = arr[startIndex];
                    arr[startIndex] = arr[stopIndex];
                    arr[stopIndex] = temp;
                    if (arr[startIndex] == pivot && arr[stopIndex] == pivot)
                        startIndex++;
                }
            }
            if(start < startIndex - 1) //om det finns ett nytt område kör Quicksort på denna.
                Quicksort(arr, start, startIndex -1);
            if (stop > stopIndex + 1)
                Quicksort(arr, stopIndex + 1, stop);

        }
    }
}
//Medel = O(n log n) -> går igenom och gemför med varje värde i array = O(n) /för varje gång algo delar in områden i mindre delar = O(log n)
//Sämsta = O(n^2) -> om det sämsta pivot-värdet väljs konsekvent varenda gång. 