# Cloudmersive.APIClient.NETCore.Barcode - the C# library for the barcodeapi

Barcode APIs let you generate barcode images, and recognize values from images of barcodes.

This C# SDK is for the [Cloudmersive Barcode API](https://www.cloudmersive.com/barcode-api):

- API version: v1
- SDK version: 2.0.4
- Build package: io.swagger.codegen.languages.CSharpClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext
- UWP >=10.0

<a name="dependencies"></a>
## Dependencies
- FubarCoder.RestSharp.Portable.Core >=4.0.7
- FubarCoder.RestSharp.Portable.HttpClient >=4.0.7
- Newtonsoft.Json >=10.0.3

<a name="installation"></a>
## Installation
Generate the DLL using your preferred tool

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Cloudmersive.APIClient.NETCore.Barcode.Api;
using Cloudmersive.APIClient.NETCore.Barcode.Client;
using Cloudmersive.APIClient.NETCore.Barcode.Model;
```
<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.Barcode.Api;
using Cloudmersive.APIClient.NETCore.Barcode.Client;
using Cloudmersive.APIClient.NETCore.Barcode.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {

            // Configure API key authorization: Apikey
            Configuration.Default.ApiKey.Add("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Apikey", "Bearer");

            var apiInstance = new BarcodeLookupApi();
            var value = value_example;  // string | Barcode value

            try
            {
                // Lookup EAN barcode value, return product data
                BarcodeLookupResponse result = apiInstance.BarcodeLookupEanLookup(value);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BarcodeLookupApi.BarcodeLookupEanLookup: " + e.Message );
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.cloudmersive.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*BarcodeLookupApi* | [**BarcodeLookupEanLookup**](docs/BarcodeLookupApi.md#barcodelookupeanlookup) | **POST** /barcode/lookup/ean | Lookup EAN barcode value, return product data
*BarcodeScanApi* | [**BarcodeScanImage**](docs/BarcodeScanApi.md#barcodescanimage) | **POST** /barcode/scan/image | Scan and recognize an image of a barcode
*GenerateBarcodeApi* | [**GenerateBarcodeEAN13**](docs/GenerateBarcodeApi.md#generatebarcodeean13) | **POST** /barcode/generate/ean-13 | Generate a EAN-13 code barcode as PNG file
*GenerateBarcodeApi* | [**GenerateBarcodeEAN8**](docs/GenerateBarcodeApi.md#generatebarcodeean8) | **POST** /barcode/generate/ean-8 | Generate a EAN-8 code barcode as PNG file
*GenerateBarcodeApi* | [**GenerateBarcodeQRCode**](docs/GenerateBarcodeApi.md#generatebarcodeqrcode) | **POST** /barcode/generate/qrcode | Generate a QR code barcode as PNG file
*GenerateBarcodeApi* | [**GenerateBarcodeUPCA**](docs/GenerateBarcodeApi.md#generatebarcodeupca) | **POST** /barcode/generate/upc-a | Generate a UPC-A code barcode as PNG file
*GenerateBarcodeApi* | [**GenerateBarcodeUPCE**](docs/GenerateBarcodeApi.md#generatebarcodeupce) | **POST** /barcode/generate/upc-e | Generate a UPC-E code barcode as PNG file


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.BarcodeLookupResponse](docs/BarcodeLookupResponse.md)
 - [Model.BarcodeScanResult](docs/BarcodeScanResult.md)
 - [Model.ProductMatch](docs/ProductMatch.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="Apikey"></a>
### Apikey

- **Type**: API key
- **API key parameter name**: Apikey
- **Location**: HTTP header

