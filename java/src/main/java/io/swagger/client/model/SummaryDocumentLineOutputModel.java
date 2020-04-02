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
import io.swagger.client.model.SummaryDocumentComprobanteAfectadoOutputModel;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
/**
 * SummaryDocumentLineOutputModel
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2020-04-02T05:58:18.345Z[GMT]")
public class SummaryDocumentLineOutputModel {
  @SerializedName("comprobante")
  private Object comprobante = null;

  @SerializedName("comprobanteAfectado")
  private SummaryDocumentComprobanteAfectadoOutputModel comprobanteAfectado = null;

  @SerializedName("tipoOperacion")
  private Object tipoOperacion = null;

  public SummaryDocumentLineOutputModel comprobante(Object comprobante) {
    this.comprobante = comprobante;
    return this;
  }

   /**
   * Get comprobante
   * @return comprobante
  **/
  @Schema(required = true, description = "")
  public Object getComprobante() {
    return comprobante;
  }

  public void setComprobante(Object comprobante) {
    this.comprobante = comprobante;
  }

  public SummaryDocumentLineOutputModel comprobanteAfectado(SummaryDocumentComprobanteAfectadoOutputModel comprobanteAfectado) {
    this.comprobanteAfectado = comprobanteAfectado;
    return this;
  }

   /**
   * Get comprobanteAfectado
   * @return comprobanteAfectado
  **/
  @Schema(description = "")
  public SummaryDocumentComprobanteAfectadoOutputModel getComprobanteAfectado() {
    return comprobanteAfectado;
  }

  public void setComprobanteAfectado(SummaryDocumentComprobanteAfectadoOutputModel comprobanteAfectado) {
    this.comprobanteAfectado = comprobanteAfectado;
  }

  public SummaryDocumentLineOutputModel tipoOperacion(Object tipoOperacion) {
    this.tipoOperacion = tipoOperacion;
    return this;
  }

   /**
   * Get tipoOperacion
   * @return tipoOperacion
  **/
  @Schema(required = true, description = "")
  public Object getTipoOperacion() {
    return tipoOperacion;
  }

  public void setTipoOperacion(Object tipoOperacion) {
    this.tipoOperacion = tipoOperacion;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    SummaryDocumentLineOutputModel summaryDocumentLineOutputModel = (SummaryDocumentLineOutputModel) o;
    return Objects.equals(this.comprobante, summaryDocumentLineOutputModel.comprobante) &&
        Objects.equals(this.comprobanteAfectado, summaryDocumentLineOutputModel.comprobanteAfectado) &&
        Objects.equals(this.tipoOperacion, summaryDocumentLineOutputModel.tipoOperacion);
  }

  @Override
  public int hashCode() {
    return Objects.hash(comprobante, comprobanteAfectado, tipoOperacion);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class SummaryDocumentLineOutputModel {\n");
    
    sb.append("    comprobante: ").append(toIndentedString(comprobante)).append("\n");
    sb.append("    comprobanteAfectado: ").append(toIndentedString(comprobanteAfectado)).append("\n");
    sb.append("    tipoOperacion: ").append(toIndentedString(tipoOperacion)).append("\n");
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
