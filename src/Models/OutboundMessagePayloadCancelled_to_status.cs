// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Soenneker.Telnyx.OpenApiClient.Models
{
    /// <summary>The delivery status of the message.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum OutboundMessagePayloadCancelled_to_status
    {
        [EnumMember(Value = "scheduled")]
        #pragma warning disable CS1591
        Scheduled,
        #pragma warning restore CS1591
        [EnumMember(Value = "queued")]
        #pragma warning disable CS1591
        Queued,
        #pragma warning restore CS1591
        [EnumMember(Value = "sending")]
        #pragma warning disable CS1591
        Sending,
        #pragma warning restore CS1591
        [EnumMember(Value = "sent")]
        #pragma warning disable CS1591
        Sent,
        #pragma warning restore CS1591
        [EnumMember(Value = "cancelled")]
        #pragma warning disable CS1591
        Cancelled,
        #pragma warning restore CS1591
        [EnumMember(Value = "expired")]
        #pragma warning disable CS1591
        Expired,
        #pragma warning restore CS1591
        [EnumMember(Value = "sending_failed")]
        #pragma warning disable CS1591
        Sending_failed,
        #pragma warning restore CS1591
        [EnumMember(Value = "delivery_unconfirmed")]
        #pragma warning disable CS1591
        Delivery_unconfirmed,
        #pragma warning restore CS1591
        [EnumMember(Value = "delivered")]
        #pragma warning disable CS1591
        Delivered,
        #pragma warning restore CS1591
        [EnumMember(Value = "delivery_failed")]
        #pragma warning disable CS1591
        Delivery_failed,
        #pragma warning restore CS1591
    }
}
