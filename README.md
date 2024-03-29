Adaptiv.MuleDotNetSamples.DotNet
================================
The following VS.NET 2013 project contains sample class libraries that demonstrate MuleESB dotNet connector features.

The classes are referenced from https://github.com/nikolaiblackie/Adaptiv.MuleDotNetSamples.MuleEsb , API overview published to http://api-portal.anypoint.mulesoft.com/adaptiv-integration/api/adaptiv-integration-complex-dotnet-sample/

Samples part of Auckland Code Camp 2014 presentation demonstrations  http://www.slideshare.net/nikolaiadaptiv/mule-anypoint-platform-dot-net-alice-in-a-java-integration-wonderland

References used to build samples:
* Dotnet Connector
  * http://www.mulesoft.org/documentation/display/current/DotNet+Connector 
* MSMQ Connector
 * http://www.mulesoft.org/documentation/display/current/MSMQ+Connector 
* Mule Blogs
 * http://blogs.mulesoft.org/solutions-for-microsoft/ 
 * http://blogs.mulesoft.org/integrating-mule-esb-net-based-rules-engines/ 

Overview of solution items:
* SampleMule - A sample class library demonstrating primitave and message parameter based method calls.

* BizTalk Samples - The following items are utilised in a BizTalk Business Rules engine sample, an installation of BizTalk server is a prerequsite to run these. 
  * BRE	- sample policy and vocab, both must me imported to the BRE to run the sample
  * SampleBRE	- sample class library that programatically calls the BizTalk business rules engine
  * BizTalkSample	- a sample BizTalk project and schema for the rules engine example, does not require deployment for sample

* Referenced Assemblies - the following included references are used in the library.
  * Newtonsoft.Json.dll	- JSON libary for .NET used in unit tests to serialise and deserialize messages
  * Org.Mule.Api.dll	MuleSoft library required to mark up methods with message parameter references

* SampleUnitTest - sample unit tests for classes
