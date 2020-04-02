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


class DebitNote(object):
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
        'cliente': 'Object',
        'detalle': 'Object',
        'fecha_emision': 'int',
        'firmante': 'Object',
        'numero': 'int',
        'proveedor': 'Object',
        'serie': 'str',
        'descripcion_sustento_de_nota': 'str',
        'serie_numero_comprobante_afectado': 'str',
        'tipo_nota': 'str'
    }

    attribute_map = {
        'cliente': 'cliente',
        'detalle': 'detalle',
        'fecha_emision': 'fechaEmision',
        'firmante': 'firmante',
        'numero': 'numero',
        'proveedor': 'proveedor',
        'serie': 'serie',
        'descripcion_sustento_de_nota': 'descripcionSustentoDeNota',
        'serie_numero_comprobante_afectado': 'serieNumeroComprobanteAfectado',
        'tipo_nota': 'tipoNota'
    }

    def __init__(self, cliente=None, detalle=None, fecha_emision=None, firmante=None, numero=None, proveedor=None, serie=None, descripcion_sustento_de_nota=None, serie_numero_comprobante_afectado=None, tipo_nota=None):  # noqa: E501
        """DebitNote - a model defined in Swagger"""  # noqa: E501
        self._cliente = None
        self._detalle = None
        self._fecha_emision = None
        self._firmante = None
        self._numero = None
        self._proveedor = None
        self._serie = None
        self._descripcion_sustento_de_nota = None
        self._serie_numero_comprobante_afectado = None
        self._tipo_nota = None
        self.discriminator = None
        self.cliente = cliente
        self.detalle = detalle
        if fecha_emision is not None:
            self.fecha_emision = fecha_emision
        if firmante is not None:
            self.firmante = firmante
        self.numero = numero
        self.proveedor = proveedor
        self.serie = serie
        self.descripcion_sustento_de_nota = descripcion_sustento_de_nota
        self.serie_numero_comprobante_afectado = serie_numero_comprobante_afectado
        if tipo_nota is not None:
            self.tipo_nota = tipo_nota

    @property
    def cliente(self):
        """Gets the cliente of this DebitNote.  # noqa: E501


        :return: The cliente of this DebitNote.  # noqa: E501
        :rtype: Object
        """
        return self._cliente

    @cliente.setter
    def cliente(self, cliente):
        """Sets the cliente of this DebitNote.


        :param cliente: The cliente of this DebitNote.  # noqa: E501
        :type: Object
        """
        if cliente is None:
            raise ValueError("Invalid value for `cliente`, must not be `None`")  # noqa: E501

        self._cliente = cliente

    @property
    def detalle(self):
        """Gets the detalle of this DebitNote.  # noqa: E501


        :return: The detalle of this DebitNote.  # noqa: E501
        :rtype: Object
        """
        return self._detalle

    @detalle.setter
    def detalle(self, detalle):
        """Sets the detalle of this DebitNote.


        :param detalle: The detalle of this DebitNote.  # noqa: E501
        :type: Object
        """
        if detalle is None:
            raise ValueError("Invalid value for `detalle`, must not be `None`")  # noqa: E501

        self._detalle = detalle

    @property
    def fecha_emision(self):
        """Gets the fecha_emision of this DebitNote.  # noqa: E501

        Fecha expresada en milliseconds  # noqa: E501

        :return: The fecha_emision of this DebitNote.  # noqa: E501
        :rtype: int
        """
        return self._fecha_emision

    @fecha_emision.setter
    def fecha_emision(self, fecha_emision):
        """Sets the fecha_emision of this DebitNote.

        Fecha expresada en milliseconds  # noqa: E501

        :param fecha_emision: The fecha_emision of this DebitNote.  # noqa: E501
        :type: int
        """

        self._fecha_emision = fecha_emision

    @property
    def firmante(self):
        """Gets the firmante of this DebitNote.  # noqa: E501


        :return: The firmante of this DebitNote.  # noqa: E501
        :rtype: Object
        """
        return self._firmante

    @firmante.setter
    def firmante(self, firmante):
        """Sets the firmante of this DebitNote.


        :param firmante: The firmante of this DebitNote.  # noqa: E501
        :type: Object
        """

        self._firmante = firmante

    @property
    def numero(self):
        """Gets the numero of this DebitNote.  # noqa: E501


        :return: The numero of this DebitNote.  # noqa: E501
        :rtype: int
        """
        return self._numero

    @numero.setter
    def numero(self, numero):
        """Sets the numero of this DebitNote.


        :param numero: The numero of this DebitNote.  # noqa: E501
        :type: int
        """
        if numero is None:
            raise ValueError("Invalid value for `numero`, must not be `None`")  # noqa: E501

        self._numero = numero

    @property
    def proveedor(self):
        """Gets the proveedor of this DebitNote.  # noqa: E501


        :return: The proveedor of this DebitNote.  # noqa: E501
        :rtype: Object
        """
        return self._proveedor

    @proveedor.setter
    def proveedor(self, proveedor):
        """Sets the proveedor of this DebitNote.


        :param proveedor: The proveedor of this DebitNote.  # noqa: E501
        :type: Object
        """
        if proveedor is None:
            raise ValueError("Invalid value for `proveedor`, must not be `None`")  # noqa: E501

        self._proveedor = proveedor

    @property
    def serie(self):
        """Gets the serie of this DebitNote.  # noqa: E501


        :return: The serie of this DebitNote.  # noqa: E501
        :rtype: str
        """
        return self._serie

    @serie.setter
    def serie(self, serie):
        """Sets the serie of this DebitNote.


        :param serie: The serie of this DebitNote.  # noqa: E501
        :type: str
        """
        if serie is None:
            raise ValueError("Invalid value for `serie`, must not be `None`")  # noqa: E501

        self._serie = serie

    @property
    def descripcion_sustento_de_nota(self):
        """Gets the descripcion_sustento_de_nota of this DebitNote.  # noqa: E501

        Razón por la que se crea la nota  # noqa: E501

        :return: The descripcion_sustento_de_nota of this DebitNote.  # noqa: E501
        :rtype: str
        """
        return self._descripcion_sustento_de_nota

    @descripcion_sustento_de_nota.setter
    def descripcion_sustento_de_nota(self, descripcion_sustento_de_nota):
        """Sets the descripcion_sustento_de_nota of this DebitNote.

        Razón por la que se crea la nota  # noqa: E501

        :param descripcion_sustento_de_nota: The descripcion_sustento_de_nota of this DebitNote.  # noqa: E501
        :type: str
        """
        if descripcion_sustento_de_nota is None:
            raise ValueError("Invalid value for `descripcion_sustento_de_nota`, must not be `None`")  # noqa: E501

        self._descripcion_sustento_de_nota = descripcion_sustento_de_nota

    @property
    def serie_numero_comprobante_afectado(self):
        """Gets the serie_numero_comprobante_afectado of this DebitNote.  # noqa: E501

        Serie y número del comprobante afectado por la nota  # noqa: E501

        :return: The serie_numero_comprobante_afectado of this DebitNote.  # noqa: E501
        :rtype: str
        """
        return self._serie_numero_comprobante_afectado

    @serie_numero_comprobante_afectado.setter
    def serie_numero_comprobante_afectado(self, serie_numero_comprobante_afectado):
        """Sets the serie_numero_comprobante_afectado of this DebitNote.

        Serie y número del comprobante afectado por la nota  # noqa: E501

        :param serie_numero_comprobante_afectado: The serie_numero_comprobante_afectado of this DebitNote.  # noqa: E501
        :type: str
        """
        if serie_numero_comprobante_afectado is None:
            raise ValueError("Invalid value for `serie_numero_comprobante_afectado`, must not be `None`")  # noqa: E501

        self._serie_numero_comprobante_afectado = serie_numero_comprobante_afectado

    @property
    def tipo_nota(self):
        """Gets the tipo_nota of this DebitNote.  # noqa: E501

        Catalogo 10  # noqa: E501

        :return: The tipo_nota of this DebitNote.  # noqa: E501
        :rtype: str
        """
        return self._tipo_nota

    @tipo_nota.setter
    def tipo_nota(self, tipo_nota):
        """Sets the tipo_nota of this DebitNote.

        Catalogo 10  # noqa: E501

        :param tipo_nota: The tipo_nota of this DebitNote.  # noqa: E501
        :type: str
        """
        allowed_values = ["INTERES_POR_MORA", "01", "AUMENTO_EN_EL_VALOR", "02", "PENALIDAD_OTROS_CONCEPTOS", "03"]  # noqa: E501
        if tipo_nota not in allowed_values:
            raise ValueError(
                "Invalid value for `tipo_nota` ({0}), must be one of {1}"  # noqa: E501
                .format(tipo_nota, allowed_values)
            )

        self._tipo_nota = tipo_nota

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
        if issubclass(DebitNote, dict):
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
        if not isinstance(other, DebitNote):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
