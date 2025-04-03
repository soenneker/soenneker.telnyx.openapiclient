// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Soenneker.Telnyx.OpenApiClient.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class CreateVerifyProfileSMSRequest : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The alphanumeric sender ID to use when sending to destinations that require an alphanumeric sender ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AlphaSender { get; set; }
#nullable restore
#else
        public string AlphaSender { get; set; }
#endif
        /// <summary>The name that identifies the application requesting 2fa in the verification message.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppName { get; set; }
#nullable restore
#else
        public string AppName { get; set; }
#endif
        /// <summary>The length of the verify code to generate.</summary>
        public int? CodeLength { get; set; }
        /// <summary>For every request that is initiated via this Verify profile, this sets the number of seconds before a verification request code expires. Once the verification request expires, the user cannot use the code to verify their identity.</summary>
        public int? DefaultVerificationTimeoutSecs { get; set; }
        /// <summary>The message template identifier selected from /verify_profiles/templates</summary>
        public Guid? MessagingTemplateId { get; set; }
        /// <summary>Enabled country destinations to send verification codes. The elements in the list must be valid ISO 3166-1 alpha-2 country codes. If set to `[&quot;*&quot;]`, all destinations will be allowed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? WhitelistedDestinations { get; set; }
#nullable restore
#else
        public List<string> WhitelistedDestinations { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.CreateVerifyProfileSMSRequest"/> and sets the default values.
        /// </summary>
        public CreateVerifyProfileSMSRequest()
        {
            AdditionalData = new Dictionary<string, object>();
            AlphaSender = "Telnyx";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.CreateVerifyProfileSMSRequest"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.OpenApiClient.Models.CreateVerifyProfileSMSRequest CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.OpenApiClient.Models.CreateVerifyProfileSMSRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "alpha_sender", n => { AlphaSender = n.GetStringValue(); } },
                { "app_name", n => { AppName = n.GetStringValue(); } },
                { "code_length", n => { CodeLength = n.GetIntValue(); } },
                { "default_verification_timeout_secs", n => { DefaultVerificationTimeoutSecs = n.GetIntValue(); } },
                { "messaging_template_id", n => { MessagingTemplateId = n.GetGuidValue(); } },
                { "whitelisted_destinations", n => { WhitelistedDestinations = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("alpha_sender", AlphaSender);
            writer.WriteStringValue("app_name", AppName);
            writer.WriteIntValue("code_length", CodeLength);
            writer.WriteIntValue("default_verification_timeout_secs", DefaultVerificationTimeoutSecs);
            writer.WriteGuidValue("messaging_template_id", MessagingTemplateId);
            writer.WriteCollectionOfPrimitiveValues<string>("whitelisted_destinations", WhitelistedDestinations);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
