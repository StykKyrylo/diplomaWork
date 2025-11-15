using Xunit;
namespace DiplomaTests
{
    public class ValidatorTests
    {
        private readonly Validator _validator = new Validator();

        [Fact]
        public void IsPositive_PositiveNumber_ReturnsTrue()
        {
            int number = 10;
            var result = _validator.IsPositive(number);
            Assert.True(result);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-5)]
        public void IsPositive_ZeroAndNegative_ReturnsFalse(int number)
        {
            var result = _validator.IsPositive(number);
            Assert.False(result);
        }
    }
}