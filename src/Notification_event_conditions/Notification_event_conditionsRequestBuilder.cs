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
namespace Soenneker.Telnyx.OpenApiClient.Notification_event_conditions
{
    /// <summary>
    /// Builds and executes requests for operations under \notification_event_conditions
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Notification_event_conditionsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Notification_event_conditions.Notification_event_conditionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Notification_event_conditionsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/notification_event_conditions{?filter%5Bassociated_record_type%5D%5Beq%5D*,page%5Bnumber%5D*,page%5Bsize%5D*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Notification_event_conditions.Notification_event_conditionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Notification_event_conditionsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/notification_event_conditions{?filter%5Bassociated_record_type%5D%5Beq%5D*,page%5Bnumber%5D*,page%5Bsize%5D*}", rawUrl)
        {
        }
        /// <summary>
        /// Returns a list of your notifications events conditions.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Notification_event_conditions.Notification_event_conditionsGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Telnyx.OpenApiClient.Models.Errors">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Notification_event_conditions.Notification_event_conditionsGetResponse?> GetAsNotification_event_conditionsGetResponseAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Notification_event_conditions.Notification_event_conditionsRequestBuilder.Notification_event_conditionsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Notification_event_conditions.Notification_event_conditionsGetResponse> GetAsNotification_event_conditionsGetResponseAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Notification_event_conditions.Notification_event_conditionsRequestBuilder.Notification_event_conditionsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Soenneker.Telnyx.OpenApiClient.Models.Errors.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.OpenApiClient.Notification_event_conditions.Notification_event_conditionsGetResponse>(requestInfo, global::Soenneker.Telnyx.OpenApiClient.Notification_event_conditions.Notification_event_conditionsGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns a list of your notifications events conditions.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Notification_event_conditions.Notification_event_conditionsResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Telnyx.OpenApiClient.Models.Errors">When receiving a 4XX or 5XX status code</exception>
        [Obsolete("This method is obsolete. Use GetAsNotification_event_conditionsGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Notification_event_conditions.Notification_event_conditionsResponse?> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Notification_event_conditions.Notification_event_conditionsRequestBuilder.Notification_event_conditionsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Notification_event_conditions.Notification_event_conditionsResponse> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Notification_event_conditions.Notification_event_conditionsRequestBuilder.Notification_event_conditionsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Soenneker.Telnyx.OpenApiClient.Models.Errors.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.OpenApiClient.Notification_event_conditions.Notification_event_conditionsResponse>(requestInfo, global::Soenneker.Telnyx.OpenApiClient.Notification_event_conditions.Notification_event_conditionsResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns a list of your notifications events conditions.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Notification_event_conditions.Notification_event_conditionsRequestBuilder.Notification_event_conditionsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Notification_event_conditions.Notification_event_conditionsRequestBuilder.Notification_event_conditionsRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Notification_event_conditions.Notification_event_conditionsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.Telnyx.OpenApiClient.Notification_event_conditions.Notification_event_conditionsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.Telnyx.OpenApiClient.Notification_event_conditions.Notification_event_conditionsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Returns a list of your notifications events conditions.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Notification_event_conditionsRequestBuilderGetQueryParameters 
        {
            /// <summary>Filter by the associated record type</summary>
            [Obsolete("This property is deprecated, use FilterassociatedRecordTypeeqAsGetFilterAssociatedRecordTypeEqQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bassociated_record_type%5D%5Beq%5D")]
            public string? FilterassociatedRecordTypeeq { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bassociated_record_type%5D%5Beq%5D")]
            public string FilterassociatedRecordTypeeq { get; set; }
#endif
            /// <summary>Filter by the associated record type</summary>
            [QueryParameter("filter%5Bassociated_record_type%5D%5Beq%5D")]
            public global::Soenneker.Telnyx.OpenApiClient.Notification_event_conditions.GetFilterAssociated_record_typeEqQueryParameterType? FilterassociatedRecordTypeeqAsGetFilterAssociatedRecordTypeEqQueryParameterType { get; set; }
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
        public partial class Notification_event_conditionsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Notification_event_conditions.Notification_event_conditionsRequestBuilder.Notification_event_conditionsRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
