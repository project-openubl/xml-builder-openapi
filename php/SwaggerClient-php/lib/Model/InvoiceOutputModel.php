<?php
/**
 * InvoiceOutputModel
 *
 * PHP version 5
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */

/**
 * XML Builder API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0.0.Final
 * Contact: projectopenubl+subscribe@googlegroups.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 * Swagger Codegen version: 3.0.18
 */
/**
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen
 * Do not edit the class manually.
 */

namespace Swagger\Client\Model;

use \ArrayAccess;
use \Swagger\Client\ObjectSerializer;

/**
 * InvoiceOutputModel Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class InvoiceOutputModel implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'InvoiceOutputModel';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'cliente' => '',
'detalle' => '',
'fecha_emision' => 'string',
'firmante' => '',
'hora_emision' => 'string',
'impuestos' => '',
'moneda' => 'string',
'proveedor' => '',
'serie_numero' => 'string',
'totales' => '',
'tipo_invoice' => ''    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'cliente' => null,
'detalle' => null,
'fecha_emision' => null,
'firmante' => null,
'hora_emision' => null,
'impuestos' => null,
'moneda' => null,
'proveedor' => null,
'serie_numero' => null,
'totales' => null,
'tipo_invoice' => null    ];

    /**
     * Array of property to type mappings. Used for (de)serialization
     *
     * @return array
     */
    public static function swaggerTypes()
    {
        return self::$swaggerTypes;
    }

    /**
     * Array of property to format mappings. Used for (de)serialization
     *
     * @return array
     */
    public static function swaggerFormats()
    {
        return self::$swaggerFormats;
    }

    /**
     * Array of attributes where the key is the local name,
     * and the value is the original name
     *
     * @var string[]
     */
    protected static $attributeMap = [
        'cliente' => 'cliente',
'detalle' => 'detalle',
'fecha_emision' => 'fechaEmision',
'firmante' => 'firmante',
'hora_emision' => 'horaEmision',
'impuestos' => 'impuestos',
'moneda' => 'moneda',
'proveedor' => 'proveedor',
'serie_numero' => 'serieNumero',
'totales' => 'totales',
'tipo_invoice' => 'tipoInvoice'    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'cliente' => 'setCliente',
'detalle' => 'setDetalle',
'fecha_emision' => 'setFechaEmision',
'firmante' => 'setFirmante',
'hora_emision' => 'setHoraEmision',
'impuestos' => 'setImpuestos',
'moneda' => 'setMoneda',
'proveedor' => 'setProveedor',
'serie_numero' => 'setSerieNumero',
'totales' => 'setTotales',
'tipo_invoice' => 'setTipoInvoice'    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'cliente' => 'getCliente',
'detalle' => 'getDetalle',
'fecha_emision' => 'getFechaEmision',
'firmante' => 'getFirmante',
'hora_emision' => 'getHoraEmision',
'impuestos' => 'getImpuestos',
'moneda' => 'getMoneda',
'proveedor' => 'getProveedor',
'serie_numero' => 'getSerieNumero',
'totales' => 'getTotales',
'tipo_invoice' => 'getTipoInvoice'    ];

    /**
     * Array of attributes where the key is the local name,
     * and the value is the original name
     *
     * @return array
     */
    public static function attributeMap()
    {
        return self::$attributeMap;
    }

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @return array
     */
    public static function setters()
    {
        return self::$setters;
    }

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @return array
     */
    public static function getters()
    {
        return self::$getters;
    }

    /**
     * The original name of the model.
     *
     * @return string
     */
    public function getModelName()
    {
        return self::$swaggerModelName;
    }

    

    /**
     * Associative array for storing property values
     *
     * @var mixed[]
     */
    protected $container = [];

    /**
     * Constructor
     *
     * @param mixed[] $data Associated array of property values
     *                      initializing the model
     */
    public function __construct(array $data = null)
    {
        $this->container['cliente'] = isset($data['cliente']) ? $data['cliente'] : null;
        $this->container['detalle'] = isset($data['detalle']) ? $data['detalle'] : null;
        $this->container['fecha_emision'] = isset($data['fecha_emision']) ? $data['fecha_emision'] : null;
        $this->container['firmante'] = isset($data['firmante']) ? $data['firmante'] : null;
        $this->container['hora_emision'] = isset($data['hora_emision']) ? $data['hora_emision'] : null;
        $this->container['impuestos'] = isset($data['impuestos']) ? $data['impuestos'] : null;
        $this->container['moneda'] = isset($data['moneda']) ? $data['moneda'] : null;
        $this->container['proveedor'] = isset($data['proveedor']) ? $data['proveedor'] : null;
        $this->container['serie_numero'] = isset($data['serie_numero']) ? $data['serie_numero'] : null;
        $this->container['totales'] = isset($data['totales']) ? $data['totales'] : null;
        $this->container['tipo_invoice'] = isset($data['tipo_invoice']) ? $data['tipo_invoice'] : null;
    }

    /**
     * Show all the invalid properties with reasons.
     *
     * @return array invalid properties with reasons
     */
    public function listInvalidProperties()
    {
        $invalidProperties = [];

        if ($this->container['cliente'] === null) {
            $invalidProperties[] = "'cliente' can't be null";
        }
        if ($this->container['firmante'] === null) {
            $invalidProperties[] = "'firmante' can't be null";
        }
        if ($this->container['impuestos'] === null) {
            $invalidProperties[] = "'impuestos' can't be null";
        }
        if ($this->container['proveedor'] === null) {
            $invalidProperties[] = "'proveedor' can't be null";
        }
        if ($this->container['totales'] === null) {
            $invalidProperties[] = "'totales' can't be null";
        }
        if ($this->container['tipo_invoice'] === null) {
            $invalidProperties[] = "'tipo_invoice' can't be null";
        }
        return $invalidProperties;
    }

    /**
     * Validate all the properties in the model
     * return true if all passed
     *
     * @return bool True if all properties are valid
     */
    public function valid()
    {
        return count($this->listInvalidProperties()) === 0;
    }


    /**
     * Gets cliente
     *
     * @return 
     */
    public function getCliente()
    {
        return $this->container['cliente'];
    }

    /**
     * Sets cliente
     *
     * @param  $cliente cliente
     *
     * @return $this
     */
    public function setCliente($cliente)
    {
        $this->container['cliente'] = $cliente;

        return $this;
    }

    /**
     * Gets detalle
     *
     * @return 
     */
    public function getDetalle()
    {
        return $this->container['detalle'];
    }

    /**
     * Sets detalle
     *
     * @param  $detalle detalle
     *
     * @return $this
     */
    public function setDetalle($detalle)
    {
        $this->container['detalle'] = $detalle;

        return $this;
    }

    /**
     * Gets fecha_emision
     *
     * @return string
     */
    public function getFechaEmision()
    {
        return $this->container['fecha_emision'];
    }

    /**
     * Sets fecha_emision
     *
     * @param string $fecha_emision fecha_emision
     *
     * @return $this
     */
    public function setFechaEmision($fecha_emision)
    {
        $this->container['fecha_emision'] = $fecha_emision;

        return $this;
    }

    /**
     * Gets firmante
     *
     * @return 
     */
    public function getFirmante()
    {
        return $this->container['firmante'];
    }

    /**
     * Sets firmante
     *
     * @param  $firmante firmante
     *
     * @return $this
     */
    public function setFirmante($firmante)
    {
        $this->container['firmante'] = $firmante;

        return $this;
    }

    /**
     * Gets hora_emision
     *
     * @return string
     */
    public function getHoraEmision()
    {
        return $this->container['hora_emision'];
    }

    /**
     * Sets hora_emision
     *
     * @param string $hora_emision hora_emision
     *
     * @return $this
     */
    public function setHoraEmision($hora_emision)
    {
        $this->container['hora_emision'] = $hora_emision;

        return $this;
    }

    /**
     * Gets impuestos
     *
     * @return 
     */
    public function getImpuestos()
    {
        return $this->container['impuestos'];
    }

    /**
     * Sets impuestos
     *
     * @param  $impuestos impuestos
     *
     * @return $this
     */
    public function setImpuestos($impuestos)
    {
        $this->container['impuestos'] = $impuestos;

        return $this;
    }

    /**
     * Gets moneda
     *
     * @return string
     */
    public function getMoneda()
    {
        return $this->container['moneda'];
    }

    /**
     * Sets moneda
     *
     * @param string $moneda moneda
     *
     * @return $this
     */
    public function setMoneda($moneda)
    {
        $this->container['moneda'] = $moneda;

        return $this;
    }

    /**
     * Gets proveedor
     *
     * @return 
     */
    public function getProveedor()
    {
        return $this->container['proveedor'];
    }

    /**
     * Sets proveedor
     *
     * @param  $proveedor proveedor
     *
     * @return $this
     */
    public function setProveedor($proveedor)
    {
        $this->container['proveedor'] = $proveedor;

        return $this;
    }

    /**
     * Gets serie_numero
     *
     * @return string
     */
    public function getSerieNumero()
    {
        return $this->container['serie_numero'];
    }

    /**
     * Sets serie_numero
     *
     * @param string $serie_numero serie_numero
     *
     * @return $this
     */
    public function setSerieNumero($serie_numero)
    {
        $this->container['serie_numero'] = $serie_numero;

        return $this;
    }

    /**
     * Gets totales
     *
     * @return 
     */
    public function getTotales()
    {
        return $this->container['totales'];
    }

    /**
     * Sets totales
     *
     * @param  $totales totales
     *
     * @return $this
     */
    public function setTotales($totales)
    {
        $this->container['totales'] = $totales;

        return $this;
    }

    /**
     * Gets tipo_invoice
     *
     * @return 
     */
    public function getTipoInvoice()
    {
        return $this->container['tipo_invoice'];
    }

    /**
     * Sets tipo_invoice
     *
     * @param  $tipo_invoice tipo_invoice
     *
     * @return $this
     */
    public function setTipoInvoice($tipo_invoice)
    {
        $this->container['tipo_invoice'] = $tipo_invoice;

        return $this;
    }
    /**
     * Returns true if offset exists. False otherwise.
     *
     * @param integer $offset Offset
     *
     * @return boolean
     */
    public function offsetExists($offset)
    {
        return isset($this->container[$offset]);
    }

    /**
     * Gets offset.
     *
     * @param integer $offset Offset
     *
     * @return mixed
     */
    public function offsetGet($offset)
    {
        return isset($this->container[$offset]) ? $this->container[$offset] : null;
    }

    /**
     * Sets value based on offset.
     *
     * @param integer $offset Offset
     * @param mixed   $value  Value to be set
     *
     * @return void
     */
    public function offsetSet($offset, $value)
    {
        if (is_null($offset)) {
            $this->container[] = $value;
        } else {
            $this->container[$offset] = $value;
        }
    }

    /**
     * Unsets offset.
     *
     * @param integer $offset Offset
     *
     * @return void
     */
    public function offsetUnset($offset)
    {
        unset($this->container[$offset]);
    }

    /**
     * Gets the string presentation of the object
     *
     * @return string
     */
    public function __toString()
    {
        if (defined('JSON_PRETTY_PRINT')) { // use JSON pretty print
            return json_encode(
                ObjectSerializer::sanitizeForSerialization($this),
                JSON_PRETTY_PRINT
            );
        }

        return json_encode(ObjectSerializer::sanitizeForSerialization($this));
    }
}
