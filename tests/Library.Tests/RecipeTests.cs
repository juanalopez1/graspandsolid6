using Full_GRASP_And_SOLID;

namespace Library.Tests;

public class RecipeTests
{
    [Test]
    public void CorrectGetProductionCost()
    {
        Product myProduct = new Product("café", 55.0);
        Equipment myEquipment = new Equipment("batidora", 80.0);
        Product myProduct2 = new Product("leche", 23.0);
        Equipment myEquipment2 = new Equipment("", 0);

        Recipe myRecipe = new Recipe();
        myRecipe.AddStep(myProduct, 2.0, myEquipment, 2);
        myRecipe.AddStep(myProduct2, 1.0, myEquipment2, 0);

        double expected = 293;
        double myResult = myRecipe.GetProductionCost();

        Assert.That(myResult, Is.EqualTo(expected));
    }

    [Test]
    public void CorrectGetCookTime()
    {
        Product myProduct = new Product("café", 55.0);
        Equipment myEquipment = new Equipment("batidora", 80.0);
        Product myProduct2 = new Product("leche", 23.0);
        Equipment myEquipment2 = new Equipment("", 0);

        Recipe myRecipe = new Recipe();
        myRecipe.AddStep(myProduct, 2.0, myEquipment, 2);
        myRecipe.AddStep(myProduct2, 1.0, myEquipment2, 0);

        int expected = 2;
        int myResult = myRecipe.GetCookTime();

        Assert.That(myResult, Is.EqualTo(expected));
    }

    [Test]
    public void CorrectCook()
    {
        Product myProduct = new Product("café", 55.0);
        Equipment myEquipment = new Equipment("batidora", 80.0);
        Product myProduct2 = new Product("leche", 23.0);
        Equipment myEquipment2 = new Equipment("", 0);

        Recipe myRecipe = new Recipe();
        myRecipe.AddStep(myProduct, 2.0, myEquipment, 2);
        myRecipe.AddStep(myProduct2, 1.0, myEquipment2, 0);

        Assert.IsFalse(myRecipe.Cooked);
        myRecipe.Cook();
        Assert.IsTrue(myRecipe.Cooked);
    }

}