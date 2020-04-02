# DebitNote

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
**tipoNota** | [**TipoNotaEnum**](#TipoNotaEnum) | Catalogo 10 |  [optional]

<a name="TipoNotaEnum"></a>
## Enum: TipoNotaEnum
Name | Value
---- | -----
INTERES_POR_MORA | &quot;INTERES_POR_MORA&quot;
_01 | &quot;01&quot;
AUMENTO_EN_EL_VALOR | &quot;AUMENTO_EN_EL_VALOR&quot;
_02 | &quot;02&quot;
PENALIDAD_OTROS_CONCEPTOS | &quot;PENALIDAD_OTROS_CONCEPTOS&quot;
_03 | &quot;03&quot;
