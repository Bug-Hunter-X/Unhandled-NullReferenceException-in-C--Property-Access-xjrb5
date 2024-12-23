public class MyClass {
    public int MyProperty { get; set; } = 0; // Initialize MyProperty to 0

    public void MyMethod() {
        Console.WriteLine(MyProperty.ToString()); 
    }

    // Alternative constructor initialization
    public MyClass(int initialValue) {
        MyProperty = initialValue;
    }
}