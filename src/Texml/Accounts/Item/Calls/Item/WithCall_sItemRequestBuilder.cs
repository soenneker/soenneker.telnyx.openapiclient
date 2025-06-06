// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Soenneker.Telnyx.OpenApiClient.Models;
using Soenneker.Telnyx.OpenApiClient.Texml.Accounts.Item.Calls.Item.Recordings;
using Soenneker.Telnyx.OpenApiClient.Texml.Accounts.Item.Calls.Item.RecordingsJson;
using Soenneker.Telnyx.OpenApiClient.Texml.Accounts.Item.Calls.Item.Siprec;
using Soenneker.Telnyx.OpenApiClient.Texml.Accounts.Item.Calls.Item.SiprecJson;
using Soenneker.Telnyx.OpenApiClient.Texml.Accounts.Item.Calls.Item.Streams;
using Soenneker.Telnyx.OpenApiClient.Texml.Accounts.Item.Calls.Item.StreamsJson;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Soenneker.Telnyx.OpenApiClient.Texml.Accounts.Item.Calls.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \texml\Accounts\{account_sid}\Calls\{call_sid}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WithCall_sItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The Recordings property</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Texml.Accounts.Item.Calls.Item.Recordings.RecordingsRequestBuilder Recordings
        {
            get => new global::Soenneker.Telnyx.OpenApiClient.Texml.Accounts.Item.Calls.Item.Recordings.RecordingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The RecordingsJson property</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Texml.Accounts.Item.Calls.Item.RecordingsJson.RecordingsJsonRequestBuilder RecordingsJson
        {
            get => new global::Soenneker.Telnyx.OpenApiClient.Texml.Accounts.Item.Calls.Item.RecordingsJson.RecordingsJsonRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Siprec property</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Texml.Accounts.Item.Calls.Item.Siprec.SiprecRequestBuilder Siprec
        {
            get => new global::Soenneker.Telnyx.OpenApiClient.Texml.Accounts.Item.Calls.Item.Siprec.SiprecRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The SiprecJson property</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Texml.Accounts.Item.Calls.Item.SiprecJson.SiprecJsonRequestBuilder SiprecJson
        {
            get => new global::Soenneker.Telnyx.OpenApiClient.Texml.Accounts.Item.Calls.Item.SiprecJson.SiprecJsonRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Streams property</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Texml.Accounts.Item.Calls.Item.Streams.StreamsRequestBuilder Streams
        {
            get => new global::Soenneker.Telnyx.OpenApiClient.Texml.Accounts.Item.Calls.Item.Streams.StreamsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The StreamsJson property</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Texml.Accounts.Item.Calls.Item.StreamsJson.StreamsJsonRequestBuilder StreamsJson
        {
            get => new global::Soenneker.Telnyx.OpenApiClient.Texml.Accounts.Item.Calls.Item.StreamsJson.StreamsJsonRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Texml.Accounts.Item.Calls.Item.WithCall_sItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithCall_sItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/texml/Accounts/{account_sid}/Calls/{call_sid}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Texml.Accounts.Item.Calls.Item.WithCall_sItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithCall_sItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/texml/Accounts/{account_sid}/Calls/{call_sid}", rawUrl)
        {
        }
        /// <summary>
        /// Returns an individual call identified by its CallSid. This endpoint is eventually consistent.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.CallResource"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Telnyx.OpenApiClient.Models.ResourceNotFoundError">When receiving a 404 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Models.CallResource?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Models.CallResource> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "404", global::Soenneker.Telnyx.OpenApiClient.Models.ResourceNotFoundError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.OpenApiClient.Models.CallResource>(requestInfo, global::Soenneker.Telnyx.OpenApiClient.Models.CallResource.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update TeXML call. Please note that the keys present in the payload MUST BE formatted in CamelCase as specified in the example.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.CallResource"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Models.CallResource?> PostAsync(global::Soenneker.Telnyx.OpenApiClient.Models.UpdateCallRequest body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Models.CallResource> PostAsync(global::Soenneker.Telnyx.OpenApiClient.Models.UpdateCallRequest body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.OpenApiClient.Models.CallResource>(requestInfo, global::Soenneker.Telnyx.OpenApiClient.Models.CallResource.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns an individual call identified by its CallSid. This endpoint is eventually consistent.
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
        /// Update TeXML call. Please note that the keys present in the payload MUST BE formatted in CamelCase as specified in the example.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Soenneker.Telnyx.OpenApiClient.Models.UpdateCallRequest body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Soenneker.Telnyx.OpenApiClient.Models.UpdateCallRequest body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/x-www-form-urlencoded", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Texml.Accounts.Item.Calls.Item.WithCall_sItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.Telnyx.OpenApiClient.Texml.Accounts.Item.Calls.Item.WithCall_sItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.Telnyx.OpenApiClient.Texml.Accounts.Item.Calls.Item.WithCall_sItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class WithCall_sItemRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class WithCall_sItemRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
