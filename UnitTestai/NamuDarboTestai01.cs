using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestai
{
    internal class NamuDarboTestai01
    {
        // NamuDarbai 2023-01-03
        // Testas “žalias” jeigu 995 dalijasi iš 3 (be liekanos)
        // Testas “žalias” jeigu šiandien trečiadienis
        //      naudoti ChatGPT, kad išsiaiškinti kaip C# dirbti su dienomis
        // Testas “žalias” jeigu dabar yra 13h
        //      naudoti ChatGPT, kad išsiaiškinti kaip C# dirbti su valandomis
        //
        //      Bonus: Testas “žalias” jei nuo 1 iki 10 yra 4 lyginiai skaičiai

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
    }
}
