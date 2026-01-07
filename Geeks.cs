// C# program to print Hello World!
using System;

// namespace declaration
namespace HelloWorldApp {

// Class declaration
class Geeks {

    // Main Method
    static void Main(string[] args)
    {

        // statement
        // printing Hello World!
        Console.WriteLine("Hello World!");

        // To prevents the screen from
        // running and closing quickly
        Console.ReadKey();
    }
}
}


We can not use accessor modifiers on an interface or an explicit interface member implementation.
We can use accessor modifiers only if the property has both set and get accessors.
If the property is an override modifier, the accessor modifier must match the accessor of the overridden accessor.
The accessibility level on the accessor must be more restrictive than the accessibility level on the property.