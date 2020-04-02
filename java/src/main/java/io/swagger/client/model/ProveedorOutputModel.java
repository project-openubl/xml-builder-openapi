/*
 * XML Builder API
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0.0.Final
 * Contact: projectopenubl+subscribe@googlegroups.com
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */

package io.swagger.client.model;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.client.model.ContactoOutputModel;
import io.swagger.client.model.DireccionOutputModel;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
/**
 * ProveedorOutputModel
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2020-04-02T05:58:18.345Z[GMT]")
public class ProveedorOutputModel {
  @SerializedName("contacto")
  private ContactoOutputModel contacto = null;

  @SerializedName("direccion")
  private DireccionOutputModel direccion = null;

  @SerializedName("nombreComercial")
  private String nombreComercial = null;

  @SerializedName("razonSocial")
  private String razonSocial = null;

  @SerializedName("ruc")
  private String ruc = null;

  public ProveedorOutputModel contacto(ContactoOutputModel contacto) {
    this.contacto = contacto;
    return this;
  }

   /**
   * Get contacto
   * @return contacto
  **/
  @Schema(description = "")
  public ContactoOutputModel getContacto() {
    return contacto;
  }

  public void setContacto(ContactoOutputModel contacto) {
    this.contacto = contacto;
  }

  public ProveedorOutputModel direccion(DireccionOutputModel direccion) {
    this.direccion = direccion;
    return this;
  }

   /**
   * Get direccion
   * @return direccion
  **/
  @Schema(description = "")
  public DireccionOutputModel getDireccion() {
    return direccion;
  }

  public void setDireccion(DireccionOutputModel direccion) {
    this.direccion = direccion;
  }

  public ProveedorOutputModel nombreComercial(String nombreComercial) {
    this.nombreComercial = nombreComercial;
    return this;
  }

   /**
   * Get nombreComercial
   * @return nombreComercial
  **/
  @Schema(description = "")
  public String getNombreComercial() {
    return nombreComercial;
  }

  public void setNombreComercial(String nombreComercial) {
    this.nombreComercial = nombreComercial;
  }

  public ProveedorOutputModel razonSocial(String razonSocial) {
    this.razonSocial = razonSocial;
    return this;
  }

   /**
   * Get razonSocial
   * @return razonSocial
  **/
  @Schema(description = "")
  public String getRazonSocial() {
    return razonSocial;
  }

  public void setRazonSocial(String razonSocial) {
    this.razonSocial = razonSocial;
  }

  public ProveedorOutputModel ruc(String ruc) {
    this.ruc = ruc;
    return this;
  }

   /**
   * Get ruc
   * @return ruc
  **/
  @Schema(description = "")
  public String getRuc() {
    return ruc;
  }

  public void setRuc(String ruc) {
    this.ruc = ruc;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ProveedorOutputModel proveedorOutputModel = (ProveedorOutputModel) o;
    return Objects.equals(this.contacto, proveedorOutputModel.contacto) &&
        Objects.equals(this.direccion, proveedorOutputModel.direccion) &&
        Objects.equals(this.nombreComercial, proveedorOutputModel.nombreComercial) &&
        Objects.equals(this.razonSocial, proveedorOutputModel.razonSocial) &&
        Objects.equals(this.ruc, proveedorOutputModel.ruc);
  }

  @Override
  public int hashCode() {
    return Objects.hash(contacto, direccion, nombreComercial, razonSocial, ruc);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ProveedorOutputModel {\n");
    
    sb.append("    contacto: ").append(toIndentedString(contacto)).append("\n");
    sb.append("    direccion: ").append(toIndentedString(direccion)).append("\n");
    sb.append("    nombreComercial: ").append(toIndentedString(nombreComercial)).append("\n");
    sb.append("    razonSocial: ").append(toIndentedString(razonSocial)).append("\n");
    sb.append("    ruc: ").append(toIndentedString(ruc)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}
