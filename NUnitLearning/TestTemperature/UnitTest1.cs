namespace TestTemperature;

[TestFixture]
public class Tests
{
    private TemperatureConverter temperatureConverter;
    [SetUp]
    public void Setup()
    {
        temperatureConverter = new TemperatureConverter();
    }

    [TestCase(0, 32)]
    [TestCase(100, 212)]
    [TestCase(37, 98.6)]
    [TestCase(-40, -40)]
    public void CelsiusToFahrenheit_ReturnCorrectValue(double celsius, double expectedFahr)
    {
        double result = temperatureConverter.CelsiusToFahrenheit(celsius);
        
        Assert.That(result, Is.EqualTo(expectedFahr).Within(0.1));
    }


    [TestCase(32, 0)]
        [TestCase(212, 100)]
        [TestCase(98.6, 37)]
        [TestCase(-40, -40)]
        public void FahrenheitToCelsius_ShouldReturnCorrectValue(double fahrenheit, double expectedCelsius)
        {
            // Act
            double result = temperatureConverter.FahrenheitToCelsius(fahrenheit);

            // Assert 
            Assert.That(result, Is.EqualTo(expectedCelsius).Within(0.1));
        }
}
