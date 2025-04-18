// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Soenneker.Telnyx.OpenApiClient.Room_sessions.Item.Participants
{
    /// <summary>
    /// Builds and executes requests for operations under \room_sessions\{room_session_id}\participants
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ParticipantsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Room_sessions.Item.Participants.ParticipantsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ParticipantsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/room_sessions/{room_session_id}/participants{?filter%5Bcontext%5D*,filter%5Bdate_joined_at%5D%5Beq%5D*,filter%5Bdate_joined_at%5D%5Bgte%5D*,filter%5Bdate_joined_at%5D%5Blte%5D*,filter%5Bdate_left_at%5D%5Beq%5D*,filter%5Bdate_left_at%5D%5Bgte%5D*,filter%5Bdate_left_at%5D%5Blte%5D*,filter%5Bdate_updated_at%5D%5Beq%5D*,filter%5Bdate_updated_at%5D%5Bgte%5D*,filter%5Bdate_updated_at%5D%5Blte%5D*,page%5Bnumber%5D*,page%5Bsize%5D*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Room_sessions.Item.Participants.ParticipantsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ParticipantsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/room_sessions/{room_session_id}/participants{?filter%5Bcontext%5D*,filter%5Bdate_joined_at%5D%5Beq%5D*,filter%5Bdate_joined_at%5D%5Bgte%5D*,filter%5Bdate_joined_at%5D%5Blte%5D*,filter%5Bdate_left_at%5D%5Beq%5D*,filter%5Bdate_left_at%5D%5Bgte%5D*,filter%5Bdate_left_at%5D%5Blte%5D*,filter%5Bdate_updated_at%5D%5Beq%5D*,filter%5Bdate_updated_at%5D%5Bgte%5D*,filter%5Bdate_updated_at%5D%5Blte%5D*,page%5Bnumber%5D*,page%5Bsize%5D*}", rawUrl)
        {
        }
        /// <summary>
        /// View a list of room participants.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Room_sessions.Item.Participants.ParticipantsGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Room_sessions.Item.Participants.ParticipantsGetResponse?> GetAsParticipantsGetResponseAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Room_sessions.Item.Participants.ParticipantsRequestBuilder.ParticipantsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Room_sessions.Item.Participants.ParticipantsGetResponse> GetAsParticipantsGetResponseAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Room_sessions.Item.Participants.ParticipantsRequestBuilder.ParticipantsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.OpenApiClient.Room_sessions.Item.Participants.ParticipantsGetResponse>(requestInfo, global::Soenneker.Telnyx.OpenApiClient.Room_sessions.Item.Participants.ParticipantsGetResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// View a list of room participants.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Room_sessions.Item.Participants.ParticipantsResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("This method is obsolete. Use GetAsParticipantsGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Room_sessions.Item.Participants.ParticipantsResponse?> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Room_sessions.Item.Participants.ParticipantsRequestBuilder.ParticipantsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Room_sessions.Item.Participants.ParticipantsResponse> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Room_sessions.Item.Participants.ParticipantsRequestBuilder.ParticipantsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.OpenApiClient.Room_sessions.Item.Participants.ParticipantsResponse>(requestInfo, global::Soenneker.Telnyx.OpenApiClient.Room_sessions.Item.Participants.ParticipantsResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Room_sessions.Item.Participants.ParticipantsRequestBuilder.ParticipantsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Room_sessions.Item.Participants.ParticipantsRequestBuilder.ParticipantsRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Room_sessions.Item.Participants.ParticipantsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.Telnyx.OpenApiClient.Room_sessions.Item.Participants.ParticipantsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.Telnyx.OpenApiClient.Room_sessions.Item.Participants.ParticipantsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// View a list of room participants.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class ParticipantsRequestBuilderGetQueryParameters 
        {
            /// <summary>Filter room participants based on the context.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bcontext%5D")]
            public string? Filtercontext { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bcontext%5D")]
            public string Filtercontext { get; set; }
#endif
            /// <summary>ISO 8601 date for filtering room participants that joined on that date.</summary>
            [QueryParameter("filter%5Bdate_joined_at%5D%5Beq%5D")]
            public Date? FilterdateJoinedAteq { get; set; }
            /// <summary>ISO 8601 date for filtering room participants that joined after that date.</summary>
            [QueryParameter("filter%5Bdate_joined_at%5D%5Bgte%5D")]
            public Date? FilterdateJoinedAtgte { get; set; }
            /// <summary>ISO 8601 date for filtering room participants that joined before that date.</summary>
            [QueryParameter("filter%5Bdate_joined_at%5D%5Blte%5D")]
            public Date? FilterdateJoinedAtlte { get; set; }
            /// <summary>ISO 8601 date for filtering room participants that left on that date.</summary>
            [QueryParameter("filter%5Bdate_left_at%5D%5Beq%5D")]
            public Date? FilterdateLeftAteq { get; set; }
            /// <summary>ISO 8601 date for filtering room participants that left after that date.</summary>
            [QueryParameter("filter%5Bdate_left_at%5D%5Bgte%5D")]
            public Date? FilterdateLeftAtgte { get; set; }
            /// <summary>ISO 8601 date for filtering room participants that left before that date.</summary>
            [QueryParameter("filter%5Bdate_left_at%5D%5Blte%5D")]
            public Date? FilterdateLeftAtlte { get; set; }
            /// <summary>ISO 8601 date for filtering room participants updated on that date.</summary>
            [QueryParameter("filter%5Bdate_updated_at%5D%5Beq%5D")]
            public Date? FilterdateUpdatedAteq { get; set; }
            /// <summary>ISO 8601 date for filtering room participants updated after that date.</summary>
            [QueryParameter("filter%5Bdate_updated_at%5D%5Bgte%5D")]
            public Date? FilterdateUpdatedAtgte { get; set; }
            /// <summary>ISO 8601 date for filtering room participants updated before that date.</summary>
            [QueryParameter("filter%5Bdate_updated_at%5D%5Blte%5D")]
            public Date? FilterdateUpdatedAtlte { get; set; }
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
        public partial class ParticipantsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Room_sessions.Item.Participants.ParticipantsRequestBuilder.ParticipantsRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
