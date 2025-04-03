// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Soenneker.Telnyx.OpenApiClient.Models
{
    /// <summary>
    /// The request body when creating a verification.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class CreateVerificationRequestSMS : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Send a self-generated numeric code to the end-user</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomCode { get; set; }
#nullable restore
#else
        public string CustomCode { get; set; }
#endif
        /// <summary>+E164 formatted phone number.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PhoneNumber { get; set; }
#nullable restore
#else
        public string PhoneNumber { get; set; }
#endif
        /// <summary>The number of seconds the verification code is valid for.</summary>
        public int? TimeoutSecs { get; set; }
        /// <summary>The identifier of the associated Verify profile.</summary>
        public Guid? VerifyProfileId { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.CreateVerificationRequestSMS"/> and sets the default values.
        /// </summary>
        public CreateVerificationRequestSMS()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.CreateVerificationRequestSMS"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.OpenApiClient.Models.CreateVerificationRequestSMS CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.OpenApiClient.Models.CreateVerificationRequestSMS();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "custom_code", n => { CustomCode = n.GetStringValue(); } },
                { "phone_number", n => { PhoneNumber = n.GetStringValue(); } },
                { "timeout_secs", n => { TimeoutSecs = n.GetIntValue(); } },
                { "verify_profile_id", n => { VerifyProfileId = n.GetGuidValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("custom_code", CustomCode);
            writer.WriteStringValue("phone_number", PhoneNumber);
            writer.WriteIntValue("timeout_secs", TimeoutSecs);
            writer.WriteGuidValue("verify_profile_id", VerifyProfileId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
