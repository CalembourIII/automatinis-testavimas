using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestai
{
    public class SkaiciuoklesTestai
    {
        [Test]
        public void SumosTestas()
        {
            // Duomenys
            int expectedResult = 10;

            // Veiksmai
            int actualResult = Skaiciuokles.Skaiciuokles.Suma(5, 5);

            // Patikrinimas
            Assert.AreEqual(expectedResult, actualResult);

            // Galima dar parašyti šitaip:
            // Assert.True(expectedResult== actualResult, $"Tikiuosi: {expectedResult}; rezultatas: {actualResult})");
        }

        [Test]
        public void AtimtiesTestas()
        {
            int expectedResult = 10;

            int actualResult = Skaiciuokles.Skaiciuokles.Atimtis(20, 10);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void SandaugosTestas()
        {
            int expectedResult = 100;

            int actualResult = Skaiciuokles.Skaiciuokles.Sandauga(10, 10);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void DalybosTestas()
        {
            double expectedResult = 1.5;

            double actualResult = Skaiciuokles.Skaiciuokles.Dalyba(6, 4);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
