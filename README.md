# FlashLive

[![Package](https://github.com/tbm0115/FlashLive/actions/workflows/package.yml/badge.svg)](https://github.com/tbm0115/FlashLive/actions/workflows/package.yml)

---
## Introduction
This is an unofficial wrapper for consuming the [FlashLive Sports API](https://rapidapi.com/tipsters/api/flashlive-sports).

## Getting Started
FlashLive is packaged and hosted on NuGet.org using GitHub Actions.

```
> dotnet add package FlashLive
```

Be ready with your RapidAPI key and use the `FlashLive.WebAccessor`:

``` c#
string apiKey = ...; // Get RapidAPI key

using (var accessor = new WebAccessor(apiKey)) {
  // Get American Football events
  var requestOptions = new FlashLive.Models.RequestOptions.EventsRequestOptions<FlashLive.Models.AmericanFootballEvent>() {
    Sport = FlashLive.Models.Contracts.Enums.SportType.AMERICAN_FOOTBALL
  };
  var footballGames = await accessor.GetEventsAsync(requestOptions);
  
  // Do something with game information
}
```

## Sponsors
Please consider supporting this project by becoming a sponsor.
