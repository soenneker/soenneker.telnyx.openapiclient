// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Soenneker.Telnyx.OpenApiClient.Models;
using Soenneker.Telnyx.OpenApiClient.Room_recordings.Item;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Soenneker.Telnyx.OpenApiClient.Room_recordings
{
    /// <summary>
    /// Builds and executes requests for operations under \room_recordings
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Room_recordingsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Soenneker.Telnyx.OpenApiClient.room_recordings.item collection</summary>
        /// <param name="position">The unique identifier of a room recording.</param>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Room_recordings.Item.WithRoom_recording_ItemRequestBuilder"/></returns>
        public global::Soenneker.Telnyx.OpenApiClient.Room_recordings.Item.WithRoom_recording_ItemRequestBuilder this[Guid position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("room_recording_id", position);
                return new global::Soenneker.Telnyx.OpenApiClient.Room_recordings.Item.WithRoom_recording_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>Gets an item from the Soenneker.Telnyx.OpenApiClient.room_recordings.item collection</summary>
        /// <param name="position">The unique identifier of a room recording.</param>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Room_recordings.Item.WithRoom_recording_ItemRequestBuilder"/></returns>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public global::Soenneker.Telnyx.OpenApiClient.Room_recordings.Item.WithRoom_recording_ItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("room_recording_id", position);
                return new global::Soenneker.Telnyx.OpenApiClient.Room_recordings.Item.WithRoom_recording_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Room_recordings.Room_recordingsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Room_recordingsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/room_recordings{?filter%5Bdate_ended_at%5D%5Beq%5D*,filter%5Bdate_ended_at%5D%5Bgte%5D*,filter%5Bdate_ended_at%5D%5Blte%5D*,filter%5Bdate_started_at%5D%5Beq%5D*,filter%5Bdate_started_at%5D%5Bgte%5D*,filter%5Bdate_started_at%5D%5Blte%5D*,filter%5Bduration_secs%5D%5Beq%5D*,filter%5Bduration_secs%5D%5Bgte%5D*,filter%5Bduration_secs%5D%5Blte%5D*,filter%5Bparticipant_id%5D*,filter%5Broom_id%5D*,filter%5Bsession_id%5D*,filter%5Bstatus%5D*,filter%5Btype%5D*,page%5Bnumber%5D*,page%5Bsize%5D*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Room_recordings.Room_recordingsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Room_recordingsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/room_recordings{?filter%5Bdate_ended_at%5D%5Beq%5D*,filter%5Bdate_ended_at%5D%5Bgte%5D*,filter%5Bdate_ended_at%5D%5Blte%5D*,filter%5Bdate_started_at%5D%5Beq%5D*,filter%5Bdate_started_at%5D%5Bgte%5D*,filter%5Bdate_started_at%5D%5Blte%5D*,filter%5Bduration_secs%5D%5Beq%5D*,filter%5Bduration_secs%5D%5Bgte%5D*,filter%5Bduration_secs%5D%5Blte%5D*,filter%5Bparticipant_id%5D*,filter%5Broom_id%5D*,filter%5Bsession_id%5D*,filter%5Bstatus%5D*,filter%5Btype%5D*,page%5Bnumber%5D*,page%5Bsize%5D*}", rawUrl)
        {
        }
        /// <summary>
        /// Delete several room recordings in a bulk.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Room_recordings.Room_recordingsDeleteResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Telnyx.OpenApiClient.Models.Errors">When receiving a 422 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Room_recordings.Room_recordingsDeleteResponse?> DeleteAsRoom_recordingsDeleteResponseAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Room_recordings.Room_recordingsRequestBuilder.Room_recordingsRequestBuilderDeleteQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Room_recordings.Room_recordingsDeleteResponse> DeleteAsRoom_recordingsDeleteResponseAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Room_recordings.Room_recordingsRequestBuilder.Room_recordingsRequestBuilderDeleteQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "422", global::Soenneker.Telnyx.OpenApiClient.Models.Errors.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.OpenApiClient.Room_recordings.Room_recordingsDeleteResponse>(requestInfo, global::Soenneker.Telnyx.OpenApiClient.Room_recordings.Room_recordingsDeleteResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete several room recordings in a bulk.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Room_recordings.Room_recordingsResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Telnyx.OpenApiClient.Models.Errors">When receiving a 422 status code</exception>
        [Obsolete("This method is obsolete. Use DeleteAsRoom_recordingsDeleteResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Room_recordings.Room_recordingsResponse?> DeleteAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Room_recordings.Room_recordingsRequestBuilder.Room_recordingsRequestBuilderDeleteQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Room_recordings.Room_recordingsResponse> DeleteAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Room_recordings.Room_recordingsRequestBuilder.Room_recordingsRequestBuilderDeleteQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "422", global::Soenneker.Telnyx.OpenApiClient.Models.Errors.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.OpenApiClient.Room_recordings.Room_recordingsResponse>(requestInfo, global::Soenneker.Telnyx.OpenApiClient.Room_recordings.Room_recordingsResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// View a list of room recordings.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Room_recordings.Room_recordingsGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Room_recordings.Room_recordingsGetResponse?> GetAsRoom_recordingsGetResponseAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Room_recordings.Room_recordingsRequestBuilder.Room_recordingsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Room_recordings.Room_recordingsGetResponse> GetAsRoom_recordingsGetResponseAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Room_recordings.Room_recordingsRequestBuilder.Room_recordingsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.OpenApiClient.Room_recordings.Room_recordingsGetResponse>(requestInfo, global::Soenneker.Telnyx.OpenApiClient.Room_recordings.Room_recordingsGetResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// View a list of room recordings.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Room_recordings.Room_recordingsResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("This method is obsolete. Use GetAsRoom_recordingsGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Room_recordings.Room_recordingsResponse?> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Room_recordings.Room_recordingsRequestBuilder.Room_recordingsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Room_recordings.Room_recordingsResponse> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Room_recordings.Room_recordingsRequestBuilder.Room_recordingsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.OpenApiClient.Room_recordings.Room_recordingsResponse>(requestInfo, global::Soenneker.Telnyx.OpenApiClient.Room_recordings.Room_recordingsResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Room_recordings.Room_recordingsRequestBuilder.Room_recordingsRequestBuilderDeleteQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Room_recordings.Room_recordingsRequestBuilder.Room_recordingsRequestBuilderDeleteQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Room_recordings.Room_recordingsRequestBuilder.Room_recordingsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Room_recordings.Room_recordingsRequestBuilder.Room_recordingsRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Room_recordings.Room_recordingsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.Telnyx.OpenApiClient.Room_recordings.Room_recordingsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.Telnyx.OpenApiClient.Room_recordings.Room_recordingsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Delete several room recordings in a bulk.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Room_recordingsRequestBuilderDeleteQueryParameters 
        {
            /// <summary>ISO 8601 date for filtering room recordings ended on that date.</summary>
            [QueryParameter("filter%5Bdate_ended_at%5D%5Beq%5D")]
            public Date? FilterdateEndedAteq { get; set; }
            /// <summary>ISO 8601 date for filtering room recordings ended after that date.</summary>
            [QueryParameter("filter%5Bdate_ended_at%5D%5Bgte%5D")]
            public Date? FilterdateEndedAtgte { get; set; }
            /// <summary>ISO 8601 date for filtering room recordings ended before that date.</summary>
            [QueryParameter("filter%5Bdate_ended_at%5D%5Blte%5D")]
            public Date? FilterdateEndedAtlte { get; set; }
            /// <summary>ISO 8601 date for filtering room recordings started on that date.</summary>
            [QueryParameter("filter%5Bdate_started_at%5D%5Beq%5D")]
            public Date? FilterdateStartedAteq { get; set; }
            /// <summary>ISO 8601 date for filtering room recordings started after that date.</summary>
            [QueryParameter("filter%5Bdate_started_at%5D%5Bgte%5D")]
            public Date? FilterdateStartedAtgte { get; set; }
            /// <summary>ISO 8601 date for filtering room recordings started before that date.</summary>
            [QueryParameter("filter%5Bdate_started_at%5D%5Blte%5D")]
            public Date? FilterdateStartedAtlte { get; set; }
            /// <summary>duration_secs equal for filtering room recordings.</summary>
            [QueryParameter("filter%5Bduration_secs%5D%5Beq%5D")]
            public int? FilterdurationSecseq { get; set; }
            /// <summary>duration_secs greater or equal for filtering room recordings.</summary>
            [QueryParameter("filter%5Bduration_secs%5D%5Bgte%5D")]
            public int? FilterdurationSecsgte { get; set; }
            /// <summary>duration_secs less or equal for filtering room recordings.</summary>
            [QueryParameter("filter%5Bduration_secs%5D%5Blte%5D")]
            public int? FilterdurationSecslte { get; set; }
            /// <summary>participant_id for filtering room recordings.</summary>
            [QueryParameter("filter%5Bparticipant_id%5D")]
            public Guid? FilterparticipantId { get; set; }
            /// <summary>room_id for filtering room recordings.</summary>
            [QueryParameter("filter%5Broom_id%5D")]
            public Guid? FilterroomId { get; set; }
            /// <summary>session_id for filtering room recordings.</summary>
            [QueryParameter("filter%5Bsession_id%5D")]
            public Guid? FiltersessionId { get; set; }
            /// <summary>status for filtering room recordings.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bstatus%5D")]
            public string? Filterstatus { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bstatus%5D")]
            public string Filterstatus { get; set; }
#endif
            /// <summary>type for filtering room recordings.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Btype%5D")]
            public string? Filtertype { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Btype%5D")]
            public string Filtertype { get; set; }
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
        public partial class Room_recordingsRequestBuilderDeleteRequestConfiguration : RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Room_recordings.Room_recordingsRequestBuilder.Room_recordingsRequestBuilderDeleteQueryParameters>
        {
        }
        /// <summary>
        /// View a list of room recordings.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Room_recordingsRequestBuilderGetQueryParameters 
        {
            /// <summary>ISO 8601 date for filtering room recordings ended on that date.</summary>
            [QueryParameter("filter%5Bdate_ended_at%5D%5Beq%5D")]
            public Date? FilterdateEndedAteq { get; set; }
            /// <summary>ISO 8601 date for filtering room recordings ended after that date.</summary>
            [QueryParameter("filter%5Bdate_ended_at%5D%5Bgte%5D")]
            public Date? FilterdateEndedAtgte { get; set; }
            /// <summary>ISO 8601 date for filtering room recordings ended before that date.</summary>
            [QueryParameter("filter%5Bdate_ended_at%5D%5Blte%5D")]
            public Date? FilterdateEndedAtlte { get; set; }
            /// <summary>ISO 8601 date for filtering room recordings started on that date.</summary>
            [QueryParameter("filter%5Bdate_started_at%5D%5Beq%5D")]
            public Date? FilterdateStartedAteq { get; set; }
            /// <summary>ISO 8601 date for filtering room recordings started after that date.</summary>
            [QueryParameter("filter%5Bdate_started_at%5D%5Bgte%5D")]
            public Date? FilterdateStartedAtgte { get; set; }
            /// <summary>ISO 8601 date for filtering room recordings started before that date.</summary>
            [QueryParameter("filter%5Bdate_started_at%5D%5Blte%5D")]
            public Date? FilterdateStartedAtlte { get; set; }
            /// <summary>duration_secs equal for filtering room recordings.</summary>
            [QueryParameter("filter%5Bduration_secs%5D%5Beq%5D")]
            public int? FilterdurationSecseq { get; set; }
            /// <summary>duration_secs greater or equal for filtering room recordings.</summary>
            [QueryParameter("filter%5Bduration_secs%5D%5Bgte%5D")]
            public int? FilterdurationSecsgte { get; set; }
            /// <summary>duration_secs less or equal for filtering room recordings.</summary>
            [QueryParameter("filter%5Bduration_secs%5D%5Blte%5D")]
            public int? FilterdurationSecslte { get; set; }
            /// <summary>participant_id for filtering room recordings.</summary>
            [QueryParameter("filter%5Bparticipant_id%5D")]
            public Guid? FilterparticipantId { get; set; }
            /// <summary>room_id for filtering room recordings.</summary>
            [QueryParameter("filter%5Broom_id%5D")]
            public Guid? FilterroomId { get; set; }
            /// <summary>session_id for filtering room recordings.</summary>
            [QueryParameter("filter%5Bsession_id%5D")]
            public Guid? FiltersessionId { get; set; }
            /// <summary>status for filtering room recordings.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bstatus%5D")]
            public string? Filterstatus { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bstatus%5D")]
            public string Filterstatus { get; set; }
#endif
            /// <summary>type for filtering room recordings.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Btype%5D")]
            public string? Filtertype { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Btype%5D")]
            public string Filtertype { get; set; }
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
        public partial class Room_recordingsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Room_recordings.Room_recordingsRequestBuilder.Room_recordingsRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
