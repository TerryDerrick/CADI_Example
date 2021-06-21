using CADI_Example.Domain.Model;
using CADI_Example.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using Xunit;

namespace CommonFunctionsLib.Tests
{
   

    public class UnitTest1:IClassFixture<DbFixture>
    {

        private ServiceProvider _serviceProvider;

        public UnitTest1(DbFixture fixture)
        {
            _serviceProvider = fixture.ServiceProvider;
        }

        [Theory]
        [InlineData(1, 1, 2)]
        public void AdditionTests(int value1, int value2, int expectedvalue)
        {
            ICommonFunctions commonFunctions = _serviceProvider.GetRequiredService<ICommonFunctions>();

            int output = commonFunctions.Addition(value1, value2);

            Assert.Equal(output, expectedvalue);

        }

        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(10, 5, 5)]
        public void SubtractionTests(int value1, int value2, int expectedvalue)
        {
            ICommonFunctions commonFunctions = _serviceProvider.GetRequiredService<ICommonFunctions>();

            int output = commonFunctions.Subtract(value1, value2);

            Assert.Equal(output, expectedvalue);

        }
    }

    public class DbFixture
    {
        public DbFixture()
        {
            var serviceCollection = new ServiceCollection();

                serviceCollection.AddSingleton<IDateTime, MachineDateTime>();
            serviceCollection.AddSingleton<ICommonFunctions, CommonFunctions>();

            ServiceProvider = serviceCollection.BuildServiceProvider();
        }

        public ServiceProvider ServiceProvider { get; private set; }
    }
}
