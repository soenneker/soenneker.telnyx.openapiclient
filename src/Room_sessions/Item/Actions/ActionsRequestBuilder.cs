// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Soenneker.Telnyx.OpenApiClient.Room_sessions.Item.Actions.End;
using Soenneker.Telnyx.OpenApiClient.Room_sessions.Item.Actions.Kick;
using Soenneker.Telnyx.OpenApiClient.Room_sessions.Item.Actions.Mute;
using Soenneker.Telnyx.OpenApiClient.Room_sessions.Item.Actions.Unmute;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Soenneker.Telnyx.OpenApiClient.Room_sessions.Item.Actions
{
    /// <summary>
    /// Builds and executes requests for operations under \room_sessions\{room_session_id}\actions
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ActionsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The end property</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Room_sessions.Item.Actions.End.EndRequestBuilder End
        {
            get => new global::Soenneker.Telnyx.OpenApiClient.Room_sessions.Item.Actions.End.EndRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The kick property</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Room_sessions.Item.Actions.Kick.KickRequestBuilder Kick
        {
            get => new global::Soenneker.Telnyx.OpenApiClient.Room_sessions.Item.Actions.Kick.KickRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The mute property</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Room_sessions.Item.Actions.Mute.MuteRequestBuilder Mute
        {
            get => new global::Soenneker.Telnyx.OpenApiClient.Room_sessions.Item.Actions.Mute.MuteRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The unmute property</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Room_sessions.Item.Actions.Unmute.UnmuteRequestBuilder Unmute
        {
            get => new global::Soenneker.Telnyx.OpenApiClient.Room_sessions.Item.Actions.Unmute.UnmuteRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Room_sessions.Item.Actions.ActionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ActionsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/room_sessions/{room_session_id}/actions", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Room_sessions.Item.Actions.ActionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ActionsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/room_sessions/{room_session_id}/actions", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
