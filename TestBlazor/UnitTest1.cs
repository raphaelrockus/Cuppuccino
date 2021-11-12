using Bunit;
using Cuppuccino.Client.Pages;
using System;
using Xunit;

namespace TestBlazor
{
    public class UnitTest1
    {
        public TestContext testContext { get; set; }

        [Fact]
        public void TestComponent()
        {
            testContext = new TestContext();
            var sut = testContext.RenderComponent<Counter>();
            var button = Assert.Single(sut.FindAll("button"));
            var instance = sut.Instance;
            Assert.Equal(0, instance.currentCount);
            button.Click();
            Assert.Equal(1, instance.currentCount);

        }
    }
}
