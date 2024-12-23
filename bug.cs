public class MyClass {
    public int MyProperty { get; set; }

    public void MyMethod() {
        // The following line will throw a NullReferenceException if MyProperty is not initialized
        Console.WriteLine(MyProperty.ToString()); 
    }
}