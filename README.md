# KiwiSoft.Bitly
#### This nuget package is meant to be used to shrink long Url into shorter one with the helps of Bitly Rest API. You need to create your own subscription with https://bitly.com before you can use this nuget package.

#### Once you have a subscription with https://bitly.com, you need to get a group guid id and generate a token. Those informations will be used by the package while communicating with the Bitly Rest API.

##### appsettings.json
```
{
  "KiwiSoft.Bitly": {
    "GroupGuidId": "GKcgnMiNain",
    "Token": "563e96dfffd3d5e744dca8172719b01aed23eb09"
  }
}
```
