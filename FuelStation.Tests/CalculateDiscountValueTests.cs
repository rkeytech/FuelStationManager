using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FuelStation.Model.Handlers;

namespace FuelStation.Tests
{
    public class CalculateDiscountValueTests
    {
        [Theory]
        [InlineData(25, 0.2, 5)]
        [InlineData(2.5, 0.1, 0.25)]
        [InlineData(30, 0, 0)]
        public void CalculateDiscountValue_WithValidArgs_ReturnsDiscountValueCorrectly(double netValue, double discountPercent, double expected)
        {
            // Arrange
            var sut = new TransactionHandler();

            // Act
            var result = sut.CalculateDiscountValue(netValue, discountPercent);

            // Assert
            Assert.Equal(expected, result);
        }
        
        [Theory]
        [InlineData(0, 0.2)]
        [InlineData(-3, 0.1)]
        public void CalculateDiscountValue_WithZeroOrNegativeNetValue_ThrowsArgumentException(double netValue, double discountPercent)
        {
            // Arrange
            var sut = new TransactionHandler();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => sut.CalculateDiscountValue(netValue, discountPercent));
        }
        
        [Theory]
        [InlineData(2.5, -1)]
        [InlineData(3, -2.5)]
        public void CalculateDiscountValue_WithNegativeDiscountPercent_ThrowsArgumentException(double netValue, double discountPercent)
        {
            // Arrange
            var sut = new TransactionHandler();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => sut.CalculateDiscountValue(netValue, discountPercent));
        }
    }
}
