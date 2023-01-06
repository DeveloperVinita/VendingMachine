using NUnit.Framework;
using VendingMachine;

namespace VendingMachineTest
{
    public class ProductTest
    {
        VendingMachines vm;
        [SetUp]
        public void Init()
        {
            vm = new VendingMachines();
        }
        [Test]
        public void Product_Validate_ColaPrice()
        {
            Assert.AreEqual(1, ProductInit.Cola.Price);
        }
        [Test]
        public void Product_Validate_ChipsPrice()
        {
            Assert.AreEqual(0.50, ProductInit.Chips.Price);
        }
        [Test]
        public void Product_Validate_CandyPrice()
        {
            Assert.AreEqual(0.65, ProductInit.Candy.Price);
        }


    }
}