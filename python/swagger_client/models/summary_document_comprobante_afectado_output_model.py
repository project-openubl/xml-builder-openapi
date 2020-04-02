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


class SummaryDocumentComprobanteAfectadoOutputModel(object):
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
        'serie_numero': 'str',
        'tipo': 'Object'
    }

    attribute_map = {
        'serie_numero': 'serieNumero',
        'tipo': 'tipo'
    }

    def __init__(self, serie_numero=None, tipo=None):  # noqa: E501
        """SummaryDocumentComprobanteAfectadoOutputModel - a model defined in Swagger"""  # noqa: E501
        self._serie_numero = None
        self._tipo = None
        self.discriminator = None
        if serie_numero is not None:
            self.serie_numero = serie_numero
        self.tipo = tipo

    @property
    def serie_numero(self):
        """Gets the serie_numero of this SummaryDocumentComprobanteAfectadoOutputModel.  # noqa: E501


        :return: The serie_numero of this SummaryDocumentComprobanteAfectadoOutputModel.  # noqa: E501
        :rtype: str
        """
        return self._serie_numero

    @serie_numero.setter
    def serie_numero(self, serie_numero):
        """Sets the serie_numero of this SummaryDocumentComprobanteAfectadoOutputModel.


        :param serie_numero: The serie_numero of this SummaryDocumentComprobanteAfectadoOutputModel.  # noqa: E501
        :type: str
        """

        self._serie_numero = serie_numero

    @property
    def tipo(self):
        """Gets the tipo of this SummaryDocumentComprobanteAfectadoOutputModel.  # noqa: E501


        :return: The tipo of this SummaryDocumentComprobanteAfectadoOutputModel.  # noqa: E501
        :rtype: Object
        """
        return self._tipo

    @tipo.setter
    def tipo(self, tipo):
        """Sets the tipo of this SummaryDocumentComprobanteAfectadoOutputModel.


        :param tipo: The tipo of this SummaryDocumentComprobanteAfectadoOutputModel.  # noqa: E501
        :type: Object
        """
        if tipo is None:
            raise ValueError("Invalid value for `tipo`, must not be `None`")  # noqa: E501

        self._tipo = tipo

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
        if issubclass(SummaryDocumentComprobanteAfectadoOutputModel, dict):
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
        if not isinstance(other, SummaryDocumentComprobanteAfectadoOutputModel):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
