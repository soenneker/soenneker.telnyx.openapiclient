[![](https://img.shields.io/nuget/v/soenneker.telnyx.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.telnyx.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.telnyx.openapiclient/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.telnyx.openapiclient/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.telnyx.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.telnyx.openapiclient/)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Telnyx.OpenApiClient
### A Telnyx .NET client generated from the Telnyx OpenAPI schema, updated daily

## Installation

```
dotnet add package Soenneker.Telnyx.OpenApiClient
```

# Soenneker.Telnyx.OpenApiClient

## Overview

**Soenneker.Telnyx.OpenApiClient** is a .NET SDK generated using **Kiota** that provides a client interface for interacting with the **Telnyx OpenAPI**. The client is automatically updated daily from the official Telnyx OpenAPI specification.

## Installation

Install the package via NuGet:

```sh
dotnet add package Soenneker.Telnyx.OpenApiClient
```

## Setup

To use this SDK, you'll need a **Telnyx API Key**. You can obtain one from the [Telnyx Portal](https://telnyx.com/).

### Creating a Client Instance

```csharp
var httpClient = new HttpClient();
httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "your_access_token_here");

// Use a null authentication provider since we're setting headers manually
var requestAdapter = new HttpClientRequestAdapter(null, httpClient: httpClient);

// Create a Telnyx API client instance
var client = new TelnyxOpenApiClient(requestAdapter);
```

## Making a Call

To initiate a call using Telnyx, you can use the **Calls API**:

```csharp
using System.Threading.Tasks;

public async Task MakeCall()
{
    var callRequest = new {
        connection_id = "your_connection_id",
        to = "+15558675309",  // The destination phone number
        from = "+15551234567"   // Your Telnyx phone number
    };
    
    var response = await client.Calls.PostAsync(callRequest);
    
    if (response != null)
    {
        Console.WriteLine("Call initiated successfully!");
    }
}
```

### Sending a Message

```csharp
var messageRequest = new {
    from = "+15551234567", // Your Telnyx number
    to = "+15558675309", // Destination number
    text = "Hello from Telnyx!"
};

var response = await client.Messages.PostAsync(messageRequest);
Console.WriteLine("Message sent successfully!");
```