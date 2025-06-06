// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Soenneker.Telnyx.OpenApiClient.Campaign.AcceptSharing.Item;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Soenneker.Telnyx.OpenApiClient.Campaign.AcceptSharing
{
    /// <summary>
    /// Builds and executes requests for operations under \campaign\acceptSharing
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class AcceptSharingRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Soenneker.Telnyx.OpenApiClient.campaign.acceptSharing.item collection</summary>
        /// <param name="position">TCR&apos;s ID for the campaign to import</param>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Campaign.AcceptSharing.Item.WithCampaignItemRequestBuilder"/></returns>
        public global::Soenneker.Telnyx.OpenApiClient.Campaign.AcceptSharing.Item.WithCampaignItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("campaignId", position);
                return new global::Soenneker.Telnyx.OpenApiClient.Campaign.AcceptSharing.Item.WithCampaignItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Campaign.AcceptSharing.AcceptSharingRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AcceptSharingRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/campaign/acceptSharing", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Campaign.AcceptSharing.AcceptSharingRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AcceptSharingRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/campaign/acceptSharing", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
