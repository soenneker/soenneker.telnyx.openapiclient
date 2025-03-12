// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Soenneker.Telnyx.Models;
using Soenneker.Telnyx.Reports.Mdr_usage_reports.Item;
using Soenneker.Telnyx.Reports.Mdr_usage_reports.Sync;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Soenneker.Telnyx.Reports.Mdr_usage_reports
{
    /// <summary>
    /// Builds and executes requests for operations under \reports\mdr_usage_reports
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Mdr_usage_reportsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The sync property</summary>
        public global::Soenneker.Telnyx.Reports.Mdr_usage_reports.Sync.SyncRequestBuilder Sync
        {
            get => new global::Soenneker.Telnyx.Reports.Mdr_usage_reports.Sync.SyncRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the Soenneker.Telnyx.reports.mdr_usage_reports.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Reports.Mdr_usage_reports.Item.Mdr_usage_reportsItemRequestBuilder"/></returns>
        public global::Soenneker.Telnyx.Reports.Mdr_usage_reports.Item.Mdr_usage_reportsItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("id", position);
                return new global::Soenneker.Telnyx.Reports.Mdr_usage_reports.Item.Mdr_usage_reportsItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Reports.Mdr_usage_reports.Mdr_usage_reportsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Mdr_usage_reportsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/reports/mdr_usage_reports{?page%5Bnumber%5D*,page%5Bsize%5D*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Reports.Mdr_usage_reports.Mdr_usage_reportsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Mdr_usage_reportsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/reports/mdr_usage_reports{?page%5Bnumber%5D*,page%5Bsize%5D*}", rawUrl)
        {
        }
        /// <summary>
        /// Fetch all messaging usage reports. Usage reports are aggregated messaging data for specified time period and breakdown
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Models.MdrGetUsageReportsResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.Models.MdrGetUsageReportsResponse?> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.Reports.Mdr_usage_reports.Mdr_usage_reportsRequestBuilder.Mdr_usage_reportsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.Models.MdrGetUsageReportsResponse> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.Reports.Mdr_usage_reports.Mdr_usage_reportsRequestBuilder.Mdr_usage_reportsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.Models.MdrGetUsageReportsResponse>(requestInfo, global::Soenneker.Telnyx.Models.MdrGetUsageReportsResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Submit request for new new messaging usage report. This endpoint will pull and aggregate messaging data in specified time period. 
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Models.MdrPostUsageReportsResponse"/></returns>
        /// <param name="body">Binary request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="contentType">The request body content type.</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.Models.MdrPostUsageReportsResponse?> PostAsync(Stream body, string contentType, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.Models.MdrPostUsageReportsResponse> PostAsync(Stream body, string contentType, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            if(string.IsNullOrEmpty(contentType)) throw new ArgumentNullException(nameof(contentType));
            var requestInfo = ToPostRequestInformation(body, contentType, requestConfiguration);
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.Models.MdrPostUsageReportsResponse>(requestInfo, global::Soenneker.Telnyx.Models.MdrPostUsageReportsResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Fetch all messaging usage reports. Usage reports are aggregated messaging data for specified time period and breakdown
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.Reports.Mdr_usage_reports.Mdr_usage_reportsRequestBuilder.Mdr_usage_reportsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.Reports.Mdr_usage_reports.Mdr_usage_reportsRequestBuilder.Mdr_usage_reportsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Submit request for new new messaging usage report. This endpoint will pull and aggregate messaging data in specified time period. 
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">Binary request body</param>
        /// <param name="contentType">The request body content type.</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Stream body, string contentType, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Stream body, string contentType, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            if(string.IsNullOrEmpty(contentType)) throw new ArgumentNullException(nameof(contentType));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetStreamContent(body, contentType);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Reports.Mdr_usage_reports.Mdr_usage_reportsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.Telnyx.Reports.Mdr_usage_reports.Mdr_usage_reportsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.Telnyx.Reports.Mdr_usage_reports.Mdr_usage_reportsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Fetch all messaging usage reports. Usage reports are aggregated messaging data for specified time period and breakdown
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Mdr_usage_reportsRequestBuilderGetQueryParameters 
        {
            /// <summary>Page number</summary>
            [QueryParameter("page%5Bnumber%5D")]
            public int? Pagenumber { get; set; }
            /// <summary>Size of the page</summary>
            [QueryParameter("page%5Bsize%5D")]
            public int? Pagesize { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Mdr_usage_reportsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Soenneker.Telnyx.Reports.Mdr_usage_reports.Mdr_usage_reportsRequestBuilder.Mdr_usage_reportsRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Mdr_usage_reportsRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
