using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FuelStation.Model.Handlers;

namespace FuelStation.Tests
{
    public class CalculateNetValueTests
    {
        [Theory]
        [InlineData(2.5, 4, 10)]
        [InlineData(4, 3.21, 12.84)]
        [InlineData(2.52, 2.32, 5.85)]
        public void CalculateNetValue_WithValidArgs_ReturnsNetValueCorrectly(double quantity, double price, double expected)
        {
            // Arrange
            var sut = new TransactionHandler();

            // Act
            var result = sut.CalculateNetValue(quantity, price);

            // Assert
            Assert.Equal(expected, result);
        }
        
        [Theory]
        [InlineData(0, 2.5)]
        [InlineData(-3, 2.5)]
        public void CalculateNetValue_WithZeroOrNegativeQuantity_ThrowsArgumentException(double quantity, double price)
        {
            // Arrange
            var sut = new TransactionHandler();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => sut.CalculateNetValue(quantity, price));
        }
        
        [Theory]
        [InlineData(2.5, 0)]
        [InlineData(3, -2)]
        public void CalculateNetValue_WithZeroOrNegativePrice_ThrowsArgumentException(double quantity, double price)
        {
            // Arrange
            var sut = new TransactionHandler();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => sut.CalculateNetValue(quantity, price));
        }
    }
}
