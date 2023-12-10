## Class or Struct

Struct: 
A struct is a value type. 
When a struct is assigned to a new variable or passed to a method, a copy of the value is passed, not the reference.
Structs are typically allocated on the stack, which gives us a performance benefits, in case of small, frequently used types.
Structs cannot inherit from another struct or class, and cannot be the base of a class.
All structs implicitly inherit from System.ValueType.

Class: 
A class is a reference type.
When a class instance is assigned to a new variable or passed to a method, the reference to the instance is passed.
Classes are allocated on the heap, garbage collector is used to manage their memory.

Structs are generally used for small, lightweight objects, while classes are used for more complex objects and/or for inheritance and polymorfism.
 
## Variance

Covariance allows a method to return a more derived type than that specified by the generic type parameter. This is useful when we want method to return a type that is a subclass of the specified type. It is useful when working with a hierarchy of objects. We can write more general code that can handle more specific types.

Example: 

IEnumerable<Cat> cats = new List<Cat>();
IEnumerable<Animal> animals = cats;

Contravariance, allows a method to accept parameters of less derived types than that specified by the generic type parameter. It's used in situations where we need to work with a more general type than specified. It's particularly useful in scenarios with delegates or event handling where a more general type is better. it increases usability, since we can write methods that work with more general types.

Example: 

IComparer<Animal> animalComparer = new AnimalComparer();
IComparer<Cat> catComparer = animalComparer;

## Thread safe

Example1 - Using Interlocked.Increment 

int sharedVariable = 0;

int newValue = Interlocked.Increment(ref sharedVariable);

Example 2 - Using lock

int sharedVariable = 0;
private readonly object lockObject = new object();

lock(lockObject)
{
    sharedVariable++;
}

# Monad

Check TestProject1 project inside this solution

# Refactoring

Check BeqomTestSolution and Tests projects inside this solution