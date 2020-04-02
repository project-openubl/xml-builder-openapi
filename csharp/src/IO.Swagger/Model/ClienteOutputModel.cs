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
    /// ClienteOutputModel
    /// </summary>
    [DataContract]
        public partial class ClienteOutputModel :  IEquatable<ClienteOutputModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClienteOutputModel" /> class.
        /// </summary>
        /// <param name="contacto">contacto.</param>
        /// <param name="direccion">direccion.</param>
        /// <param name="nombre">nombre.</param>
        /// <param name="numeroDocumentoIdentidad">numeroDocumentoIdentidad.</param>
        /// <param name="tipoDocumentoIdentidad">tipoDocumentoIdentidad (required).</param>
        public ClienteOutputModel(ContactoOutputModel contacto = default(ContactoOutputModel), DireccionOutputModel direccion = default(DireccionOutputModel), string nombre = default(string), string numeroDocumentoIdentidad = default(string),  tipoDocumentoIdentidad = default())
        {
            // to ensure "tipoDocumentoIdentidad" is required (not null)
            if (tipoDocumentoIdentidad == null)
            {
                throw new InvalidDataException("tipoDocumentoIdentidad is a required property for ClienteOutputModel and cannot be null");
            }
            else
            {
                this.TipoDocumentoIdentidad = tipoDocumentoIdentidad;
            }
            this.Contacto = contacto;
            this.Direccion = direccion;
            this.Nombre = nombre;
            this.NumeroDocumentoIdentidad = numeroDocumentoIdentidad;
        }
        
        /// <summary>
        /// Gets or Sets Contacto
        /// </summary>
        [DataMember(Name="contacto", EmitDefaultValue=false)]
        public ContactoOutputModel Contacto { get; set; }

        /// <summary>
        /// Gets or Sets Direccion
        /// </summary>
        [DataMember(Name="direccion", EmitDefaultValue=false)]
        public DireccionOutputModel Direccion { get; set; }

        /// <summary>
        /// Gets or Sets Nombre
        /// </summary>
        [DataMember(Name="nombre", EmitDefaultValue=false)]
        public string Nombre { get; set; }

        /// <summary>
        /// Gets or Sets NumeroDocumentoIdentidad
        /// </summary>
        [DataMember(Name="numeroDocumentoIdentidad", EmitDefaultValue=false)]
        public string NumeroDocumentoIdentidad { get; set; }

        /// <summary>
        /// Gets or Sets TipoDocumentoIdentidad
        /// </summary>
        [DataMember(Name="tipoDocumentoIdentidad", EmitDefaultValue=false)]
        public  TipoDocumentoIdentidad { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClienteOutputModel {\n");
            sb.Append("  Contacto: ").Append(Contacto).Append("\n");
            sb.Append("  Direccion: ").Append(Direccion).Append("\n");
            sb.Append("  Nombre: ").Append(Nombre).Append("\n");
            sb.Append("  NumeroDocumentoIdentidad: ").Append(NumeroDocumentoIdentidad).Append("\n");
            sb.Append("  TipoDocumentoIdentidad: ").Append(TipoDocumentoIdentidad).Append("\n");
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
            return this.Equals(input as ClienteOutputModel);
        }

        /// <summary>
        /// Returns true if ClienteOutputModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ClienteOutputModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClienteOutputModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Contacto == input.Contacto ||
                    (this.Contacto != null &&
                    this.Contacto.Equals(input.Contacto))
                ) && 
                (
                    this.Direccion == input.Direccion ||
                    (this.Direccion != null &&
                    this.Direccion.Equals(input.Direccion))
                ) && 
                (
                    this.Nombre == input.Nombre ||
                    (this.Nombre != null &&
                    this.Nombre.Equals(input.Nombre))
                ) && 
                (
                    this.NumeroDocumentoIdentidad == input.NumeroDocumentoIdentidad ||
                    (this.NumeroDocumentoIdentidad != null &&
                    this.NumeroDocumentoIdentidad.Equals(input.NumeroDocumentoIdentidad))
                ) && 
                (
                    this.TipoDocumentoIdentidad == input.TipoDocumentoIdentidad ||
                    (this.TipoDocumentoIdentidad != null &&
                    this.TipoDocumentoIdentidad.Equals(input.TipoDocumentoIdentidad))
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
                if (this.Contacto != null)
                    hashCode = hashCode * 59 + this.Contacto.GetHashCode();
                if (this.Direccion != null)
                    hashCode = hashCode * 59 + this.Direccion.GetHashCode();
                if (this.Nombre != null)
                    hashCode = hashCode * 59 + this.Nombre.GetHashCode();
                if (this.NumeroDocumentoIdentidad != null)
                    hashCode = hashCode * 59 + this.NumeroDocumentoIdentidad.GetHashCode();
                if (this.TipoDocumentoIdentidad != null)
                    hashCode = hashCode * 59 + this.TipoDocumentoIdentidad.GetHashCode();
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
