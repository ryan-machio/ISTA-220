# Ryan Manchanthasouk
## C# Chapter 9 Homework
## February 11th, 2020

1. What is an enum?
  -Enum: enumeration, a value type whose values are limited to a set of symbolic names.  (A series of related symbolic constance)
1. Declare an enum for military ranks, either ocer or enlisted. Name it Ranks. What are the symbols,
like Private, Corporal, Sergeant or Lieutenant, Captain, Major?

  enum Ranks {Pvt, Cpl, Sgt, Lt, Cap, Maj}
1. Using the Ranks enum, assign a rank to yourself and a friend.

  Ranks Ryan = Ranks.Sgt

  Ranks Pat = Ranks.Maj
1. Determine the numeric index of particular ranks, using the Ranks enum.

  enum Ranks {Pvt = 1, PFC = 2, LCpl = 3, Cpl = 4, Sgt = 5}
1. How do you select the type of an enum?

  enum Ranks : long {PVT, PFC, LCpl, Cpl, Sgt}

  byte, sbyte, short, ushort, int, uint, long, ulong
1. What is a struct?

  A structure is a value type.
1. List some differences between classes and structs.

  -No default constructor for a structures because the compiler always generates one

  -In a class you can initialize instance fields at their point of declaration.  You can't with a struct.

  -A structure is a value type, a class is a reference type.

  -Classes live on the heap, structures live on the stack

  -Structs are values, classes are objects

1. Are structs stored on the stack or on the heap? What about enums?

  Structs are stored on the stack

  Enums are stored on the stack
1. Review the documentation for the C# System.Int32 struct. List the fields. List the methods.

  -Fields: MaxValue, MinValue

  -CompareTo(), Equals(), GetHashCode(), GetTypeCode(), Parse(), ToString(), TryParse()
1. Declare a struct named DOD with four branches.

struct DOD
{
  private string USMC, USN, USA, USAF
}
1. Why can't you create a default constructor for a struct?

  The compiler always generates one
1. What is CIL? What does the CLR do to the CIL?

  The common language runtime (CLR) converts the CIL instructions in to real time machine instructions that the processor on your computer can understand and execute; i.e. managed execution environment.
