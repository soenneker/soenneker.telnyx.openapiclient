// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Soenneker.Telnyx.Models;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Soenneker.Telnyx.Detail_records
{
    /// <summary>
    /// Builds and executes requests for operations under \detail_records
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Detail_recordsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Detail_records.Detail_recordsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Detail_recordsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/detail_records?filter[record_type]={filter%5Brecord_type%5D}{&filter*,filter%5Bdate_range%5D*,page%5Bnumber%5D*,page%5Bsize%5D*,sort*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Detail_records.Detail_recordsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Detail_recordsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/detail_records?filter[record_type]={filter%5Brecord_type%5D}{&filter*,filter%5Bdate_range%5D*,page%5Bnumber%5D*,page%5Bsize%5D*,sort*}", rawUrl)
        {
        }
        /// <summary>
        /// Search for any detail record across the Telnyx Platform
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Models.DetailRecordsSearchResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.Models.DetailRecordsSearchResponse?> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.Detail_records.Detail_recordsRequestBuilder.Detail_recordsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.Models.DetailRecordsSearchResponse> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.Detail_records.Detail_recordsRequestBuilder.Detail_recordsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.Models.DetailRecordsSearchResponse>(requestInfo, global::Soenneker.Telnyx.Models.DetailRecordsSearchResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Search for any detail record across the Telnyx Platform
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.Detail_records.Detail_recordsRequestBuilder.Detail_recordsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.Detail_records.Detail_recordsRequestBuilder.Detail_recordsRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Soenneker.Telnyx.Detail_records.Detail_recordsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.Telnyx.Detail_records.Detail_recordsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.Telnyx.Detail_records.Detail_recordsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Search for any detail record across the Telnyx Platform
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Detail_recordsRequestBuilderGetQueryParameters 
        {
            /// <summary>Filter records on a given record attribute and value. &lt;br/&gt;Example: filter[status]=delivered</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter")]
            public string? Filter { get; set; }
#nullable restore
#else
            [QueryParameter("filter")]
            public string Filter { get; set; }
#endif
            /// <summary>Filter by the given user-friendly date range. You can specify one of the following enum values, or a dynamic one using this format: last_N_days.</summary>
            [Obsolete("This property is deprecated, use FilterdateRangeAsGetFilterDateRangeQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bdate_range%5D")]
            public string? FilterdateRange { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bdate_range%5D")]
            public string FilterdateRange { get; set; }
#endif
            /// <summary>Filter by the given user-friendly date range. You can specify one of the following enum values, or a dynamic one using this format: last_N_days.</summary>
            [QueryParameter("filter%5Bdate_range%5D")]
            public global::Soenneker.Telnyx.Detail_records.GetFilterDate_rangeQueryParameterType? FilterdateRangeAsGetFilterDateRangeQueryParameterType { get; set; }
            /// <summary>Filter by the given record type.</summary>
            [Obsolete("This property is deprecated, use FilterrecordTypeAsGetFilterRecordTypeQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Brecord_type%5D")]
            public string? FilterrecordType { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Brecord_type%5D")]
            public string FilterrecordType { get; set; }
#endif
            /// <summary>Filter by the given record type.</summary>
            [QueryParameter("filter%5Brecord_type%5D")]
            public global::Soenneker.Telnyx.Detail_records.GetFilterRecord_typeQueryParameterType? FilterrecordTypeAsGetFilterRecordTypeQueryParameterType { get; set; }
            /// <summary>Page number</summary>
            [QueryParameter("page%5Bnumber%5D")]
            public int? Pagenumber { get; set; }
            /// <summary>Page size</summary>
            [QueryParameter("page%5Bsize%5D")]
            public int? Pagesize { get; set; }
            /// <summary>Specifies the sort order for results. &lt;br/&gt;Example: sort=-created_at</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("sort")]
            public string[]? Sort { get; set; }
#nullable restore
#else
            [QueryParameter("sort")]
            public string[] Sort { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Detail_recordsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Soenneker.Telnyx.Detail_records.Detail_recordsRequestBuilder.Detail_recordsRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
