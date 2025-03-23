// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Soenneker.Telnyx.Room_sessions.Item;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Soenneker.Telnyx.Room_sessions
{
    /// <summary>
    /// Builds and executes requests for operations under \room_sessions
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Room_sessionsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Soenneker.Telnyx.room_sessions.item collection</summary>
        /// <param name="position">The unique identifier of a room session.</param>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Room_sessions.Item.WithRoom_session_ItemRequestBuilder"/></returns>
        public global::Soenneker.Telnyx.Room_sessions.Item.WithRoom_session_ItemRequestBuilder this[Guid position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("room_session_id", position);
                return new global::Soenneker.Telnyx.Room_sessions.Item.WithRoom_session_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>Gets an item from the Soenneker.Telnyx.room_sessions.item collection</summary>
        /// <param name="position">The unique identifier of a room session.</param>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Room_sessions.Item.WithRoom_session_ItemRequestBuilder"/></returns>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public global::Soenneker.Telnyx.Room_sessions.Item.WithRoom_session_ItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("room_session_id", position);
                return new global::Soenneker.Telnyx.Room_sessions.Item.WithRoom_session_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Room_sessions.Room_sessionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Room_sessionsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/room_sessions{?filter%5Bactive%5D*,filter%5Bdate_created_at%5D%5Beq%5D*,filter%5Bdate_created_at%5D%5Bgte%5D*,filter%5Bdate_created_at%5D%5Blte%5D*,filter%5Bdate_ended_at%5D%5Beq%5D*,filter%5Bdate_ended_at%5D%5Bgte%5D*,filter%5Bdate_ended_at%5D%5Blte%5D*,filter%5Bdate_updated_at%5D%5Beq%5D*,filter%5Bdate_updated_at%5D%5Bgte%5D*,filter%5Bdate_updated_at%5D%5Blte%5D*,filter%5Broom_id%5D*,include_participants*,page%5Bnumber%5D*,page%5Bsize%5D*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Room_sessions.Room_sessionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Room_sessionsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/room_sessions{?filter%5Bactive%5D*,filter%5Bdate_created_at%5D%5Beq%5D*,filter%5Bdate_created_at%5D%5Bgte%5D*,filter%5Bdate_created_at%5D%5Blte%5D*,filter%5Bdate_ended_at%5D%5Beq%5D*,filter%5Bdate_ended_at%5D%5Bgte%5D*,filter%5Bdate_ended_at%5D%5Blte%5D*,filter%5Bdate_updated_at%5D%5Beq%5D*,filter%5Bdate_updated_at%5D%5Bgte%5D*,filter%5Bdate_updated_at%5D%5Blte%5D*,filter%5Broom_id%5D*,include_participants*,page%5Bnumber%5D*,page%5Bsize%5D*}", rawUrl)
        {
        }
        /// <summary>
        /// View a list of room sessions.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Room_sessions.Room_sessionsGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.Room_sessions.Room_sessionsGetResponse?> GetAsRoom_sessionsGetResponseAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.Room_sessions.Room_sessionsRequestBuilder.Room_sessionsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.Room_sessions.Room_sessionsGetResponse> GetAsRoom_sessionsGetResponseAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.Room_sessions.Room_sessionsRequestBuilder.Room_sessionsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.Room_sessions.Room_sessionsGetResponse>(requestInfo, global::Soenneker.Telnyx.Room_sessions.Room_sessionsGetResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// View a list of room sessions.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Room_sessions.Room_sessionsResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("This method is obsolete. Use GetAsRoom_sessionsGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.Room_sessions.Room_sessionsResponse?> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.Room_sessions.Room_sessionsRequestBuilder.Room_sessionsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.Room_sessions.Room_sessionsResponse> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.Room_sessions.Room_sessionsRequestBuilder.Room_sessionsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.Room_sessions.Room_sessionsResponse>(requestInfo, global::Soenneker.Telnyx.Room_sessions.Room_sessionsResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.Room_sessions.Room_sessionsRequestBuilder.Room_sessionsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.Room_sessions.Room_sessionsRequestBuilder.Room_sessionsRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Soenneker.Telnyx.Room_sessions.Room_sessionsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.Telnyx.Room_sessions.Room_sessionsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.Telnyx.Room_sessions.Room_sessionsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// View a list of room sessions.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Room_sessionsRequestBuilderGetQueryParameters 
        {
            /// <summary>Filter active or inactive room sessions.</summary>
            [QueryParameter("filter%5Bactive%5D")]
            public bool? Filteractive { get; set; }
            /// <summary>ISO 8601 date for filtering room sessions created on that date.</summary>
            [QueryParameter("filter%5Bdate_created_at%5D%5Beq%5D")]
            public Date? FilterdateCreatedAteq { get; set; }
            /// <summary>ISO 8601 date for filtering room sessions created after that date.</summary>
            [QueryParameter("filter%5Bdate_created_at%5D%5Bgte%5D")]
            public Date? FilterdateCreatedAtgte { get; set; }
            /// <summary>ISO 8601 date for filtering room sessions created before that date.</summary>
            [QueryParameter("filter%5Bdate_created_at%5D%5Blte%5D")]
            public Date? FilterdateCreatedAtlte { get; set; }
            /// <summary>ISO 8601 date for filtering room sessions ended on that date.</summary>
            [QueryParameter("filter%5Bdate_ended_at%5D%5Beq%5D")]
            public Date? FilterdateEndedAteq { get; set; }
            /// <summary>ISO 8601 date for filtering room sessions ended after that date.</summary>
            [QueryParameter("filter%5Bdate_ended_at%5D%5Bgte%5D")]
            public Date? FilterdateEndedAtgte { get; set; }
            /// <summary>ISO 8601 date for filtering room sessions ended before that date.</summary>
            [QueryParameter("filter%5Bdate_ended_at%5D%5Blte%5D")]
            public Date? FilterdateEndedAtlte { get; set; }
            /// <summary>ISO 8601 date for filtering room sessions updated on that date.</summary>
            [QueryParameter("filter%5Bdate_updated_at%5D%5Beq%5D")]
            public Date? FilterdateUpdatedAteq { get; set; }
            /// <summary>ISO 8601 date for filtering room sessions updated after that date.</summary>
            [QueryParameter("filter%5Bdate_updated_at%5D%5Bgte%5D")]
            public Date? FilterdateUpdatedAtgte { get; set; }
            /// <summary>ISO 8601 date for filtering room sessions updated before that date.</summary>
            [QueryParameter("filter%5Bdate_updated_at%5D%5Blte%5D")]
            public Date? FilterdateUpdatedAtlte { get; set; }
            /// <summary>Room_id for filtering room sessions.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Broom_id%5D")]
            public string? FilterroomId { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Broom_id%5D")]
            public string FilterroomId { get; set; }
#endif
            /// <summary>To decide if room participants should be included in the response.</summary>
            [QueryParameter("include_participants")]
            public bool? IncludeParticipants { get; set; }
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
        public partial class Room_sessionsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Soenneker.Telnyx.Room_sessions.Room_sessionsRequestBuilder.Room_sessionsRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
