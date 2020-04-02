# DocumentLine

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**cantidad** | **Object** |  | 
**descripcion** | **String** | Descripción del producto/servicio | 
**icb** | **Boolean** | True si el producto está afecto al impuesto ICB_PE |  [optional]
**precioConIgv** | **Object** |  |  [optional]
**precioUnitario** | **Object** |  |  [optional]
**tipoIgv** | [**TipoIgvEnum**](#TipoIgvEnum) | Catalogo 07 |  [optional]
**unidadMedida** | **String** |  |  [optional]

<a name="TipoIgvEnum"></a>
## Enum: TipoIgvEnum
Name | Value
---- | -----
GRAVADO_OPERACION_ONEROSA | &quot;GRAVADO_OPERACION_ONEROSA&quot;
_10 | &quot;10&quot;
GRAVADO_RETIRO_POR_PREMIO | &quot;GRAVADO_RETIRO_POR_PREMIO&quot;
_11 | &quot;11&quot;
GRAVADO_RETIRO_POR_DONACION | &quot;GRAVADO_RETIRO_POR_DONACION&quot;
_12 | &quot;12&quot;
GRAVADO_RETIRO | &quot;GRAVADO_RETIRO&quot;
_13 | &quot;13&quot;
GRAVADO_RETIRO_POR_PUBLICIDAD | &quot;GRAVADO_RETIRO_POR_PUBLICIDAD&quot;
_14 | &quot;14&quot;
GRAVADO_BONIFICACIONES | &quot;GRAVADO_BONIFICACIONES&quot;
_15 | &quot;15&quot;
GRAVADO_RETIRO_POR_ENTREGA_A_TRABAJADORES | &quot;GRAVADO_RETIRO_POR_ENTREGA_A_TRABAJADORES&quot;
_16 | &quot;16&quot;
GRAVADO_IVAP | &quot;GRAVADO_IVAP&quot;
_17 | &quot;17&quot;
EXONERADO_OPERACION_ONEROSA | &quot;EXONERADO_OPERACION_ONEROSA&quot;
_20 | &quot;20&quot;
EXONERADO_TRANSFERENCIA_GRATUITA | &quot;EXONERADO_TRANSFERENCIA_GRATUITA&quot;
_21 | &quot;21&quot;
INAFECTO_OPERACION_ONEROSA | &quot;INAFECTO_OPERACION_ONEROSA&quot;
_30 | &quot;30&quot;
INAFECTO_RETIRO_POR_BONIFICACION | &quot;INAFECTO_RETIRO_POR_BONIFICACION&quot;
_31 | &quot;31&quot;
INAFECTO_RETIRO | &quot;INAFECTO_RETIRO&quot;
_32 | &quot;32&quot;
INAFECTO_RETIRO_POR_MUESTRAS_MEDICAS | &quot;INAFECTO_RETIRO_POR_MUESTRAS_MEDICAS&quot;
_33 | &quot;33&quot;
INAFECTO_RETIRO_POR_CONVENIO_COLECTIVO | &quot;INAFECTO_RETIRO_POR_CONVENIO_COLECTIVO&quot;
_34 | &quot;34&quot;
INAFECTO_RETIRO_POR_PREMIO | &quot;INAFECTO_RETIRO_POR_PREMIO&quot;
_35 | &quot;35&quot;
INAFECTO_RETIRO_POR_PUBLICIDAD | &quot;INAFECTO_RETIRO_POR_PUBLICIDAD&quot;
_36 | &quot;36&quot;
EXPORTACION | &quot;EXPORTACION&quot;
_40 | &quot;40&quot;
