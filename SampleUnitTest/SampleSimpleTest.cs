using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdaptivIntegration.SampleMule;
using Newtonsoft.Json;

namespace AdaptivIntegration.SampleUnitTest
{
    [TestClass]
    public class SampleSimpleTest
    {
        [TestMethod]
        public void TestSampleSimple()
        {
            SampleSimple simple = new SampleSimple();
            object simpleResponse = simple.ExecuteSimple("bob", 10);

            string json = JsonConvert.SerializeObject(simpleResponse, Formatting.None);

            Assert.AreEqual(@"{""Name"":""MULED UP bob"",""Age"":10}", json);
        }
    }
}
