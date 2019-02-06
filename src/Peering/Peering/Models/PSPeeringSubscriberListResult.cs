// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.PowerShell.Cmdlets.Peering.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The ARM paginated class.
    /// </summary>
    public partial class PSPeeringSubscriberListResult
    {
        /// <summary>
        /// Initializes a new instance of the PSPeeringSubscriberListResult
        /// class.
        /// </summary>
        public PSPeeringSubscriberListResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PSPeeringSubscriberListResult
        /// class.
        /// </summary>
        /// <param name="value">Gets or sets the value.</param>
        /// <param name="nextLink">Gets or sets the next link.</param>
        public PSPeeringSubscriberListResult(IList<PSPeeringSubscriber> value = default(IList<PSPeeringSubscriber>), string nextLink = default(string))
        {
            Value = value;
            NextLink = nextLink;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<PSPeeringSubscriber> Value { get; set; }

        /// <summary>
        /// Gets or sets the next link.
        /// </summary>
        [JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; set; }

    }
}