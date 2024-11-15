// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Extensions;

    /// <summary>Static sites user roles invitation link resource.</summary>
    public partial class StaticSiteUserInvitationResponseResource :
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteUserInvitationResponseResource,
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteUserInvitationResponseResourceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResource __proxyOnlyResource = new Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.ProxyOnlyResource();

        /// <summary>The expiration time of the invitation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Inlined)]
        public global::System.DateTime? ExpiresOn { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteUserInvitationResponseResourcePropertiesInternal)Property).ExpiresOn; }

        /// <summary>Resource Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)__proxyOnlyResource).Id; }

        /// <summary>The url for the invitation link</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Inlined)]
        public string InvitationUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteUserInvitationResponseResourcePropertiesInternal)Property).InvitationUrl; }

        /// <summary>Kind of resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Inherited)]
        public string Kind { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)__proxyOnlyResource).Kind; set => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)__proxyOnlyResource).Kind = value ?? null; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)__proxyOnlyResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)__proxyOnlyResource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)__proxyOnlyResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)__proxyOnlyResource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)__proxyOnlyResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)__proxyOnlyResource).Type = value; }

        /// <summary>Internal Acessors for ExpiresOn</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteUserInvitationResponseResourceInternal.ExpiresOn { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteUserInvitationResponseResourcePropertiesInternal)Property).ExpiresOn; set => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteUserInvitationResponseResourcePropertiesInternal)Property).ExpiresOn = value; }

        /// <summary>Internal Acessors for InvitationUrl</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteUserInvitationResponseResourceInternal.InvitationUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteUserInvitationResponseResourcePropertiesInternal)Property).InvitationUrl; set => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteUserInvitationResponseResourcePropertiesInternal)Property).InvitationUrl = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteUserInvitationResponseResourceProperties Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteUserInvitationResponseResourceInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.StaticSiteUserInvitationResponseResourceProperties()); set { {_property = value;} } }

        /// <summary>Resource Name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)__proxyOnlyResource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteUserInvitationResponseResourceProperties _property;

        /// <summary>StaticSiteUserInvitationResponseResource resource specific properties</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteUserInvitationResponseResourceProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.StaticSiteUserInvitationResponseResourceProperties()); set => this._property = value; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>Resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)__proxyOnlyResource).Type; }

        /// <summary>
        /// Creates an new <see cref="StaticSiteUserInvitationResponseResource" /> instance.
        /// </summary>
        public StaticSiteUserInvitationResponseResource()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__proxyOnlyResource), __proxyOnlyResource);
            await eventListener.AssertObjectIsValid(nameof(__proxyOnlyResource), __proxyOnlyResource);
        }
    }
    /// Static sites user roles invitation link resource.
    public partial interface IStaticSiteUserInvitationResponseResource :
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResource
    {
        /// <summary>The expiration time of the invitation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The expiration time of the invitation",
        SerializedName = @"expiresOn",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? ExpiresOn { get;  }
        /// <summary>The url for the invitation link</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The url for the invitation link",
        SerializedName = @"invitationUrl",
        PossibleTypes = new [] { typeof(string) })]
        string InvitationUrl { get;  }

    }
    /// Static sites user roles invitation link resource.
    internal partial interface IStaticSiteUserInvitationResponseResourceInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal
    {
        /// <summary>The expiration time of the invitation</summary>
        global::System.DateTime? ExpiresOn { get; set; }
        /// <summary>The url for the invitation link</summary>
        string InvitationUrl { get; set; }
        /// <summary>StaticSiteUserInvitationResponseResource resource specific properties</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IStaticSiteUserInvitationResponseResourceProperties Property { get; set; }

    }
}