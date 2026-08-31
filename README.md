[![](https://img.shields.io/nuget/v/soenneker.telnyx.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.telnyx.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.telnyx.openapiclient/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.telnyx.openapiclient/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.telnyx.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.telnyx.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.telnyx.openapiclient/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.telnyx.openapiclient/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Telnyx.OpenApiClient

A Kiota-generated .NET client for Telnyx's REST API, covering messaging, calling, numbers, networking, identity, billing, AI, and other Telnyx resources.

## Installation

```bash
dotnet add package Soenneker.Telnyx.OpenApiClient
```

## Usage

```csharp
using System.Net.Http.Headers;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Soenneker.Telnyx.OpenApiClient;
using Soenneker.Telnyx.OpenApiClient.Models;

var httpClient = new HttpClient();
httpClient.DefaultRequestHeaders.Authorization =
    new AuthenticationHeaderValue("Bearer", telnyxApiKey);

var authentication = new AnonymousAuthenticationProvider();
var adapter = new HttpClientRequestAdapter(authentication, httpClient: httpClient);
var telnyx = new TelnyxOpenApiClient(adapter);

ListMessagingProfilesResponse? response = await telnyx.Messaging_profiles.GetAsync(
    cancellationToken: cancellationToken);
```

Keep the `HttpClient`, request adapter, and `TelnyxOpenApiClient` for reuse instead of constructing them per request. The client defaults to `https://api.telnyx.com/v2`.

The generated surface follows Telnyx's OpenAPI operation and schema names, including underscore-separated members such as `Messaging_profiles`. Regeneration can add or rename generated types as the upstream schema changes.

Many Telnyx operations create billable messages, calls, numbers, or other resources. Review the generated request type and Telnyx operation semantics before invoking mutation methods such as `PostAsync`, `PatchAsync`, or `DeleteAsync`.
