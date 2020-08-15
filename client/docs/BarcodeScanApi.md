# Cloudmersive.APIClient.NETCore.Barcode.Api.BarcodeScanApi

All URIs are relative to *https://api.cloudmersive.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BarcodeScanImage**](BarcodeScanApi.md#barcodescanimage) | **POST** /barcode/scan/image | Scan and recognize an image of a barcode


<a name="barcodescanimage"></a>
# **BarcodeScanImage**
> BarcodeScanResult BarcodeScanImage (System.IO.Stream imageFile)

Scan and recognize an image of a barcode

Scan an image or photo of a barcode and return the result.  Supported barcode types include AZTEC, CODABAR, CODE_39, CODE_93, CODE_128, DATA_MATRIX, EAN_8, EAN_13, ITF, MAXICODE, PDF_417, QR_CODE, RSS_14, RSS_EXPANDED, UPC_A, UPC_E, All_1D, UPC_EAN_EXTENSION, MSI, PLESSEY, IMB

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.Barcode.Api;
using Cloudmersive.APIClient.NETCore.Barcode.Client;
using Cloudmersive.APIClient.NETCore.Barcode.Model;

namespace Example
{
    public class BarcodeScanImageExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new BarcodeScanApi();
            var imageFile = new System.IO.Stream(); // System.IO.Stream | Image file to perform the operation on.  Common file formats such as PNG, JPEG are supported.

            try
            {
                // Scan and recognize an image of a barcode
                BarcodeScanResult result = apiInstance.BarcodeScanImage(imageFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BarcodeScanApi.BarcodeScanImage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **imageFile** | **System.IO.Stream**| Image file to perform the operation on.  Common file formats such as PNG, JPEG are supported. | 

### Return type

[**BarcodeScanResult**](BarcodeScanResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

