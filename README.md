# SortingAlgorithmTestEnvironment
*C# and Windows Forms based sorting algorithm test environment*

This application's purpose is to design, test, and compare sorting algorithms.

# Design
Additional sorting algorithms can be added to the program by creating a new class which inherits and 
overrides the SortingAlgorithm.cs class. Currently a SortingAlgorithmSelectSort.cs class has been added
as an example.

# Test
Additional sorting algorithms can be implemented on the main form. The default button (Sort all lists in the "IntLists" directory)
is the recommended button.

# Compare
The program generates a graph in .jpg format in the project's base directory, which can be used to determine the time complexity,
and to compare with other implemented sorting algorithms.
