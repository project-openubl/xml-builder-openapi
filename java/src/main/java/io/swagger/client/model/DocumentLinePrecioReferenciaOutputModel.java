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
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
/**
 * DocumentLinePrecioReferenciaOutputModel
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2020-04-02T05:58:18.345Z[GMT]")
public class DocumentLinePrecioReferenciaOutputModel {
  @SerializedName("precio")
  private Object precio = null;

  @SerializedName("tipoPrecio")
  private Object tipoPrecio = null;

  public DocumentLinePrecioReferenciaOutputModel precio(Object precio) {
    this.precio = precio;
    return this;
  }

   /**
   * Get precio
   * @return precio
  **/
  @Schema(required = true, description = "")
  public Object getPrecio() {
    return precio;
  }

  public void setPrecio(Object precio) {
    this.precio = precio;
  }

  public DocumentLinePrecioReferenciaOutputModel tipoPrecio(Object tipoPrecio) {
    this.tipoPrecio = tipoPrecio;
    return this;
  }

   /**
   * Get tipoPrecio
   * @return tipoPrecio
  **/
  @Schema(required = true, description = "")
  public Object getTipoPrecio() {
    return tipoPrecio;
  }

  public void setTipoPrecio(Object tipoPrecio) {
    this.tipoPrecio = tipoPrecio;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    DocumentLinePrecioReferenciaOutputModel documentLinePrecioReferenciaOutputModel = (DocumentLinePrecioReferenciaOutputModel) o;
    return Objects.equals(this.precio, documentLinePrecioReferenciaOutputModel.precio) &&
        Objects.equals(this.tipoPrecio, documentLinePrecioReferenciaOutputModel.tipoPrecio);
  }

  @Override
  public int hashCode() {
    return Objects.hash(precio, tipoPrecio);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class DocumentLinePrecioReferenciaOutputModel {\n");
    
    sb.append("    precio: ").append(toIndentedString(precio)).append("\n");
    sb.append("    tipoPrecio: ").append(toIndentedString(tipoPrecio)).append("\n");
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
