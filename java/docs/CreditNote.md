# CreditNote

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**cliente** | **Object** |  | 
**detalle** | **Object** |  | 
**fechaEmision** | **Long** | Fecha expresada en milliseconds |  [optional]
**firmante** | **Object** |  |  [optional]
**numero** | **Integer** |  | 
**proveedor** | **Object** |  | 
**serie** | **String** |  | 
**descripcionSustentoDeNota** | **String** | Razón por la que se crea la nota | 
**serieNumeroComprobanteAfectado** | **String** | Serie y número del comprobante afectado por la nota | 
**tipoNota** | [**TipoNotaEnum**](#TipoNotaEnum) | Catalogo 09 |  [optional]

<a name="TipoNotaEnum"></a>
## Enum: TipoNotaEnum
Name | Value
---- | -----
ANULACION_DE_LA_OPERACION | &quot;ANULACION_DE_LA_OPERACION&quot;
_01 | &quot;01&quot;
ANULACION_POR_ERROR_EN_EL_RUC | &quot;ANULACION_POR_ERROR_EN_EL_RUC&quot;
_02 | &quot;02&quot;
CORRECCION_POR_ERROR_EN_LA_DESCRIPCION | &quot;CORRECCION_POR_ERROR_EN_LA_DESCRIPCION&quot;
_03 | &quot;03&quot;
DESCUENTO_GLOBAL | &quot;DESCUENTO_GLOBAL&quot;
_04 | &quot;04&quot;
DESCUENTO_POR_ITEM | &quot;DESCUENTO_POR_ITEM&quot;
_05 | &quot;05&quot;
DEVOLUCION_TOTAL | &quot;DEVOLUCION_TOTAL&quot;
_06 | &quot;06&quot;
DEVOLUCION_POR_ITEM | &quot;DEVOLUCION_POR_ITEM&quot;
_07 | &quot;07&quot;
BONIFICACION | &quot;BONIFICACION&quot;
_08 | &quot;08&quot;
DISMINUCION_EN_EL_VALOR | &quot;DISMINUCION_EN_EL_VALOR&quot;
_09 | &quot;09&quot;
OTROS_CONCEPTOS | &quot;OTROS_CONCEPTOS&quot;
_10 | &quot;10&quot;
