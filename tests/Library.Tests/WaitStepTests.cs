using Full_GRASP_And_SOLID;

public class WaitStepTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CorrectCreation()
    {
        WaitStep step = new WaitStep("cafe", 7);

        string expected = "Esperando 'cafe' durante 7";
        string myResult = step.GetTextToPrint();

        Assert.That(myResult, Is.EqualTo(expected));
    }
}