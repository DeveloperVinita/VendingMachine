using NUnit.Framework;
using VendingMachine;
namespace VendingMachineTest
{
    [TestFixture]
     class VendingMachineTest
    {
        VendingMachines vm;

        [SetUp]
        public void Init()
        {
            vm = new VendingMachines();
        }
        [Test]
        public void ValidateQuarter_Success()
        {
            VendingMachineBaseClass.CustomerWallet=0.25m;
            Assert.AreEqual(0.25m, VendingMachineBaseClass.CustomerWallet);
        }
        [Test]
        public void ValidateQuarter_Fail()
        {
            VendingMachineBaseClass.CustomerWallet = 0.05m;
            Assert.AreNotEqual(0.25m, VendingMachineBaseClass.CustomerWallet);
        }
        [Test]
        public void ValidateNickels_Success()
        {
            VendingMachineBaseClass.CustomerWallet = 0.05m;
            Assert.AreEqual(0.05m, VendingMachineBaseClass.CustomerWallet);
        }
        [Test]
        public void ValidateNickels_Fail()
        {
            VendingMachineBaseClass.CustomerWallet = 0.25m;
            Assert.AreNotEqual(0.05m, VendingMachineBaseClass.CustomerWallet);
        }
        [Test]
        public void ValidateDimes_Success()
        {
            VendingMachineBaseClass.CustomerWallet = 0.1m;
            Assert.AreEqual(0.1m, VendingMachineBaseClass.CustomerWallet);
        }
        [Test]
        public void ValidateDimes_Fail()
        {
            VendingMachineBaseClass.CustomerWallet = 0.25m;
            Assert.AreNotEqual(0.1m, VendingMachineBaseClass.CustomerWallet);
        }
    }
}
