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
 * FirmanteOutputModel
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2020-04-02T05:58:18.345Z[GMT]")
public class FirmanteOutputModel {
  @SerializedName("razonSocial")
  private String razonSocial = null;

  @SerializedName("ruc")
  private String ruc = null;

  public FirmanteOutputModel razonSocial(String razonSocial) {
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

  public FirmanteOutputModel ruc(String ruc) {
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
    FirmanteOutputModel firmanteOutputModel = (FirmanteOutputModel) o;
    return Objects.equals(this.razonSocial, firmanteOutputModel.razonSocial) &&
        Objects.equals(this.ruc, firmanteOutputModel.ruc);
  }

  @Override
  public int hashCode() {
    return Objects.hash(razonSocial, ruc);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class FirmanteOutputModel {\n");
    
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
