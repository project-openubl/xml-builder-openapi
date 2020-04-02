<?php
/**
 * SummaryDocument
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
 * SummaryDocument Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class SummaryDocument implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'SummaryDocument';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'detalle' => '',
'fecha_emision' => 'int',
'fecha_emision_de_comprobantes_asociados' => 'int',
'firmante' => '\Swagger\Client\Model\Firmante',
'numero' => 'int',
'proveedor' => ''    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'detalle' => null,
'fecha_emision' => 'int64',
'fecha_emision_de_comprobantes_asociados' => 'int64',
'firmante' => null,
'numero' => 'int32',
'proveedor' => null    ];

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
        'detalle' => 'detalle',
'fecha_emision' => 'fechaEmision',
'fecha_emision_de_comprobantes_asociados' => 'fechaEmisionDeComprobantesAsociados',
'firmante' => 'firmante',
'numero' => 'numero',
'proveedor' => 'proveedor'    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'detalle' => 'setDetalle',
'fecha_emision' => 'setFechaEmision',
'fecha_emision_de_comprobantes_asociados' => 'setFechaEmisionDeComprobantesAsociados',
'firmante' => 'setFirmante',
'numero' => 'setNumero',
'proveedor' => 'setProveedor'    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'detalle' => 'getDetalle',
'fecha_emision' => 'getFechaEmision',
'fecha_emision_de_comprobantes_asociados' => 'getFechaEmisionDeComprobantesAsociados',
'firmante' => 'getFirmante',
'numero' => 'getNumero',
'proveedor' => 'getProveedor'    ];

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
        $this->container['detalle'] = isset($data['detalle']) ? $data['detalle'] : null;
        $this->container['fecha_emision'] = isset($data['fecha_emision']) ? $data['fecha_emision'] : null;
        $this->container['fecha_emision_de_comprobantes_asociados'] = isset($data['fecha_emision_de_comprobantes_asociados']) ? $data['fecha_emision_de_comprobantes_asociados'] : null;
        $this->container['firmante'] = isset($data['firmante']) ? $data['firmante'] : null;
        $this->container['numero'] = isset($data['numero']) ? $data['numero'] : null;
        $this->container['proveedor'] = isset($data['proveedor']) ? $data['proveedor'] : null;
    }

    /**
     * Show all the invalid properties with reasons.
     *
     * @return array invalid properties with reasons
     */
    public function listInvalidProperties()
    {
        $invalidProperties = [];

        if ($this->container['detalle'] === null) {
            $invalidProperties[] = "'detalle' can't be null";
        }
        if ($this->container['fecha_emision_de_comprobantes_asociados'] === null) {
            $invalidProperties[] = "'fecha_emision_de_comprobantes_asociados' can't be null";
        }
        if ($this->container['numero'] === null) {
            $invalidProperties[] = "'numero' can't be null";
        }
        if ($this->container['proveedor'] === null) {
            $invalidProperties[] = "'proveedor' can't be null";
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
     * @return int
     */
    public function getFechaEmision()
    {
        return $this->container['fecha_emision'];
    }

    /**
     * Sets fecha_emision
     *
     * @param int $fecha_emision Fecha en la que se emite el comprobante de Resumen Diario. Fecha expresada en milliseconds
     *
     * @return $this
     */
    public function setFechaEmision($fecha_emision)
    {
        $this->container['fecha_emision'] = $fecha_emision;

        return $this;
    }

    /**
     * Gets fecha_emision_de_comprobantes_asociados
     *
     * @return int
     */
    public function getFechaEmisionDeComprobantesAsociados()
    {
        return $this->container['fecha_emision_de_comprobantes_asociados'];
    }

    /**
     * Sets fecha_emision_de_comprobantes_asociados
     *
     * @param int $fecha_emision_de_comprobantes_asociados Fecha en la que todos los comprobantes, dentro del resumen, fueron emitidos. Fecha expresada en milliseconds
     *
     * @return $this
     */
    public function setFechaEmisionDeComprobantesAsociados($fecha_emision_de_comprobantes_asociados)
    {
        $this->container['fecha_emision_de_comprobantes_asociados'] = $fecha_emision_de_comprobantes_asociados;

        return $this;
    }

    /**
     * Gets firmante
     *
     * @return \Swagger\Client\Model\Firmante
     */
    public function getFirmante()
    {
        return $this->container['firmante'];
    }

    /**
     * Sets firmante
     *
     * @param \Swagger\Client\Model\Firmante $firmante firmante
     *
     * @return $this
     */
    public function setFirmante($firmante)
    {
        $this->container['firmante'] = $firmante;

        return $this;
    }

    /**
     * Gets numero
     *
     * @return int
     */
    public function getNumero()
    {
        return $this->container['numero'];
    }

    /**
     * Sets numero
     *
     * @param int $numero Número de Resumen Diario emitido en el día
     *
     * @return $this
     */
    public function setNumero($numero)
    {
        $this->container['numero'] = $numero;

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
