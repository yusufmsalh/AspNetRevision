namespace OOPRev
{
    public class MyClass
    {
        public int z;
        public MyClass() { }
        public MyClass(int x)
        {
            z = x;
        }
    }

    public struct MyStruct
    {
      public  int x;
       
        public MyStruct(int z)

        {
            x = z;
        }

    }
    public struct MyStructOfClass
    {
        public MyClass x;

        public MyStructOfClass (int y)

        {
            x = new MyClass(y);
        }

    }

}