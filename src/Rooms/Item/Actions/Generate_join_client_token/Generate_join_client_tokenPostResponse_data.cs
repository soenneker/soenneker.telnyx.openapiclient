// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Soenneker.Telnyx.OpenApiClient.Rooms.Item.Actions.Generate_join_client_token
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class Generate_join_client_tokenPostResponse_data : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The refresh_token property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RefreshToken { get; set; }
#nullable restore
#else
        public string RefreshToken { get; set; }
#endif
        /// <summary>ISO 8601 timestamp when the refresh token expires.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RefreshTokenExpiresAt { get; set; }
#nullable restore
#else
        public string RefreshTokenExpiresAt { get; set; }
#endif
        /// <summary>The token property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token { get; set; }
#nullable restore
#else
        public string Token { get; set; }
#endif
        /// <summary>ISO 8601 timestamp when the token expires.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TokenExpiresAt { get; set; }
#nullable restore
#else
        public string TokenExpiresAt { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Rooms.Item.Actions.Generate_join_client_token.Generate_join_client_tokenPostResponse_data"/> and sets the default values.
        /// </summary>
        public Generate_join_client_tokenPostResponse_data()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Rooms.Item.Actions.Generate_join_client_token.Generate_join_client_tokenPostResponse_data"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.OpenApiClient.Rooms.Item.Actions.Generate_join_client_token.Generate_join_client_tokenPostResponse_data CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.OpenApiClient.Rooms.Item.Actions.Generate_join_client_token.Generate_join_client_tokenPostResponse_data();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "refresh_token", n => { RefreshToken = n.GetStringValue(); } },
                { "refresh_token_expires_at", n => { RefreshTokenExpiresAt = n.GetStringValue(); } },
                { "token", n => { Token = n.GetStringValue(); } },
                { "token_expires_at", n => { TokenExpiresAt = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("refresh_token", RefreshToken);
            writer.WriteStringValue("refresh_token_expires_at", RefreshTokenExpiresAt);
            writer.WriteStringValue("token", Token);
            writer.WriteStringValue("token_expires_at", TokenExpiresAt);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
