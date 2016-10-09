using Xunit;
using TodoApi.Controllers;
using System.Collections.Generic;

namespace test
{
    // see example explanation on xUnit.net website:
    // https://xunit.github.io/docs/getting-started-dotnet-core.html
    public class ValuesControllersTest
    {
        private readonly ValuesController _valuesController;
        public ValuesControllersTest()
        {
            _valuesController = new ValuesController();
        }
         [Fact]
        public void ValuesController_NotNull()
        {
            Assert.NotNull(_valuesController);
        }

        [Fact]
        public void ValuesController_Index()
        {
            IEnumerable<string> res = _valuesController.Get();
            Assert.NotNull(res);
        }

        [Fact]
        public void ValuesController_GetId_5_Returns()
        {
            string res = _valuesController.Get(5);
                        
            Assert.NotNull(res);
        }

    }
}
