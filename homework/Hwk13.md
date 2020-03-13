# Ryan Manchanthasouk
## C# Chapter 13 Homework
## February 23th, 2020
1. What is an interface as the term is used on object-oriented programming?
  - An interface does not contain any code or data; it just specifies the methods and properties that a class that inherits from the interface must provide.
1. How do you define an interface?
  - Defining an interface is syntactically similar to defining a class, except that you use the interface keyword instead of the class keyword.  To implement an interface, you declare a class or structure that inherits from the interface and that implements all methods specified by the interface.
1. Can an interface have variables, fields, or properties?
  - Interfaces can define methods, properties, indexers, and events, but not fields.
1. How do you define a method in an interface?
  - interface Name
  {
    void methodName(int para);
  }
1. Can you instantiate an object through an interface? Why or why not?
  - An interface can't be instantiated directly. Its members are implemented by any class or struct that implements the interface.
1. Using the new keyword, can you declare a reference to an interface?
  - In the same way that you can reference an object by using a variable defined as a class that is higher up the hierarchy, you can reference an object by using a variable defi ned as an interface that the
object’s class implements.
1. Can an object inherit from multiple interfaces? Can a class implement multiple interfaces? If so, how
can it do so?
  - An object can inherit from multiple interfaces.  A class can implement multiple interfaces.  If a structure or class implements more than one interface, you specify the interfaces as a comma-separated list. If a class also has a base class, the interfaces are listed after the base class.
  - An interface cannot inherit from multiple classes.
1. What does it mean to explicitly implement an interface?
  - You declare the interface type prior to the method you are implementing.  You specify which interface a method belongs to.
  - Implicit, implied
  - Explicit, you have to spell it out
1. What are the restrictions on interfaces?
  - You’re not allowed to define any fields in an interface, not even static fields. A field is an implementation detail of a class or structure.
  - You’re not allowed to define any constructors in an interface. A constructor is also considered to be an implementation detail of a class or structure.
  - You’re not allowed to define a destructor in an interface. A destructor contains the statements used to destroy an object instance. (Destructors are described in Chapter 14, “Using garbage collection and resource management.”)
  - You cannot specify an access modifier for any method. All methods in an interface are implicitly public.
  - You cannot nest any types (such as enumerations, structures, classes, or interfaces) inside an interface.
  - An interface is not allowed to inherit from a structure or a class, although an interface can inherit from another interface. Structures and classes contain implementation; if an interface were allowed to inherit from either, it would be inheriting some implementation.
1. What is the difference between an abstract class and an interface?
  - In C#, an Interface provides only those public services declared in the interface, whereas an abstract class provides the public services defined in an abstract class and those members that are inherited from the abstract class's base class.
1. What is an abstract method?
  - An abstract method is similar in principle to a virtual method (covered in Chapter 12), except that it does not contain a method body.
1. What is an sealed class?
  - You can use the sealed keyword to prevent a class from being used as a base class if you decide that it should not be.  
1. What is an sealed method?
  - You can also use the sealed keyword to declare that an individual method in an unsealed class is sealed. This means that a derived class cannot override this method.
