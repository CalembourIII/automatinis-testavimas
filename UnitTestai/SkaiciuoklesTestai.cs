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

        [TestCase(6, 4, 1.5)]
        [TestCase(8, 4, 2)]
        [TestCase(1, 3, 0.3333333333333333)]
        [Test]
        public void Dalyba(int int1, int int2, double rez)
        {
            Assert.AreEqual(rez, Skaiciuokles.Skaiciuokles.Dalyba(int1, int2));
        }

        [TestCase(6, 4, 10)]
        [TestCase(8, 4, 12)]
        [TestCase(1, 3, 4)]
        [Test]
        public void Suma(int int1, int int2, int rez)
        {
            Assert.AreEqual(rez, Skaiciuokles.Skaiciuokles.Suma(int1, int2));
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
    }
}
