// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401
{
    using Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.PowerShell;

    /// <summary>Edge Device properties</summary>
    [System.ComponentModel.TypeConverter(typeof(EdgeDevicePropertiesTypeConverter))]
    public partial class EdgeDeviceProperties
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.EdgeDeviceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IEdgeDeviceProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IEdgeDeviceProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new EdgeDeviceProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.EdgeDeviceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IEdgeDeviceProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IEdgeDeviceProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new EdgeDeviceProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.EdgeDeviceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal EdgeDeviceProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("DeviceConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IEdgeDevicePropertiesInternal)this).DeviceConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IDeviceConfiguration) content.GetValueForProperty("DeviceConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IEdgeDevicePropertiesInternal)this).DeviceConfiguration, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.DeviceConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IEdgeDevicePropertiesInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IEdgeDevicePropertiesInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ProvisioningState.CreateFrom);
            }
            if (content.Contains("DeviceConfigurationNicDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IEdgeDevicePropertiesInternal)this).DeviceConfigurationNicDetail = (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.INicDetail[]) content.GetValueForProperty("DeviceConfigurationNicDetail",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IEdgeDevicePropertiesInternal)this).DeviceConfigurationNicDetail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.INicDetail>(__y, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.NicDetailTypeConverter.ConvertFrom));
            }
            if (content.Contains("DeviceConfigurationDeviceMetadata"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IEdgeDevicePropertiesInternal)this).DeviceConfigurationDeviceMetadata = (string) content.GetValueForProperty("DeviceConfigurationDeviceMetadata",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IEdgeDevicePropertiesInternal)this).DeviceConfigurationDeviceMetadata, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.EdgeDeviceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal EdgeDeviceProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("DeviceConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IEdgeDevicePropertiesInternal)this).DeviceConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IDeviceConfiguration) content.GetValueForProperty("DeviceConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IEdgeDevicePropertiesInternal)this).DeviceConfiguration, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.DeviceConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IEdgeDevicePropertiesInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IEdgeDevicePropertiesInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ProvisioningState.CreateFrom);
            }
            if (content.Contains("DeviceConfigurationNicDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IEdgeDevicePropertiesInternal)this).DeviceConfigurationNicDetail = (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.INicDetail[]) content.GetValueForProperty("DeviceConfigurationNicDetail",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IEdgeDevicePropertiesInternal)this).DeviceConfigurationNicDetail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.INicDetail>(__y, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.NicDetailTypeConverter.ConvertFrom));
            }
            if (content.Contains("DeviceConfigurationDeviceMetadata"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IEdgeDevicePropertiesInternal)this).DeviceConfigurationDeviceMetadata = (string) content.GetValueForProperty("DeviceConfigurationDeviceMetadata",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IEdgeDevicePropertiesInternal)this).DeviceConfigurationDeviceMetadata, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="EdgeDeviceProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="EdgeDeviceProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IEdgeDeviceProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Edge Device properties
    [System.ComponentModel.TypeConverter(typeof(EdgeDevicePropertiesTypeConverter))]
    public partial interface IEdgeDeviceProperties

    {

    }
}