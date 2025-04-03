// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Soenneker.Telnyx.OpenApiClient.Models;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Soenneker.Telnyx.OpenApiClient.Global_ip_assignment_health
{
    /// <summary>
    /// Global IP Assignment Health Check Metrics over time
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Global_ip_assignment_healthRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Global_ip_assignment_health.Global_ip_assignment_healthRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Global_ip_assignment_healthRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/global_ip_assignment_health{?filter%5Bglobal_ip_assignment_id%5D%5Bin%5D*,filter%5Bglobal_ip_id%5D%5Bin%5D*,filter%5Btimestamp%5D%5Bgt%5D*,filter%5Btimestamp%5D%5Blt%5D*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Global_ip_assignment_health.Global_ip_assignment_healthRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Global_ip_assignment_healthRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/global_ip_assignment_health{?filter%5Bglobal_ip_assignment_id%5D%5Bin%5D*,filter%5Bglobal_ip_id%5D%5Bin%5D*,filter%5Btimestamp%5D%5Bgt%5D*,filter%5Btimestamp%5D%5Blt%5D*}", rawUrl)
        {
        }
        /// <summary>
        /// Global IP Assignment Health Check Metrics
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Global_ip_assignment_health.Global_ip_assignment_healthGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Telnyx.OpenApiClient.Models.Errors">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Global_ip_assignment_health.Global_ip_assignment_healthGetResponse?> GetAsGlobal_ip_assignment_healthGetResponseAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Global_ip_assignment_health.Global_ip_assignment_healthRequestBuilder.Global_ip_assignment_healthRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Global_ip_assignment_health.Global_ip_assignment_healthGetResponse> GetAsGlobal_ip_assignment_healthGetResponseAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Global_ip_assignment_health.Global_ip_assignment_healthRequestBuilder.Global_ip_assignment_healthRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Soenneker.Telnyx.OpenApiClient.Models.Errors.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.OpenApiClient.Global_ip_assignment_health.Global_ip_assignment_healthGetResponse>(requestInfo, global::Soenneker.Telnyx.OpenApiClient.Global_ip_assignment_health.Global_ip_assignment_healthGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Global IP Assignment Health Check Metrics
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Global_ip_assignment_health.Global_ip_assignment_healthResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Telnyx.OpenApiClient.Models.Errors">When receiving a 4XX or 5XX status code</exception>
        [Obsolete("This method is obsolete. Use GetAsGlobal_ip_assignment_healthGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Global_ip_assignment_health.Global_ip_assignment_healthResponse?> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Global_ip_assignment_health.Global_ip_assignment_healthRequestBuilder.Global_ip_assignment_healthRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Global_ip_assignment_health.Global_ip_assignment_healthResponse> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Global_ip_assignment_health.Global_ip_assignment_healthRequestBuilder.Global_ip_assignment_healthRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Soenneker.Telnyx.OpenApiClient.Models.Errors.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.OpenApiClient.Global_ip_assignment_health.Global_ip_assignment_healthResponse>(requestInfo, global::Soenneker.Telnyx.OpenApiClient.Global_ip_assignment_health.Global_ip_assignment_healthResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Global IP Assignment Health Check Metrics
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Global_ip_assignment_health.Global_ip_assignment_healthRequestBuilder.Global_ip_assignment_healthRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Global_ip_assignment_health.Global_ip_assignment_healthRequestBuilder.Global_ip_assignment_healthRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Global_ip_assignment_health.Global_ip_assignment_healthRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.Telnyx.OpenApiClient.Global_ip_assignment_health.Global_ip_assignment_healthRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.Telnyx.OpenApiClient.Global_ip_assignment_health.Global_ip_assignment_healthRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Global IP Assignment Health Check Metrics
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Global_ip_assignment_healthRequestBuilderGetQueryParameters 
        {
            /// <summary>Filter by Global IP Assignment ID(s) separated by commas</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bglobal_ip_assignment_id%5D%5Bin%5D")]
            public string? FilterglobalIpAssignmentIdin { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bglobal_ip_assignment_id%5D%5Bin%5D")]
            public string FilterglobalIpAssignmentIdin { get; set; }
#endif
            /// <summary>Filter by Global IP ID(s) separated by commas</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bglobal_ip_id%5D%5Bin%5D")]
            public string? FilterglobalIpIdin { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bglobal_ip_id%5D%5Bin%5D")]
            public string FilterglobalIpIdin { get; set; }
#endif
            /// <summary>Filter by timestamp greater than</summary>
            [QueryParameter("filter%5Btimestamp%5D%5Bgt%5D")]
            public DateTimeOffset? Filtertimestampgt { get; set; }
            /// <summary>Filter by timestamp less than</summary>
            [QueryParameter("filter%5Btimestamp%5D%5Blt%5D")]
            public DateTimeOffset? Filtertimestamplt { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Global_ip_assignment_healthRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Global_ip_assignment_health.Global_ip_assignment_healthRequestBuilder.Global_ip_assignment_healthRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
