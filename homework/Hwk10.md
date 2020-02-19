# Ryan Manchanthasouk
## C# Chapter 10 Homework
## February 12th, 2020
1. What does an array look like in memory?

  -A contiguous block of memory
1. Where is memory allocated to hold an array, on the stack or on the heap

  -Heap
1. Where is memory allocated to hold an array reference, on the stack or on the heap?

  -heap
1. Can an array hold values of different types? This is a trick question, the answer is, \It depends." What
determines the types that an array can hold?

  -Yes, arrays can hold different types such as primitive types and objects of classes depending on the definition of the array.
1. Describe the syntax of the condition for a for-each loop.

  - a for-each loop must match the type of elements in the array.
1. How do you make a deep copy of a array?

  -type variableNameOfCopy = variableNameOfArray //shallow copy

  -type array = array

  -type copy = new type[array.length] //deep copy
1. What is the difference in the syntax between a multi-dimensional array and an array of arrays?

  - array[variable, variable, variable] //(multidimensional)
  - array[ ][ ] array = new type[amount][] //multidimensional
  - array[ ][ ] variablename; //array of arrays
  type [ ] variableName1 = new type[index#WhereNumberIsStored1]
  type [ ] variableName2 = new type[index#WhereNumberIsStored2]
  etc...
  type[indexNumberAssignment] = variableName1
  type[indexNumberAssignment] = varaibleName2
1. What is the difference in the uses for a multi-dimensional array and an array of arrays? In other words,
what determines whether you would use one as opposed to the other?

  -When multidimensional arrays might consume too much memory, using an array of arrays will save more memory space; i.e. if you have a multidimensional array with a lot of unused variables, it would be wise to use an array of arrays, which would only allocate memory space for necessary elements.
1. How do you "flatten" a multidimensional array? In other words, take something that looks like a matrix and turn it into an array [1; 2; 3; 4; 5; 6; 7; 8; 9]? Write the code to do this in English.

  1 2 3
  4 5 6
  7 8 9

  int matrix [] = {1, 2, 3, 4, 5, 6, 7, 8, 9}

1. (Thought question) When we use a for loop, we can change the values of the array elements inside the loop. When we use a foreach loop, we cannot change the values of the array elements inside the loop. Why not? How is for different from for-each?

  -foreach loops are a read-only copy of each element of an array.  
