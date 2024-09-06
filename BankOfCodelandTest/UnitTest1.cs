using BankOfCodeland;

namespace BankOfCodelandTest;

public class MakeTransferValidator
{
    private readonly DateTime _today = DateTime.Today;
    
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void DateNotPastValidator_ShouldPass_WhenTransferDateIsToday()
    {
        // Arrange
        var sut = new DateNotPastValidator(() => _today);
        var transfer = MakeTransfer.Dummy with { Date = _today };
        
        Assert.IsTrue(sut.IsValid(transfer));
    }
}