// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.CommonDataModel.ObjectModel.Persistence.Syms.Models
{
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Query artifacts response.
    /// </summary>
    public partial class QueryArtifactsResponse
    {
        /// <summary>
        /// Initializes a new instance of the QueryArtifactsResponse class.
        /// </summary>
        public QueryArtifactsResponse() { }

        /// <summary>
        /// Initializes a new instance of the QueryArtifactsResponse class.
        /// </summary>
        /// <param name="continuationToken">Continuation token to get next
        /// page.</param>
        public QueryArtifactsResponse(System.Collections.Generic.IList<object> items = default(System.Collections.Generic.IList<object>), string continuationToken = default(string))
        {
            Items = items;
            ContinuationToken = continuationToken;
        }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "Items")]
        public System.Collections.Generic.IList<object> Items { get; set; }

        /// <summary>
        /// Gets or sets continuation token to get next page.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "ContinuationToken")]
        public string ContinuationToken { get; set; }

    }
}