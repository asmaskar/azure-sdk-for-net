// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ServiceFabric.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Specifies set of extensions that should be installed onto the virtual
    /// machines.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class VMSSExtension
    {
        /// <summary>
        /// Initializes a new instance of the VMSSExtension class.
        /// </summary>
        public VMSSExtension()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VMSSExtension class.
        /// </summary>
        /// <param name="name">The name of the extension.</param>
        /// <param name="publisher">The name of the extension handler
        /// publisher.</param>
        /// <param name="type">Specifies the type of the extension; an example
        /// is "CustomScriptExtension".</param>
        /// <param name="typeHandlerVersion">Specifies the version of the
        /// script handler.</param>
        /// <param name="forceUpdateTag">If a value is provided and is
        /// different from the previous value, the extension handler will be
        /// forced to update even if the extension configuration has not
        /// changed.</param>
        /// <param name="autoUpgradeMinorVersion">Indicates whether the
        /// extension should use a newer minor version if one is available at
        /// deployment time. Once deployed, however, the extension will not
        /// upgrade minor versions unless redeployed, even with this property
        /// set to true.</param>
        /// <param name="settings">Json formatted public settings for the
        /// extension.</param>
        /// <param name="protectedSettings">The extension can contain either
        /// protectedSettings or protectedSettingsFromKeyVault or no protected
        /// settings at all.</param>
        /// <param name="provisioningState">The provisioning state, which only
        /// appears in the response.</param>
        /// <param name="provisionAfterExtensions">Collection of extension
        /// names after which this extension needs to be provisioned.</param>
        public VMSSExtension(string name, string publisher, string type, string typeHandlerVersion, string forceUpdateTag = default(string), bool? autoUpgradeMinorVersion = default(bool?), object settings = default(object), object protectedSettings = default(object), string provisioningState = default(string), IList<string> provisionAfterExtensions = default(IList<string>))
        {
            Name = name;
            ForceUpdateTag = forceUpdateTag;
            Publisher = publisher;
            Type = type;
            TypeHandlerVersion = typeHandlerVersion;
            AutoUpgradeMinorVersion = autoUpgradeMinorVersion;
            Settings = settings;
            ProtectedSettings = protectedSettings;
            ProvisioningState = provisioningState;
            ProvisionAfterExtensions = provisionAfterExtensions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the extension.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets if a value is provided and is different from the
        /// previous value, the extension handler will be forced to update even
        /// if the extension configuration has not changed.
        /// </summary>
        [JsonProperty(PropertyName = "properties.forceUpdateTag")]
        public string ForceUpdateTag { get; set; }

        /// <summary>
        /// Gets or sets the name of the extension handler publisher.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publisher")]
        public string Publisher { get; set; }

        /// <summary>
        /// Gets or sets specifies the type of the extension; an example is
        /// "CustomScriptExtension".
        /// </summary>
        [JsonProperty(PropertyName = "properties.type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets specifies the version of the script handler.
        /// </summary>
        [JsonProperty(PropertyName = "properties.typeHandlerVersion")]
        public string TypeHandlerVersion { get; set; }

        /// <summary>
        /// Gets or sets indicates whether the extension should use a newer
        /// minor version if one is available at deployment time. Once
        /// deployed, however, the extension will not upgrade minor versions
        /// unless redeployed, even with this property set to true.
        /// </summary>
        [JsonProperty(PropertyName = "properties.autoUpgradeMinorVersion")]
        public bool? AutoUpgradeMinorVersion { get; set; }

        /// <summary>
        /// Gets or sets json formatted public settings for the extension.
        /// </summary>
        [JsonProperty(PropertyName = "properties.settings")]
        public object Settings { get; set; }

        /// <summary>
        /// Gets or sets the extension can contain either protectedSettings or
        /// protectedSettingsFromKeyVault or no protected settings at all.
        /// </summary>
        [JsonProperty(PropertyName = "properties.protectedSettings")]
        public object ProtectedSettings { get; set; }

        /// <summary>
        /// Gets the provisioning state, which only appears in the response.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets collection of extension names after which this
        /// extension needs to be provisioned.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisionAfterExtensions")]
        public IList<string> ProvisionAfterExtensions { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Publisher == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Publisher");
            }
            if (Type == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Type");
            }
            if (TypeHandlerVersion == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TypeHandlerVersion");
            }
        }
    }
}
