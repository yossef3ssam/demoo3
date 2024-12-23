// boxing and un boking 
// boxing :  the process of converting a value type into a reference type by wrapping it in an object.
// unboxing : the reverse of boxing. It converts a reference type (object) back into a value type.

using System;

class Program
{
    static void Main(string[] args)
    {
        //boxing
        //int value = 42;               // Value type
        //object boxedValue = value;    // Boxing: value type is wrapped into an object

        //Console.WriteLine($"Value: {value}");           // Output: Value: 42
        //Console.WriteLine($"Boxed Value: {boxedValue}"); // Output: Boxed Value:
        //unboxing 
        //object boxedValue = 42;        // Boxing: value type is stored as an object
        //int value = (int)boxedValue;   // Unboxing: explicitly cast back to int

        //Console.WriteLine($"Boxed Value: {boxedValue}"); // Output: Boxed Value: 42
        //Console.WriteLine($"Unboxed Value: {value}");    // Output: Unboxed Value: 42
        //boxing and unboxing 
        //int number = 100;             // Value type
        //object boxedNumber = number;  // Boxing
        //int unboxedNumber = (int)boxedNumber; // Unboxing

        //Console.WriteLine($"Original: {number}");         // Output: Original: 100
        //Console.WriteLine($"Boxed: {boxedNumber}");       // Output: Boxed: 100
        //Console.WriteLine($"Unboxed: {unboxedNumber}");   // Output: Unboxed: 100

        //nullable A nullable type defaults to null if no value is assigned
        //using System;


        //int? age = null;

        //// Check if the value is null
        //if (age == null)
        //{
        //    Console.WriteLine("Age is not provided.");
        //}
        //else
        //{
        //    Console.WriteLine($"Age: {age}");
        //}

        //// Using null-coalescing operator
        //int displayedAge = age ?? 0; // Default to 0 if age is null
        //Console.WriteLine($"Displayed Age: {displayedAge}");
    
    }

}


