
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Text;

////////////////////////////////////////////////////////////////////////////////
//  Code from: TestClass02.cs                                                 //
////////////////////////////////////////////////////////////////////////////////

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

////////////////////////////////////////////////////////////////////////////////
//  Code from: TestClass03.cs                                                 //
////////////////////////////////////////////////////////////////////////////////

    class TestClass03
    {
        public void Dosomething(string bla)
        {
            Console.WriteLine(bla);
        }
    }
