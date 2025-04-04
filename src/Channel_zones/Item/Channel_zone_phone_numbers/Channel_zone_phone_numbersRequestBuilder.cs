// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Soenneker.Telnyx.OpenApiClient.Channel_zones.Item.Channel_zone_phone_numbers.Item;
using Soenneker.Telnyx.OpenApiClient.Models;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Soenneker.Telnyx.OpenApiClient.Channel_zones.Item.Channel_zone_phone_numbers
{
    /// <summary>
    /// Builds and executes requests for operations under \channel_zones\{channel_zone_id}\channel_zone_phone_numbers
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Channel_zone_phone_numbersRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Soenneker.Telnyx.OpenApiClient.channel_zones.item.channel_zone_phone_numbers.item collection</summary>
        /// <param name="position">The phone number to be looked up</param>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Channel_zones.Item.Channel_zone_phone_numbers.Item.WithPhone_numberItemRequestBuilder"/></returns>
        public global::Soenneker.Telnyx.OpenApiClient.Channel_zones.Item.Channel_zone_phone_numbers.Item.WithPhone_numberItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("phone_number", position);
                return new global::Soenneker.Telnyx.OpenApiClient.Channel_zones.Item.Channel_zone_phone_numbers.Item.WithPhone_numberItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Channel_zones.Item.Channel_zone_phone_numbers.Channel_zone_phone_numbersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Channel_zone_phone_numbersRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/channel_zones/{channel_zone_id}/channel_zone_phone_numbers{?page%5Bnumber%5D*,page%5Bsize%5D*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Channel_zones.Item.Channel_zone_phone_numbers.Channel_zone_phone_numbersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Channel_zone_phone_numbersRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/channel_zones/{channel_zone_id}/channel_zone_phone_numbers{?page%5Bnumber%5D*,page%5Bsize%5D*}", rawUrl)
        {
        }
        /// <summary>
        /// Retrieve the assigned phone numbers in a channel zone. Phone numbers assigned to a channel zone can receive concurrent calls up to the quantity reserved in that channel zone. Additional concurrent calls are rejected with a busy signal.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Channel_zones.Item.Channel_zone_phone_numbers.Channel_zone_phone_numbersGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Channel_zones.Item.Channel_zone_phone_numbers.Channel_zone_phone_numbersGetResponse?> GetAsChannel_zone_phone_numbersGetResponseAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Channel_zones.Item.Channel_zone_phone_numbers.Channel_zone_phone_numbersRequestBuilder.Channel_zone_phone_numbersRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Channel_zones.Item.Channel_zone_phone_numbers.Channel_zone_phone_numbersGetResponse> GetAsChannel_zone_phone_numbersGetResponseAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Channel_zones.Item.Channel_zone_phone_numbers.Channel_zone_phone_numbersRequestBuilder.Channel_zone_phone_numbersRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.OpenApiClient.Channel_zones.Item.Channel_zone_phone_numbers.Channel_zone_phone_numbersGetResponse>(requestInfo, global::Soenneker.Telnyx.OpenApiClient.Channel_zones.Item.Channel_zone_phone_numbers.Channel_zone_phone_numbersGetResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieve the assigned phone numbers in a channel zone. Phone numbers assigned to a channel zone can receive concurrent calls up to the quantity reserved in that channel zone. Additional concurrent calls are rejected with a busy signal.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Channel_zones.Item.Channel_zone_phone_numbers.Channel_zone_phone_numbersResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("This method is obsolete. Use GetAsChannel_zone_phone_numbersGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Channel_zones.Item.Channel_zone_phone_numbers.Channel_zone_phone_numbersResponse?> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Channel_zones.Item.Channel_zone_phone_numbers.Channel_zone_phone_numbersRequestBuilder.Channel_zone_phone_numbersRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Channel_zones.Item.Channel_zone_phone_numbers.Channel_zone_phone_numbersResponse> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Channel_zones.Item.Channel_zone_phone_numbers.Channel_zone_phone_numbersRequestBuilder.Channel_zone_phone_numbersRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.OpenApiClient.Channel_zones.Item.Channel_zone_phone_numbers.Channel_zone_phone_numbersResponse>(requestInfo, global::Soenneker.Telnyx.OpenApiClient.Channel_zones.Item.Channel_zone_phone_numbers.Channel_zone_phone_numbersResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// You should own the phone number being assigned to the channel zone. Remember that you should reserve channels in this channel zone, otherwise you won&apos;t be able to receive incoming calls.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.GcbPhoneNumber"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Telnyx.OpenApiClient.Models.Errors">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Models.GcbPhoneNumber?> PostAsync(global::Soenneker.Telnyx.OpenApiClient.Channel_zones.Item.Channel_zone_phone_numbers.Channel_zone_phone_numbersPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Models.GcbPhoneNumber> PostAsync(global::Soenneker.Telnyx.OpenApiClient.Channel_zones.Item.Channel_zone_phone_numbers.Channel_zone_phone_numbersPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Soenneker.Telnyx.OpenApiClient.Models.Errors.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.OpenApiClient.Models.GcbPhoneNumber>(requestInfo, global::Soenneker.Telnyx.OpenApiClient.Models.GcbPhoneNumber.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieve the assigned phone numbers in a channel zone. Phone numbers assigned to a channel zone can receive concurrent calls up to the quantity reserved in that channel zone. Additional concurrent calls are rejected with a busy signal.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Channel_zones.Item.Channel_zone_phone_numbers.Channel_zone_phone_numbersRequestBuilder.Channel_zone_phone_numbersRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Channel_zones.Item.Channel_zone_phone_numbers.Channel_zone_phone_numbersRequestBuilder.Channel_zone_phone_numbersRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// You should own the phone number being assigned to the channel zone. Remember that you should reserve channels in this channel zone, otherwise you won&apos;t be able to receive incoming calls.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Soenneker.Telnyx.OpenApiClient.Channel_zones.Item.Channel_zone_phone_numbers.Channel_zone_phone_numbersPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Soenneker.Telnyx.OpenApiClient.Channel_zones.Item.Channel_zone_phone_numbers.Channel_zone_phone_numbersPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Channel_zones.Item.Channel_zone_phone_numbers.Channel_zone_phone_numbersRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.Telnyx.OpenApiClient.Channel_zones.Item.Channel_zone_phone_numbers.Channel_zone_phone_numbersRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.Telnyx.OpenApiClient.Channel_zones.Item.Channel_zone_phone_numbers.Channel_zone_phone_numbersRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Retrieve the assigned phone numbers in a channel zone. Phone numbers assigned to a channel zone can receive concurrent calls up to the quantity reserved in that channel zone. Additional concurrent calls are rejected with a busy signal.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Channel_zone_phone_numbersRequestBuilderGetQueryParameters 
        {
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
        public partial class Channel_zone_phone_numbersRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Channel_zones.Item.Channel_zone_phone_numbers.Channel_zone_phone_numbersRequestBuilder.Channel_zone_phone_numbersRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Channel_zone_phone_numbersRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
