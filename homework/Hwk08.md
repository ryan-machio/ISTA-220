# Ryan Manchanthasouk
## C# Chapter 8 Homework
## February 5th, 2020

1. What is the difference between deep copy and shallow copy?
  A deep copy is the process of creating a new object and copying the fields of the current object to the newly created object to make a complete copy of the internal reference types.
  A shallow copy is creating a new object and copying the value type fields of the current object to the new object.
1. What is the value of a reference after you declare and initialize it?
  null
1. How do you declare a value type?
  type variable_name = value;
1. How do you declare a reference type?
class variablename = "string"
1. Does C# allow you to assign NULL to a value type?
no
1. Can you assign a nullable value type to a non-nullable variable of the same type? Why or why not?
  yes because nullable types can only work with the value type, which means all value types are able to be null.
1. What is the difference between the stack and the heap?
  the stack is used to store local variables and the heap is used to store objects.
1. What does it mean when we say that all classes are specialized types?
With specialization we nominate a subset of the objects in a type as a subtype. The objects in the subset are chosen such that they have "something in common". Typically, the objects in the subset are constrained in a certain way that set them apart from the surrounding set of objects.
1. What does ref do?
indicates the that the argument is passed by a reference
1. What does out do?
 It makes the formal parameter an alias for the argument, which must be a variable
1. Describe boxing and unboxing in your own words.
  boxing is converting a value type to an object type.
  unboxing is converting from an object type to a value type or from an interface type to a value type that implements the interface
1. What does cast do?
  Cast informs the cpmiler that you want to make a conversion even though data loss may occur.
