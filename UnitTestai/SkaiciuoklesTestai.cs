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
            int laukiamaSuma = 10;

            // Veiksmai
            int tikrojiSuma = Skaiciuokles.Skaiciuokles.Suma(5, 5);

            // Patikrinimas
            Assert.AreEqual(laukiamaSuma, tikrojiSuma);

        }

        [Test]
        public void AtimtiesTestas()
        {
            // Duomenys
            int laukiamaAtimtis = 10;

            // Veiksmai
            int tikrojiAtimtis = Skaiciuokles.Skaiciuokles.Atimtis(10, 10);

            // Patikrinimas
            Assert.AreEqual(laukiamaAtimtis, tikrojiAtimtis);

        }

        [Test]
        public void SandaugosTestas()
        {
            // Duomenys
            int laukiamaSandauga = 100;

            // Veiksmai
            int tikrojiSandauga = Skaiciuokles.Skaiciuokles.Sandauga(10, 10);

            // Patikrinimas
            Assert.AreEqual(laukiamaSandauga, tikrojiSandauga);

        }

        [Test]
        public void DalybosTestas()
        {
            // Duomenys
            double laukiamaDalyba = 2.3;

            // Veiksmai
            double tikrojiDalyba = Skaiciuokles.Skaiciuokles.Dalyba(7, 3);

            // Patikrinimas
            Assert.AreEqual(laukiamaDalyba, tikrojiDalyba);

        }
    }
}
