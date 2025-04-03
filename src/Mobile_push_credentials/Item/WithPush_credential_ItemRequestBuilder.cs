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
namespace Soenneker.Telnyx.OpenApiClient.Mobile_push_credentials.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \mobile_push_credentials\{push_credential_id}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WithPush_credential_ItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Mobile_push_credentials.Item.WithPush_credential_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithPush_credential_ItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/mobile_push_credentials/{push_credential_id}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Mobile_push_credentials.Item.WithPush_credential_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithPush_credential_ItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/mobile_push_credentials/{push_credential_id}", rawUrl)
        {
        }
        /// <summary>
        /// Deletes a mobile push credential based on the given `push_credential_id`
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Telnyx.OpenApiClient.Models.Errors">When receiving a 401 status code</exception>
        /// <exception cref="global::Soenneker.Telnyx.OpenApiClient.Models.Errors">When receiving a 404 status code</exception>
        /// <exception cref="global::Soenneker.Telnyx.OpenApiClient.Models.Errors">When receiving a 422 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "401", global::Soenneker.Telnyx.OpenApiClient.Models.Errors.CreateFromDiscriminatorValue },
                { "404", global::Soenneker.Telnyx.OpenApiClient.Models.Errors.CreateFromDiscriminatorValue },
                { "422", global::Soenneker.Telnyx.OpenApiClient.Models.Errors.CreateFromDiscriminatorValue },
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieves mobile push credential based on the given `push_credential_id`
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.PushCredentialResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Telnyx.OpenApiClient.Models.Errors">When receiving a 401 status code</exception>
        /// <exception cref="global::Soenneker.Telnyx.OpenApiClient.Models.Errors">When receiving a 404 status code</exception>
        /// <exception cref="global::Soenneker.Telnyx.OpenApiClient.Models.Errors">When receiving a 422 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Models.PushCredentialResponse?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Models.PushCredentialResponse> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "401", global::Soenneker.Telnyx.OpenApiClient.Models.Errors.CreateFromDiscriminatorValue },
                { "404", global::Soenneker.Telnyx.OpenApiClient.Models.Errors.CreateFromDiscriminatorValue },
                { "422", global::Soenneker.Telnyx.OpenApiClient.Models.Errors.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.OpenApiClient.Models.PushCredentialResponse>(requestInfo, global::Soenneker.Telnyx.OpenApiClient.Models.PushCredentialResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Deletes a mobile push credential based on the given `push_credential_id`
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Retrieves mobile push credential based on the given `push_credential_id`
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Mobile_push_credentials.Item.WithPush_credential_ItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.Telnyx.OpenApiClient.Mobile_push_credentials.Item.WithPush_credential_ItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.Telnyx.OpenApiClient.Mobile_push_credentials.Item.WithPush_credential_ItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class WithPush_credential_ItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class WithPush_credential_ItemRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
