// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataShare.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A kusto database data set.
    /// </summary>
    [Newtonsoft.Json.JsonObject("KustoDatabase")]
    [Rest.Serialization.JsonTransformation]
    public partial class KustoDatabaseDataSet : DataSet
    {
        /// <summary>
        /// Initializes a new instance of the KustoDatabaseDataSet class.
        /// </summary>
        public KustoDatabaseDataSet()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the KustoDatabaseDataSet class.
        /// </summary>
        /// <param name="kustoDatabaseResourceId">Resource id of the kusto
        /// database.</param>
        /// <param name="id">The resource id of the azure resource</param>
        /// <param name="name">Name of the azure resource</param>
        /// <param name="systemData">System Data of the Azure resource.</param>
        /// <param name="type">Type of the azure resource</param>
        /// <param name="dataSetId">Unique id for identifying a data set
        /// resource</param>
        /// <param name="location">Location of the kusto cluster.</param>
        /// <param name="provisioningState">Provisioning state of the kusto
        /// database data set. Possible values include: 'Succeeded',
        /// 'Creating', 'Deleting', 'Moving', 'Failed'</param>
        public KustoDatabaseDataSet(string kustoDatabaseResourceId, string id = default(string), string name = default(string), SystemData systemData = default(SystemData), string type = default(string), string dataSetId = default(string), string location = default(string), string provisioningState = default(string))
            : base(id, name, systemData, type)
        {
            DataSetId = dataSetId;
            KustoDatabaseResourceId = kustoDatabaseResourceId;
            Location = location;
            ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets unique id for identifying a data set resource
        /// </summary>
        [JsonProperty(PropertyName = "properties.dataSetId")]
        public string DataSetId { get; private set; }

        /// <summary>
        /// Gets or sets resource id of the kusto database.
        /// </summary>
        [JsonProperty(PropertyName = "properties.kustoDatabaseResourceId")]
        public string KustoDatabaseResourceId { get; set; }

        /// <summary>
        /// Gets location of the kusto cluster.
        /// </summary>
        [JsonProperty(PropertyName = "properties.location")]
        public string Location { get; private set; }

        /// <summary>
        /// Gets provisioning state of the kusto database data set. Possible
        /// values include: 'Succeeded', 'Creating', 'Deleting', 'Moving',
        /// 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (KustoDatabaseResourceId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "KustoDatabaseResourceId");
            }
        }
    }
}
