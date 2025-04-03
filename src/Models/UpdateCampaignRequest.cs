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
    public partial class UpdateCampaignRequest : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Help message of the campaign.</summary>
        public bool? AutoRenewal { get; set; }
        /// <summary>Help message of the campaign.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HelpMessage { get; set; }
#nullable restore
#else
        public string HelpMessage { get; set; }
#endif
        /// <summary>Message flow description.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MessageFlow { get; set; }
#nullable restore
#else
        public string MessageFlow { get; set; }
#endif
        /// <summary>Alphanumeric identifier of the reseller that you want to associate with this campaign.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResellerId { get; set; }
#nullable restore
#else
        public string ResellerId { get; set; }
#endif
        /// <summary>Message sample. Some campaign tiers require 1 or more message samples.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Sample1 { get; set; }
#nullable restore
#else
        public string Sample1 { get; set; }
#endif
        /// <summary>Message sample. Some campaign tiers require 2 or more message samples.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Sample2 { get; set; }
#nullable restore
#else
        public string Sample2 { get; set; }
#endif
        /// <summary>Message sample. Some campaign tiers require 3 or more message samples.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Sample3 { get; set; }
#nullable restore
#else
        public string Sample3 { get; set; }
#endif
        /// <summary>Message sample. Some campaign tiers require 4 or more message samples.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Sample4 { get; set; }
#nullable restore
#else
        public string Sample4 { get; set; }
#endif
        /// <summary>Message sample. Some campaign tiers require 5 or more message samples.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Sample5 { get; set; }
#nullable restore
#else
        public string Sample5 { get; set; }
#endif
        /// <summary>Webhook failover to which campaign status updates are sent.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WebhookFailoverURL { get; set; }
#nullable restore
#else
        public string WebhookFailoverURL { get; set; }
#endif
        /// <summary>Webhook to which campaign status updates are sent.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WebhookURL { get; set; }
#nullable restore
#else
        public string WebhookURL { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.UpdateCampaignRequest"/> and sets the default values.
        /// </summary>
        public UpdateCampaignRequest()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.UpdateCampaignRequest"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.OpenApiClient.Models.UpdateCampaignRequest CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.OpenApiClient.Models.UpdateCampaignRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "autoRenewal", n => { AutoRenewal = n.GetBoolValue(); } },
                { "helpMessage", n => { HelpMessage = n.GetStringValue(); } },
                { "messageFlow", n => { MessageFlow = n.GetStringValue(); } },
                { "resellerId", n => { ResellerId = n.GetStringValue(); } },
                { "sample1", n => { Sample1 = n.GetStringValue(); } },
                { "sample2", n => { Sample2 = n.GetStringValue(); } },
                { "sample3", n => { Sample3 = n.GetStringValue(); } },
                { "sample4", n => { Sample4 = n.GetStringValue(); } },
                { "sample5", n => { Sample5 = n.GetStringValue(); } },
                { "webhookFailoverURL", n => { WebhookFailoverURL = n.GetStringValue(); } },
                { "webhookURL", n => { WebhookURL = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("autoRenewal", AutoRenewal);
            writer.WriteStringValue("helpMessage", HelpMessage);
            writer.WriteStringValue("messageFlow", MessageFlow);
            writer.WriteStringValue("resellerId", ResellerId);
            writer.WriteStringValue("sample1", Sample1);
            writer.WriteStringValue("sample2", Sample2);
            writer.WriteStringValue("sample3", Sample3);
            writer.WriteStringValue("sample4", Sample4);
            writer.WriteStringValue("sample5", Sample5);
            writer.WriteStringValue("webhookFailoverURL", WebhookFailoverURL);
            writer.WriteStringValue("webhookURL", WebhookURL);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
