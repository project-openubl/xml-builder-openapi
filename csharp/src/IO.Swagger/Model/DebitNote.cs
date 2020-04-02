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
    /// DebitNote
    /// </summary>
    [DataContract]
        public partial class DebitNote :  IEquatable<DebitNote>, IValidatableObject
    {
        /// <summary>
        /// Catalogo 10
        /// </summary>
        /// <value>Catalogo 10</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TipoNotaEnum
        {
            /// <summary>
            /// Enum INTERESPORMORA for value: INTERES_POR_MORA
            /// </summary>
            [EnumMember(Value = "INTERES_POR_MORA")]
            INTERESPORMORA = 1,
            /// <summary>
            /// Enum _01 for value: 01
            /// </summary>
            [EnumMember(Value = "01")]
            _01 = 2,
            /// <summary>
            /// Enum AUMENTOENELVALOR for value: AUMENTO_EN_EL_VALOR
            /// </summary>
            [EnumMember(Value = "AUMENTO_EN_EL_VALOR")]
            AUMENTOENELVALOR = 3,
            /// <summary>
            /// Enum _02 for value: 02
            /// </summary>
            [EnumMember(Value = "02")]
            _02 = 4,
            /// <summary>
            /// Enum PENALIDADOTROSCONCEPTOS for value: PENALIDAD_OTROS_CONCEPTOS
            /// </summary>
            [EnumMember(Value = "PENALIDAD_OTROS_CONCEPTOS")]
            PENALIDADOTROSCONCEPTOS = 5,
            /// <summary>
            /// Enum _03 for value: 03
            /// </summary>
            [EnumMember(Value = "03")]
            _03 = 6        }
        /// <summary>
        /// Catalogo 10
        /// </summary>
        /// <value>Catalogo 10</value>
        [DataMember(Name="tipoNota", EmitDefaultValue=false)]
        public TipoNotaEnum? TipoNota { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DebitNote" /> class.
        /// </summary>
        /// <param name="cliente">cliente (required).</param>
        /// <param name="detalle">detalle (required).</param>
        /// <param name="fechaEmision">Fecha expresada en milliseconds.</param>
        /// <param name="firmante">firmante.</param>
        /// <param name="numero">numero (required).</param>
        /// <param name="proveedor">proveedor (required).</param>
        /// <param name="serie">serie (required).</param>
        /// <param name="descripcionSustentoDeNota">Razón por la que se crea la nota (required).</param>
        /// <param name="serieNumeroComprobanteAfectado">Serie y número del comprobante afectado por la nota (required).</param>
        /// <param name="tipoNota">Catalogo 10.</param>
        public DebitNote( cliente = default(),  detalle = default(), long? fechaEmision = default(long?),  firmante = default(), int? numero = default(int?),  proveedor = default(), string serie = default(string), string descripcionSustentoDeNota = default(string), string serieNumeroComprobanteAfectado = default(string), TipoNotaEnum? tipoNota = default(TipoNotaEnum?))
        {
            // to ensure "cliente" is required (not null)
            if (cliente == null)
            {
                throw new InvalidDataException("cliente is a required property for DebitNote and cannot be null");
            }
            else
            {
                this.Cliente = cliente;
            }
            // to ensure "detalle" is required (not null)
            if (detalle == null)
            {
                throw new InvalidDataException("detalle is a required property for DebitNote and cannot be null");
            }
            else
            {
                this.Detalle = detalle;
            }
            // to ensure "numero" is required (not null)
            if (numero == null)
            {
                throw new InvalidDataException("numero is a required property for DebitNote and cannot be null");
            }
            else
            {
                this.Numero = numero;
            }
            // to ensure "proveedor" is required (not null)
            if (proveedor == null)
            {
                throw new InvalidDataException("proveedor is a required property for DebitNote and cannot be null");
            }
            else
            {
                this.Proveedor = proveedor;
            }
            // to ensure "serie" is required (not null)
            if (serie == null)
            {
                throw new InvalidDataException("serie is a required property for DebitNote and cannot be null");
            }
            else
            {
                this.Serie = serie;
            }
            // to ensure "descripcionSustentoDeNota" is required (not null)
            if (descripcionSustentoDeNota == null)
            {
                throw new InvalidDataException("descripcionSustentoDeNota is a required property for DebitNote and cannot be null");
            }
            else
            {
                this.DescripcionSustentoDeNota = descripcionSustentoDeNota;
            }
            // to ensure "serieNumeroComprobanteAfectado" is required (not null)
            if (serieNumeroComprobanteAfectado == null)
            {
                throw new InvalidDataException("serieNumeroComprobanteAfectado is a required property for DebitNote and cannot be null");
            }
            else
            {
                this.SerieNumeroComprobanteAfectado = serieNumeroComprobanteAfectado;
            }
            this.FechaEmision = fechaEmision;
            this.Firmante = firmante;
            this.TipoNota = tipoNota;
        }
        
        /// <summary>
        /// Gets or Sets Cliente
        /// </summary>
        [DataMember(Name="cliente", EmitDefaultValue=false)]
        public  Cliente { get; set; }

        /// <summary>
        /// Gets or Sets Detalle
        /// </summary>
        [DataMember(Name="detalle", EmitDefaultValue=false)]
        public  Detalle { get; set; }

        /// <summary>
        /// Fecha expresada en milliseconds
        /// </summary>
        /// <value>Fecha expresada en milliseconds</value>
        [DataMember(Name="fechaEmision", EmitDefaultValue=false)]
        public long? FechaEmision { get; set; }

        /// <summary>
        /// Gets or Sets Firmante
        /// </summary>
        [DataMember(Name="firmante", EmitDefaultValue=false)]
        public  Firmante { get; set; }

        /// <summary>
        /// Gets or Sets Numero
        /// </summary>
        [DataMember(Name="numero", EmitDefaultValue=false)]
        public int? Numero { get; set; }

        /// <summary>
        /// Gets or Sets Proveedor
        /// </summary>
        [DataMember(Name="proveedor", EmitDefaultValue=false)]
        public  Proveedor { get; set; }

        /// <summary>
        /// Gets or Sets Serie
        /// </summary>
        [DataMember(Name="serie", EmitDefaultValue=false)]
        public string Serie { get; set; }

        /// <summary>
        /// Razón por la que se crea la nota
        /// </summary>
        /// <value>Razón por la que se crea la nota</value>
        [DataMember(Name="descripcionSustentoDeNota", EmitDefaultValue=false)]
        public string DescripcionSustentoDeNota { get; set; }

        /// <summary>
        /// Serie y número del comprobante afectado por la nota
        /// </summary>
        /// <value>Serie y número del comprobante afectado por la nota</value>
        [DataMember(Name="serieNumeroComprobanteAfectado", EmitDefaultValue=false)]
        public string SerieNumeroComprobanteAfectado { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DebitNote {\n");
            sb.Append("  Cliente: ").Append(Cliente).Append("\n");
            sb.Append("  Detalle: ").Append(Detalle).Append("\n");
            sb.Append("  FechaEmision: ").Append(FechaEmision).Append("\n");
            sb.Append("  Firmante: ").Append(Firmante).Append("\n");
            sb.Append("  Numero: ").Append(Numero).Append("\n");
            sb.Append("  Proveedor: ").Append(Proveedor).Append("\n");
            sb.Append("  Serie: ").Append(Serie).Append("\n");
            sb.Append("  DescripcionSustentoDeNota: ").Append(DescripcionSustentoDeNota).Append("\n");
            sb.Append("  SerieNumeroComprobanteAfectado: ").Append(SerieNumeroComprobanteAfectado).Append("\n");
            sb.Append("  TipoNota: ").Append(TipoNota).Append("\n");
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
            return this.Equals(input as DebitNote);
        }

        /// <summary>
        /// Returns true if DebitNote instances are equal
        /// </summary>
        /// <param name="input">Instance of DebitNote to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DebitNote input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Cliente == input.Cliente ||
                    (this.Cliente != null &&
                    this.Cliente.Equals(input.Cliente))
                ) && 
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
                    this.Firmante == input.Firmante ||
                    (this.Firmante != null &&
                    this.Firmante.Equals(input.Firmante))
                ) && 
                (
                    this.Numero == input.Numero ||
                    (this.Numero != null &&
                    this.Numero.Equals(input.Numero))
                ) && 
                (
                    this.Proveedor == input.Proveedor ||
                    (this.Proveedor != null &&
                    this.Proveedor.Equals(input.Proveedor))
                ) && 
                (
                    this.Serie == input.Serie ||
                    (this.Serie != null &&
                    this.Serie.Equals(input.Serie))
                ) && 
                (
                    this.DescripcionSustentoDeNota == input.DescripcionSustentoDeNota ||
                    (this.DescripcionSustentoDeNota != null &&
                    this.DescripcionSustentoDeNota.Equals(input.DescripcionSustentoDeNota))
                ) && 
                (
                    this.SerieNumeroComprobanteAfectado == input.SerieNumeroComprobanteAfectado ||
                    (this.SerieNumeroComprobanteAfectado != null &&
                    this.SerieNumeroComprobanteAfectado.Equals(input.SerieNumeroComprobanteAfectado))
                ) && 
                (
                    this.TipoNota == input.TipoNota ||
                    (this.TipoNota != null &&
                    this.TipoNota.Equals(input.TipoNota))
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
                if (this.Cliente != null)
                    hashCode = hashCode * 59 + this.Cliente.GetHashCode();
                if (this.Detalle != null)
                    hashCode = hashCode * 59 + this.Detalle.GetHashCode();
                if (this.FechaEmision != null)
                    hashCode = hashCode * 59 + this.FechaEmision.GetHashCode();
                if (this.Firmante != null)
                    hashCode = hashCode * 59 + this.Firmante.GetHashCode();
                if (this.Numero != null)
                    hashCode = hashCode * 59 + this.Numero.GetHashCode();
                if (this.Proveedor != null)
                    hashCode = hashCode * 59 + this.Proveedor.GetHashCode();
                if (this.Serie != null)
                    hashCode = hashCode * 59 + this.Serie.GetHashCode();
                if (this.DescripcionSustentoDeNota != null)
                    hashCode = hashCode * 59 + this.DescripcionSustentoDeNota.GetHashCode();
                if (this.SerieNumeroComprobanteAfectado != null)
                    hashCode = hashCode * 59 + this.SerieNumeroComprobanteAfectado.GetHashCode();
                if (this.TipoNota != null)
                    hashCode = hashCode * 59 + this.TipoNota.GetHashCode();
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
