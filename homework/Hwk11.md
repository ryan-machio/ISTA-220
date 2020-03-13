# Ryan Manchanthasouk
## C# Chapter 11 Homework
## February 12th, 2020
1. What is a parameter array?
  - Using a params array, you can pass a variable number of arguments to a method.
  - This means that you can declare an indefinite number of arguments (param array) which allows the a procedure to accept an array of values for the parameter.
  - You indicate a params array by using the params keyword as an array parameter modifi er when you defi ne the method parameters.
1. How do you define a method that takes an arbitrary number of arguments?
  - public static variable MethodName(params int[] paramList);
  - paramList = params array
1. How do you call a method that takes an arbitrary number of arguments?
  - MethodName();
1. Why can't you use an array to pass an arbitrary number of arguments to a method?
  - Because an array has a fixed number
1. How many parameters can a method have?
  - any number
1. Do parameter arguments have to have the same type?
  - No, because you can use object as the type passed
1. What is the difference between a method that takes a parameter argument and one that takes optional arguments?
  - A parameter is a variable in a method definition. When a method is called, the arguments are the data you pass into the method's parameters.
1. How do you define a method that takes different (and arbitrary) types of arguments?
  - public static void (params object[] paramList)
1. Write a method that accepts any number of arguments of a given type.
  - public static void  Method
1. Write a method that accepts any number of arguments of any type.
  - public static void object MethodName(params int[] paramList)
