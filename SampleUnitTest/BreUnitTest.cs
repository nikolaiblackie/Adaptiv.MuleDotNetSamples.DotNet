using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdaptivIntegration.SampleBRE;
using System.Xml;

namespace AdaptivIntegration.SampleUnitTes
{
    [TestClass]
    public class BreUnitTest
    {
        [TestMethod]
        public void TestBre()
        {
            SampleBreCall breCall = new SampleBreCall();
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(@"<ns0:Request xmlns:ns0=""http://AdaptivIntegration.BizTalkSample.SampleSchema""><A>10</A><PlusB>10</PlusB><Equals>0</Equals></ns0:Request>");

            doc = breCall.RunHardCodePolicy(doc);

            Assert.AreEqual(@"<ns0:Request xmlns:ns0=""http://AdaptivIntegration.BizTalkSample.SampleSchema""><A>10</A><PlusB>10</PlusB><Equals>20</Equals></ns0:Request>", doc.OuterXml);
        }
    }
}
