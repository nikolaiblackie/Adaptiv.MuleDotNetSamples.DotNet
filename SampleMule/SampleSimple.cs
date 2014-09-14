using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptivIntegration.SampleMule
{
    public class SampleSimple
    {
        public object ExecuteSimple(string name, int age)
        {
            return new { Name = "MULED UP " + name, Age = age };
        }
    }
}
