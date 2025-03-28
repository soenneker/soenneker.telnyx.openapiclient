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
namespace Soenneker.Telnyx.Calls.Item.Actions.Answer
{
    /// <summary>
    /// Builds and executes requests for operations under \calls\{call_control_id}\actions\answer
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class AnswerRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Calls.Item.Actions.Answer.AnswerRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AnswerRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/calls/{call_control_id}/actions/answer", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Calls.Item.Actions.Answer.AnswerRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AnswerRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/calls/{call_control_id}/actions/answer", rawUrl)
        {
        }
        /// <summary>
        /// Answer an incoming call. You must issue this command before executing subsequent commands on an incoming call.**Expected Webhooks (see [callback schema](https://developers.telnyx.com/api/call-control/answer-call#callbacks) below):**- `call.answered`- `streaming.started`, `streaming.stopped` or `streaming.failed` if `stream_url` was setWhen the `record` parameter is set to `record-from-answer`, the response will include a `recording_id` field.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Calls.Item.Actions.Answer.AnswerPostResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Telnyx.Models.Errors">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.Calls.Item.Actions.Answer.AnswerPostResponse?> PostAsAnswerPostResponseAsync(global::Soenneker.Telnyx.Models.AnswerRequest body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.Calls.Item.Actions.Answer.AnswerPostResponse> PostAsAnswerPostResponseAsync(global::Soenneker.Telnyx.Models.AnswerRequest body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Soenneker.Telnyx.Models.Errors.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.Calls.Item.Actions.Answer.AnswerPostResponse>(requestInfo, global::Soenneker.Telnyx.Calls.Item.Actions.Answer.AnswerPostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Answer an incoming call. You must issue this command before executing subsequent commands on an incoming call.**Expected Webhooks (see [callback schema](https://developers.telnyx.com/api/call-control/answer-call#callbacks) below):**- `call.answered`- `streaming.started`, `streaming.stopped` or `streaming.failed` if `stream_url` was setWhen the `record` parameter is set to `record-from-answer`, the response will include a `recording_id` field.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Calls.Item.Actions.Answer.AnswerResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Telnyx.Models.Errors">When receiving a 4XX or 5XX status code</exception>
        [Obsolete("This method is obsolete. Use PostAsAnswerPostResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.Calls.Item.Actions.Answer.AnswerResponse?> PostAsync(global::Soenneker.Telnyx.Models.AnswerRequest body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.Calls.Item.Actions.Answer.AnswerResponse> PostAsync(global::Soenneker.Telnyx.Models.AnswerRequest body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Soenneker.Telnyx.Models.Errors.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.Calls.Item.Actions.Answer.AnswerResponse>(requestInfo, global::Soenneker.Telnyx.Calls.Item.Actions.Answer.AnswerResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Answer an incoming call. You must issue this command before executing subsequent commands on an incoming call.**Expected Webhooks (see [callback schema](https://developers.telnyx.com/api/call-control/answer-call#callbacks) below):**- `call.answered`- `streaming.started`, `streaming.stopped` or `streaming.failed` if `stream_url` was setWhen the `record` parameter is set to `record-from-answer`, the response will include a `recording_id` field.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Soenneker.Telnyx.Models.AnswerRequest body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Soenneker.Telnyx.Models.AnswerRequest body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Soenneker.Telnyx.Calls.Item.Actions.Answer.AnswerRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.Telnyx.Calls.Item.Actions.Answer.AnswerRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.Telnyx.Calls.Item.Actions.Answer.AnswerRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class AnswerRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
