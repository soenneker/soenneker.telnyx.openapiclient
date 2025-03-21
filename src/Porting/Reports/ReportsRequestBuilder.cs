// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Soenneker.Telnyx.Porting.Reports.Item;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Soenneker.Telnyx.Porting.Reports
{
    /// <summary>
    /// Builds and executes requests for operations under \porting\reports
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ReportsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Soenneker.Telnyx.porting.reports.item collection</summary>
        /// <param name="position">Identifies a report.</param>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Porting.Reports.Item.ReportsItemRequestBuilder"/></returns>
        public global::Soenneker.Telnyx.Porting.Reports.Item.ReportsItemRequestBuilder this[Guid position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("id", position);
                return new global::Soenneker.Telnyx.Porting.Reports.Item.ReportsItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>Gets an item from the Soenneker.Telnyx.porting.reports.item collection</summary>
        /// <param name="position">Identifies a report.</param>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Porting.Reports.Item.ReportsItemRequestBuilder"/></returns>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public global::Soenneker.Telnyx.Porting.Reports.Item.ReportsItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("id", position);
                return new global::Soenneker.Telnyx.Porting.Reports.Item.ReportsItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Porting.Reports.ReportsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ReportsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/porting/reports{?filter%5Breport_type%5D*,filter%5Bstatus%5D*,page%5Bnumber%5D*,page%5Bsize%5D*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Porting.Reports.ReportsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ReportsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/porting/reports{?filter%5Breport_type%5D*,filter%5Bstatus%5D*,page%5Bnumber%5D*,page%5Bsize%5D*}", rawUrl)
        {
        }
        /// <summary>
        /// List the reports generated about porting operations.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Porting.Reports.ReportsGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.Porting.Reports.ReportsGetResponse?> GetAsReportsGetResponseAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.Porting.Reports.ReportsRequestBuilder.ReportsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.Porting.Reports.ReportsGetResponse> GetAsReportsGetResponseAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.Porting.Reports.ReportsRequestBuilder.ReportsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.Porting.Reports.ReportsGetResponse>(requestInfo, global::Soenneker.Telnyx.Porting.Reports.ReportsGetResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// List the reports generated about porting operations.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Porting.Reports.ReportsResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("This method is obsolete. Use GetAsReportsGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.Porting.Reports.ReportsResponse?> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.Porting.Reports.ReportsRequestBuilder.ReportsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.Porting.Reports.ReportsResponse> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.Porting.Reports.ReportsRequestBuilder.ReportsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.Porting.Reports.ReportsResponse>(requestInfo, global::Soenneker.Telnyx.Porting.Reports.ReportsResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Generate reports about porting operations.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Porting.Reports.ReportsPostResponse"/></returns>
        /// <param name="body">The parameters for generating a new porting related report.</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.Porting.Reports.ReportsPostResponse?> PostAsReportsPostResponseAsync(global::Soenneker.Telnyx.Porting.Reports.ReportsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.Porting.Reports.ReportsPostResponse> PostAsReportsPostResponseAsync(global::Soenneker.Telnyx.Porting.Reports.ReportsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.Porting.Reports.ReportsPostResponse>(requestInfo, global::Soenneker.Telnyx.Porting.Reports.ReportsPostResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Generate reports about porting operations.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Porting.Reports.ReportsResponse"/></returns>
        /// <param name="body">The parameters for generating a new porting related report.</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("This method is obsolete. Use PostAsReportsPostResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.Porting.Reports.ReportsResponse?> PostAsync(global::Soenneker.Telnyx.Porting.Reports.ReportsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.Porting.Reports.ReportsResponse> PostAsync(global::Soenneker.Telnyx.Porting.Reports.ReportsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.Porting.Reports.ReportsResponse>(requestInfo, global::Soenneker.Telnyx.Porting.Reports.ReportsResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// List the reports generated about porting operations.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.Porting.Reports.ReportsRequestBuilder.ReportsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.Porting.Reports.ReportsRequestBuilder.ReportsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Generate reports about porting operations.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The parameters for generating a new porting related report.</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Soenneker.Telnyx.Porting.Reports.ReportsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Soenneker.Telnyx.Porting.Reports.ReportsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Soenneker.Telnyx.Porting.Reports.ReportsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.Telnyx.Porting.Reports.ReportsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.Telnyx.Porting.Reports.ReportsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// List the reports generated about porting operations.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class ReportsRequestBuilderGetQueryParameters 
        {
            /// <summary>Filter reports of a specific type</summary>
            [Obsolete("This property is deprecated, use FilterreportTypeAsGetFilterReportTypeQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Breport_type%5D")]
            public string? FilterreportType { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Breport_type%5D")]
            public string FilterreportType { get; set; }
#endif
            /// <summary>Filter reports of a specific type</summary>
            [QueryParameter("filter%5Breport_type%5D")]
            public global::Soenneker.Telnyx.Porting.Reports.GetFilterReport_typeQueryParameterType? FilterreportTypeAsGetFilterReportTypeQueryParameterType { get; set; }
            /// <summary>Filter reports of a specific status</summary>
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
            /// <summary>Filter reports of a specific status</summary>
            [QueryParameter("filter%5Bstatus%5D")]
            public global::Soenneker.Telnyx.Porting.Reports.GetFilterStatusQueryParameterType? FilterstatusAsGetFilterStatusQueryParameterType { get; set; }
            /// <summary>The page number to load.</summary>
            [QueryParameter("page%5Bnumber%5D")]
            public int? Pagenumber { get; set; }
            /// <summary>The size of the page.</summary>
            [QueryParameter("page%5Bsize%5D")]
            public int? Pagesize { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class ReportsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Soenneker.Telnyx.Porting.Reports.ReportsRequestBuilder.ReportsRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class ReportsRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
