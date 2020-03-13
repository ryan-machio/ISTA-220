# Ryan Manchanthasouk
## C# Chapter 12 Homework
## February 12th, 2020
1. How does inheritance promote the principle of don't repeat yourself (DRY)?
  - Inheritance allows you to utilize a method from a parent class, rather than redefining the method over and over again.
1. What is the syntax of a derived class that inherits from a base class?
  - class DerivedClass : BaseClass
1. Do all user defined types (classes and structs) inherit from some base class? If so, what is it?
  - Scructs and Classes inherit from the base class Object.
1. What happens if you do not have a default constructor in a base class when creating a derived class?
  - The compiler will attempt to silently insert a call to the base class's default constructor before executing the code in the derived class.
1. Can you assign a variable of a derived class to another variable of its base class? Why or why not?
  - Yes, as long as the derived class is calling from it's inheritance hierarchy.
1. Can you assign a variable of a derived class to another variable of a derived class of its base class?
Why or why not?
  - Any methods defined in children classes cannot be accessed by each other because the parent class does not contain them.
1. Can you assign a variable of a base class to another variable of a derived class? Why or why not?
  - No because a reference to a derived class must actually refer to an instance of the derived class.
1. Under what circumstances would you want to use the new keyword when defining a method in a
derived class?
  - You declare new before stating the method to let the compiler know that you understand what you are doing.
1. What is a virtual method? Why would you want to dene a virtual method?
  - A virtual method is a method that is intended to be overridden.  Overriding a method is a mechanism for providing different implementations of the same method - the methods are related because they are intended to perform the same task, but in a class-specific manner.
1. What does override do? Why does it do it?
  - If a base class declares a method as virtual, a derived class can use the override keyword to declare another implementation of that method.  This happens so that the child method can give its own implementation to a method which is already provided by the parent class.
1. How do you define an extension type?
  - You define an extension method in a static class and specify the type to which the method applies
as the first parameter to the method, along with the this keyword
  - static class Util
    {
      public static int Negate(this int i)
      {
        return -i;
      }
    }
1. Why do you define an extension type?
  - You would define an extension type so that you don't have to change the definition of every int varaible to the (what would be) virtual class, which is actually an extended class.
1. (Not in book) Explain the Liskov substitution principle.
  - The Liskov substitution principle is a definition of subtyping relation, where is variable x is a subtype of w, then objects of type w may be replaced with objects of type x.  I.e. inheritance.
