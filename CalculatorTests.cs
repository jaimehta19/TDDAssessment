using NUnit.Framework;
using System;

[TestFixture]
public class CalculatorTests
{
    [Test]
    public void TestEmptyString()
    {
        Assert.AreEqual(0, Calculator.Add(""));
    }

    [Test]
    public void TestSingleNumber()
    {
        
        Assert.AreEqual(1, Calculator.Add("1"));
    }

    [Test]
    public void TestTwoNumbers()
    {
        
        Assert.AreEqual(3, Calculator.Add("1,2"));
    }

    [Test]
    public void TestNewLineDelimiter()
    {
        
        Assert.AreEqual(6, Calculator.Add("1\n2,3"));
    }

    [Test]
    public void TestCustomDelimiter()
    {
       
        Assert.AreEqual(3, Calculator.Add("//;\n1;2"));
    }

    [Test]
    public void TestNegativeNumbers()
    {
        
        var ex = Assert.Throws<ArgumentException>(() => Calculator.Add("1,-2,3,-4"));
        Assert.AreEqual("Negative numbers not allowed: -2, -4", ex.Message);
    }
}
