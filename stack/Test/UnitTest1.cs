using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using stack; 


namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        
        public void Test_count()
        {
            int n = 2;
            Stack s = new Stack(n);
            s.Push("1");
            s.Push("2");
            Int32.TryParse(s.Count(n).ToString() , out int csk);
            Assert.AreEqual(n, csk);
            
        }
        [TestMethod]
        public void Test_pop()
        {
            int n = 2;
            Stack s = new Stack(n);
            s.Push("1");
            s.Push("2");
            s.Pop(); 
            Int32.TryParse(s.Count(n).ToString(), out int csk);
            Assert.AreEqual(1, csk);

        }

    }
}
