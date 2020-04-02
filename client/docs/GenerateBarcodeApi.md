# Cloudmersive.APIClient.NETCore.Barcode.Api.GenerateBarcodeApi

All URIs are relative to *https://api.cloudmersive.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GenerateBarcodeEAN13**](GenerateBarcodeApi.md#generatebarcodeean13) | **POST** /barcode/generate/ean-13 | Generate a EAN-13 code barcode as PNG file
[**GenerateBarcodeEAN8**](GenerateBarcodeApi.md#generatebarcodeean8) | **POST** /barcode/generate/ean-8 | Generate a EAN-8 code barcode as PNG file
[**GenerateBarcodeQRCode**](GenerateBarcodeApi.md#generatebarcodeqrcode) | **POST** /barcode/generate/qrcode | Generate a QR code barcode as PNG file
[**GenerateBarcodeUPCA**](GenerateBarcodeApi.md#generatebarcodeupca) | **POST** /barcode/generate/upc-a | Generate a UPC-A code barcode as PNG file
[**GenerateBarcodeUPCE**](GenerateBarcodeApi.md#generatebarcodeupce) | **POST** /barcode/generate/upc-e | Generate a UPC-E code barcode as PNG file


<a name="generatebarcodeean13"></a>
# **GenerateBarcodeEAN13**
> System.IO.Stream GenerateBarcodeEAN13 (string value)

Generate a EAN-13 code barcode as PNG file

Validates and generate a EAN-13 barcode as a PNG file, a type of 1D barcode

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.Barcode.Api;
using Cloudmersive.APIClient.NETCore.Barcode.Client;
using Cloudmersive.APIClient.NETCore.Barcode.Model;

namespace Example
{
    public class GenerateBarcodeEAN13Example
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new GenerateBarcodeApi();
            var value = value_example;  // string | Barcode value to generate from

            try
            {
                // Generate a EAN-13 code barcode as PNG file
                System.IO.Stream result = apiInstance.GenerateBarcodeEAN13(value);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GenerateBarcodeApi.GenerateBarcodeEAN13: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **value** | **string**| Barcode value to generate from | 

### Return type

**System.IO.Stream**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: image/png

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="generatebarcodeean8"></a>
# **GenerateBarcodeEAN8**
> System.IO.Stream GenerateBarcodeEAN8 (string value)

Generate a EAN-8 code barcode as PNG file

Validates and generate a EAN-8 barcode as a PNG file, a type of 1D barcode

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.Barcode.Api;
using Cloudmersive.APIClient.NETCore.Barcode.Client;
using Cloudmersive.APIClient.NETCore.Barcode.Model;

namespace Example
{
    public class GenerateBarcodeEAN8Example
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new GenerateBarcodeApi();
            var value = value_example;  // string | Barcode value to generate from

            try
            {
                // Generate a EAN-8 code barcode as PNG file
                System.IO.Stream result = apiInstance.GenerateBarcodeEAN8(value);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GenerateBarcodeApi.GenerateBarcodeEAN8: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **value** | **string**| Barcode value to generate from | 

### Return type

**System.IO.Stream**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: image/png

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="generatebarcodeqrcode"></a>
# **GenerateBarcodeQRCode**
> System.IO.Stream GenerateBarcodeQRCode (string value)

Generate a QR code barcode as PNG file

Generate a QR code barcode as a PNG file, a type of 2D barcode which can encode free-form text information

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.Barcode.Api;
using Cloudmersive.APIClient.NETCore.Barcode.Client;
using Cloudmersive.APIClient.NETCore.Barcode.Model;

namespace Example
{
    public class GenerateBarcodeQRCodeExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new GenerateBarcodeApi();
            var value = value_example;  // string | QR code text to convert into the QR code barcode

            try
            {
                // Generate a QR code barcode as PNG file
                System.IO.Stream result = apiInstance.GenerateBarcodeQRCode(value);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GenerateBarcodeApi.GenerateBarcodeQRCode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **value** | **string**| QR code text to convert into the QR code barcode | 

### Return type

**System.IO.Stream**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: image/png

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="generatebarcodeupca"></a>
# **GenerateBarcodeUPCA**
> System.IO.Stream GenerateBarcodeUPCA (string value)

Generate a UPC-A code barcode as PNG file

Validate and generate a UPC-A barcode as a PNG file, a type of 1D barcode

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.Barcode.Api;
using Cloudmersive.APIClient.NETCore.Barcode.Client;
using Cloudmersive.APIClient.NETCore.Barcode.Model;

namespace Example
{
    public class GenerateBarcodeUPCAExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new GenerateBarcodeApi();
            var value = value_example;  // string | UPC-A barcode value to generate from

            try
            {
                // Generate a UPC-A code barcode as PNG file
                System.IO.Stream result = apiInstance.GenerateBarcodeUPCA(value);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GenerateBarcodeApi.GenerateBarcodeUPCA: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **value** | **string**| UPC-A barcode value to generate from | 

### Return type

**System.IO.Stream**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: image/png

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="generatebarcodeupce"></a>
# **GenerateBarcodeUPCE**
> System.IO.Stream GenerateBarcodeUPCE (string value)

Generate a UPC-E code barcode as PNG file

Validates and generate a UPC-E barcode as a PNG file, a type of 1D barcode

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.Barcode.Api;
using Cloudmersive.APIClient.NETCore.Barcode.Client;
using Cloudmersive.APIClient.NETCore.Barcode.Model;

namespace Example
{
    public class GenerateBarcodeUPCEExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new GenerateBarcodeApi();
            var value = value_example;  // string | UPC-E barcode value to generate from

            try
            {
                // Generate a UPC-E code barcode as PNG file
                System.IO.Stream result = apiInstance.GenerateBarcodeUPCE(value);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GenerateBarcodeApi.GenerateBarcodeUPCE: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **value** | **string**| UPC-E barcode value to generate from | 

### Return type

**System.IO.Stream**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: image/png

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

