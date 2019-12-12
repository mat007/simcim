﻿using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMConcreteJob : CIMJob
    {
        protected CIMConcreteJob()
        {
        }

        protected CIMConcreteJob(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public System.UInt16? JobState
        {
            get
            {
                System.UInt16? result;
                this.GetProperty("JobState", out result);
                return result;
            }

            set
            {
                this.SetProperty("JobState", value);
            }
        }

        public System.DateTime? TimeBeforeRemoval
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("TimeBeforeRemoval", out result);
                return result;
            }

            set
            {
                this.SetProperty("TimeBeforeRemoval", value);
            }
        }

        public System.DateTime? TimeOfLastStateChange
        {
            get
            {
                System.DateTime? result;
                this.GetProperty("TimeOfLastStateChange", out result);
                return result;
            }

            set
            {
                this.SetProperty("TimeOfLastStateChange", value);
            }
        }

        public System.UInt32 RequestStateChange(System.UInt16? inRequestedState, System.DateTime? inTimeoutPeriod)
        {
            var parameters = new CimMethodParametersCollection();
            if (inRequestedState.HasValue)
                parameters.Add(CimMethodParameter.Create("RequestedState", inRequestedState.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("RequestedState", null, CimFlags.NullValue));
            if (inTimeoutPeriod.HasValue)
                parameters.Add(CimMethodParameter.Create("TimeoutPeriod", inTimeoutPeriod.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("TimeoutPeriod", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "RequestStateChange", parameters);
            return (System.UInt32)result.ReturnValue.Value;
        }

        public (System.UInt32 retval, System.String outError) GetError()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "GetError", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (System.String)result.OutParameters["Error"].Value);
        }
    }
}