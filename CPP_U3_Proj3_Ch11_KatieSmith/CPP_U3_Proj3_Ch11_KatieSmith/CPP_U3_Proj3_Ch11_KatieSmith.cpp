// Program:	U3 Project 3 Chapter 11
// Class:	CSC-234 Adv C++
// Author:	Katie Smith
// Date:	2-9-22

// header info
#include <iostream>
#include <string>
#include <ctime>
using namespace std;

#ifndef MYDATE_H
#define MYDATE_H

class MyDate {
public:
	MyDate();
	MyDate(long);
	MyDate(int, int, int);
	int getYear() const;
	int getMonth() const;
	int getDay() const;
	void setYear(int);
	void setMonth(int);
	void setDay(int);

private:
	int year;
	int month;
	int day;
	void setDate(long elapsedTime);
};

#endif

// Determine if it is a leap year
bool isLeapYear(int year) {
	return year % 400 == 0 || (year % 4 == 0 && year % 100 != 0);
}
// Get the English name for the month
// Whichever month number is checked by the switch-case statement, will return the 
//		string equivalent of the month name
string getMonthName(int month) {
	switch (month) {
	case 1:
		return "January";
	case 2:
		return "February";
	case 3:
		return "March";
	case 4:
		return "April";
	case 5:
		return "May";
	case 6:
		return "June";
	case 7:
		return "July";
	case 8:
		return "August";
	case 9:
		return "September";
	case 10:
		return "October";
	case 11:
		return "November";
	case 12:
		return "December";
	default:
		cout << "Wrong month" << endl;
	}
	return NULL;
}

// Get the number of days in a month
// If statement looks for the month number and returns the number of days in that month
int getNumberOfDaysInMonth(int year, int month) {
	if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 ||
		month == 10 || month == 12)
		return 31;
	if (month == 4 || month == 6 || month == 9 || month == 11)
		return 30;
	if (month == 2) return isLeapYear(year) ? 29 : 28;
	return 0; // if month is incorrect
}

MyDate::MyDate() {
	setDate(time_t(0)); 
}

MyDate::MyDate(long elapsedTime) {
	setDate(elapsedTime);
}

MyDate::MyDate(int year, int month, int day) {
	this->year = year;
	this->month = month;
	this->day = day;
}

void MyDate::setDate(long elapsedTime) {
	long seconds = elapsedTime;
	long currentSecond = seconds % 60;
	long minutes = seconds / 60;
	long currentMinute = minutes % 60;
	long hours = minutes / 60;
	long currentHour = hours % 24;
	long days = hours / 24;

	days += 1;

	// Get year
	int year = 1970;
	while (days >= (isLeapYear(year) ? 366 : 365)) {
		days = days - (isLeapYear(year) ? 366 : 365);
		year++;
	}

	// Get month
	int month = 1;
	while (days >= getNumberOfDaysInMonth(year, month)) {
		days = days - getNumberOfDaysInMonth(year, month);
		month++;
	}

	this->year = year;
	this->month = month;
	this->day = days;
}
int MyDate::getYear() const {
	return year;
 }

int MyDate::getMonth() const {
	return month;
}

int MyDate::getDay() const {
	return day;
}

void MyDate::setYear(int year) {
	this->year = year;
}

void MyDate::setMonth(int month) {
	this->month = month;
}

void MyDate::setDay(int day) {
	this->day = day;
}

// main method defined and outputs established
// the getters are used to pull info into the cout statements
int main() {
	MyDate today;

	cout << "Current date is " << getMonthName(today.getMonth()) << " " <<
		today.getDay() << ", " << today.getYear() << endl;
	
	MyDate day(561555550);

	cout << "The date is " << getMonthName(day.getMonth()) << " " <<
		day.getDay() << ", " << day.getYear() << endl;

	MyDate day2(1739577540);

	cout << "The date is " << getMonthName(day2.getMonth()) << " " <<
		day2.getDay() << ", " << day2.getYear() << endl;

	return 0;
}