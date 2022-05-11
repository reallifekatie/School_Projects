// Program:	Project 7
// Author:	Katie Smith
// Date:	4-20-22

#include<iostream>
#include<stdexcept>
#include<string>
#include<cctype>
using namespace std;

int hex2Dec(const string& hexString);
int convertHexToDec(char ch);

int hex2Dec(const string& hexString) {
	int value = 0;
	for (unsigned int i = 0; i < hexString.size(); i++)
		value = value * 16 + convertHexToDec(toupper(hexString[i]));
	return value;
}

// the function returns an int for a hex digit
// throws an invalid_argument ("Not a hex number") if the hex character is invalid
int convertHexToDec(char ch) {
	if (ch >= 'A' && ch <= 'F')
		return 10 + (ch - 'A');
	else if (ch <= '9' && ch >= '0')
		return ch - '0';
	else throw invalid_argument("Not a hex number");
}

int main() {
	// declare variable hex for use in try-catch
	string hex;
	// try-catch statement for main function
	try {
		// ask the user to enter a hex number and assign the user's input to variable hex
		cout << "Enter a hex number: " << endl;
		cin >> hex;
		// print out the value returned from the function call
		cout << hex2Dec(hex) << endl;
	}
	// if an error is thrown back from the function, the catch statement displays the argument string error message
	catch (invalid_argument& ex) {
		// stuff
		cout << ex.what() << endl;
	}
}