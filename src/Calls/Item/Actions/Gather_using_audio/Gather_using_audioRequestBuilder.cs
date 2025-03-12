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
namespace Soenneker.Telnyx.Calls.Item.Actions.Gather_using_audio
{
    /// <summary>
    /// Builds and executes requests for operations under \calls\{call_control_id}\actions\gather_using_audio
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Gather_using_audioRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Calls.Item.Actions.Gather_using_audio.Gather_using_audioRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Gather_using_audioRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/calls/{call_control_id}/actions/gather_using_audio", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Calls.Item.Actions.Gather_using_audio.Gather_using_audioRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Gather_using_audioRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/calls/{call_control_id}/actions/gather_using_audio", rawUrl)
        {
        }
        /// <summary>
        /// Play an audio file on the call until the required DTMF signals are gathered to build interactive menus.You can pass a list of valid digits along with an &apos;invalid_audio_url&apos;, which will be played back at the beginning of each prompt. Playback will be interrupted when a DTMF signal is received. The `Answer command must be issued before the `gather_using_audio` command.**Expected Webhooks (see [callback schema](https://developers.telnyx.com/api/call-control/gather-using-audio#callbacks) below):**- `call.playback.started`- `call.playback.ended`- `call.dtmf.received` (you may receive many of these webhooks)- `call.gather.ended`
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Calls.Item.Actions.Gather_using_audio.Gather_using_audioPostResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Telnyx.Models.Errors">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.Calls.Item.Actions.Gather_using_audio.Gather_using_audioPostResponse?> PostAsGather_using_audioPostResponseAsync(global::Soenneker.Telnyx.Models.GatherUsingAudioRequest body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.Calls.Item.Actions.Gather_using_audio.Gather_using_audioPostResponse> PostAsGather_using_audioPostResponseAsync(global::Soenneker.Telnyx.Models.GatherUsingAudioRequest body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Soenneker.Telnyx.Models.Errors.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.Calls.Item.Actions.Gather_using_audio.Gather_using_audioPostResponse>(requestInfo, global::Soenneker.Telnyx.Calls.Item.Actions.Gather_using_audio.Gather_using_audioPostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Play an audio file on the call until the required DTMF signals are gathered to build interactive menus.You can pass a list of valid digits along with an &apos;invalid_audio_url&apos;, which will be played back at the beginning of each prompt. Playback will be interrupted when a DTMF signal is received. The `Answer command must be issued before the `gather_using_audio` command.**Expected Webhooks (see [callback schema](https://developers.telnyx.com/api/call-control/gather-using-audio#callbacks) below):**- `call.playback.started`- `call.playback.ended`- `call.dtmf.received` (you may receive many of these webhooks)- `call.gather.ended`
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Calls.Item.Actions.Gather_using_audio.Gather_using_audioResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Telnyx.Models.Errors">When receiving a 4XX or 5XX status code</exception>
        [Obsolete("This method is obsolete. Use PostAsGather_using_audioPostResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.Calls.Item.Actions.Gather_using_audio.Gather_using_audioResponse?> PostAsync(global::Soenneker.Telnyx.Models.GatherUsingAudioRequest body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.Calls.Item.Actions.Gather_using_audio.Gather_using_audioResponse> PostAsync(global::Soenneker.Telnyx.Models.GatherUsingAudioRequest body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Soenneker.Telnyx.Models.Errors.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.Calls.Item.Actions.Gather_using_audio.Gather_using_audioResponse>(requestInfo, global::Soenneker.Telnyx.Calls.Item.Actions.Gather_using_audio.Gather_using_audioResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Play an audio file on the call until the required DTMF signals are gathered to build interactive menus.You can pass a list of valid digits along with an &apos;invalid_audio_url&apos;, which will be played back at the beginning of each prompt. Playback will be interrupted when a DTMF signal is received. The `Answer command must be issued before the `gather_using_audio` command.**Expected Webhooks (see [callback schema](https://developers.telnyx.com/api/call-control/gather-using-audio#callbacks) below):**- `call.playback.started`- `call.playback.ended`- `call.dtmf.received` (you may receive many of these webhooks)- `call.gather.ended`
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Soenneker.Telnyx.Models.GatherUsingAudioRequest body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Soenneker.Telnyx.Models.GatherUsingAudioRequest body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Soenneker.Telnyx.Calls.Item.Actions.Gather_using_audio.Gather_using_audioRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.Telnyx.Calls.Item.Actions.Gather_using_audio.Gather_using_audioRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.Telnyx.Calls.Item.Actions.Gather_using_audio.Gather_using_audioRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Gather_using_audioRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
