using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.RuleEngine;
using System.Xml;


namespace AdaptivIntegration.SampleBRE
{
    public class SampleBreCall
    {

        public XmlDocument RunHardCodePolicy(XmlDocument request)
        {
            //load request into typed document
            TypedXmlDocument txd = new TypedXmlDocument("AdaptivIntegration.BizTalkSample.SampleSchema", request);

            //load BRE policy from the BTS Rules Engine DB
            Policy policy = new Policy("AdaptivIntegration.BizTalkSample.Policy");

            //Execute the policy
            policy.Execute(txd);

            //load up modified document as response
            XmlDocument response = new XmlDocument();
            response.LoadXml(txd.Document.OuterXml);

            return response;
        }
    }
}
