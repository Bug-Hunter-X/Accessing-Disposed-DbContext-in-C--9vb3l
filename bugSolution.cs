public class MyClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a disposed object - fixed
        MyObject myObject = null;
        using (var context = new MyDbContext())
        {
            myObject = context.MyObjects.Find(1);
        }

        //This will no longer throw an exception
        if (myObject != null)
        {
            //use myObject here
        }
        else
        {
            //Handle the case where myObject is null
        }
    }
}