using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdaptivIntegration.SampleMule;
using Newtonsoft.Json;

namespace AdaptivIntegration.SampleUnitTest
{
    [TestClass]
    public class SampleComplexTest
    {
        [TestMethod]
        public void TestSampleComplex()
        {
            SampleComplex Complex = new SampleComplex();

            string input = "{ 'Email': 'james@example.com', 'Active': true }";

            JsonRequestContract request = JsonConvert.DeserializeObject<JsonRequestContract>(input);

            object complexResponse = Complex.ExecuteComplex(request);

            string json = JsonConvert.SerializeObject(complexResponse, Formatting.None);

            Assert.AreEqual(@"{""Name"":""MULED UP "",""Email"":""james@example.com""}", json);
        }
    }
}
