// Program:	Chapter 13.1 Create a text file
// Author:	Katie Smith
// Date:	2-23-22
// Class:	CSC-234 Advanced C++ Programming

#include <iostream>
#include <fstream>
using namespace std;

int main() {
	ofstream output;

	// opening file in append mode
	output.open("Exercise13_1.txt", ios::app);

	// for loop created to cycle thru 100 times and write
	// 100 integers to the file, separated by a single whilespace
	for (int i = 0; i < 100; i++) {
		output << rand() % 100 << " ";
	}
	return 0;
}