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
 * SummaryDocumentOutputModel
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2020-04-03T17:52:28.678Z[GMT]")
public class SummaryDocumentOutputModel {
  @SerializedName("detalle")
  private Object detalle = null;

  @SerializedName("fechaEmision")
  private String fechaEmision = null;

  @SerializedName("fechaEmisionDeComprobantesAsociados")
  private String fechaEmisionDeComprobantesAsociados = null;

  @SerializedName("firmante")
  private Object firmante = null;

  @SerializedName("moneda")
  private String moneda = null;

  @SerializedName("proveedor")
  private Object proveedor = null;

  @SerializedName("serieNumero")
  private String serieNumero = null;

  public SummaryDocumentOutputModel detalle(Object detalle) {
    this.detalle = detalle;
    return this;
  }

   /**
   * Get detalle
   * @return detalle
  **/
  @Schema(required = true, description = "")
  public Object getDetalle() {
    return detalle;
  }

  public void setDetalle(Object detalle) {
    this.detalle = detalle;
  }

  public SummaryDocumentOutputModel fechaEmision(String fechaEmision) {
    this.fechaEmision = fechaEmision;
    return this;
  }

   /**
   * Get fechaEmision
   * @return fechaEmision
  **/
  @Schema(description = "")
  public String getFechaEmision() {
    return fechaEmision;
  }

  public void setFechaEmision(String fechaEmision) {
    this.fechaEmision = fechaEmision;
  }

  public SummaryDocumentOutputModel fechaEmisionDeComprobantesAsociados(String fechaEmisionDeComprobantesAsociados) {
    this.fechaEmisionDeComprobantesAsociados = fechaEmisionDeComprobantesAsociados;
    return this;
  }

   /**
   * Get fechaEmisionDeComprobantesAsociados
   * @return fechaEmisionDeComprobantesAsociados
  **/
  @Schema(description = "")
  public String getFechaEmisionDeComprobantesAsociados() {
    return fechaEmisionDeComprobantesAsociados;
  }

  public void setFechaEmisionDeComprobantesAsociados(String fechaEmisionDeComprobantesAsociados) {
    this.fechaEmisionDeComprobantesAsociados = fechaEmisionDeComprobantesAsociados;
  }

  public SummaryDocumentOutputModel firmante(Object firmante) {
    this.firmante = firmante;
    return this;
  }

   /**
   * Get firmante
   * @return firmante
  **/
  @Schema(required = true, description = "")
  public Object getFirmante() {
    return firmante;
  }

  public void setFirmante(Object firmante) {
    this.firmante = firmante;
  }

  public SummaryDocumentOutputModel moneda(String moneda) {
    this.moneda = moneda;
    return this;
  }

   /**
   * Get moneda
   * @return moneda
  **/
  @Schema(description = "")
  public String getMoneda() {
    return moneda;
  }

  public void setMoneda(String moneda) {
    this.moneda = moneda;
  }

  public SummaryDocumentOutputModel proveedor(Object proveedor) {
    this.proveedor = proveedor;
    return this;
  }

   /**
   * Get proveedor
   * @return proveedor
  **/
  @Schema(required = true, description = "")
  public Object getProveedor() {
    return proveedor;
  }

  public void setProveedor(Object proveedor) {
    this.proveedor = proveedor;
  }

  public SummaryDocumentOutputModel serieNumero(String serieNumero) {
    this.serieNumero = serieNumero;
    return this;
  }

   /**
   * Get serieNumero
   * @return serieNumero
  **/
  @Schema(description = "")
  public String getSerieNumero() {
    return serieNumero;
  }

  public void setSerieNumero(String serieNumero) {
    this.serieNumero = serieNumero;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    SummaryDocumentOutputModel summaryDocumentOutputModel = (SummaryDocumentOutputModel) o;
    return Objects.equals(this.detalle, summaryDocumentOutputModel.detalle) &&
        Objects.equals(this.fechaEmision, summaryDocumentOutputModel.fechaEmision) &&
        Objects.equals(this.fechaEmisionDeComprobantesAsociados, summaryDocumentOutputModel.fechaEmisionDeComprobantesAsociados) &&
        Objects.equals(this.firmante, summaryDocumentOutputModel.firmante) &&
        Objects.equals(this.moneda, summaryDocumentOutputModel.moneda) &&
        Objects.equals(this.proveedor, summaryDocumentOutputModel.proveedor) &&
        Objects.equals(this.serieNumero, summaryDocumentOutputModel.serieNumero);
  }

  @Override
  public int hashCode() {
    return Objects.hash(detalle, fechaEmision, fechaEmisionDeComprobantesAsociados, firmante, moneda, proveedor, serieNumero);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class SummaryDocumentOutputModel {\n");
    
    sb.append("    detalle: ").append(toIndentedString(detalle)).append("\n");
    sb.append("    fechaEmision: ").append(toIndentedString(fechaEmision)).append("\n");
    sb.append("    fechaEmisionDeComprobantesAsociados: ").append(toIndentedString(fechaEmisionDeComprobantesAsociados)).append("\n");
    sb.append("    firmante: ").append(toIndentedString(firmante)).append("\n");
    sb.append("    moneda: ").append(toIndentedString(moneda)).append("\n");
    sb.append("    proveedor: ").append(toIndentedString(proveedor)).append("\n");
    sb.append("    serieNumero: ").append(toIndentedString(serieNumero)).append("\n");
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
