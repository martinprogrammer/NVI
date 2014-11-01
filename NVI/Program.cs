using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NVI
{
    class Program
    {
        static void Main(string[] args)
        {
            Base myBase = new Base();
            myBase.MyProperty = 2;
            Console.WriteLine(myBase.MyProperty);
            Derived myDerived = new Derived();
            myDerived.MyProperty = 17;
            Console.WriteLine(myDerived.MyProperty);
            Console.Read();
         
        }
    }

    public class Base
    {
        public virtual int MyProperty { get; set; }
        public virtual void DoWork()
        {
            CoreDoWork();
        }

        protected virtual void CoreDoWork()
        {
            Console.WriteLine("Base.DoWork()");
            Console.Read();
        }
    }

    public class Derived : Base
    {
        public override int MyProperty { get { return 1; } }

         public override void DoWork()
        {
            Console.WriteLine(hello);
            Console.Read();
        }
        protected override void CoreDoWork()
        {
            Console.WriteLine("Derived one");
            base.CoreDoWork();
            Console.Read();
            
        }

    }
}
