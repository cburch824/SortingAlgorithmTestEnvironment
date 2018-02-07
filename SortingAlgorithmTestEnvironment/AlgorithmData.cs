using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithmTestEnvironment
{
    class AlgorithmData
    {
        //Data Members
        string sortingListName;
        int sortingListNValue;
        double stopwatchDuration;
        int exchangeCount;
        int compareCount;
        int arrayAccessCount;

        public AlgorithmData(string sortingListName, int sortingListNValue, double stopwatchDuration, int exchangeCount, int compareCount, int arrayAccessCount)
        {
            this.SortingListName = sortingListName;
            this.SortingListNValue = sortingListNValue;
            this.StopwatchDuration = stopwatchDuration;
            this.ExchangeCount = exchangeCount;
            this.CompareCount = compareCount;
            this.ArrayAccessCount = arrayAccessCount;
        }

        public string SortingListName { get => sortingListName; set => sortingListName = value; }
        public int SortingListNValue { get => sortingListNValue; set => sortingListNValue = value; }
        public double StopwatchDuration { get => stopwatchDuration; set => stopwatchDuration = value; }
        public int ExchangeCount { get => exchangeCount; set => exchangeCount = value; }
        public int CompareCount { get => compareCount; set => compareCount = value; }
        public int ArrayAccessCount { get => arrayAccessCount; set => arrayAccessCount = value; }
    }
}
