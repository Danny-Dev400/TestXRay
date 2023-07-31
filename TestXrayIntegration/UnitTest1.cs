namespace TestXrayIntegration
{
    [TestFixture]
    public class Tests
    {
        [TestCase(1, 1, 2)]
        [TestCase(-1, -1, -2)]
        [TestCase(100, 5, 105)]
        [Category("CALC_1")]
        [Category("fast")]
        [Property("Requirement", "CALC-69")]
        [Property("Test", "CALC-10")]
        public void CanAddNumbers(int a, int b, int expected)
        {
            Assert.That(Calculator.Add(a, b), Is.EqualTo(expected));
        }


        [TestCase(1, 1, 0)]
        [TestCase(-1, -1, 0)]
        [TestCase(100, 5, 95)]
        [Category("CALC_2")]
        public void CanSubtract(int x, int y, int expected)
        {
            Assert.That(Calculator.Subtract(x, y), Is.EqualTo(expected));
        }
    }
}