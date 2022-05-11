// Program:	Final Project: Part 1
// Author:	Katie Smith
// Date:	4-25-22

#include<iostream>
using namespace std;

// function to convert the user-entered decimal to a binary number
void decimalToBinary(int value) {
	// declaration of variable to be used in console output
	int userNum = value;
	// created array to store binary number
	int binaryNum[32];
	// convert to binary array
	int i = 0;
	while (value > 0) {
		// storing remainder in binary array
		binaryNum[i] = value % 2;
		value = value / 2;
		i++;
	}
	cout << userNum << " is binary ";
	// for-loop to print binary array
	for (int j = i - 1; j >= 0; j--) {
		cout << binaryNum[j];
	}
}
// main program to test the function's conversion
// asking user to input number, then passing it into conversion function
int main() {
	int number;
	cout << "Enter a decimal integer: ";
	cin >> number;
	decimalToBinary(number);
	return 0;
}