﻿using Microsoft.Management.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using SimCim.Core;

namespace SimCim.Root.Virtualization.V2
{
    public class MsvmReplicationService : CIMService
    {
        public MsvmReplicationService()
        {
        }

        public MsvmReplicationService(IInfrastructureObjectScope scope, CimInstance instance): base(scope, instance)
        {
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) ModifyServiceSettings(System.String inSettingData)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("SettingData", inSettingData, inSettingData == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ModifyServiceSettings", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) AddAuthorizationEntry(System.String inAuthorizationEntry)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("AuthorizationEntry", inAuthorizationEntry, inAuthorizationEntry == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "AddAuthorizationEntry", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) ModifyAuthorizationEntry(System.String inAuthorizationEntry)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("AuthorizationEntry", inAuthorizationEntry, inAuthorizationEntry == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ModifyAuthorizationEntry", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) RemoveAuthorizationEntry(System.String inAllowedPrimaryHostSystem)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("AllowedPrimaryHostSystem", inAllowedPrimaryHostSystem, inAllowedPrimaryHostSystem == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "RemoveAuthorizationEntry", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) TestReplicationConnection(System.UInt16? inAuthenticationType, System.Boolean? inBypassProxyServer, System.String inCertificateThumbPrint, System.String inRecoveryConnectionPoint, System.UInt16? inRecoveryServerPortNumber)
        {
            var parameters = new CimMethodParametersCollection();
            if (inAuthenticationType.HasValue)
                parameters.Add(CimMethodParameter.Create("AuthenticationType", inAuthenticationType.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("AuthenticationType", null, CimFlags.NullValue));
            if (inBypassProxyServer.HasValue)
                parameters.Add(CimMethodParameter.Create("BypassProxyServer", inBypassProxyServer.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("BypassProxyServer", null, CimFlags.NullValue));
            parameters.Add(CimMethodParameter.Create("CertificateThumbPrint", inCertificateThumbPrint, inCertificateThumbPrint == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("RecoveryConnectionPoint", inRecoveryConnectionPoint, inRecoveryConnectionPoint == null ? CimFlags.NullValue : CimFlags.None));
            if (inRecoveryServerPortNumber.HasValue)
                parameters.Add(CimMethodParameter.Create("RecoveryServerPortNumber", inRecoveryServerPortNumber.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("RecoveryServerPortNumber", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "TestReplicationConnection", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) CreateReplicationRelationship(CIMComputerSystem inComputerSystem, System.String inReplicationSettingData)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("ComputerSystem", inComputerSystem.AsCimInstance(), inComputerSystem == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("ReplicationSettingData", inReplicationSettingData, inReplicationSettingData == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "CreateReplicationRelationship", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) ModifyReplicationSettings(CIMComputerSystem inComputerSystem, System.String inReplicationSettingData)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("ComputerSystem", inComputerSystem.AsCimInstance(), inComputerSystem == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("ReplicationSettingData", inReplicationSettingData, inReplicationSettingData == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ModifyReplicationSettings", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) RemoveReplicationRelationship(CIMComputerSystem inComputerSystem)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("ComputerSystem", inComputerSystem.AsCimInstance(), inComputerSystem == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "RemoveReplicationRelationship", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) RemoveReplicationRelationshipEx(CIMComputerSystem inComputerSystem, System.String inReplicationRelationship)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("ComputerSystem", inComputerSystem.AsCimInstance(), inComputerSystem == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("ReplicationRelationship", inReplicationRelationship, inReplicationRelationship == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "RemoveReplicationRelationshipEx", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) StartReplication(CIMComputerSystem inComputerSystem, System.String inInitialReplicationExportLocation, System.UInt16? inInitialReplicationType, System.DateTime? inStartTime)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("ComputerSystem", inComputerSystem.AsCimInstance(), inComputerSystem == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("InitialReplicationExportLocation", inInitialReplicationExportLocation, inInitialReplicationExportLocation == null ? CimFlags.NullValue : CimFlags.None));
            if (inInitialReplicationType.HasValue)
                parameters.Add(CimMethodParameter.Create("InitialReplicationType", inInitialReplicationType.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("InitialReplicationType", null, CimFlags.NullValue));
            if (inStartTime.HasValue)
                parameters.Add(CimMethodParameter.Create("StartTime", inStartTime.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("StartTime", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "StartReplication", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) ImportInitialReplica(CIMComputerSystem inComputerSystem, System.String inInitialReplicationImportLocation)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("ComputerSystem", inComputerSystem.AsCimInstance(), inComputerSystem == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("InitialReplicationImportLocation", inInitialReplicationImportLocation, inInitialReplicationImportLocation == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ImportInitialReplica", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) ReverseReplicationRelationship(CIMComputerSystem inComputerSystem, System.String inReplicationSettingData)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("ComputerSystem", inComputerSystem.AsCimInstance(), inComputerSystem == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("ReplicationSettingData", inReplicationSettingData, inReplicationSettingData == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ReverseReplicationRelationship", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) InitiateFailover(CIMComputerSystem inComputerSystem, CIMVirtualSystemSettingData inSnapshotSettingData)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("ComputerSystem", inComputerSystem.AsCimInstance(), inComputerSystem == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("SnapshotSettingData", inSnapshotSettingData.AsCimInstance(), inSnapshotSettingData == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "InitiateFailover", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) RevertFailover(CIMComputerSystem inComputerSystem)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("ComputerSystem", inComputerSystem.AsCimInstance(), inComputerSystem == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "RevertFailover", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) CommitFailover(CIMComputerSystem inComputerSystem)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("ComputerSystem", inComputerSystem.AsCimInstance(), inComputerSystem == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "CommitFailover", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob, CIMComputerSystem outResultingSystem) TestReplicaSystem(CIMComputerSystem inComputerSystem, CIMVirtualSystemSettingData inSnapshotSettingData)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("ComputerSystem", inComputerSystem.AsCimInstance(), inComputerSystem == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("SnapshotSettingData", inSnapshotSettingData.AsCimInstance(), inSnapshotSettingData == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "TestReplicaSystem", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value), (CIMComputerSystem)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["ResultingSystem"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) Resynchronize(CIMComputerSystem inComputerSystem, System.DateTime? inStartTime)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("ComputerSystem", inComputerSystem.AsCimInstance(), inComputerSystem == null ? CimFlags.NullValue : CimFlags.None));
            if (inStartTime.HasValue)
                parameters.Add(CimMethodParameter.Create("StartTime", inStartTime.Value, CimFlags.None));
            else
                parameters.Add(CimMethodParameter.Create("StartTime", null, CimFlags.NullValue));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "Resynchronize", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) SetFailoverNetworkAdapterSettings(CIMComputerSystem inComputerSystem, System.String[] inNetworkSettings)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("ComputerSystem", inComputerSystem.AsCimInstance(), inComputerSystem == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("NetworkSettings", inNetworkSettings, inNetworkSettings == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetFailoverNetworkAdapterSettings", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob, System.String[] outReplicationHealthIssues, System.String[] outReplicationStatistics) GetReplicationStatistics(CIMComputerSystem inComputerSystem)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("ComputerSystem", inComputerSystem.AsCimInstance(), inComputerSystem == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "GetReplicationStatistics", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value), (System.String[])result.OutParameters["ReplicationHealthIssues"].Value, (System.String[])result.OutParameters["ReplicationStatistics"].Value);
        }

        public (System.UInt32 retval, CIMConcreteJob outJob, System.String[] outReplicationHealthIssues, System.String[] outReplicationStatistics) GetReplicationStatisticsEx(CIMComputerSystem inComputerSystem, System.String inReplicationRelationship)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("ComputerSystem", inComputerSystem.AsCimInstance(), inComputerSystem == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("ReplicationRelationship", inReplicationRelationship, inReplicationRelationship == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "GetReplicationStatisticsEx", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value), (System.String[])result.OutParameters["ReplicationHealthIssues"].Value, (System.String[])result.OutParameters["ReplicationStatistics"].Value);
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) ResetReplicationStatistics(CIMComputerSystem inComputerSystem)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("ComputerSystem", inComputerSystem.AsCimInstance(), inComputerSystem == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ResetReplicationStatistics", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) ResetReplicationStatisticsEx(CIMComputerSystem inComputerSystem, System.String inReplicationRelationship)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("ComputerSystem", inComputerSystem.AsCimInstance(), inComputerSystem == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("ReplicationRelationship", inReplicationRelationship, inReplicationRelationship == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ResetReplicationStatisticsEx", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) SetAuthorizationEntry(System.String inAuthorizationEntry, CIMComputerSystem inComputerSystem)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("AuthorizationEntry", inAuthorizationEntry, inAuthorizationEntry == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("ComputerSystem", inComputerSystem.AsCimInstance(), inComputerSystem == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "SetAuthorizationEntry", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, System.String[] outEncodedCertificates) GetSystemCertificates()
        {
            var parameters = new CimMethodParametersCollection();
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "GetSystemCertificates", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (System.String[])result.OutParameters["EncodedCertificates"].Value);
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) ChangeReplicationModeToPrimary(CIMComputerSystem inComputerSystem, System.String inReplicationRelationship)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("ComputerSystem", inComputerSystem.AsCimInstance(), inComputerSystem == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("ReplicationRelationship", inReplicationRelationship, inReplicationRelationship == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "ChangeReplicationModeToPrimary", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }

        public (System.UInt32 retval, CIMConcreteJob outJob) InitiateFailback(CIMComputerSystem inComputerSystem, System.String inRecoveryPointIdentifier, System.String inReplicationSettingData)
        {
            var parameters = new CimMethodParametersCollection();
            parameters.Add(CimMethodParameter.Create("ComputerSystem", inComputerSystem.AsCimInstance(), inComputerSystem == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("RecoveryPointIdentifier", inRecoveryPointIdentifier, inRecoveryPointIdentifier == null ? CimFlags.NullValue : CimFlags.None));
            parameters.Add(CimMethodParameter.Create("ReplicationSettingData", inReplicationSettingData, inReplicationSettingData == null ? CimFlags.NullValue : CimFlags.None));
            var result = InfrastuctureObjectScope.CimSession.InvokeMethod(InnerCimInstance, "InitiateFailback", parameters);
            return ((System.UInt32)result.ReturnValue.Value, (CIMConcreteJob)InfrastuctureObjectScope.Mapper.Create((CimInstance)result.OutParameters["Job"].Value));
        }
    }
}