# coding: utf-8

"""
    XML Builder API

    No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)  # noqa: E501

    OpenAPI spec version: 1.0.0.Final
    Contact: projectopenubl+subscribe@googlegroups.com
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""

import pprint
import re  # noqa: F401

import six


class DocumentLineOutputModel(object):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    """
    """
    Attributes:
      swagger_types (dict): The key is attribute name
                            and the value is attribute type.
      attribute_map (dict): The key is attribute name
                            and the value is json key in definition.
    """
    swagger_types = {
        'cantidad': 'Object',
        'descripcion': 'str',
        'impuestos': 'Object',
        'precio_con_igv': 'Object',
        'precio_de_referencia': 'Object',
        'precio_unitario': 'Object',
        'unidad_medida': 'str',
        'valor_venta_sin_impuestos': 'Object'
    }

    attribute_map = {
        'cantidad': 'cantidad',
        'descripcion': 'descripcion',
        'impuestos': 'impuestos',
        'precio_con_igv': 'precioConIgv',
        'precio_de_referencia': 'precioDeReferencia',
        'precio_unitario': 'precioUnitario',
        'unidad_medida': 'unidadMedida',
        'valor_venta_sin_impuestos': 'valorVentaSinImpuestos'
    }

    def __init__(self, cantidad=None, descripcion=None, impuestos=None, precio_con_igv=None, precio_de_referencia=None, precio_unitario=None, unidad_medida=None, valor_venta_sin_impuestos=None):  # noqa: E501
        """DocumentLineOutputModel - a model defined in Swagger"""  # noqa: E501
        self._cantidad = None
        self._descripcion = None
        self._impuestos = None
        self._precio_con_igv = None
        self._precio_de_referencia = None
        self._precio_unitario = None
        self._unidad_medida = None
        self._valor_venta_sin_impuestos = None
        self.discriminator = None
        self.cantidad = cantidad
        if descripcion is not None:
            self.descripcion = descripcion
        self.impuestos = impuestos
        self.precio_con_igv = precio_con_igv
        self.precio_de_referencia = precio_de_referencia
        self.precio_unitario = precio_unitario
        if unidad_medida is not None:
            self.unidad_medida = unidad_medida
        self.valor_venta_sin_impuestos = valor_venta_sin_impuestos

    @property
    def cantidad(self):
        """Gets the cantidad of this DocumentLineOutputModel.  # noqa: E501


        :return: The cantidad of this DocumentLineOutputModel.  # noqa: E501
        :rtype: Object
        """
        return self._cantidad

    @cantidad.setter
    def cantidad(self, cantidad):
        """Sets the cantidad of this DocumentLineOutputModel.


        :param cantidad: The cantidad of this DocumentLineOutputModel.  # noqa: E501
        :type: Object
        """
        if cantidad is None:
            raise ValueError("Invalid value for `cantidad`, must not be `None`")  # noqa: E501

        self._cantidad = cantidad

    @property
    def descripcion(self):
        """Gets the descripcion of this DocumentLineOutputModel.  # noqa: E501


        :return: The descripcion of this DocumentLineOutputModel.  # noqa: E501
        :rtype: str
        """
        return self._descripcion

    @descripcion.setter
    def descripcion(self, descripcion):
        """Sets the descripcion of this DocumentLineOutputModel.


        :param descripcion: The descripcion of this DocumentLineOutputModel.  # noqa: E501
        :type: str
        """

        self._descripcion = descripcion

    @property
    def impuestos(self):
        """Gets the impuestos of this DocumentLineOutputModel.  # noqa: E501


        :return: The impuestos of this DocumentLineOutputModel.  # noqa: E501
        :rtype: Object
        """
        return self._impuestos

    @impuestos.setter
    def impuestos(self, impuestos):
        """Sets the impuestos of this DocumentLineOutputModel.


        :param impuestos: The impuestos of this DocumentLineOutputModel.  # noqa: E501
        :type: Object
        """
        if impuestos is None:
            raise ValueError("Invalid value for `impuestos`, must not be `None`")  # noqa: E501

        self._impuestos = impuestos

    @property
    def precio_con_igv(self):
        """Gets the precio_con_igv of this DocumentLineOutputModel.  # noqa: E501


        :return: The precio_con_igv of this DocumentLineOutputModel.  # noqa: E501
        :rtype: Object
        """
        return self._precio_con_igv

    @precio_con_igv.setter
    def precio_con_igv(self, precio_con_igv):
        """Sets the precio_con_igv of this DocumentLineOutputModel.


        :param precio_con_igv: The precio_con_igv of this DocumentLineOutputModel.  # noqa: E501
        :type: Object
        """
        if precio_con_igv is None:
            raise ValueError("Invalid value for `precio_con_igv`, must not be `None`")  # noqa: E501

        self._precio_con_igv = precio_con_igv

    @property
    def precio_de_referencia(self):
        """Gets the precio_de_referencia of this DocumentLineOutputModel.  # noqa: E501


        :return: The precio_de_referencia of this DocumentLineOutputModel.  # noqa: E501
        :rtype: Object
        """
        return self._precio_de_referencia

    @precio_de_referencia.setter
    def precio_de_referencia(self, precio_de_referencia):
        """Sets the precio_de_referencia of this DocumentLineOutputModel.


        :param precio_de_referencia: The precio_de_referencia of this DocumentLineOutputModel.  # noqa: E501
        :type: Object
        """
        if precio_de_referencia is None:
            raise ValueError("Invalid value for `precio_de_referencia`, must not be `None`")  # noqa: E501

        self._precio_de_referencia = precio_de_referencia

    @property
    def precio_unitario(self):
        """Gets the precio_unitario of this DocumentLineOutputModel.  # noqa: E501


        :return: The precio_unitario of this DocumentLineOutputModel.  # noqa: E501
        :rtype: Object
        """
        return self._precio_unitario

    @precio_unitario.setter
    def precio_unitario(self, precio_unitario):
        """Sets the precio_unitario of this DocumentLineOutputModel.


        :param precio_unitario: The precio_unitario of this DocumentLineOutputModel.  # noqa: E501
        :type: Object
        """
        if precio_unitario is None:
            raise ValueError("Invalid value for `precio_unitario`, must not be `None`")  # noqa: E501

        self._precio_unitario = precio_unitario

    @property
    def unidad_medida(self):
        """Gets the unidad_medida of this DocumentLineOutputModel.  # noqa: E501


        :return: The unidad_medida of this DocumentLineOutputModel.  # noqa: E501
        :rtype: str
        """
        return self._unidad_medida

    @unidad_medida.setter
    def unidad_medida(self, unidad_medida):
        """Sets the unidad_medida of this DocumentLineOutputModel.


        :param unidad_medida: The unidad_medida of this DocumentLineOutputModel.  # noqa: E501
        :type: str
        """

        self._unidad_medida = unidad_medida

    @property
    def valor_venta_sin_impuestos(self):
        """Gets the valor_venta_sin_impuestos of this DocumentLineOutputModel.  # noqa: E501


        :return: The valor_venta_sin_impuestos of this DocumentLineOutputModel.  # noqa: E501
        :rtype: Object
        """
        return self._valor_venta_sin_impuestos

    @valor_venta_sin_impuestos.setter
    def valor_venta_sin_impuestos(self, valor_venta_sin_impuestos):
        """Sets the valor_venta_sin_impuestos of this DocumentLineOutputModel.


        :param valor_venta_sin_impuestos: The valor_venta_sin_impuestos of this DocumentLineOutputModel.  # noqa: E501
        :type: Object
        """
        if valor_venta_sin_impuestos is None:
            raise ValueError("Invalid value for `valor_venta_sin_impuestos`, must not be `None`")  # noqa: E501

        self._valor_venta_sin_impuestos = valor_venta_sin_impuestos

    def to_dict(self):
        """Returns the model properties as a dict"""
        result = {}

        for attr, _ in six.iteritems(self.swagger_types):
            value = getattr(self, attr)
            if isinstance(value, list):
                result[attr] = list(map(
                    lambda x: x.to_dict() if hasattr(x, "to_dict") else x,
                    value
                ))
            elif hasattr(value, "to_dict"):
                result[attr] = value.to_dict()
            elif isinstance(value, dict):
                result[attr] = dict(map(
                    lambda item: (item[0], item[1].to_dict())
                    if hasattr(item[1], "to_dict") else item,
                    value.items()
                ))
            else:
                result[attr] = value
        if issubclass(DocumentLineOutputModel, dict):
            for key, value in self.items():
                result[key] = value

        return result

    def to_str(self):
        """Returns the string representation of the model"""
        return pprint.pformat(self.to_dict())

    def __repr__(self):
        """For `print` and `pprint`"""
        return self.to_str()

    def __eq__(self, other):
        """Returns true if both objects are equal"""
        if not isinstance(other, DocumentLineOutputModel):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
