using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework.Internal;

namespace TestCalculoAreas
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void CalculateArea_Radio5_Result78()
        {
            // Arrange
            double radio = 5;

            Calculo_de_areas.Circle circulo = new Calculo_de_areas.Circle (radio);

            // Act
            circulo.CalculateArea();

            // Assert
            Assert.AreEqual(circulo.getArea(), 78.539816339744831);
        }

        [TestMethod]
        public void CalculateArea_Radio6_Result113()
        {
            // Arrange
            double radio = 6;

            Calculo_de_areas.Circle circulo = new Calculo_de_areas.Circle(radio);

            // Act
            circulo.CalculateArea();

            // Assert
            Assert.AreEqual(circulo.getArea(), 113.09733552923255);
        }

        [TestMethod]
        public void CalculateArea_Radio7_Result153()
        {
            // Arrange
            double radio = 7;

            Calculo_de_areas.Circle circulo = new Calculo_de_areas.Circle(radio);

            // Act
            circulo.CalculateArea();

            // Assert
            Assert.AreEqual(circulo.getArea(), 153.93804002589985);
        }

        [TestMethod]
        public void CalculateArea_Radio8_Result201()
        {
            // Arrange
            double radio = 8;

            Calculo_de_areas.Circle circulo = new Calculo_de_areas.Circle(radio);

            // Act
            circulo.CalculateArea();

            // Assert
            Assert.AreEqual(circulo.getArea(), 201.06192982974676);
        }
    }
}
