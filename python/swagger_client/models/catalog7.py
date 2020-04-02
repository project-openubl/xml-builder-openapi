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


class Catalog7(object):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    """

    """
    allowed enum values
    """
    EXONERADO_OPERACION_ONEROSA = "EXONERADO_OPERACION_ONEROSA"
    EXONERADO_TRANSFERENCIA_GRATUITA = "EXONERADO_TRANSFERENCIA_GRATUITA"
    EXPORTACION = "EXPORTACION"
    GRAVADO_BONIFICACIONES = "GRAVADO_BONIFICACIONES"
    GRAVADO_IVAP = "GRAVADO_IVAP"
    GRAVADO_OPERACION_ONEROSA = "GRAVADO_OPERACION_ONEROSA"
    GRAVADO_RETIRO = "GRAVADO_RETIRO"
    GRAVADO_RETIRO_POR_DONACION = "GRAVADO_RETIRO_POR_DONACION"
    GRAVADO_RETIRO_POR_ENTREGA_A_TRABAJADORES = "GRAVADO_RETIRO_POR_ENTREGA_A_TRABAJADORES"
    GRAVADO_RETIRO_POR_PREMIO = "GRAVADO_RETIRO_POR_PREMIO"
    GRAVADO_RETIRO_POR_PUBLICIDAD = "GRAVADO_RETIRO_POR_PUBLICIDAD"
    INAFECTO_OPERACION_ONEROSA = "INAFECTO_OPERACION_ONEROSA"
    INAFECTO_RETIRO = "INAFECTO_RETIRO"
    INAFECTO_RETIRO_POR_BONIFICACION = "INAFECTO_RETIRO_POR_BONIFICACION"
    INAFECTO_RETIRO_POR_CONVENIO_COLECTIVO = "INAFECTO_RETIRO_POR_CONVENIO_COLECTIVO"
    INAFECTO_RETIRO_POR_MUESTRAS_MEDICAS = "INAFECTO_RETIRO_POR_MUESTRAS_MEDICAS"
    INAFECTO_RETIRO_POR_PREMIO = "INAFECTO_RETIRO_POR_PREMIO"
    INAFECTO_RETIRO_POR_PUBLICIDAD = "INAFECTO_RETIRO_POR_PUBLICIDAD"
    """
    Attributes:
      swagger_types (dict): The key is attribute name
                            and the value is attribute type.
      attribute_map (dict): The key is attribute name
                            and the value is json key in definition.
    """
    swagger_types = {
    }

    attribute_map = {
    }

    def __init__(self):  # noqa: E501
        """Catalog7 - a model defined in Swagger"""  # noqa: E501
        self.discriminator = None

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
        if issubclass(Catalog7, dict):
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
        if not isinstance(other, Catalog7):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
