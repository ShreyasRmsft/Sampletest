using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataDrivenTestProject
{
    [TestClass, ExcludeFromCodeCoverage]
    public class UnitTests
    {
        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {
            tempFile = Path.Combine(Path.GetTempPath(), "tempfile.txt");
        }

        static IEnumerable<object[]> ReusableTestDataProperty
        {
            get
            {
                return new[]
                    {   new object[] {1, 2, 3},
                        new object[] {4, 5, 6}
                    };
            }
        }

        static IEnumerable<object[]> ReusableTestDataMethod()
        {
            return new[]
                        {   new object[] {1, 2, 3},
                        new object[] {4, 5, 6}
                    };
        }

        // Property ReusableTestDataProperty can be used as data source for test data with data driven test case.
        [TestMethod]
        [DynamicData("ReusableTestDataProperty")]
        public void DynamicDataTestMethod1(int a, int b, int c)
        {
            if (a == 4)
            {
                if (!File.Exists(tempFile))
                {
                    File.WriteAllText(tempFile, "1");
                }
            }
        }

        // Method ReusableTestDataMethod can be used as data source for test data with data driven test case.
        [TestMethod]
        [DynamicData("ReusableTestDataMethod", DynamicDataSourceType.Method)]
        public void DynamicDataTestMethod2(int a, int b, int c)
        {
            if (a == 4)
            {
                if (File.Exists(tempFile))
                {
                    if (int.Parse(File.ReadAllText(tempFile)) == 1)
                    {
                        Assert.Fail();
                    }

                    File.Delete(tempFile);
                }
            }
        }

        // Property ReusableTestDataProperty can be used as data source for test data with data driven test case.
        [TestMethod]
        [DynamicData("ReusableTestDataProperty")]
        public void DynamicDataTestMethod3(int a, int b, int c)
        {
            if (a == 4)
            {
                if (File.Exists(tempFile))
                {
                    File.WriteAllText(tempFile, "2");
                }
            }
        }

        private static string tempFile;
    }
}
