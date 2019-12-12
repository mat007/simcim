﻿using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmResourcePoolConfigurationService : CIMService
    {
        public MsvmResourcePoolConfigurationService()
        {
        }

        public MsvmResourcePoolConfigurationService(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public (System.UInt32 retval, CIMConcreteJob outJob, CIMResourcePool outPool) CreatePool(System.String[] inAllocationSettings, IEnumerable<CIMResourcePool> inParentPools, System.String inPoolSettings)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("AllocationSettings", inAllocationSettings, inAllocationSettings == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("ParentPools", inParentPools.AsCimInstance(), inParentPools == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("PoolSettings", inPoolSettings, inPoolSettings == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "CreatePool", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value), (CIMResourcePool)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Pool"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) ModifyPoolResources(System.String[] inAllocationSettings, CIMResourcePool inChildPool, IEnumerable<CIMResourcePool> inParentPools)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("AllocationSettings", inAllocationSettings, inAllocationSettings == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("ChildPool", inChildPool.AsCimInstance(), inChildPool == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("ParentPools", inParentPools.AsCimInstance(), inParentPools == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ModifyPoolResources", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) ModifyPoolSettings(CIMResourcePool inChildPool, System.String inPoolSettings)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("ChildPool", inChildPool.AsCimInstance(), inChildPool == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("PoolSettings", inPoolSettings, inPoolSettings == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ModifyPoolSettings", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) DeletePool(CIMResourcePool inPool)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("Pool", inPool.AsCimInstance(), inPool == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "DeletePool", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }
    }
}