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
    /// Composed type wrapper for classes <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.CreateAndroidPushCredentialRequest"/>, <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.CreateIosPushCredentialRequest"/>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class CreatePushCredential : IComposedTypeWrapper, IParsable
    {
        /// <summary>Composed type representation for type <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.CreateAndroidPushCredentialRequest"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Telnyx.OpenApiClient.Models.CreateAndroidPushCredentialRequest? CreateAndroidPushCredentialRequest { get; set; }
#nullable restore
#else
        public global::Soenneker.Telnyx.OpenApiClient.Models.CreateAndroidPushCredentialRequest CreateAndroidPushCredentialRequest { get; set; }
#endif
        /// <summary>Composed type representation for type <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.CreateIosPushCredentialRequest"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Telnyx.OpenApiClient.Models.CreateIosPushCredentialRequest? CreateIosPushCredentialRequest { get; set; }
#nullable restore
#else
        public global::Soenneker.Telnyx.OpenApiClient.Models.CreateIosPushCredentialRequest CreateIosPushCredentialRequest { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.CreatePushCredential"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.OpenApiClient.Models.CreatePushCredential CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("type")?.GetStringValue();
            var result = new global::Soenneker.Telnyx.OpenApiClient.Models.CreatePushCredential();
            if("CreateAndroidPushCredentialRequest".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
            {
                result.CreateAndroidPushCredentialRequest = new global::Soenneker.Telnyx.OpenApiClient.Models.CreateAndroidPushCredentialRequest();
            }
            else if("CreateIosPushCredentialRequest".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
            {
                result.CreateIosPushCredentialRequest = new global::Soenneker.Telnyx.OpenApiClient.Models.CreateIosPushCredentialRequest();
            }
            return result;
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            if(CreateAndroidPushCredentialRequest != null)
            {
                return CreateAndroidPushCredentialRequest.GetFieldDeserializers();
            }
            else if(CreateIosPushCredentialRequest != null)
            {
                return CreateIosPushCredentialRequest.GetFieldDeserializers();
            }
            return new Dictionary<string, Action<IParseNode>>();
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            if(CreateAndroidPushCredentialRequest != null)
            {
                writer.WriteObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.CreateAndroidPushCredentialRequest>(null, CreateAndroidPushCredentialRequest);
            }
            else if(CreateIosPushCredentialRequest != null)
            {
                writer.WriteObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.CreateIosPushCredentialRequest>(null, CreateIosPushCredentialRequest);
            }
        }
    }
}
#pragma warning restore CS0618
