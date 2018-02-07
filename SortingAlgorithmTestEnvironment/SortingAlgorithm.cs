using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithmTestEnvironment
{
    abstract class SortingAlgorithm
    {

        //Data members
        string algorithmName;
        private int exchangeCount;
        private int compareCount;
        private int arrayAccessCount;
        List<AlgorithmData> dataList;

        public int ExchangeCount { get => exchangeCount; set => exchangeCount = value; }
        public int CompareCount { get => compareCount; set => compareCount = value; }
        public int ArrayAccessCount { get => arrayAccessCount; set => arrayAccessCount = value; }
        public string AlgorithmName { get => algorithmName; set => algorithmName = value; }
        internal List<AlgorithmData> DataList { get => dataList; set => dataList = value; }

        public SortingAlgorithm(string algorithmName)
        {
            this.AlgorithmName = algorithmName;

            ExchangeCount = 0;
            CompareCount = 0;
            ArrayAccessCount = 0;
            DataList = new List<AlgorithmData>(0);
        }

        //Abstract Methods
        abstract public int[] Sort(int[] unsortedArray);


        //Non-abstract Methods
        public bool Validate(int[] inputArray)
        {
            for(int i = 1; i < inputArray.Length; i++)
            {
                if (inputArray[i - 1] > inputArray[i])
                    return false;
            }

            return true;
        }

        public void AddAlgorithmData(AlgorithmData data)
        {
            DataList.Add(data);
        }

        protected void Exchange(int pIndex, int qIndex, int[] a)
        {
            int i = a[pIndex];

            a[pIndex] = a[qIndex];
            a[qIndex] = i;

            ExchangeCount++;
        }

        protected bool Less(int i, int j)
        {
            CompareCount++;
            if (i < j)
                return true;
            else
                return false;
        }

        protected void resetExchangeCount()
        {
            ExchangeCount = 0;
        }

        protected void resetComparisonCount()
        {
            CompareCount = 0;
        }

        protected void resetArrayAccesses()
        {
            ArrayAccessCount = 0;
        }

    }//close class
}//close namespace
