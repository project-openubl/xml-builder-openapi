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
    /// DocumentLineOutputModel
    /// </summary>
    [DataContract]
        public partial class DocumentLineOutputModel :  IEquatable<DocumentLineOutputModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentLineOutputModel" /> class.
        /// </summary>
        /// <param name="cantidad">cantidad (required).</param>
        /// <param name="descripcion">descripcion.</param>
        /// <param name="impuestos">impuestos (required).</param>
        /// <param name="precioConIgv">precioConIgv (required).</param>
        /// <param name="precioDeReferencia">precioDeReferencia (required).</param>
        /// <param name="precioUnitario">precioUnitario (required).</param>
        /// <param name="unidadMedida">unidadMedida.</param>
        /// <param name="valorVentaSinImpuestos">valorVentaSinImpuestos (required).</param>
        public DocumentLineOutputModel( cantidad = default(), string descripcion = default(string),  impuestos = default(),  precioConIgv = default(),  precioDeReferencia = default(),  precioUnitario = default(), string unidadMedida = default(string),  valorVentaSinImpuestos = default())
        {
            // to ensure "cantidad" is required (not null)
            if (cantidad == null)
            {
                throw new InvalidDataException("cantidad is a required property for DocumentLineOutputModel and cannot be null");
            }
            else
            {
                this.Cantidad = cantidad;
            }
            // to ensure "impuestos" is required (not null)
            if (impuestos == null)
            {
                throw new InvalidDataException("impuestos is a required property for DocumentLineOutputModel and cannot be null");
            }
            else
            {
                this.Impuestos = impuestos;
            }
            // to ensure "precioConIgv" is required (not null)
            if (precioConIgv == null)
            {
                throw new InvalidDataException("precioConIgv is a required property for DocumentLineOutputModel and cannot be null");
            }
            else
            {
                this.PrecioConIgv = precioConIgv;
            }
            // to ensure "precioDeReferencia" is required (not null)
            if (precioDeReferencia == null)
            {
                throw new InvalidDataException("precioDeReferencia is a required property for DocumentLineOutputModel and cannot be null");
            }
            else
            {
                this.PrecioDeReferencia = precioDeReferencia;
            }
            // to ensure "precioUnitario" is required (not null)
            if (precioUnitario == null)
            {
                throw new InvalidDataException("precioUnitario is a required property for DocumentLineOutputModel and cannot be null");
            }
            else
            {
                this.PrecioUnitario = precioUnitario;
            }
            // to ensure "valorVentaSinImpuestos" is required (not null)
            if (valorVentaSinImpuestos == null)
            {
                throw new InvalidDataException("valorVentaSinImpuestos is a required property for DocumentLineOutputModel and cannot be null");
            }
            else
            {
                this.ValorVentaSinImpuestos = valorVentaSinImpuestos;
            }
            this.Descripcion = descripcion;
            this.UnidadMedida = unidadMedida;
        }
        
        /// <summary>
        /// Gets or Sets Cantidad
        /// </summary>
        [DataMember(Name="cantidad", EmitDefaultValue=false)]
        public  Cantidad { get; set; }

        /// <summary>
        /// Gets or Sets Descripcion
        /// </summary>
        [DataMember(Name="descripcion", EmitDefaultValue=false)]
        public string Descripcion { get; set; }

        /// <summary>
        /// Gets or Sets Impuestos
        /// </summary>
        [DataMember(Name="impuestos", EmitDefaultValue=false)]
        public  Impuestos { get; set; }

        /// <summary>
        /// Gets or Sets PrecioConIgv
        /// </summary>
        [DataMember(Name="precioConIgv", EmitDefaultValue=false)]
        public  PrecioConIgv { get; set; }

        /// <summary>
        /// Gets or Sets PrecioDeReferencia
        /// </summary>
        [DataMember(Name="precioDeReferencia", EmitDefaultValue=false)]
        public  PrecioDeReferencia { get; set; }

        /// <summary>
        /// Gets or Sets PrecioUnitario
        /// </summary>
        [DataMember(Name="precioUnitario", EmitDefaultValue=false)]
        public  PrecioUnitario { get; set; }

        /// <summary>
        /// Gets or Sets UnidadMedida
        /// </summary>
        [DataMember(Name="unidadMedida", EmitDefaultValue=false)]
        public string UnidadMedida { get; set; }

        /// <summary>
        /// Gets or Sets ValorVentaSinImpuestos
        /// </summary>
        [DataMember(Name="valorVentaSinImpuestos", EmitDefaultValue=false)]
        public  ValorVentaSinImpuestos { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentLineOutputModel {\n");
            sb.Append("  Cantidad: ").Append(Cantidad).Append("\n");
            sb.Append("  Descripcion: ").Append(Descripcion).Append("\n");
            sb.Append("  Impuestos: ").Append(Impuestos).Append("\n");
            sb.Append("  PrecioConIgv: ").Append(PrecioConIgv).Append("\n");
            sb.Append("  PrecioDeReferencia: ").Append(PrecioDeReferencia).Append("\n");
            sb.Append("  PrecioUnitario: ").Append(PrecioUnitario).Append("\n");
            sb.Append("  UnidadMedida: ").Append(UnidadMedida).Append("\n");
            sb.Append("  ValorVentaSinImpuestos: ").Append(ValorVentaSinImpuestos).Append("\n");
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
            return this.Equals(input as DocumentLineOutputModel);
        }

        /// <summary>
        /// Returns true if DocumentLineOutputModel instances are equal
        /// </summary>
        /// <param name="input">Instance of DocumentLineOutputModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentLineOutputModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Cantidad == input.Cantidad ||
                    (this.Cantidad != null &&
                    this.Cantidad.Equals(input.Cantidad))
                ) && 
                (
                    this.Descripcion == input.Descripcion ||
                    (this.Descripcion != null &&
                    this.Descripcion.Equals(input.Descripcion))
                ) && 
                (
                    this.Impuestos == input.Impuestos ||
                    (this.Impuestos != null &&
                    this.Impuestos.Equals(input.Impuestos))
                ) && 
                (
                    this.PrecioConIgv == input.PrecioConIgv ||
                    (this.PrecioConIgv != null &&
                    this.PrecioConIgv.Equals(input.PrecioConIgv))
                ) && 
                (
                    this.PrecioDeReferencia == input.PrecioDeReferencia ||
                    (this.PrecioDeReferencia != null &&
                    this.PrecioDeReferencia.Equals(input.PrecioDeReferencia))
                ) && 
                (
                    this.PrecioUnitario == input.PrecioUnitario ||
                    (this.PrecioUnitario != null &&
                    this.PrecioUnitario.Equals(input.PrecioUnitario))
                ) && 
                (
                    this.UnidadMedida == input.UnidadMedida ||
                    (this.UnidadMedida != null &&
                    this.UnidadMedida.Equals(input.UnidadMedida))
                ) && 
                (
                    this.ValorVentaSinImpuestos == input.ValorVentaSinImpuestos ||
                    (this.ValorVentaSinImpuestos != null &&
                    this.ValorVentaSinImpuestos.Equals(input.ValorVentaSinImpuestos))
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
                if (this.Cantidad != null)
                    hashCode = hashCode * 59 + this.Cantidad.GetHashCode();
                if (this.Descripcion != null)
                    hashCode = hashCode * 59 + this.Descripcion.GetHashCode();
                if (this.Impuestos != null)
                    hashCode = hashCode * 59 + this.Impuestos.GetHashCode();
                if (this.PrecioConIgv != null)
                    hashCode = hashCode * 59 + this.PrecioConIgv.GetHashCode();
                if (this.PrecioDeReferencia != null)
                    hashCode = hashCode * 59 + this.PrecioDeReferencia.GetHashCode();
                if (this.PrecioUnitario != null)
                    hashCode = hashCode * 59 + this.PrecioUnitario.GetHashCode();
                if (this.UnidadMedida != null)
                    hashCode = hashCode * 59 + this.UnidadMedida.GetHashCode();
                if (this.ValorVentaSinImpuestos != null)
                    hashCode = hashCode * 59 + this.ValorVentaSinImpuestos.GetHashCode();
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
