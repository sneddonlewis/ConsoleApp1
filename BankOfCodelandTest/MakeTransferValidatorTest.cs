using BankOfCodeland;

namespace BankOfCodelandTest;

public class MakeTransferValidatorTest
{
    private readonly DateTime _today = DateTime.Today;
    
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void DateNotPastValidator_ShouldPass_WhenTransferDateIsToday()
    {
        var sut = new DateNotPastValidator(() => _today);
        var transfer = MakeTransfer.Dummy with { Date = _today };
        
        Assert.IsTrue(sut.IsValid(transfer));
    }

    [TestCase(+1, ExpectedResult = true)]
    [TestCase(0, ExpectedResult = true)]
    [TestCase(-1, ExpectedResult = false)]
    public bool DateNotPastValidator_ShouldFail_WhenTransferDateIsPast(int offset)
    {
        var sut = new DateNotPastValidator(() => _today);
        var transfer = MakeTransfer.Dummy with { Date = _today.AddDays(offset) };

        return sut.IsValid(transfer);
    }
}