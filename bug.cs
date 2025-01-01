public class MyClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a disposed object
        using (var context = new MyDbContext())
        {
            var myObject = context.MyObjects.Find(1);
        }

        // This will throw an exception because the context is already disposed
        var anotherObject = context.MyObjects.Find(2);
    }
}