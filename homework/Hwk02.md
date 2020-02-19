# Ryan Manchanthasouk
### C# HWK 2
1. A local variable is a variable that only exists in a method or another small section of code.
(anything between an open and closed brace)
1. A statement is a command that performs an action, such as calculating a value and storing the result or displaying a message to a user.
1. identifiers are names that you use to identify the elements in your programs, such as namespaces, classes, methods, and variables
1. A variable is a storage location that holds a value.
1. A method is a named sequence of statements//a code block that contains a series of statements
1. A value type is whatever type resides on the stack, a
primitive type is defined at the programming language level, but is
often a value type directly supported by the compiler of the language.
i.e. a primitive type can be mapped directly to the base class library,
while a value type inherits from system.valuetype
1. You can use the arithmetic operators on values of type char, int, float, double, or decimal
however you can't use it on boolean or string types.  you can use the + operator
to concatenate string values.
1. You can turn an integer into a string by using the ToString() method.
1. You can turn a string into an integer by using the Parse() method,
Convert Class, Type(Parse) Method.
1. Precedence governs the order in which an expression's operators are evaluated.
in precedence, the order of operations will determine the result, but you can use
parentheses to override the result.
associativity is the direction (left or right) in which the operands of an operator
are evaluated.
i.e.: in the equation 4 * 2 / 2, there would be no precedence, but associativity.
here, the equation could be evaluated left to right or right to left, because
the precedence of both operators is the same.  however, in this case, the
operation would be evaluated from left to right.
in the equation 4 + 2 * 8, precedence would take place because of the order
of operations.  multiplication has precedence over addition, so
2 * 8 would evaluate first, which is 16.  then, the 4 would be added, to finally
be evaluated to 20.
1. The definite assignment rule states that every variable must have a value
before it is read from.  
1. Increment adds one, decrement decreases one.
1. String interpolation is the process of evaluating a string literal
containing one or more place holders to yield a result where placeholders
are replaced with their corresponding values.
Interpolation: the insertion of something of a different nature into something else
1. The var keyword is used to declare implicit type variables.
