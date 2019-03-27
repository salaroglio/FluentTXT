using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentTXT.UnitTest
{
    [TestClass]
    public class UTCheckMapping
    {
        [TestMethod]
        public void Should_Deserialize()
        {
            var mapper = new ZucchettiMovimentiPagheMap();
            var workingText = File.ReadAllText(@".\TestFiles\PPTRCG.D");
            var listOfObjects = mapper.Get(workingText);
            Assert.IsTrue(listOfObjects.Count == 286);
        }
    }
    
}
