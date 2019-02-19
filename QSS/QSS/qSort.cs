using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QSS
{
    class qSort
    {
        //Global variables
        static int[] array;

        /// <summary>
        /// Sorts an array ascendingly.
        /// </summary>
        // algo: Get a pivot from the array and make 2 counters.  
        // Start searching for numbers greater than and smaller than the pivot with the counters.
        // If there are 2 numbers found swap them, if the counters crossed eachother do nothing.
        public static int[] quicksort(int[] unsorted_array)
        {
            array = unsorted_array;
            recursiveSort(0, array.Length - 1);
            return array;
        }

        static void recursiveSort(int beginNumber, int endNumber)
        {
            //Stop check, if beginNumber is smaller than endNumber execute the code.
            if (beginNumber < endNumber)
            {
                //Pivot
                int p = array[beginNumber];
                //Greater than counter
                int gt = beginNumber + 1;
                //Smaller than counter
                int st = endNumber;

                while (gt < st)
                {
                    //while array[gt] is smaller or equal to the pivot AND gt is smaller than end add 1 to gt
                    while (array[gt] <= p && gt < endNumber)
                    {
                        gt++; 
                    }

                    //While array[st] is bigger than the pivot remove 1 from st
                    while (array[st] > p) 
                    {
                        st--;
                    }

                    //If gt and st didn't cross eachother, swap eachother
                    if (gt < st)
                    {
                        swap(gt, st);
                    }
                }

                //If pivot is greater than array[st] than swap st with the pivot
                if (p > array[st])
                {
                    swap(st, beginNumber);
                }
                
                //Recursive
                recursiveSort(beginNumber, st - 1);
                recursiveSort(st + 1, endNumber);
            }
        }

        /// <summary>
        /// Swap 2 items in an array.
        /// </summary>
        static void swap(int a, int b)
        {
            int temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }
    }
}
