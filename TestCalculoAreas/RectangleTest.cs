using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCalculoAreas
{
    [TestClass]
    public class RectangleTest
    {
        [TestMethod]
        public void CalculateArea_Base2height2()
        {
            // Arrange
            double Base = 2;
            double height = 2;

            Calculo_de_areas.Rectangle rectangulo = new Calculo_de_areas.Rectangle(Base, height);

            // Act
            rectangulo.CalculateArea();

            // Assert
            Assert.AreEqual(rectangulo.GetArea(), 4);
        }

        [TestMethod]
        public void CalculateArea_Base3height5()
        {
            // Arrange
            double Base = 3;
            double height = 5;

            Calculo_de_areas.Rectangle rectangulo = new Calculo_de_areas.Rectangle(Base, height);

            // Act
            rectangulo.CalculateArea();

            // Assert
            Assert.AreEqual(rectangulo.GetArea(), 15);
        }
    }
}
