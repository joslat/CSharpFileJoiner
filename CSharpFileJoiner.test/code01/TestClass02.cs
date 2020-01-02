using System;
using System.Collections.Generic;
using System.Text;

namespace ConsTestApp
{
    interface IInterface
    {
        bool returnsomething();
    }

    class TestClass02
    {
        public TestClass02()
        {

        }

        public int MyProperty { get; set; }

        public void Dosomething(string bla)
        {
            Console.WriteLine(bla);
        }
    }
}
