// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Soenneker.Telnyx.OpenApiClient.Models;
using Soenneker.Telnyx.OpenApiClient.Phone_number_campaigns.Item;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Soenneker.Telnyx.OpenApiClient.Phone_number_campaigns
{
    /// <summary>
    /// Builds and executes requests for operations under \phone_number_campaigns
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Phone_number_campaignsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Soenneker.Telnyx.OpenApiClient.phone_number_campaigns.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Phone_number_campaigns.Item.WithPhoneNumberItemRequestBuilder"/></returns>
        public global::Soenneker.Telnyx.OpenApiClient.Phone_number_campaigns.Item.WithPhoneNumberItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("phoneNumber", position);
                return new global::Soenneker.Telnyx.OpenApiClient.Phone_number_campaigns.Item.WithPhoneNumberItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Phone_number_campaigns.Phone_number_campaignsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Phone_number_campaignsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/phone_number_campaigns{?filter%5Btcr_brand_id%5D*,filter%5Btcr_campaign_id%5D*,filter%5Btelnyx_brand_id%5D*,filter%5Btelnyx_campaign_id%5D*,page*,recordsPerPage*,sort*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Phone_number_campaigns.Phone_number_campaignsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Phone_number_campaignsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/phone_number_campaigns{?filter%5Btcr_brand_id%5D*,filter%5Btcr_campaign_id%5D*,filter%5Btelnyx_brand_id%5D*,filter%5Btelnyx_campaign_id%5D*,page*,recordsPerPage*,sort*}", rawUrl)
        {
        }
        /// <summary>
        /// Retrieve All Phone Number Campaigns
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.PhoneNumberCampaignPaginated"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Telnyx.OpenApiClient.Models.Errors">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Models.PhoneNumberCampaignPaginated?> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Phone_number_campaigns.Phone_number_campaignsRequestBuilder.Phone_number_campaignsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Models.PhoneNumberCampaignPaginated> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Phone_number_campaigns.Phone_number_campaignsRequestBuilder.Phone_number_campaignsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Soenneker.Telnyx.OpenApiClient.Models.Errors.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.OpenApiClient.Models.PhoneNumberCampaignPaginated>(requestInfo, global::Soenneker.Telnyx.OpenApiClient.Models.PhoneNumberCampaignPaginated.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Create New Phone Number Campaign
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.PhoneNumberCampaign"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Telnyx.OpenApiClient.Models.Errors">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Models.PhoneNumberCampaign?> PostAsync(global::Soenneker.Telnyx.OpenApiClient.Models.PhoneNumberCampaignCreate body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Models.PhoneNumberCampaign> PostAsync(global::Soenneker.Telnyx.OpenApiClient.Models.PhoneNumberCampaignCreate body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Soenneker.Telnyx.OpenApiClient.Models.Errors.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.OpenApiClient.Models.PhoneNumberCampaign>(requestInfo, global::Soenneker.Telnyx.OpenApiClient.Models.PhoneNumberCampaign.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieve All Phone Number Campaigns
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Phone_number_campaigns.Phone_number_campaignsRequestBuilder.Phone_number_campaignsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Phone_number_campaigns.Phone_number_campaignsRequestBuilder.Phone_number_campaignsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Create New Phone Number Campaign
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Soenneker.Telnyx.OpenApiClient.Models.PhoneNumberCampaignCreate body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Soenneker.Telnyx.OpenApiClient.Models.PhoneNumberCampaignCreate body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Phone_number_campaigns.Phone_number_campaignsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.Telnyx.OpenApiClient.Phone_number_campaigns.Phone_number_campaignsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.Telnyx.OpenApiClient.Phone_number_campaigns.Phone_number_campaignsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Retrieve All Phone Number Campaigns
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Phone_number_campaignsRequestBuilderGetQueryParameters 
        {
            /// <summary>Filter results by the TCR Brand id</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Btcr_brand_id%5D")]
            public string? FiltertcrBrandId { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Btcr_brand_id%5D")]
            public string FiltertcrBrandId { get; set; }
#endif
            /// <summary>Filter results by the TCR Campaign id</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Btcr_campaign_id%5D")]
            public string? FiltertcrCampaignId { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Btcr_campaign_id%5D")]
            public string FiltertcrCampaignId { get; set; }
#endif
            /// <summary>Filter results by the Telnyx Brand id</summary>
            [QueryParameter("filter%5Btelnyx_brand_id%5D")]
            public Guid? FiltertelnyxBrandId { get; set; }
            /// <summary>Filter results by the Telnyx Campaign id</summary>
            [QueryParameter("filter%5Btelnyx_campaign_id%5D")]
            public Guid? FiltertelnyxCampaignId { get; set; }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("page")]
            public string? Page { get; set; }
#nullable restore
#else
            [QueryParameter("page")]
            public string Page { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("recordsPerPage")]
            public string? RecordsPerPage { get; set; }
#nullable restore
#else
            [QueryParameter("recordsPerPage")]
            public string RecordsPerPage { get; set; }
#endif
            /// <summary>Specifies the sort order for results. If not given, results are sorted by createdAt in descending order.</summary>
            [Obsolete("This property is deprecated, use SortAsGetSortQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("sort")]
            public string? Sort { get; set; }
#nullable restore
#else
            [QueryParameter("sort")]
            public string Sort { get; set; }
#endif
            /// <summary>Specifies the sort order for results. If not given, results are sorted by createdAt in descending order.</summary>
            [QueryParameter("sort")]
            public global::Soenneker.Telnyx.OpenApiClient.Phone_number_campaigns.GetSortQueryParameterType? SortAsGetSortQueryParameterType { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Phone_number_campaignsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Phone_number_campaigns.Phone_number_campaignsRequestBuilder.Phone_number_campaignsRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Phone_number_campaignsRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
