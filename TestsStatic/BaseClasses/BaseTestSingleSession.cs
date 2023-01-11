using FrameworkStatic.Pages.DemoQA;
using FrameworkStatic;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsStatic.BaseClasses
{
    internal class BaseTestSingleSession
    {
        [OneTimeSetUp]
        public void SetUp()
        {
            Driver.Initialize();
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.CloseDriver();
        }
    }
}
