﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptivIntegration.SampleMule
{
    
    public class JsonRequestContract
    {
        const string jsonExample = @"{'Email': 'james@example.com','Active': true}";

        public string Email { get; set; }
        public bool Active { get; set; }
    }



}
