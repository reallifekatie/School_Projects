// Program: Project 2 Chapter 10
// Class:   CSC-234 Advanced C++
// Author:  Katie Smith
// Date:    1-31-22

#include <iostream>
#include <string>
using namespace std;

int main()
{
    string genome;
    cout << "Enter a genome string: ";
    cin >> genome;

    int start = -1;

    bool found = false;

    for (int i = 0; i < genome.length() - 2; i++)
    {
        string triplet = genome.substr(i, 3);

        if (triplet == "ATG")
            start = i + 3;
        else if ((triplet == "TAG" || triplet == "TAA" || triplet == "TGA") && start != -1)
        {
            // A possible gene is found
            string gene(genome.substr(start, 3));
            if (gene.length() % 3 == 0)
            {
                // A gene is found and display the gene
                found = true;
                cout << gene << endl;
                start = -1;  // Start to find the next gene in the genome
            }
        }
    }

    if (!found)
        cout << "no gene is found" << endl;

    return 0;
}
