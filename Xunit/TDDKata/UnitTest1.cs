using RandomTestClass;
using Xunit;

namespace TDDKata;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var randomBorrower = new Borrower(20000);

        randomBorrower.askForMoreMoney(250);

        Assert.Equal(randomBorrower.returnBalance(),20250);
    }
}