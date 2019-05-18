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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Cloudmersive.APIClient.NETCore.Barcode.Client.SwaggerDateConverter;

namespace Cloudmersive.APIClient.NETCore.Barcode.Model
{
    /// <summary>
    /// Result of the barcode scan
    /// </summary>
    [DataContract]
    public partial class BarcodeScanResult :  IEquatable<BarcodeScanResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BarcodeScanResult" /> class.
        /// </summary>
        /// <param name="Successful">True if the operation was successful, false otherwise.</param>
        /// <param name="BarcodeType">The type of the barcode; possible values are AZTEC, CODABAR, CODE_39, CODE_93, CODE_128, DATA_MATRIX, EAN_8, EAN_13, ITF, MAXICODE, PDF_417, QR_CODE, RSS_14, RSS_EXPANDED, UPC_A, UPC_E, All_1D, UPC_EAN_EXTENSION, MSI, PLESSEY, IMB.</param>
        /// <param name="RawText">The barcode text.</param>
        public BarcodeScanResult(bool? Successful = default(bool?), string BarcodeType = default(string), string RawText = default(string))
        {
            this.Successful = Successful;
            this.BarcodeType = BarcodeType;
            this.RawText = RawText;
        }
        
        /// <summary>
        /// True if the operation was successful, false otherwise
        /// </summary>
        /// <value>True if the operation was successful, false otherwise</value>
        [DataMember(Name="Successful", EmitDefaultValue=false)]
        public bool? Successful { get; set; }

        /// <summary>
        /// The type of the barcode; possible values are AZTEC, CODABAR, CODE_39, CODE_93, CODE_128, DATA_MATRIX, EAN_8, EAN_13, ITF, MAXICODE, PDF_417, QR_CODE, RSS_14, RSS_EXPANDED, UPC_A, UPC_E, All_1D, UPC_EAN_EXTENSION, MSI, PLESSEY, IMB
        /// </summary>
        /// <value>The type of the barcode; possible values are AZTEC, CODABAR, CODE_39, CODE_93, CODE_128, DATA_MATRIX, EAN_8, EAN_13, ITF, MAXICODE, PDF_417, QR_CODE, RSS_14, RSS_EXPANDED, UPC_A, UPC_E, All_1D, UPC_EAN_EXTENSION, MSI, PLESSEY, IMB</value>
        [DataMember(Name="BarcodeType", EmitDefaultValue=false)]
        public string BarcodeType { get; set; }

        /// <summary>
        /// The barcode text
        /// </summary>
        /// <value>The barcode text</value>
        [DataMember(Name="RawText", EmitDefaultValue=false)]
        public string RawText { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BarcodeScanResult {\n");
            sb.Append("  Successful: ").Append(Successful).Append("\n");
            sb.Append("  BarcodeType: ").Append(BarcodeType).Append("\n");
            sb.Append("  RawText: ").Append(RawText).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as BarcodeScanResult);
        }

        /// <summary>
        /// Returns true if BarcodeScanResult instances are equal
        /// </summary>
        /// <param name="input">Instance of BarcodeScanResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BarcodeScanResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Successful == input.Successful ||
                    (this.Successful != null &&
                    this.Successful.Equals(input.Successful))
                ) && 
                (
                    this.BarcodeType == input.BarcodeType ||
                    (this.BarcodeType != null &&
                    this.BarcodeType.Equals(input.BarcodeType))
                ) && 
                (
                    this.RawText == input.RawText ||
                    (this.RawText != null &&
                    this.RawText.Equals(input.RawText))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Successful != null)
                    hashCode = hashCode * 59 + this.Successful.GetHashCode();
                if (this.BarcodeType != null)
                    hashCode = hashCode * 59 + this.BarcodeType.GetHashCode();
                if (this.RawText != null)
                    hashCode = hashCode * 59 + this.RawText.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
