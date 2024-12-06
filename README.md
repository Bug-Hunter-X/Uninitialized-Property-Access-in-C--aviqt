# Uninitialized Property Access in C# Example

This repository demonstrates a common error in C#: accessing a property before it has been assigned a value.  This can lead to unexpected results or runtime exceptions, depending on the context and the property's type.

The `bug.cs` file shows the erroneous code, and `bugSolution.cs` provides a corrected version.

## How to Reproduce
1. Clone this repository.
2. Compile and run `bug.cs`. Observe the potential issue. 
3. Compile and run `bugSolution.cs` to see the correct way to handle property initialization.

## Related Issues
* Uninitialized variables
* Default values in C#