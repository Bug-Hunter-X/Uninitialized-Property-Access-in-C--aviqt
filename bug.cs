public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a non-initialized property
        int value = MyProperty * 2; // Bug: MyProperty might be 0 or uninitialized.
    }
}