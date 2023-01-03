using NUnit.Framework;
using NUnit.Framework.Constraints;
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
        // 1. Testas “žalias” jeigu 995 dalijasi iš 3 (be liekanos)
        // 2. Testas “žalias” jeigu šiandien trečiadienis
        //      naudoti ChatGPT, kad išsiaiškinti kaip C# dirbti su dienomis
        // 3. Testas “žalias” jeigu dabar yra 13h
        //      naudoti ChatGPT, kad išsiaiškinti kaip C# dirbti su valandomis
        //
        // 4. Bonus: Testas “žalias” jei nuo 1 iki 10 yra 4 lyginiai skaičiai

        [Test]
        public void DalybosTestas()
        {
            // Duomenys
            double expectedResult = 0;

            // Veiksmai
            double actualResult = 995 % 3;

            // Patikrinimas
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Ar_Siandien_Treciadienis()
        {
            bool expectedResult = true;

            //bool actualResult = true;

            if (DateTime.Today.DayOfWeek == DayOfWeek.Wednesday)
            {
                expectedResult = true;
            }
            else
            {
                expectedResult = false;
            }

            //Assert.AreEqual(expectedResult, actualResult);
            Assert.IsTrue(expectedResult);
        }

        [Test]
        public void Ar_dabar_13_val()
        {
            bool expectedResult = true;

            bool actualResult = true;

            if (DateTime.Now.Hour == 13)
            {
                actualResult = true;
            }
            else
            {
                actualResult = false;
            }

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Lyginiai_nuo_1_iki_10()
        {
            int expectedResult = 4;

            int actualResult = 0;

            for(int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    actualResult++;
                }
            }

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
