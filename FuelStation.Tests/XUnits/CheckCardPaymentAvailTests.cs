using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FuelStation.Model.Handlers;

namespace FuelStation.Tests
{
    public class CheckCardPaymentAvailTests
    {
        [Theory]
        [InlineData(20, true)]
        [InlineData(0, true)]
        [InlineData(60, false)]
        public void CheckCardPaymentAvail_WithValidArgs_ReturnsCardPaymentAvailabilityCorrectly(double totalValue, bool expected)
        {
            // Arrange
            var sut = new TransactionHandler();

            // Act
            var result = sut.CheckCardPaymentAvail(totalValue);

            // Assert
            Assert.Equal(expected, result);
        }
        
        [Theory]
        [InlineData(-2.5)]
        [InlineData(-3)]
        public void CheckCardPaymentAvail_WithNegativeTotalValue_ThrowsArgumentException(double totalValue)
        {
            // Arrange
            var sut = new TransactionHandler();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => sut.CheckCardPaymentAvail(totalValue));
        }
    }
}
