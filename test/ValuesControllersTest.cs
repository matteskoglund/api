using Xunit;
using TodoApi.Controllers;

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

        public void PassingTest()
        {
            Assert.NotNull(_valuesController);
        }

    }
}
