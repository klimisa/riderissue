using System;

namespace RiderIssue.Core
{
    public enum EnmFoo
    {
        A,
        B
    }
    
    public class Foo
    {
        public readonly EnmFoo EnmFooProp;

        public Func<int, string> TheIssue()
        {
            return EnmFooProp switch
            {
                EnmFoo.A => (_) => "A",
                EnmFoo.B => (_) => "B",
                _ => throw new InvalidOperationException()
            };
        }
    }
}