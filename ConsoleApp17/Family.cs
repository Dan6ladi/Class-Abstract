using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    // this is an abstract class
    internal abstract class Family
    {
        // father and role does not return any value
        public abstract void father();
        public void role() 
        {
            Console.WriteLine("Father is: Head of the family");
        }
    }
    //This class was inherited from the class Family
    class Son : Family 
    {
        public override void father()
        {
           Console.WriteLine("Son is: first child");
        }
    }

}
