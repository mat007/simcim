﻿using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.StandardCimV2
{
    public abstract class PARAMETERS : GenericInfrastructureObject
    {
        protected PARAMETERS()
        {
        }

        protected PARAMETERS(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }
    }
}