using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
          //var  a=MyClass.MyBuilder.SetHave(true).SetName("sss").build();
          Visitor.mymain();
            Console.WriteLine("Hello World!");
        }
    }

    class MyClass
    {
        public bool IsHave { get; private set; }
        public  string Name { get; private set; }
        private MyClass(Builder builder)
        {
            this.IsHave = builder.IsHave;
            this.Name = builder.Name;
        }
        public static Builder MyBuilder { get; }=new Builder();
        
      public class Builder
      {
          public bool IsHave { get; private set; }
          public  string Name { get; private set; }
          
           public MyClass build()
           {
               return  new MyClass(this);
           }
           public Builder SetHave(bool have)
           {
               this.IsHave = have;
               return this;
           }
           public Builder SetName(string name)
           {
               this.Name = name;
               return this;
           }
       }
    }
}