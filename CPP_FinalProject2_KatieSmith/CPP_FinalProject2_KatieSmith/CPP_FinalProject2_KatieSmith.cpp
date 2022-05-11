// Program:		Final Project: Part 2
// Developer:	Katie Smith
// Date:		4-27-22

#include <iostream>
using namespace std;

// function created to handle the conversion of decimal to hex
void decimalToHex(int value) {

	// creating array to store numbers for hex
	char hexArray[100];
	// declaration of variable and initialized to equal the user's number passed in as argument
	// doing this because the value of value variable will be changed in while-loop & I need original for cout
	int userNum = value;
	// declaration and initialization of variable to be used as control loop variable
	int i = 0;
	// while-loop, with nested if-statement, to cycle thru the number and convert it to hex
	while (value != 0) {
		int temp = 0;
		temp = value % 16;
		if (temp < 10) {
			hexArray[i] = temp + 48;
			i++;
		}
		else {
			hexArray[i] = temp + 55;
			i++;
		}
		value /= 16;
	}
	// printing out the converted hex number to console using cout and for-loop
	cout << userNum << " is hex ";
	for (int j = i - 1; j >= 0; j--)
		cout << hexArray[j];
}
// main function to ask user for decimal integer and pass the user's input to function for conversion
int main() {
	int number;
	cout << "Enter a decimal integer: ";
	cin >> number;
	decimalToHex(number);
	return 0;
}