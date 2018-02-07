﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Diagnostics;

namespace SortingAlgorithmTestEnvironment
{
    public partial class frmSortingTestMain : Form
    {
        public frmSortingTestMain()
        {
            InitializeComponent();
        }

        private void frmSortingTestMain_Load(object sender, EventArgs e)
        {

        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            List<string> outputStringList = new List<string>(0);
            lblOutput.Text = "";

            Regex removeSpaces = new Regex(" ");
            string inputString = txtInput.Text;
            inputString = inputString.Trim();  //removing leading and trailing spaces avoids regex errors
            string[] numberArray = removeSpaces.Split(inputString);

            int[] intArray = new int[5];

            for(int i = 0; i < numberArray.Length; i++)
            {
                intArray[i] = int.Parse(numberArray[i]);
            }




            for(int i = 0; i < numberArray.Length; i++)
            {
                lblOutput.Text += numberArray[i] + " ";
            }

            SortingAlgorithmSelectSort selectSort = new SortingAlgorithmSelectSort("Select Sort");
            lblBool.Text = selectSort.Validate(intArray).ToString();
            intArray = selectSort.Sort(intArray);

            lblSorted.Text = "";
            foreach(int i in intArray)
            {
                lblSorted.Text += i.ToString() + " ";
            }
            lblPostValidation.Text = selectSort.Validate(intArray).ToString();

            /*
            to-do: 
                add additional sorting algorithm ( insertion sort),
                --done, use 2 methods within form --and taking in a list of ints into an int array from a file,
                --done, use cbLibrary drawScatterplot --and work on graphing, 
                --done, --and stopwatch additions,
                and then UI.

            */



        }//close btnSort_Click

        private void button1_Click(object sender, EventArgs e)
        {
            //Generate and shuffle list of n integers
            int n = 10000000;
            Random rng = new Random();

                    //generate
            List<int> intList = new List<int>(n);
            for(int i = 1; i < n + 1; i++)
            {
                intList.Add(i);
            }

            //Fisher-Yates shuffle
            int j = intList.Count;
            while( j > 1)
            {
                j--;
                int k = rng.Next(j + 1);
                int value = intList[k];
                intList[k] = intList[j];
                intList[j] = value;
            }

            //Open filestream
            FileStream intFile = new FileStream("sortInt" + n.ToString() + ".txt", FileMode.Create);
            StreamWriter intFileWriter = new StreamWriter(intFile);
            
            //write to filestream
            foreach(int val in intList)
            {
                intFileWriter.WriteLine(val.ToString());
            }
            
            intFileWriter.Close();
            //close stream
            intFile.Dispose();

        }

        //Retrieve list of ints from file, delimited by newline
        private List<int> GetListIntFromFile(string filename)
        {
            //Initialize int list
            List<int> intsFromFile = new List<int>();

            //Open File Reader
            FileStream intFile = new FileStream(filename, FileMode.Open);
            StreamReader intFileReader = new StreamReader(intFile);

            //Read while it is not the end of file
            while(!intFileReader.EndOfStream)
                intsFromFile.Add(int.Parse(intFileReader.ReadLine())); //Read the next line, retrieve the string, parse the string as an int, 
                                                                       //   and add that int to the list of ints.

            intFileReader.Close();
            intFile.Close();
            return intsFromFile;
        }

        //Convert List of Ints to an array of ints
        private int[] ConvertListOfIntsToArrayOfInts(List<int> intList)
        {
            //Create an array with the correct size
            int listSize = intList.Count;
            int[] intArray = new int[listSize];

            for(int i = 0; i < listSize; i++)
            {
                intArray[i] = intList[i];
            }

            return intArray;

        }

        private void btnSort10Ints_Click(object sender, EventArgs e)
        {
            //Initalize required components
            int nValue = 10;
            List<int> intList = GetListIntFromFile("sortInt" + nValue.ToString() + ".txt");
            int[] intArray = ConvertListOfIntsToArrayOfInts(intList);
            int[] sortedIntArray;
            Stopwatch sortingTimer = new Stopwatch();

            //Initalize the sorting algorithms
            SortingAlgorithmSelectSort selectSort = new SortingAlgorithmSelectSort("Select Sort");
            TimeSpan selectSortTime = new TimeSpan();

            //Ensure the array is not yet sorted.
            if (selectSort.Validate(intArray) == true)
            {
                MessageBox.Show("Error: the array is already sorted");
            }

            //Sort the algorithm and take a stopwatch time.
            selectSortTime = getSortingTime(selectSort, sortingTimer, intArray);

            selectSort.AddAlgorithmData(new AlgorithmData(selectSort.AlgorithmName, nValue, selectSortTime.Milliseconds, selectSort.ExchangeCount, selectSort.CompareCount, selectSort.ArrayAccessCount));

            lblOutput.Text = "SelectSort Sorting time (in ms): " + selectSort.DataList[0].StopwatchDuration.ToString();

            
        }

        private void btnSortThrough1e7_Click(object sender, EventArgs e)
        {

            //Initalize required components
            double maxNValue = Math.Pow(10, 5);
            //int nValue = 10;
            //List<int> intList = GetListIntFromFile("sortInt" + nValue.ToString() + ".txt"); //imports a list of ints
            List<int[]> listIntArray = new List<int[]>();
            //int[] intArray = ConvertListOfIntsToArrayOfInts(intList);
            //int[] sortedIntArray;
            Stopwatch sortingTimer = new Stopwatch();

            //Initalize the sorting algorithms
            SortingAlgorithmSelectSort selectSort = new SortingAlgorithmSelectSort("Select Sort");
            TimeSpan selectSortTime = new TimeSpan();



            //Generate multiple int arrays from the imported lists
            for (int i = 10; i < maxNValue; i *= 10 )
            {
                listIntArray.Add(ConvertListOfIntsToArrayOfInts(GetListIntFromFile("sortInt" + i.ToString() + ".txt")));
            }

            //Sort those int arrays
            int currentNValue = 1;
            foreach (int[] iArray in listIntArray)
            {
                currentNValue *= 10;
                if (selectSort.Validate(iArray) == true)
                    MessageBox.Show("Error: the array is already sorted");

                selectSortTime = getSortingTime(selectSort, sortingTimer, iArray);
                selectSort.AddAlgorithmData(new AlgorithmData(selectSort.AlgorithmName, currentNValue, selectSortTime.Milliseconds, selectSort.ExchangeCount, selectSort.CompareCount, selectSort.ArrayAccessCount));
            }



            //Generate datasets
            List<cbLibrary.clsDoublePoint> selectSortDataSet = new List<cbLibrary.clsDoublePoint>();
            foreach(AlgorithmData ad in selectSort.DataList)
            {
                selectSortDataSet.Add(new cbLibrary.clsDoublePoint(ad.SortingListNValue, ad.StopwatchDuration));
            }

            cbLibrary.DrawScatterplot selectSortScatterplot = new cbLibrary.DrawScatterplot(selectSortDataSet, "SelectSort Dataset");


        }


        private TimeSpan getSortingTime(SortingAlgorithm sa, Stopwatch sw, int[] intArray)
        {
            //Start the stopwatch, sort the list, stop the stopwatch
            sw.Start();
            intArray =  sa.Sort(intArray);
            sw.Stop();

            //Set the elapsed time to a timespan object, and reset the stopwatch object
            TimeSpan sortingTime = sw.Elapsed;
            sw.Reset();

            //Validate the sorted algorithm and return the timespan
            if(sa.Validate(intArray) == true)
                return sortingTime;
            else
            {
                MessageBox.Show("Error: list was not sorted properly.");
                return sortingTime;
            }
            
        }

    }//close form class



}//close namespace