using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Visitor
    {
        public static void mymain()
        {
            var pdf=new PDFFile();
            var ppt=new PPTFile();
            var list=new List<ResourceFile>();
            list.Add(pdf);
            list.Add(ppt);
            var howlog=new Log();
            var howsize=new WriteSize();
            foreach (var f in list)
            {
                f.DoSomething(howlog);
                f.DoSomething(howsize);
            }
            
        }
    }

   public class Log:IDoSomething
    {
        public void Exe(PDFFile file)
        {
            Console.WriteLine("pdf log");
        }

        public void Exe(PPTFile file)
        {
            Console.WriteLine("ppt log");
        }
    }

   public class WriteSize : IDoSomething
   {
       public void Exe(PDFFile file)
       {
           Console.WriteLine("ppt size");
       }

       public void Exe(PPTFile file)
       {
           Console.WriteLine("ppt size");
       }
   }

  public  interface IDoSomething
    {
        void Exe(PDFFile file);
        void Exe(PPTFile file);
        
    }

  public abstract class ResourceFile
  {
      public abstract void DoSomething(IDoSomething ds);
  }
   public  class PDFFile:ResourceFile
    {
        public override void DoSomething(IDoSomething ds)
        {
            ds.Exe(this);
        }
    }
    
   public class PPTFile:ResourceFile
    {
        public override void DoSomething(IDoSomething ds)
        {
            ds.Exe(this);
        }
    }
}