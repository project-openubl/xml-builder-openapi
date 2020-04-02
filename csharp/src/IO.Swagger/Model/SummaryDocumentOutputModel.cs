/* 
 * XML Builder API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0.0.Final
 * Contact: projectopenubl+subscribe@googlegroups.com
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// SummaryDocumentOutputModel
    /// </summary>
    [DataContract]
        public partial class SummaryDocumentOutputModel :  IEquatable<SummaryDocumentOutputModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SummaryDocumentOutputModel" /> class.
        /// </summary>
        /// <param name="detalle">detalle (required).</param>
        /// <param name="fechaEmision">fechaEmision.</param>
        /// <param name="fechaEmisionDeComprobantesAsociados">fechaEmisionDeComprobantesAsociados.</param>
        /// <param name="firmante">firmante (required).</param>
        /// <param name="moneda">moneda.</param>
        /// <param name="proveedor">proveedor (required).</param>
        /// <param name="serieNumero">serieNumero.</param>
        public SummaryDocumentOutputModel( detalle = default(), string fechaEmision = default(string), string fechaEmisionDeComprobantesAsociados = default(string),  firmante = default(), string moneda = default(string),  proveedor = default(), string serieNumero = default(string))
        {
            // to ensure "detalle" is required (not null)
            if (detalle == null)
            {
                throw new InvalidDataException("detalle is a required property for SummaryDocumentOutputModel and cannot be null");
            }
            else
            {
                this.Detalle = detalle;
            }
            // to ensure "firmante" is required (not null)
            if (firmante == null)
            {
                throw new InvalidDataException("firmante is a required property for SummaryDocumentOutputModel and cannot be null");
            }
            else
            {
                this.Firmante = firmante;
            }
            // to ensure "proveedor" is required (not null)
            if (proveedor == null)
            {
                throw new InvalidDataException("proveedor is a required property for SummaryDocumentOutputModel and cannot be null");
            }
            else
            {
                this.Proveedor = proveedor;
            }
            this.FechaEmision = fechaEmision;
            this.FechaEmisionDeComprobantesAsociados = fechaEmisionDeComprobantesAsociados;
            this.Moneda = moneda;
            this.SerieNumero = serieNumero;
        }
        
        /// <summary>
        /// Gets or Sets Detalle
        /// </summary>
        [DataMember(Name="detalle", EmitDefaultValue=false)]
        public  Detalle { get; set; }

        /// <summary>
        /// Gets or Sets FechaEmision
        /// </summary>
        [DataMember(Name="fechaEmision", EmitDefaultValue=false)]
        public string FechaEmision { get; set; }

        /// <summary>
        /// Gets or Sets FechaEmisionDeComprobantesAsociados
        /// </summary>
        [DataMember(Name="fechaEmisionDeComprobantesAsociados", EmitDefaultValue=false)]
        public string FechaEmisionDeComprobantesAsociados { get; set; }

        /// <summary>
        /// Gets or Sets Firmante
        /// </summary>
        [DataMember(Name="firmante", EmitDefaultValue=false)]
        public  Firmante { get; set; }

        /// <summary>
        /// Gets or Sets Moneda
        /// </summary>
        [DataMember(Name="moneda", EmitDefaultValue=false)]
        public string Moneda { get; set; }

        /// <summary>
        /// Gets or Sets Proveedor
        /// </summary>
        [DataMember(Name="proveedor", EmitDefaultValue=false)]
        public  Proveedor { get; set; }

        /// <summary>
        /// Gets or Sets SerieNumero
        /// </summary>
        [DataMember(Name="serieNumero", EmitDefaultValue=false)]
        public string SerieNumero { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SummaryDocumentOutputModel {\n");
            sb.Append("  Detalle: ").Append(Detalle).Append("\n");
            sb.Append("  FechaEmision: ").Append(FechaEmision).Append("\n");
            sb.Append("  FechaEmisionDeComprobantesAsociados: ").Append(FechaEmisionDeComprobantesAsociados).Append("\n");
            sb.Append("  Firmante: ").Append(Firmante).Append("\n");
            sb.Append("  Moneda: ").Append(Moneda).Append("\n");
            sb.Append("  Proveedor: ").Append(Proveedor).Append("\n");
            sb.Append("  SerieNumero: ").Append(SerieNumero).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as SummaryDocumentOutputModel);
        }

        /// <summary>
        /// Returns true if SummaryDocumentOutputModel instances are equal
        /// </summary>
        /// <param name="input">Instance of SummaryDocumentOutputModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SummaryDocumentOutputModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Detalle == input.Detalle ||
                    (this.Detalle != null &&
                    this.Detalle.Equals(input.Detalle))
                ) && 
                (
                    this.FechaEmision == input.FechaEmision ||
                    (this.FechaEmision != null &&
                    this.FechaEmision.Equals(input.FechaEmision))
                ) && 
                (
                    this.FechaEmisionDeComprobantesAsociados == input.FechaEmisionDeComprobantesAsociados ||
                    (this.FechaEmisionDeComprobantesAsociados != null &&
                    this.FechaEmisionDeComprobantesAsociados.Equals(input.FechaEmisionDeComprobantesAsociados))
                ) && 
                (
                    this.Firmante == input.Firmante ||
                    (this.Firmante != null &&
                    this.Firmante.Equals(input.Firmante))
                ) && 
                (
                    this.Moneda == input.Moneda ||
                    (this.Moneda != null &&
                    this.Moneda.Equals(input.Moneda))
                ) && 
                (
                    this.Proveedor == input.Proveedor ||
                    (this.Proveedor != null &&
                    this.Proveedor.Equals(input.Proveedor))
                ) && 
                (
                    this.SerieNumero == input.SerieNumero ||
                    (this.SerieNumero != null &&
                    this.SerieNumero.Equals(input.SerieNumero))
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
                if (this.Detalle != null)
                    hashCode = hashCode * 59 + this.Detalle.GetHashCode();
                if (this.FechaEmision != null)
                    hashCode = hashCode * 59 + this.FechaEmision.GetHashCode();
                if (this.FechaEmisionDeComprobantesAsociados != null)
                    hashCode = hashCode * 59 + this.FechaEmisionDeComprobantesAsociados.GetHashCode();
                if (this.Firmante != null)
                    hashCode = hashCode * 59 + this.Firmante.GetHashCode();
                if (this.Moneda != null)
                    hashCode = hashCode * 59 + this.Moneda.GetHashCode();
                if (this.Proveedor != null)
                    hashCode = hashCode * 59 + this.Proveedor.GetHashCode();
                if (this.SerieNumero != null)
                    hashCode = hashCode * 59 + this.SerieNumero.GetHashCode();
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
