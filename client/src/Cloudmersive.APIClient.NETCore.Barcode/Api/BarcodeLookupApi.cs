/* 
 * barcodeapi
 *
 * Barcode APIs let you generate barcode images, and recognize values from images of barcodes.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp.Portable;
using Cloudmersive.APIClient.NETCore.Barcode.Client;
using Cloudmersive.APIClient.NETCore.Barcode.Model;

namespace Cloudmersive.APIClient.NETCore.Barcode.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBarcodeLookupApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Lookup EAN barcode value, return product data
        /// </summary>
        /// <remarks>
        /// Lookup an input EAN barcode and return key details about the product
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NETCore.Barcode.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="value">Barcode value</param>
        /// <returns>BarcodeLookupResponse</returns>
        BarcodeLookupResponse BarcodeLookupEanLookup (string value);

        /// <summary>
        /// Lookup EAN barcode value, return product data
        /// </summary>
        /// <remarks>
        /// Lookup an input EAN barcode and return key details about the product
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NETCore.Barcode.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="value">Barcode value</param>
        /// <returns>ApiResponse of BarcodeLookupResponse</returns>
        ApiResponse<BarcodeLookupResponse> BarcodeLookupEanLookupWithHttpInfo (string value);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Lookup EAN barcode value, return product data
        /// </summary>
        /// <remarks>
        /// Lookup an input EAN barcode and return key details about the product
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NETCore.Barcode.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="value">Barcode value</param>
        /// <returns>Task of BarcodeLookupResponse</returns>
        System.Threading.Tasks.Task<BarcodeLookupResponse> BarcodeLookupEanLookupAsync (string value);

        /// <summary>
        /// Lookup EAN barcode value, return product data
        /// </summary>
        /// <remarks>
        /// Lookup an input EAN barcode and return key details about the product
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NETCore.Barcode.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="value">Barcode value</param>
        /// <returns>Task of ApiResponse (BarcodeLookupResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<BarcodeLookupResponse>> BarcodeLookupEanLookupAsyncWithHttpInfo (string value);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class BarcodeLookupApi : IBarcodeLookupApi
    {
        private Cloudmersive.APIClient.NETCore.Barcode.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="BarcodeLookupApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BarcodeLookupApi(String basePath)
        {
            this.Configuration = new Cloudmersive.APIClient.NETCore.Barcode.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Cloudmersive.APIClient.NETCore.Barcode.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BarcodeLookupApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public BarcodeLookupApi(Cloudmersive.APIClient.NETCore.Barcode.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Cloudmersive.APIClient.NETCore.Barcode.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Cloudmersive.APIClient.NETCore.Barcode.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Cloudmersive.APIClient.NETCore.Barcode.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Cloudmersive.APIClient.NETCore.Barcode.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Lookup EAN barcode value, return product data Lookup an input EAN barcode and return key details about the product
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NETCore.Barcode.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="value">Barcode value</param>
        /// <returns>BarcodeLookupResponse</returns>
        public BarcodeLookupResponse BarcodeLookupEanLookup (string value)
        {
             ApiResponse<BarcodeLookupResponse> localVarResponse = BarcodeLookupEanLookupWithHttpInfo(value);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lookup EAN barcode value, return product data Lookup an input EAN barcode and return key details about the product
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NETCore.Barcode.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="value">Barcode value</param>
        /// <returns>ApiResponse of BarcodeLookupResponse</returns>
        public ApiResponse< BarcodeLookupResponse > BarcodeLookupEanLookupWithHttpInfo (string value)
        {
            // verify the required parameter 'value' is set
            if (value == null)
                throw new ApiException(400, "Missing required parameter 'value' when calling BarcodeLookupApi->BarcodeLookupEanLookup");

            var localVarPath = "./barcode/lookup/ean";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml", 
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (value != null && value.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(value); // http body (model) parameter
            }
            else
            {
                localVarPostBody = value; // byte array
            }

            // authentication (Apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Apikey")))
            {
                localVarHeaderParams["Apikey"] = this.Configuration.GetApiKeyWithPrefix("Apikey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("BarcodeLookupEanLookup", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<BarcodeLookupResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (BarcodeLookupResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BarcodeLookupResponse)));
        }

        /// <summary>
        /// Lookup EAN barcode value, return product data Lookup an input EAN barcode and return key details about the product
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NETCore.Barcode.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="value">Barcode value</param>
        /// <returns>Task of BarcodeLookupResponse</returns>
        public async System.Threading.Tasks.Task<BarcodeLookupResponse> BarcodeLookupEanLookupAsync (string value)
        {
             ApiResponse<BarcodeLookupResponse> localVarResponse = await BarcodeLookupEanLookupAsyncWithHttpInfo(value);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lookup EAN barcode value, return product data Lookup an input EAN barcode and return key details about the product
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NETCore.Barcode.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="value">Barcode value</param>
        /// <returns>Task of ApiResponse (BarcodeLookupResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BarcodeLookupResponse>> BarcodeLookupEanLookupAsyncWithHttpInfo (string value)
        {
            // verify the required parameter 'value' is set
            if (value == null)
                throw new ApiException(400, "Missing required parameter 'value' when calling BarcodeLookupApi->BarcodeLookupEanLookup");

            var localVarPath = "./barcode/lookup/ean";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml", 
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (value != null && value.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(value); // http body (model) parameter
            }
            else
            {
                localVarPostBody = value; // byte array
            }

            // authentication (Apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Apikey")))
            {
                localVarHeaderParams["Apikey"] = this.Configuration.GetApiKeyWithPrefix("Apikey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("BarcodeLookupEanLookup", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<BarcodeLookupResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (BarcodeLookupResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BarcodeLookupResponse)));
        }

    }
}
