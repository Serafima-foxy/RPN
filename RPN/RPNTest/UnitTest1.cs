using NUnit.Framework;
using System;
using RPN;
using System.Collections.Generic;

namespace RPNTest
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase('(', 0)]
        [TestCase(')', 1)]
        [TestCase('+', 2)]
        [TestCase('-', 3)]
        [TestCase('*', 4)]
        [TestCase('/', 4)]
        [TestCase('^', 5)]
        public void GetPriorityMethod(char oper, int expRes)
        {
            int actRes = new Methods().GetPriority(oper);
            Assert.AreEqual(expRes, actRes);
        }

        [TestCase('(', true)]
        [TestCase(')', true)]
        [TestCase('+', true)]
        [TestCase('-', true)]
        [TestCase('*', true)]
        [TestCase('/', true)]
        [TestCase('^', true)]
        [TestCase('f', false)]
        [TestCase('5', false)]
        [TestCase('#', false)]
        [TestCase('!', false)]

        public void IsOperatorMethod(char oper, bool expRes)
        {
            bool actRes = new Methods().IsOperator(oper);
            Assert.AreEqual(expRes, actRes);
        }

        [TestCase('=', true)]
        [TestCase(' ', true)]
        [TestCase('+', false)]
        [TestCase('/', false)]
        [TestCase('g', false)]
        [TestCase('#', false)]
        public void IsDelimeterMethod(char oper, bool expRes)
        {
            bool actRes = new Methods().IsDelimeter(oper);
            Assert.AreEqual(expRes, actRes);
        }

        [TestCase("2+3/2-4", -0.5)]
        [TestCase("3+4*2/(1-5)^2", 3.5)]
        [TestCase("3+4*2/(1-5)^0", 11)]
        [TestCase("4*0/(1-5)^2", 0)]
        public void CalculateMethod(string expression, double expRes)
        {
            double actRes = new Methods().Calculate(expression);
            Assert.AreEqual(expRes, actRes);
        }
    }
}
