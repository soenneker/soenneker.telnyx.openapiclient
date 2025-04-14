// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Soenneker.Telnyx.OpenApiClient.External_connections.Log_messages.Item;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Soenneker.Telnyx.OpenApiClient.External_connections.Log_messages
{
    /// <summary>
    /// Builds and executes requests for operations under \external_connections\log_messages
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Log_messagesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Soenneker.Telnyx.OpenApiClient.external_connections.log_messages.item collection</summary>
        /// <param name="position">Identifies the resource.</param>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.External_connections.Log_messages.Item.Log_messagesItemRequestBuilder"/></returns>
        public global::Soenneker.Telnyx.OpenApiClient.External_connections.Log_messages.Item.Log_messagesItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("id", position);
                return new global::Soenneker.Telnyx.OpenApiClient.External_connections.Log_messages.Item.Log_messagesItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.External_connections.Log_messages.Log_messagesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Log_messagesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/external_connections/log_messages{?filter%5Bexternal_connection_id%5D*,filter%5Btelephone_number%5D%5Bcontains%5D*,filter%5Btelephone_number%5D%5Beq%5D*,page%5Bnumber%5D*,page%5Bsize%5D*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.External_connections.Log_messages.Log_messagesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Log_messagesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/external_connections/log_messages{?filter%5Bexternal_connection_id%5D*,filter%5Btelephone_number%5D%5Bcontains%5D*,filter%5Btelephone_number%5D%5Beq%5D*,page%5Bnumber%5D*,page%5Bsize%5D*}", rawUrl)
        {
        }
        /// <summary>
        /// Retrieve a list of log messages for all external connections associated with your account.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.External_connections.Log_messages.Log_messagesGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.OpenApiClient.External_connections.Log_messages.Log_messagesGetResponse?> GetAsLog_messagesGetResponseAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.External_connections.Log_messages.Log_messagesRequestBuilder.Log_messagesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.OpenApiClient.External_connections.Log_messages.Log_messagesGetResponse> GetAsLog_messagesGetResponseAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.External_connections.Log_messages.Log_messagesRequestBuilder.Log_messagesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.OpenApiClient.External_connections.Log_messages.Log_messagesGetResponse>(requestInfo, global::Soenneker.Telnyx.OpenApiClient.External_connections.Log_messages.Log_messagesGetResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieve a list of log messages for all external connections associated with your account.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.External_connections.Log_messages.Log_messagesResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("This method is obsolete. Use GetAsLog_messagesGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.OpenApiClient.External_connections.Log_messages.Log_messagesResponse?> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.External_connections.Log_messages.Log_messagesRequestBuilder.Log_messagesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.OpenApiClient.External_connections.Log_messages.Log_messagesResponse> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.External_connections.Log_messages.Log_messagesRequestBuilder.Log_messagesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.OpenApiClient.External_connections.Log_messages.Log_messagesResponse>(requestInfo, global::Soenneker.Telnyx.OpenApiClient.External_connections.Log_messages.Log_messagesResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieve a list of log messages for all external connections associated with your account.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.External_connections.Log_messages.Log_messagesRequestBuilder.Log_messagesRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.External_connections.Log_messages.Log_messagesRequestBuilder.Log_messagesRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.External_connections.Log_messages.Log_messagesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.Telnyx.OpenApiClient.External_connections.Log_messages.Log_messagesRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.Telnyx.OpenApiClient.External_connections.Log_messages.Log_messagesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Retrieve a list of log messages for all external connections associated with your account.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Log_messagesRequestBuilderGetQueryParameters 
        {
            /// <summary>The external connection ID to filter by or &quot;null&quot; to filter for logs without an external connection ID</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bexternal_connection_id%5D")]
            public string? FilterexternalConnectionId { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bexternal_connection_id%5D")]
            public string FilterexternalConnectionId { get; set; }
#endif
            /// <summary>The partial phone number to filter log messages for. Requires 3-15 digits.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Btelephone_number%5D%5Bcontains%5D")]
            public string? FiltertelephoneNumbercontains { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Btelephone_number%5D%5Bcontains%5D")]
            public string FiltertelephoneNumbercontains { get; set; }
#endif
            /// <summary>The phone number to filter log messages for or &quot;null&quot; to filter for logs without a phone number</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Btelephone_number%5D%5Beq%5D")]
            public string? FiltertelephoneNumbereq { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Btelephone_number%5D%5Beq%5D")]
            public string FiltertelephoneNumbereq { get; set; }
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
        public partial class Log_messagesRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.External_connections.Log_messages.Log_messagesRequestBuilder.Log_messagesRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
