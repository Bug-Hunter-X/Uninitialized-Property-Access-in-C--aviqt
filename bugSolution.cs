public class ExampleClass
{
    public int MyProperty { get; set; } = 0; // Solution: Initialize the property with a default value

    public void MyMethod()
    {
        // Accessing an initialized property
        int value = MyProperty * 2;
    }

    // Or, you can initialize in the constructor
    public ExampleClass(int initialValue) 
    {
        MyProperty = initialValue;
    }
}