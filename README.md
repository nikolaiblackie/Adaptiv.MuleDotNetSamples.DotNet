Adaptiv.MuleDotNetSamples.DotNet
================================
The following VS.NET 2013 project contains sample class libraries that demonstrate MuleESB dotNet connector features.

The classes are referenced from https://github.com/nikolaiblackie/Adaptiv.MuleDotNetSamples.MuleEsb

* SampleMule - A sample class library demonstrating primitave and message parameter based method calls.

* BizTalk Samples - The following items are utilised in a BizTalk Business Rules engine sample, an installation of BizTalk server is a prerequsite to run these. 
  * BRE	- sample policy and vocab, both must me imported to the BRE to run the sample
  * SampleBRE	- sample class library that programatically calls the BizTalk business rules engine
  * BizTalkSample	- a sample BizTalk project and schema for the rules engine example, does not require deployment for sample

* Referenced Assemblies - the following included references are used in the library.
  * Newtonsoft.Json.dll	- JSON libary for .NET used in unit tests to serialise and deserialize messages
  * Org.Mule.Api.dll	MuleSoft library required to mark up methods with message parameter references

* SampleUnitTest - sample unit tests for classes
