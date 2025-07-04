// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Soenneker.Telnyx.OpenApiClient.Portouts.Events;
using Soenneker.Telnyx.OpenApiClient.Portouts.Item;
using Soenneker.Telnyx.OpenApiClient.Portouts.Rejections;
using Soenneker.Telnyx.OpenApiClient.Portouts.Reports;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Soenneker.Telnyx.OpenApiClient.Portouts
{
    /// <summary>
    /// Builds and executes requests for operations under \portouts
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class PortoutsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The events property</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Portouts.Events.EventsRequestBuilder Events
        {
            get => new global::Soenneker.Telnyx.OpenApiClient.Portouts.Events.EventsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The rejections property</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Portouts.Rejections.RejectionsRequestBuilder Rejections
        {
            get => new global::Soenneker.Telnyx.OpenApiClient.Portouts.Rejections.RejectionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The reports property</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Portouts.Reports.ReportsRequestBuilder Reports
        {
            get => new global::Soenneker.Telnyx.OpenApiClient.Portouts.Reports.ReportsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the Soenneker.Telnyx.OpenApiClient.portouts.item collection</summary>
        /// <param name="position">Portout id</param>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Portouts.Item.PortoutsItemRequestBuilder"/></returns>
        public global::Soenneker.Telnyx.OpenApiClient.Portouts.Item.PortoutsItemRequestBuilder this[Guid position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("id", position);
                return new global::Soenneker.Telnyx.OpenApiClient.Portouts.Item.PortoutsItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>Gets an item from the Soenneker.Telnyx.OpenApiClient.portouts.item collection</summary>
        /// <param name="position">Portout id</param>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Portouts.Item.PortoutsItemRequestBuilder"/></returns>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public global::Soenneker.Telnyx.OpenApiClient.Portouts.Item.PortoutsItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("id", position);
                return new global::Soenneker.Telnyx.OpenApiClient.Portouts.Item.PortoutsItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Portouts.PortoutsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PortoutsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/portouts{?filter%5Bcarrier_name%5D*,filter%5Bfoc_date%5D*,filter%5Binserted_at%5D%5Bgte%5D*,filter%5Binserted_at%5D%5Blte%5D*,filter%5Bphone_number%5D*,filter%5Bpon%5D*,filter%5Bported_out_at%5D%5Bgte%5D*,filter%5Bported_out_at%5D%5Blte%5D*,filter%5Bspid%5D*,filter%5Bstatus%5D*,filter%5Bstatus_in%5D*,filter%5Bsupport_key%5D*,page%5Bnumber%5D*,page%5Bsize%5D*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Portouts.PortoutsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PortoutsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/portouts{?filter%5Bcarrier_name%5D*,filter%5Bfoc_date%5D*,filter%5Binserted_at%5D%5Bgte%5D*,filter%5Binserted_at%5D%5Blte%5D*,filter%5Bphone_number%5D*,filter%5Bpon%5D*,filter%5Bported_out_at%5D%5Bgte%5D*,filter%5Bported_out_at%5D%5Blte%5D*,filter%5Bspid%5D*,filter%5Bstatus%5D*,filter%5Bstatus_in%5D*,filter%5Bsupport_key%5D*,page%5Bnumber%5D*,page%5Bsize%5D*}", rawUrl)
        {
        }
        /// <summary>
        /// Returns the portout requests according to filters
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Portouts.PortoutsGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Portouts.PortoutsGetResponse?> GetAsPortoutsGetResponseAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Portouts.PortoutsRequestBuilder.PortoutsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Portouts.PortoutsGetResponse> GetAsPortoutsGetResponseAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Portouts.PortoutsRequestBuilder.PortoutsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.OpenApiClient.Portouts.PortoutsGetResponse>(requestInfo, global::Soenneker.Telnyx.OpenApiClient.Portouts.PortoutsGetResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns the portout requests according to filters
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Portouts.PortoutsResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("This method is obsolete. Use GetAsPortoutsGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Portouts.PortoutsResponse?> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Portouts.PortoutsRequestBuilder.PortoutsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Portouts.PortoutsResponse> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Portouts.PortoutsRequestBuilder.PortoutsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.OpenApiClient.Portouts.PortoutsResponse>(requestInfo, global::Soenneker.Telnyx.OpenApiClient.Portouts.PortoutsResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns the portout requests according to filters
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Portouts.PortoutsRequestBuilder.PortoutsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Portouts.PortoutsRequestBuilder.PortoutsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Portouts.PortoutsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.Telnyx.OpenApiClient.Portouts.PortoutsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.Telnyx.OpenApiClient.Portouts.PortoutsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Returns the portout requests according to filters
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class PortoutsRequestBuilderGetQueryParameters 
        {
            /// <summary>Filter by new carrier name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bcarrier_name%5D")]
            public string? FiltercarrierName { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bcarrier_name%5D")]
            public string FiltercarrierName { get; set; }
#endif
            /// <summary>Filter by foc_date. Matches all portouts with the same date</summary>
            [QueryParameter("filter%5Bfoc_date%5D")]
            public DateTimeOffset? FilterfocDate { get; set; }
            /// <summary>Filter by inserted_at date greater than or equal.</summary>
            [QueryParameter("filter%5Binserted_at%5D%5Bgte%5D")]
            public DateTimeOffset? FilterinsertedAtgte { get; set; }
            /// <summary>Filter by inserted_at date less than or equal.</summary>
            [QueryParameter("filter%5Binserted_at%5D%5Blte%5D")]
            public DateTimeOffset? FilterinsertedAtlte { get; set; }
            /// <summary>Filter by a phone number on the portout. Matches all portouts with the phone number</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bphone_number%5D")]
            public string? FilterphoneNumber { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bphone_number%5D")]
            public string FilterphoneNumber { get; set; }
#endif
            /// <summary>Filter by Port Order Number (PON).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bpon%5D")]
            public string? Filterpon { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bpon%5D")]
            public string Filterpon { get; set; }
#endif
            /// <summary>Filter by ported_out_at date greater than or equal.</summary>
            [QueryParameter("filter%5Bported_out_at%5D%5Bgte%5D")]
            public DateTimeOffset? FilterportedOutAtgte { get; set; }
            /// <summary>Filter by ported_out_at date less than or equal.</summary>
            [QueryParameter("filter%5Bported_out_at%5D%5Blte%5D")]
            public DateTimeOffset? FilterportedOutAtlte { get; set; }
            /// <summary>Filter by new carrier spid.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bspid%5D")]
            public string? Filterspid { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bspid%5D")]
            public string Filterspid { get; set; }
#endif
            /// <summary>Filter by portout status.</summary>
            [Obsolete("This property is deprecated, use FilterstatusAsGetFilterStatusQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bstatus%5D")]
            public string? Filterstatus { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bstatus%5D")]
            public string Filterstatus { get; set; }
#endif
            /// <summary>Filter by portout status.</summary>
            [QueryParameter("filter%5Bstatus%5D")]
            public global::Soenneker.Telnyx.OpenApiClient.Portouts.GetFilterStatusQueryParameterType? FilterstatusAsGetFilterStatusQueryParameterType { get; set; }
            /// <summary>Filter by a list of portout statuses</summary>
            [Obsolete("This property is deprecated, use FilterstatusInAsGetFilterStatusInQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bstatus_in%5D")]
            public string[]? FilterstatusIn { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bstatus_in%5D")]
            public string[] FilterstatusIn { get; set; }
#endif
            /// <summary>Filter by a list of portout statuses</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bstatus_in%5D")]
            public global::Soenneker.Telnyx.OpenApiClient.Portouts.GetFilterStatus_inQueryParameterType[]? FilterstatusInAsGetFilterStatusInQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bstatus_in%5D")]
            public global::Soenneker.Telnyx.OpenApiClient.Portouts.GetFilterStatus_inQueryParameterType[] FilterstatusInAsGetFilterStatusInQueryParameterType { get; set; }
#endif
            /// <summary>Filter by the portout&apos;s support_key</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bsupport_key%5D")]
            public string? FiltersupportKey { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bsupport_key%5D")]
            public string FiltersupportKey { get; set; }
#endif
            /// <summary>The page number to load</summary>
            [QueryParameter("page%5Bnumber%5D")]
            public int? Pagenumber { get; set; }
            /// <summary>The size of the page</summary>
            [QueryParameter("page%5Bsize%5D")]
            public int? Pagesize { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class PortoutsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Portouts.PortoutsRequestBuilder.PortoutsRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
