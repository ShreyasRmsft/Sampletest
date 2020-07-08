using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace CodedUITestProject3
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CodedUITest1
    {
        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {
            tempFile = Path.Combine(Path.GetTempPath(), "tempfile.txt");
        }

        public CodedUITest1()
        {
        }

        [TestMethod]
        public void CodedUITest111()
        {
            if (!File.Exists(tempFile))
            {
                File.WriteAllText(tempFile, "1");
            }
        }

        [TestMethod]
        public void CodedUITest112()
        {
            if (File.Exists(tempFile))
            {
                if (int.Parse(File.ReadAllText(tempFile)) == 1)
                {
                    File.WriteAllText(tempFile, "2");
                    Assert.Fail();
                }

                File.Delete(tempFile);
            }
        }

        [TestMethod]
        public void CodedUITest113()
        {
            //Always pass
        }

        [TestMethod]
        public void CodedUITest114()
        {
            //Always pass
        }

        [TestMethod]
        public void CodedUITest115()
        {
            //Always pass
        }

        [TestMethod]
        public void CodedUITest116()
        {
            //Always pass
        }

        #region Additional test attributes

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        public UIMap UIMap
        {
            get
            {
                if (this.map == null)
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private static string tempFile;
        private UIMap map;
    }
}
