using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.Mule.Api;
namespace AdaptivIntegration.SampleMule
{
    public class SampleComplex
    {
        public object ExecuteComplex([MuleMessage(From = MessagePart.FromBody)] JsonRequestContract jsonRequestContract)
        {
            return new { Name = "MULED UP ", Email = jsonRequestContract.Email };
        }
    }
}
