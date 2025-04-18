// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Soenneker.Telnyx.OpenApiClient.Models;
using Soenneker.Telnyx.OpenApiClient.Phone_number_blocks.Jobs.Delete_phone_number_block;
using Soenneker.Telnyx.OpenApiClient.Phone_number_blocks.Jobs.Item;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Soenneker.Telnyx.OpenApiClient.Phone_number_blocks.Jobs
{
    /// <summary>
    /// Builds and executes requests for operations under \phone_number_blocks\jobs
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class JobsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The delete_phone_number_block property</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Phone_number_blocks.Jobs.Delete_phone_number_block.Delete_phone_number_blockRequestBuilder Delete_phone_number_block
        {
            get => new global::Soenneker.Telnyx.OpenApiClient.Phone_number_blocks.Jobs.Delete_phone_number_block.Delete_phone_number_blockRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the Soenneker.Telnyx.OpenApiClient.phone_number_blocks.jobs.item collection</summary>
        /// <param name="position">Identifies the Phone Number Blocks Job.</param>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Phone_number_blocks.Jobs.Item.JobsItemRequestBuilder"/></returns>
        public global::Soenneker.Telnyx.OpenApiClient.Phone_number_blocks.Jobs.Item.JobsItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("id", position);
                return new global::Soenneker.Telnyx.OpenApiClient.Phone_number_blocks.Jobs.Item.JobsItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Phone_number_blocks.Jobs.JobsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public JobsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/phone_number_blocks/jobs{?filter%5Bstatus%5D*,filter%5Btype%5D*,page%5Bnumber%5D*,page%5Bsize%5D*,sort*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Phone_number_blocks.Jobs.JobsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public JobsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/phone_number_blocks/jobs{?filter%5Bstatus%5D*,filter%5Btype%5D*,page%5Bnumber%5D*,page%5Bsize%5D*,sort*}", rawUrl)
        {
        }
        /// <summary>
        /// Lists the phone number blocks jobs
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Phone_number_blocks.Jobs.JobsGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Telnyx.OpenApiClient.Models.Errors">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Phone_number_blocks.Jobs.JobsGetResponse?> GetAsJobsGetResponseAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Phone_number_blocks.Jobs.JobsRequestBuilder.JobsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Phone_number_blocks.Jobs.JobsGetResponse> GetAsJobsGetResponseAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Phone_number_blocks.Jobs.JobsRequestBuilder.JobsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Soenneker.Telnyx.OpenApiClient.Models.Errors.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.OpenApiClient.Phone_number_blocks.Jobs.JobsGetResponse>(requestInfo, global::Soenneker.Telnyx.OpenApiClient.Phone_number_blocks.Jobs.JobsGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Lists the phone number blocks jobs
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Phone_number_blocks.Jobs.JobsResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Telnyx.OpenApiClient.Models.Errors">When receiving a 4XX or 5XX status code</exception>
        [Obsolete("This method is obsolete. Use GetAsJobsGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Phone_number_blocks.Jobs.JobsResponse?> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Phone_number_blocks.Jobs.JobsRequestBuilder.JobsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Phone_number_blocks.Jobs.JobsResponse> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Phone_number_blocks.Jobs.JobsRequestBuilder.JobsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Soenneker.Telnyx.OpenApiClient.Models.Errors.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.OpenApiClient.Phone_number_blocks.Jobs.JobsResponse>(requestInfo, global::Soenneker.Telnyx.OpenApiClient.Phone_number_blocks.Jobs.JobsResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Lists the phone number blocks jobs
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Phone_number_blocks.Jobs.JobsRequestBuilder.JobsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Phone_number_blocks.Jobs.JobsRequestBuilder.JobsRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Phone_number_blocks.Jobs.JobsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.Telnyx.OpenApiClient.Phone_number_blocks.Jobs.JobsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.Telnyx.OpenApiClient.Phone_number_blocks.Jobs.JobsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Lists the phone number blocks jobs
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class JobsRequestBuilderGetQueryParameters 
        {
            /// <summary>Filter the phone number blocks jobs by status.</summary>
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
            /// <summary>Filter the phone number blocks jobs by status.</summary>
            [QueryParameter("filter%5Bstatus%5D")]
            public global::Soenneker.Telnyx.OpenApiClient.Phone_number_blocks.Jobs.GetFilterStatusQueryParameterType? FilterstatusAsGetFilterStatusQueryParameterType { get; set; }
            /// <summary>Filter the phone number blocks jobs by type.</summary>
            [Obsolete("This property is deprecated, use FiltertypeAsGetFilterTypeQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Btype%5D")]
            public string? Filtertype { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Btype%5D")]
            public string Filtertype { get; set; }
#endif
            /// <summary>Filter the phone number blocks jobs by type.</summary>
            [QueryParameter("filter%5Btype%5D")]
            public global::Soenneker.Telnyx.OpenApiClient.Phone_number_blocks.Jobs.GetFilterTypeQueryParameterType? FiltertypeAsGetFilterTypeQueryParameterType { get; set; }
            /// <summary>The page number to load</summary>
            [QueryParameter("page%5Bnumber%5D")]
            public int? Pagenumber { get; set; }
            /// <summary>The size of the page</summary>
            [QueryParameter("page%5Bsize%5D")]
            public int? Pagesize { get; set; }
            /// <summary>Specifies the sort order for results. If not given, results are sorted by created_at in descending order.</summary>
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
            /// <summary>Specifies the sort order for results. If not given, results are sorted by created_at in descending order.</summary>
            [QueryParameter("sort")]
            public global::Soenneker.Telnyx.OpenApiClient.Phone_number_blocks.Jobs.GetSortQueryParameterType? SortAsGetSortQueryParameterType { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class JobsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Phone_number_blocks.Jobs.JobsRequestBuilder.JobsRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
