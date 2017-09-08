using NSubstitute;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace MongoDB_Clean_Code
{
    [TestClass]
    public class PersonServiceTest
    {
        private IPerson _person;
      

        private PersonService _personService;

        [TestInitialize]
        public void Initialize()
        {
            _person = Substitute.For<IPerson>();
            _personService = new PersonService(_person);
        }

        [TestMethod]
        public void ChangeStock_WhenProductNotNull_Change()
        {


            _personService.ChangeStock(Arg.Any<string>(), Arg.Any<string>())
                .Returns(true);

            // Act
            var result = _personService.ChangeStock("a", "b");

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ChangeStock_WhenProductNull_WriteLogMessage()
        {
            // Act
            _personService.ChangeStock("a","b");
            
        }

        [TestCleanup]
        public void Cleanup()
        {
            _person = null;
        }
    }
}
