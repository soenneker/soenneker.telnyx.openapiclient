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
    public partial class UpdateBrand : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Alternate business identifier such as DUNS, LEI, or GIIN</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AltBusinessId { get; set; }
#nullable restore
#else
        public string AltBusinessId { get; set; }
#endif
        /// <summary>An enumeration.</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.AltBusinessIdType? AltBusinessIdType { get; set; }
        /// <summary>Business contact email.Required if `entityType` will be changed to `PUBLIC_PROFIT`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BusinessContactEmail { get; set; }
#nullable restore
#else
        public string BusinessContactEmail { get; set; }
#endif
        /// <summary>City name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? City { get; set; }
#nullable restore
#else
        public string City { get; set; }
#endif
        /// <summary>(Required for Non-profit/private/public) Legal company name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CompanyName { get; set; }
#nullable restore
#else
        public string CompanyName { get; set; }
#endif
        /// <summary>ISO2 2 characters country code. Example: US - United States</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Country { get; set; }
#nullable restore
#else
        public string Country { get; set; }
#endif
        /// <summary>Display or marketing name of the brand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>(Required for Non-profit) Government assigned corporate tax ID. EIN is 9-digits in U.S.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Ein { get; set; }
#nullable restore
#else
        public string Ein { get; set; }
#endif
        /// <summary>Valid email address of brand support contact.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Email { get; set; }
#nullable restore
#else
        public string Email { get; set; }
#endif
        /// <summary>Entity type behind the brand. This is the form of business establishment.</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.EntityType? EntityType { get; set; }
        /// <summary>First name of business contact.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FirstName { get; set; }
#nullable restore
#else
        public string FirstName { get; set; }
#endif
        /// <summary>The verification status of an active brand</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.BrandIdentityStatus? IdentityStatus { get; set; }
        /// <summary>IP address of the browser requesting to create brand identity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IpAddress { get; set; }
#nullable restore
#else
        public string IpAddress { get; set; }
#endif
        /// <summary>The isReseller property</summary>
        public bool? IsReseller { get; set; }
        /// <summary>Last name of business contact.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastName { get; set; }
#nullable restore
#else
        public string LastName { get; set; }
#endif
        /// <summary>Valid phone number in e.164 international format.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Phone { get; set; }
#nullable restore
#else
        public string Phone { get; set; }
#endif
        /// <summary>Postal codes. Use 5 digit zipcode for United States</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PostalCode { get; set; }
#nullable restore
#else
        public string PostalCode { get; set; }
#endif
        /// <summary>State. Must be 2 letters code for United States.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? State { get; set; }
#nullable restore
#else
        public string State { get; set; }
#endif
        /// <summary>(Required for public company) stock exchange.</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.StockExchange? StockExchange { get; set; }
        /// <summary>(Required for public company) stock symbol.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StockSymbol { get; set; }
#nullable restore
#else
        public string StockSymbol { get; set; }
#endif
        /// <summary>Street number and name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Street { get; set; }
#nullable restore
#else
        public string Street { get; set; }
#endif
        /// <summary>Vertical or industry segment of the brand.</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.Vertical? Vertical { get; set; }
        /// <summary>Webhook failover URL for brand status updates.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WebhookFailoverURL { get; set; }
#nullable restore
#else
        public string WebhookFailoverURL { get; set; }
#endif
        /// <summary>Webhook URL for brand status updates.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WebhookURL { get; set; }
#nullable restore
#else
        public string WebhookURL { get; set; }
#endif
        /// <summary>Brand website URL.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Website { get; set; }
#nullable restore
#else
        public string Website { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.UpdateBrand"/> and sets the default values.
        /// </summary>
        public UpdateBrand()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.UpdateBrand"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.OpenApiClient.Models.UpdateBrand CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.OpenApiClient.Models.UpdateBrand();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "altBusiness_id", n => { AltBusinessId = n.GetStringValue(); } },
                { "altBusinessIdType", n => { AltBusinessIdType = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.AltBusinessIdType>(); } },
                { "businessContactEmail", n => { BusinessContactEmail = n.GetStringValue(); } },
                { "city", n => { City = n.GetStringValue(); } },
                { "companyName", n => { CompanyName = n.GetStringValue(); } },
                { "country", n => { Country = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "ein", n => { Ein = n.GetStringValue(); } },
                { "email", n => { Email = n.GetStringValue(); } },
                { "entityType", n => { EntityType = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.EntityType>(); } },
                { "firstName", n => { FirstName = n.GetStringValue(); } },
                { "identityStatus", n => { IdentityStatus = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.BrandIdentityStatus>(); } },
                { "ipAddress", n => { IpAddress = n.GetStringValue(); } },
                { "isReseller", n => { IsReseller = n.GetBoolValue(); } },
                { "lastName", n => { LastName = n.GetStringValue(); } },
                { "phone", n => { Phone = n.GetStringValue(); } },
                { "postalCode", n => { PostalCode = n.GetStringValue(); } },
                { "state", n => { State = n.GetStringValue(); } },
                { "stockExchange", n => { StockExchange = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.StockExchange>(); } },
                { "stockSymbol", n => { StockSymbol = n.GetStringValue(); } },
                { "street", n => { Street = n.GetStringValue(); } },
                { "vertical", n => { Vertical = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.Vertical>(); } },
                { "webhookFailoverURL", n => { WebhookFailoverURL = n.GetStringValue(); } },
                { "webhookURL", n => { WebhookURL = n.GetStringValue(); } },
                { "website", n => { Website = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("altBusiness_id", AltBusinessId);
            writer.WriteEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.AltBusinessIdType>("altBusinessIdType", AltBusinessIdType);
            writer.WriteStringValue("businessContactEmail", BusinessContactEmail);
            writer.WriteStringValue("city", City);
            writer.WriteStringValue("companyName", CompanyName);
            writer.WriteStringValue("country", Country);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("ein", Ein);
            writer.WriteStringValue("email", Email);
            writer.WriteEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.EntityType>("entityType", EntityType);
            writer.WriteStringValue("firstName", FirstName);
            writer.WriteEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.BrandIdentityStatus>("identityStatus", IdentityStatus);
            writer.WriteStringValue("ipAddress", IpAddress);
            writer.WriteBoolValue("isReseller", IsReseller);
            writer.WriteStringValue("lastName", LastName);
            writer.WriteStringValue("phone", Phone);
            writer.WriteStringValue("postalCode", PostalCode);
            writer.WriteStringValue("state", State);
            writer.WriteEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.StockExchange>("stockExchange", StockExchange);
            writer.WriteStringValue("stockSymbol", StockSymbol);
            writer.WriteStringValue("street", Street);
            writer.WriteEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.Vertical>("vertical", Vertical);
            writer.WriteStringValue("webhookFailoverURL", WebhookFailoverURL);
            writer.WriteStringValue("webhookURL", WebhookURL);
            writer.WriteStringValue("website", Website);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
