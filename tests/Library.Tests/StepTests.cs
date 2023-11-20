using Full_GRASP_And_SOLID;

public class StepTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CorrectCreation()
    {
        Product myProduct = new Product("café", 55.0);
        Equipment myEquipment = new Equipment("batidora", 80.0);
        Step step = new Step(myProduct, 25.0, myEquipment, 6);

        string expected = "25 de 'café' usando 'batidora' durante 6";
        string myResult = step.GetTextToPrint();

        Assert.That(myResult, Is.EqualTo(expected));
    }

    [Test]
    public void CorrectGetStepCpst()
    {
        Product myProduct = new Product("café", 55.0);
        Equipment myEquipment = new Equipment("batidora", 80.0);
        Step step = new Step(myProduct, 25.0, myEquipment, 6);

        double expected = 1855;
        double myResult = step.GetStepCost();

        Assert.That(myResult, Is.EqualTo(expected));
    }
}