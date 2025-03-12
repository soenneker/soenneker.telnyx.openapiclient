// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Soenneker.Telnyx.Models;
using System.Collections.Generic;
using System.IO;
using System;
namespace Soenneker.Telnyx.Verify_profiles.Item
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class WithVerify_profile_PatchRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The call property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Telnyx.Models.UpdateVerifyProfileCallRequest? Call { get; set; }
#nullable restore
#else
        public global::Soenneker.Telnyx.Models.UpdateVerifyProfileCallRequest Call { get; set; }
#endif
        /// <summary>The flashcall property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Telnyx.Models.UpdateVerifyProfileFlashcallRequest? Flashcall { get; set; }
#nullable restore
#else
        public global::Soenneker.Telnyx.Models.UpdateVerifyProfileFlashcallRequest Flashcall { get; set; }
#endif
        /// <summary>The language property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Language { get; set; }
#nullable restore
#else
        public string Language { get; set; }
#endif
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The sms property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Telnyx.Models.UpdateVerifyProfileSMSRequest? Sms { get; set; }
#nullable restore
#else
        public global::Soenneker.Telnyx.Models.UpdateVerifyProfileSMSRequest Sms { get; set; }
#endif
        /// <summary>The webhook_failover_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WebhookFailoverUrl { get; set; }
#nullable restore
#else
        public string WebhookFailoverUrl { get; set; }
#endif
        /// <summary>The webhook_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WebhookUrl { get; set; }
#nullable restore
#else
        public string WebhookUrl { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Verify_profiles.Item.WithVerify_profile_PatchRequestBody"/> and sets the default values.
        /// </summary>
        public WithVerify_profile_PatchRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Verify_profiles.Item.WithVerify_profile_PatchRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.Verify_profiles.Item.WithVerify_profile_PatchRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.Verify_profiles.Item.WithVerify_profile_PatchRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "call", n => { Call = n.GetObjectValue<global::Soenneker.Telnyx.Models.UpdateVerifyProfileCallRequest>(global::Soenneker.Telnyx.Models.UpdateVerifyProfileCallRequest.CreateFromDiscriminatorValue); } },
                { "flashcall", n => { Flashcall = n.GetObjectValue<global::Soenneker.Telnyx.Models.UpdateVerifyProfileFlashcallRequest>(global::Soenneker.Telnyx.Models.UpdateVerifyProfileFlashcallRequest.CreateFromDiscriminatorValue); } },
                { "language", n => { Language = n.GetStringValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "sms", n => { Sms = n.GetObjectValue<global::Soenneker.Telnyx.Models.UpdateVerifyProfileSMSRequest>(global::Soenneker.Telnyx.Models.UpdateVerifyProfileSMSRequest.CreateFromDiscriminatorValue); } },
                { "webhook_failover_url", n => { WebhookFailoverUrl = n.GetStringValue(); } },
                { "webhook_url", n => { WebhookUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Soenneker.Telnyx.Models.UpdateVerifyProfileCallRequest>("call", Call);
            writer.WriteObjectValue<global::Soenneker.Telnyx.Models.UpdateVerifyProfileFlashcallRequest>("flashcall", Flashcall);
            writer.WriteStringValue("language", Language);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<global::Soenneker.Telnyx.Models.UpdateVerifyProfileSMSRequest>("sms", Sms);
            writer.WriteStringValue("webhook_failover_url", WebhookFailoverUrl);
            writer.WriteStringValue("webhook_url", WebhookUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
