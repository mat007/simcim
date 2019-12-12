﻿using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public abstract class CIMVirtualSystemManagementService : CIMService
    {
        protected CIMVirtualSystemManagementService()
        {
        }

        protected CIMVirtualSystemManagementService(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public (System.UInt32 retval, CIMConcreteJob outJob, IEnumerable<CIMResourceAllocationSettingData> outResultingResourceSettings) AddResourceSettings(CIMVirtualSystemSettingData inAffectedConfiguration, System.String[] inResourceSettings)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("AffectedConfiguration", inAffectedConfiguration.AsCimInstance(), inAffectedConfiguration == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("ResourceSettings", inResourceSettings, inResourceSettings == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "AddResourceSettings", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value), (IEnumerable<CIMResourceAllocationSettingData>)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["ResultingResourceSettings"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob, CIMComputerSystem outResultingSystem) DefineSystem(CIMVirtualSystemSettingData inReferenceConfiguration, System.String[] inResourceSettings, System.String inSystemSettings)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("ReferenceConfiguration", inReferenceConfiguration.AsCimInstance(), inReferenceConfiguration == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("ResourceSettings", inResourceSettings, inResourceSettings == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("SystemSettings", inSystemSettings, inSystemSettings == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "DefineSystem", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value), (CIMComputerSystem)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["ResultingSystem"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) DestroySystem(CIMComputerSystem inAffectedSystem)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("AffectedSystem", inAffectedSystem.AsCimInstance(), inAffectedSystem == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "DestroySystem", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob, IEnumerable<CIMResourceAllocationSettingData> outResultingResourceSettings) ModifyResourceSettings(System.String[] inResourceSettings)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("ResourceSettings", inResourceSettings, inResourceSettings == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ModifyResourceSettings", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value), (IEnumerable<CIMResourceAllocationSettingData>)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["ResultingResourceSettings"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) ModifySystemSettings(System.String inSystemSettings)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("SystemSettings", inSystemSettings, inSystemSettings == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ModifySystemSettings", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) RemoveResourceSettings(IEnumerable<CIMResourceAllocationSettingData> inResourceSettings)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("ResourceSettings", inResourceSettings.AsCimInstance(), inResourceSettings == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "RemoveResourceSettings", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }
    }
}