# swagger_client.CreateApi

All URIs are relative to *http://xml-builder-project-openubl.apps.us-west-1.starter.openshift-online.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**api_documents_credit_note_create_post**](CreateApi.md#api_documents_credit_note_create_post) | **POST** /api/documents/credit-note/create | Create a XML file from the input
[**api_documents_debit_note_create_post**](CreateApi.md#api_documents_debit_note_create_post) | **POST** /api/documents/debit-note/create | Create a XML file from the input
[**api_documents_invoice_create_post**](CreateApi.md#api_documents_invoice_create_post) | **POST** /api/documents/invoice/create | Create a XML file from the input
[**api_documents_summary_document_create_post**](CreateApi.md#api_documents_summary_document_create_post) | **POST** /api/documents/summary-document/create | Create a XML file from the input
[**api_documents_voided_document_create_post**](CreateApi.md#api_documents_voided_document_create_post) | **POST** /api/documents/voided-document/create | Create a XML file from the input

# **api_documents_credit_note_create_post**
> str api_documents_credit_note_create_post(body=body)

Create a XML file from the input

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CreateApi()
body = swagger_client.CreditNote() # CreditNote |  (optional)

try:
    # Create a XML file from the input
    api_response = api_instance.api_documents_credit_note_create_post(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CreateApi->api_documents_credit_note_create_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreditNote**](CreditNote.md)|  | [optional] 

### Return type

**str**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **api_documents_debit_note_create_post**
> str api_documents_debit_note_create_post(body=body)

Create a XML file from the input

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CreateApi()
body = swagger_client.DebitNote() # DebitNote |  (optional)

try:
    # Create a XML file from the input
    api_response = api_instance.api_documents_debit_note_create_post(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CreateApi->api_documents_debit_note_create_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DebitNote**](DebitNote.md)|  | [optional] 

### Return type

**str**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **api_documents_invoice_create_post**
> str api_documents_invoice_create_post(body=body)

Create a XML file from the input

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CreateApi()
body = swagger_client.Invoice() # Invoice |  (optional)

try:
    # Create a XML file from the input
    api_response = api_instance.api_documents_invoice_create_post(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CreateApi->api_documents_invoice_create_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Invoice**](Invoice.md)|  | [optional] 

### Return type

**str**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **api_documents_summary_document_create_post**
> str api_documents_summary_document_create_post(body=body)

Create a XML file from the input

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CreateApi()
body = swagger_client.SummaryDocument() # SummaryDocument |  (optional)

try:
    # Create a XML file from the input
    api_response = api_instance.api_documents_summary_document_create_post(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CreateApi->api_documents_summary_document_create_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SummaryDocument**](SummaryDocument.md)|  | [optional] 

### Return type

**str**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **api_documents_voided_document_create_post**
> str api_documents_voided_document_create_post(body=body)

Create a XML file from the input

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CreateApi()
body = swagger_client.VoidedDocument() # VoidedDocument |  (optional)

try:
    # Create a XML file from the input
    api_response = api_instance.api_documents_voided_document_create_post(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CreateApi->api_documents_voided_document_create_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**VoidedDocument**](VoidedDocument.md)|  | [optional] 

### Return type

**str**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

