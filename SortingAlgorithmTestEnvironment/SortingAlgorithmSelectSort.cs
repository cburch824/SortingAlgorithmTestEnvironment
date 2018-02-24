using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithmTestEnvironment
{
    class SortingAlgorithmSelectSort : SortingAlgorithm
    {
        //Constructor
        public SortingAlgorithmSelectSort(string algorithmName) : base(algorithmName)
        { }
        

        //Sorting algorithm
        public override int[] Sort(int[] unsortedArray)
        {
            int[] sortedArray = unsortedArray;
            int N = sortedArray.Length;
            for(int i = 0; i < N; i++)
            {
                int min = i;
                for (int j = i + 1; j < N; j++)
                {
                    if (Less(sortedArray[j], sortedArray[min]))
                        min = j;
                    this.ArrayAccessCount++;
                }
                Exchange(i, min, sortedArray);
                this.ArrayAccessCount++;
            }

            return sortedArray;
        }// close sort

        


    }//close class
}//close namespace
