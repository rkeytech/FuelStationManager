using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FuelStation.Model.Handlers;

namespace FuelStation.Tests
{
    public class CalculateLineTotalValueTests
    {
        [Theory]
        [InlineData(5, 30, 25)]
        [InlineData(2.5, 7, 4.5)]
        [InlineData(0, 10, 10)]
        public void CalculateLineTotalValue_WithValidArgs_ReturnsTotalValueCorrectly(double discountValue, double netValue, double expected)
        {
            // Arrange
            var sut = new TransactionHandler();

            // Act
            var result = sut.CalculateLineTotalValue(discountValue, netValue);

            // Assert
            Assert.Equal(expected, result);
        }
        
        [Theory]
        [InlineData(-2.5, 0.2)]
        [InlineData(-3, 0.1)]
        public void CalculateLineTotalValue_WithNegativeDiscountValue_ThrowsArgumentException(double discountValue, double netValue)
        {
            // Arrange
            var sut = new TransactionHandler();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => sut.CalculateLineTotalValue(discountValue, netValue));
        }
        
        [Theory]
        [InlineData(2.5, 0)]
        [InlineData(3, -2.5)]
        public void CalculateLineTotalValue_WithZeroOrNegativeNetValue_ThrowsArgumentException(double discountValue, double netValue)
        {
            // Arrange
            var sut = new TransactionHandler();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => sut.CalculateLineTotalValue(discountValue, netValue));
        }
    }
}
