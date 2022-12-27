// This program allows the user to insert and delete items from the table. Also, it traverses the table and displays the items in the table.
// Date: 12/09/2022
// Author: Jesus Sunuc

using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_13_Project
{
    public class TableException : System.Exception
    {
        public TableException(String s) : base(s)
        {
        }
    }

    public interface TableInterface<T>
    {
        // Table operations:
        // Precondition for all operations:
        // No two items of the table have the same search key.
        // The table's items are sorted by search key.

        public bool tableIsEmpty();
        // Determines whether a table is empty.
        // Postcondition: Returns true if the table is
        // empty; otherwise returns false.

        public int tableLength();
        // Determines the length of a table.
        // Postcondition: Returns the number of items in the
        // table.

        public void tableInsert(T newItem);
        // Inserts an item into a table.
        // Precondition: The item to be inserted into the
        // table is newItem which differs from
        // all itmes presently in the table.
        // Postcondition: If the insertion was successful,
        // newItem is in properly place in the table.
        // Otherwise, the table is unchanged, and
        // TableException is thrown.

        public bool tableDelete(T item);
        // Deletes an item from a table.
        // Postcondition: If the item existed in the table, 
        // the item was deleted and method returns true. 
        // Otherwise, the table is unchanged and the method 
        //returns false.

        public T tableRetrieve(T Item);
        // Retrieves an item from a table.
        // Postcondition: If the retrieval was successful,
        // the table item is returned. If no such item 
        // exists, the method
        // returns a null reference.

    }  // end TableInterface
}
