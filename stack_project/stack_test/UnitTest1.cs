using System;
using stack_project;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace stack_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void stack_campacity()
        {
            int campacity = 3;
            Stack s = new Stack(campacity);
           
                for (int i = 0; i < 5; i++)
                {
                    s.Push("element" + i);
                }

            Assert.AreEqual(campacity, s.Count());
        }
        [TestMethod]
        public void push_check()
        {
            int campacity = 1;
            Stack s = new Stack(campacity);
            s.Push("test");

            Assert.AreEqual("test", s.Peek());

        }
        [TestMethod]
        public void peek_test()
        {
            int campacity = 2;
            Stack s = new Stack(campacity);
            s.Push("test");

            Assert.AreEqual("test", s.Peek());
            s.Push("result");
            Assert.AreEqual("result", s.Peek());


        }
        [TestMethod]
        public void pop_test()
        {
            int campacity = 2;
            Stack s = new Stack(campacity);
            s.Push("test");

            Assert.AreEqual("test", s.Peek());
            s.Push("result");
            Assert.AreEqual("result", s.Peek());
            s.Pop();
            Assert.AreEqual("test", s.Peek());
            s.Pop();
            Assert.AreEqual("Stack is Empty", s.Peek());

        }
        [TestMethod]
        public void isEmpty_test()
        {
            int campacity = 2;
            Stack s = new Stack(campacity);
      
            Assert.IsTrue(s.isEmpty());
            s.Push("NowIsNotEmpty");
            Assert.IsFalse(s.isEmpty());

        }
        [TestMethod]
        public void isFull_test()
        {
            int campacity = 2;
            Stack s = new Stack(campacity);

            Assert.IsFalse(s.isFull());
            s.Push("NowIsNotEmpty");
            Assert.IsFalse(s.isFull());
            s.Push("Now is Full");
            Assert.IsTrue(s.isFull());

        }
        [TestMethod]
        public void clear_test()
        {
            int campacity = 10;
            Stack s = new Stack(campacity);
            for (int i = 0; i < 10; i++)
            {
                s.Push(i.ToString());
            }

            Assert.IsFalse(s.isEmpty());
            s.Clear();
            Assert.IsTrue(s.isEmpty());

        }
        [TestMethod]
        public void Count_test()
        {
            int campacity = 10;
            Stack s = new Stack(campacity);

            Assert.AreEqual(0, s.Count());

            for (int i = 0; i < 10; i++)
            {
                s.Push(i.ToString());
            }
           
            Assert.AreEqual(10, s.Count());
            s.Pop();
            Assert.AreEqual(9, s.Count());
            s.Clear();

            Assert.AreEqual(0, s.Count());

        }



    }
}
