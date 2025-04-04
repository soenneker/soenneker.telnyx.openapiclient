// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Soenneker.Telnyx.OpenApiClient.Conferences.Item.Actions.Hold;
using Soenneker.Telnyx.OpenApiClient.Conferences.Item.Actions.Join;
using Soenneker.Telnyx.OpenApiClient.Conferences.Item.Actions.Leave;
using Soenneker.Telnyx.OpenApiClient.Conferences.Item.Actions.Mute;
using Soenneker.Telnyx.OpenApiClient.Conferences.Item.Actions.Play;
using Soenneker.Telnyx.OpenApiClient.Conferences.Item.Actions.Record_pause;
using Soenneker.Telnyx.OpenApiClient.Conferences.Item.Actions.Record_resume;
using Soenneker.Telnyx.OpenApiClient.Conferences.Item.Actions.Record_start;
using Soenneker.Telnyx.OpenApiClient.Conferences.Item.Actions.Record_stop;
using Soenneker.Telnyx.OpenApiClient.Conferences.Item.Actions.Speak;
using Soenneker.Telnyx.OpenApiClient.Conferences.Item.Actions.Stop;
using Soenneker.Telnyx.OpenApiClient.Conferences.Item.Actions.Unhold;
using Soenneker.Telnyx.OpenApiClient.Conferences.Item.Actions.Unmute;
using Soenneker.Telnyx.OpenApiClient.Conferences.Item.Actions.Update;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Soenneker.Telnyx.OpenApiClient.Conferences.Item.Actions
{
    /// <summary>
    /// Builds and executes requests for operations under \conferences\{conference_-id}\actions
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ActionsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The hold property</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Conferences.Item.Actions.Hold.HoldRequestBuilder Hold
        {
            get => new global::Soenneker.Telnyx.OpenApiClient.Conferences.Item.Actions.Hold.HoldRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The join property</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Conferences.Item.Actions.Join.JoinRequestBuilder Join
        {
            get => new global::Soenneker.Telnyx.OpenApiClient.Conferences.Item.Actions.Join.JoinRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The leave property</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Conferences.Item.Actions.Leave.LeaveRequestBuilder Leave
        {
            get => new global::Soenneker.Telnyx.OpenApiClient.Conferences.Item.Actions.Leave.LeaveRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The mute property</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Conferences.Item.Actions.Mute.MuteRequestBuilder Mute
        {
            get => new global::Soenneker.Telnyx.OpenApiClient.Conferences.Item.Actions.Mute.MuteRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The play property</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Conferences.Item.Actions.Play.PlayRequestBuilder Play
        {
            get => new global::Soenneker.Telnyx.OpenApiClient.Conferences.Item.Actions.Play.PlayRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The record_pause property</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Conferences.Item.Actions.Record_pause.Record_pauseRequestBuilder Record_pause
        {
            get => new global::Soenneker.Telnyx.OpenApiClient.Conferences.Item.Actions.Record_pause.Record_pauseRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The record_resume property</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Conferences.Item.Actions.Record_resume.Record_resumeRequestBuilder Record_resume
        {
            get => new global::Soenneker.Telnyx.OpenApiClient.Conferences.Item.Actions.Record_resume.Record_resumeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The record_start property</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Conferences.Item.Actions.Record_start.Record_startRequestBuilder Record_start
        {
            get => new global::Soenneker.Telnyx.OpenApiClient.Conferences.Item.Actions.Record_start.Record_startRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The record_stop property</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Conferences.Item.Actions.Record_stop.Record_stopRequestBuilder Record_stop
        {
            get => new global::Soenneker.Telnyx.OpenApiClient.Conferences.Item.Actions.Record_stop.Record_stopRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The speak property</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Conferences.Item.Actions.Speak.SpeakRequestBuilder Speak
        {
            get => new global::Soenneker.Telnyx.OpenApiClient.Conferences.Item.Actions.Speak.SpeakRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The stop property</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Conferences.Item.Actions.Stop.StopRequestBuilder Stop
        {
            get => new global::Soenneker.Telnyx.OpenApiClient.Conferences.Item.Actions.Stop.StopRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The unhold property</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Conferences.Item.Actions.Unhold.UnholdRequestBuilder Unhold
        {
            get => new global::Soenneker.Telnyx.OpenApiClient.Conferences.Item.Actions.Unhold.UnholdRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The unmute property</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Conferences.Item.Actions.Unmute.UnmuteRequestBuilder Unmute
        {
            get => new global::Soenneker.Telnyx.OpenApiClient.Conferences.Item.Actions.Unmute.UnmuteRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The update property</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Conferences.Item.Actions.Update.UpdateRequestBuilder Update
        {
            get => new global::Soenneker.Telnyx.OpenApiClient.Conferences.Item.Actions.Update.UpdateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Conferences.Item.Actions.ActionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ActionsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/conferences/{conference_%2Did}/actions", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Conferences.Item.Actions.ActionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ActionsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/conferences/{conference_%2Did}/actions", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
