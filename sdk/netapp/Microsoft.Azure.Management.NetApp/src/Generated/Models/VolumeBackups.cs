// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.NetApp.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Volume details using the backup policy
    /// </summary>
    public partial class VolumeBackups
    {
        /// <summary>
        /// Initializes a new instance of the VolumeBackups class.
        /// </summary>
        public VolumeBackups()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VolumeBackups class.
        /// </summary>
        /// <param name="volumeName">Volume name</param>
        /// <param name="backupsCount">Total count of backups for
        /// volume</param>
        /// <param name="policyEnabled">Policy enabled</param>
        public VolumeBackups(string volumeName = default(string), int? backupsCount = default(int?), bool? policyEnabled = default(bool?))
        {
            VolumeName = volumeName;
            BackupsCount = backupsCount;
            PolicyEnabled = policyEnabled;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets volume name
        /// </summary>
        [JsonProperty(PropertyName = "volumeName")]
        public string VolumeName { get; set; }

        /// <summary>
        /// Gets or sets total count of backups for volume
        /// </summary>
        [JsonProperty(PropertyName = "backupsCount")]
        public int? BackupsCount { get; set; }

        /// <summary>
        /// Gets or sets policy enabled
        /// </summary>
        [JsonProperty(PropertyName = "policyEnabled")]
        public bool? PolicyEnabled { get; set; }

    }
}