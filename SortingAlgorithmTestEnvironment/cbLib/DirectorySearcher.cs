using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace cbLibrary
{
    class DirectorySearcher
    {

         /// <summary>
         /// The ReturnFileNames method is a static method which receives a base directory and returns the full filename (and directory) of all files of a specific type within that directory, and all sub directories.
         /// </summary>
         /// <param name="inputFolderDirectory">The base directory in which we start the search.</param>
         /// <param name="fileType">The file type the program is searching for.</param>
         /// <returns>A list containing the full name of all found files.</returns>
        public static List<string> ReturnFileNames(string inputFolderDirectory, string fileType)
        {
            List<string> outputList = new List<string>(0);
            outputList = ReturnFileNamesRecursive(inputFolderDirectory, fileType, outputList);

            return outputList;
        }

        private static List<string> ReturnFileNamesRecursive(string inputFolderDirectory, string fileType, List<string> inputList)
        {
            List<string> outputFileList = new List<string>(0);
            
            //Search for further directories, and through recursion, add each of the ".fileType" files in their directories to the list
            IEnumerable<string> directoryEnum = Directory.EnumerateDirectories(inputFolderDirectory);
            foreach (string directory in directoryEnum)
            {

                outputFileList.AddRange(ReturnFileNamesRecursive(directory, fileType, inputList)); //put this in the directory search FOR-EACH statement
            }

            IEnumerable<string> fileEnum = Directory.EnumerateFiles(inputFolderDirectory);
            foreach (string file in fileEnum)
            {
                if (getFileType(file) == fileType)
                    outputFileList.Add(file);
            }

            return outputFileList;

        }


        /***
         * getFileType() Method
         * 
         * Input: A full filename, including directory and a filetype at the end
         * Output: A 3 character string of the filetype at the end of the input string
         * 
         * Uses: Mainly used for comparing filetypes of full file directories in the ReturnFileNames method
         * */
        private static string getFileType(string inputFileName)
        {
            int indexOfLastPeriod = inputFileName.LastIndexOf('.');

            string fileType = inputFileName.Remove(0, indexOfLastPeriod + 1); //we are removing indexOfLastPeriod + 1 because we also want to remove the period

            return fileType; //Test Status: Tested and working

        }

    }
}
