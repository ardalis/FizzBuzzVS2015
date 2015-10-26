using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzzConsole.Model;

namespace FizzBuzz.UnitTests
{
    [TestClass]
    public class FizzBuzzServiceFormatNumberShould
    {
        private FizzBuzzService _fizzBuzzService;
        [TestInitialize]
        public void Setup()
        {
            _fizzBuzzService = new FizzBuzzService();
        }

        [TestMethod]
        public void Return1Given1()
        {
            var result = _fizzBuzzService.FormatNumber(1);

            Assert.AreEqual("1", result);
        }

        [TestMethod]
        public void Return2Given2()
        {
            var result = _fizzBuzzService.FormatNumber(2);

            Assert.AreEqual("2", result);
        }

        [TestMethod]
        public void ReturnFizzGiven3()
        {
            var result = _fizzBuzzService.FormatNumber(3);

            Assert.AreEqual("Fizz", result);
        }
        [TestMethod]
        public void ReturnFizzGiven6()
        {
            var result = _fizzBuzzService.FormatNumber(6);

            Assert.AreEqual("Fizz", result);
        }

        [TestMethod]
        public void ReturnBuzzGiven5()
        {
            var result = _fizzBuzzService.FormatNumber(5);

            Assert.AreEqual("Buzz", result);
        }

        [TestMethod]
        public void ReturnBuzzGiven10()
        {
            var result = _fizzBuzzService.FormatNumber(10);

            Assert.AreEqual("Buzz", result);
        }
        [TestMethod]
        public void ReturnFizzBuzzGiven15()
        {
            var result = _fizzBuzzService.FormatNumber(15);

            Assert.AreEqual("FizzBuzz", result);
        }
    }
}
