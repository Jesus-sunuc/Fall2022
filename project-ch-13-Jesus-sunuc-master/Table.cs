// This program allows the user to insert and delete items from the table. Also, it traverses the table and displays the items in the table.
// Date: 12/09/2022
// Author: Jesus Sunuc

using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_13_Project
{
    class Table : TableInterface<string> // TableInterface is the interface
    {
        const int sizeOfTables = 7; // This is the size of the table
        private string[] hashingArray = new string[sizeOfTables]; // This is the array that will hold the items
        private bool[] flag = new bool[sizeOfTables]; // This is the array that will hold the flags
        public bool tableIsEmpty() // This method will determine if the table is empty
        {
            return true;
        }
        public int tableLength() // This method will determine the length of the table
        {
            return 0;
        }
        public void tableInsert(string newItem) // This method will insert an item into the table
        {
            int searchKey = Horner(newItem);    // This will get the search key

            int index = searchKey % sizeOfTables; // This will get the index
            for (int i = 0; i < flag.Length; i++) // This will check if the table is full
            {
                if (flag[index] == false) // This will check if the index is empty
                {
                    hashingArray[index] = newItem; // This will insert the item into the table
                    flag[index] = true; // This will set the flag to true
                }
                else
                {
                    int doubleHash = DoubleHashing(newItem, searchKey); // This will get the double hashing search key
                    hashingArray[index + doubleHash] = newItem; // This will insert the item into the table
                }
            }
        }
        public bool tableDelete(string item)    // This method will delete an item from the table
        {
            return true;
        }
        public string tableRetrieve(string Item)    // This method will retrieve an item from the table
        {
            return default;
        }
        private int Horner(string newItem)  // This method will get the search key
        {
            int searchKey = 0;  // This will hold the search key
            char singleLetter = ' ';
            char[] letter = newItem.ToCharArray();  // This will convert the string to a char array
            for (int i = 0; i <= letter.Length; i++)    // This will loop through the char array
            {
                singleLetter = letter[i];   // This will get the single letter
                Console.WriteLine(singleLetter);    // This will display the single letter
                int number = (int)singleLetter; // This will convert the single letter to a number
                Console.WriteLine($" value of the number{number}"); // This will display the number
                searchKey += (int)Math.Pow(number, i);  // This will get the search key
                Console.WriteLine($"This is the value of the searchKey:{searchKey}");   // This will display the search key
            }
            Console.WriteLine($"This is the searchKey real: {searchKey}");  // This will display the search key
            return searchKey;
        }
        private int DoubleHashing(string newItem, int searchKey)    // This method will get the double hashing search key
        {
            int doubleHashingSearchKey = sizeOfTables - (searchKey % sizeOfTables);
            return doubleHashingSearchKey;
        }

    }
}
