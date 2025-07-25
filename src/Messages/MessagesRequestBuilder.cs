// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Soenneker.Telnyx.OpenApiClient.Messages.Group_mms;
using Soenneker.Telnyx.OpenApiClient.Messages.Item;
using Soenneker.Telnyx.OpenApiClient.Messages.Long_code;
using Soenneker.Telnyx.OpenApiClient.Messages.Number_pool;
using Soenneker.Telnyx.OpenApiClient.Messages.Rcs;
using Soenneker.Telnyx.OpenApiClient.Messages.Schedule;
using Soenneker.Telnyx.OpenApiClient.Messages.Short_code;
using Soenneker.Telnyx.OpenApiClient.Models;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Soenneker.Telnyx.OpenApiClient.Messages
{
    /// <summary>
    /// Builds and executes requests for operations under \messages
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class MessagesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The group_mms property</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Messages.Group_mms.Group_mmsRequestBuilder Group_mms
        {
            get => new global::Soenneker.Telnyx.OpenApiClient.Messages.Group_mms.Group_mmsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The long_code property</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Messages.Long_code.Long_codeRequestBuilder Long_code
        {
            get => new global::Soenneker.Telnyx.OpenApiClient.Messages.Long_code.Long_codeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The number_pool property</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Messages.Number_pool.Number_poolRequestBuilder Number_pool
        {
            get => new global::Soenneker.Telnyx.OpenApiClient.Messages.Number_pool.Number_poolRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The rcs property</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Messages.Rcs.RcsRequestBuilder Rcs
        {
            get => new global::Soenneker.Telnyx.OpenApiClient.Messages.Rcs.RcsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The schedule property</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Messages.Schedule.ScheduleRequestBuilder Schedule
        {
            get => new global::Soenneker.Telnyx.OpenApiClient.Messages.Schedule.ScheduleRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The short_code property</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Messages.Short_code.Short_codeRequestBuilder Short_code
        {
            get => new global::Soenneker.Telnyx.OpenApiClient.Messages.Short_code.Short_codeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the Soenneker.Telnyx.OpenApiClient.messages.item collection</summary>
        /// <param name="position">The id of the message to cancel</param>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Messages.Item.MessagesItemRequestBuilder"/></returns>
        public global::Soenneker.Telnyx.OpenApiClient.Messages.Item.MessagesItemRequestBuilder this[Guid position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("id", position);
                return new global::Soenneker.Telnyx.OpenApiClient.Messages.Item.MessagesItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>Gets an item from the Soenneker.Telnyx.OpenApiClient.messages.item collection</summary>
        /// <param name="position">The id of the message to cancel</param>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Messages.Item.MessagesItemRequestBuilder"/></returns>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public global::Soenneker.Telnyx.OpenApiClient.Messages.Item.MessagesItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("id", position);
                return new global::Soenneker.Telnyx.OpenApiClient.Messages.Item.MessagesItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Messages.MessagesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MessagesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/messages", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Messages.MessagesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MessagesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/messages", rawUrl)
        {
        }
        /// <summary>
        /// Send a message with a Phone Number, Alphanumeric Sender ID, Short Code or Number Pool.This endpoint allows you to send a message with any messaging resource.Current messaging resources include: long-code, short-code, number-pool, andalphanumeric-sender-id.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Messages.MessagesPostResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Telnyx.OpenApiClient.Models.Errors">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Messages.MessagesPostResponse?> PostAsMessagesPostResponseAsync(global::Soenneker.Telnyx.OpenApiClient.Models.CreateMessageRequest body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Messages.MessagesPostResponse> PostAsMessagesPostResponseAsync(global::Soenneker.Telnyx.OpenApiClient.Models.CreateMessageRequest body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Soenneker.Telnyx.OpenApiClient.Models.Errors.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.OpenApiClient.Messages.MessagesPostResponse>(requestInfo, global::Soenneker.Telnyx.OpenApiClient.Messages.MessagesPostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Send a message with a Phone Number, Alphanumeric Sender ID, Short Code or Number Pool.This endpoint allows you to send a message with any messaging resource.Current messaging resources include: long-code, short-code, number-pool, andalphanumeric-sender-id.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Messages.MessagesResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Telnyx.OpenApiClient.Models.Errors">When receiving a 4XX or 5XX status code</exception>
        [Obsolete("This method is obsolete. Use PostAsMessagesPostResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Messages.MessagesResponse?> PostAsync(global::Soenneker.Telnyx.OpenApiClient.Models.CreateMessageRequest body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Messages.MessagesResponse> PostAsync(global::Soenneker.Telnyx.OpenApiClient.Models.CreateMessageRequest body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Soenneker.Telnyx.OpenApiClient.Models.Errors.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.OpenApiClient.Messages.MessagesResponse>(requestInfo, global::Soenneker.Telnyx.OpenApiClient.Messages.MessagesResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Send a message with a Phone Number, Alphanumeric Sender ID, Short Code or Number Pool.This endpoint allows you to send a message with any messaging resource.Current messaging resources include: long-code, short-code, number-pool, andalphanumeric-sender-id.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Soenneker.Telnyx.OpenApiClient.Models.CreateMessageRequest body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Soenneker.Telnyx.OpenApiClient.Models.CreateMessageRequest body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Messages.MessagesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.Telnyx.OpenApiClient.Messages.MessagesRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.Telnyx.OpenApiClient.Messages.MessagesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class MessagesRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
