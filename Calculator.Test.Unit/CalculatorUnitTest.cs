using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace Calculator.Test.Unit
{
    [TestFixture]
    public class CalculatorUnitTest
    {
        [Test]
        public void add_add10and10Returns20()
        {
            // variablen uut, står for 'unit under test'
            var uut = new Calculator();
            Assert.That(uut.add(10,10), Is.EqualTo(20));

        }

        [Test]
        public void add_add10and20Returns30()
        {
            // variablen uut, står for 'unit under test'
            var uut = new Calculator();
            Assert.That(uut.add(10, 20), Is.EqualTo(30));

        }

        [Test]
        public void subtract_subtractMinus1andMinus20()
        {
            var uut = new Calculator();
            Assert.That(uut.subtract(-1,-20), Is.EqualTo(19));
        }
        
    }
}
