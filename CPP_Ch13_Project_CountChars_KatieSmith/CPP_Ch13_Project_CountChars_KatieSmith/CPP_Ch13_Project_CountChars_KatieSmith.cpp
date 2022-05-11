// Program:	Chapter 13.1 Count characters
// Author:	Katie Smith
// Date:	2-23-22
// Class:	CSC-234 Advanced C++ Programming

// hash includes for iostream and fstream
// this allows for user-input and for reading from file
#include <iostream>
#include <fstream>
using namespace std;

// main function defined
// contains entire program
int main() {
	// string variable declared so the user can input the filename they would like to count
	string filename;
	cout << "Enter a file name: ";
	cin >> filename;

	// ch variable declared to be used for counting chars
	// numOfChars will increment each time thru the coming while loop
	char ch;
	int numOfChars = 0;

	// instance of input stream is declared and assigned as the filename input from user
	ifstream input(filename.c_str());
	
	// while loop to cycle thru file looking for the end of the file
	// the loop will pull each character out individually and increment numOfChars each time thru the loop
	while (!input.eof()) {
		input.get(ch);
		numOfChars++;
	}
	// display results for the user
	cout << "This file contains " << numOfChars << " characters. " << endl;

	return 0;
}