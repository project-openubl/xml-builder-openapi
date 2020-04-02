# swagger_client.EnrichApi

All URIs are relative to *http://xml-builder-project-openubl.apps.us-west-1.starter.openshift-online.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**api_documents_credit_note_enrich_post**](EnrichApi.md#api_documents_credit_note_enrich_post) | **POST** /api/documents/credit-note/enrich | Enriches the input
[**api_documents_debit_note_enrich_post**](EnrichApi.md#api_documents_debit_note_enrich_post) | **POST** /api/documents/debit-note/enrich | Enriches the input
[**api_documents_invoice_enrich_post**](EnrichApi.md#api_documents_invoice_enrich_post) | **POST** /api/documents/invoice/enrich | Enriches the input
[**api_documents_summary_document_enrich_post**](EnrichApi.md#api_documents_summary_document_enrich_post) | **POST** /api/documents/summary-document/enrich | Enriches the input
[**api_documents_voided_document_enrich_post**](EnrichApi.md#api_documents_voided_document_enrich_post) | **POST** /api/documents/voided-document/enrich | Enriches the input

# **api_documents_credit_note_enrich_post**
> CreditNoteOutputModel api_documents_credit_note_enrich_post(body=body)

Enriches the input

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EnrichApi()
body = swagger_client.CreditNote() # CreditNote |  (optional)

try:
    # Enriches the input
    api_response = api_instance.api_documents_credit_note_enrich_post(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EnrichApi->api_documents_credit_note_enrich_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreditNote**](CreditNote.md)|  | [optional] 

### Return type

[**CreditNoteOutputModel**](CreditNoteOutputModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **api_documents_debit_note_enrich_post**
> DebitNoteOutputModel api_documents_debit_note_enrich_post(body=body)

Enriches the input

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EnrichApi()
body = swagger_client.DebitNote() # DebitNote |  (optional)

try:
    # Enriches the input
    api_response = api_instance.api_documents_debit_note_enrich_post(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EnrichApi->api_documents_debit_note_enrich_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DebitNote**](DebitNote.md)|  | [optional] 

### Return type

[**DebitNoteOutputModel**](DebitNoteOutputModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **api_documents_invoice_enrich_post**
> InvoiceOutputModel api_documents_invoice_enrich_post(body=body)

Enriches the input

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EnrichApi()
body = swagger_client.Invoice() # Invoice |  (optional)

try:
    # Enriches the input
    api_response = api_instance.api_documents_invoice_enrich_post(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EnrichApi->api_documents_invoice_enrich_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Invoice**](Invoice.md)|  | [optional] 

### Return type

[**InvoiceOutputModel**](InvoiceOutputModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **api_documents_summary_document_enrich_post**
> SummaryDocumentOutputModel api_documents_summary_document_enrich_post(body=body)

Enriches the input

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EnrichApi()
body = swagger_client.SummaryDocument() # SummaryDocument |  (optional)

try:
    # Enriches the input
    api_response = api_instance.api_documents_summary_document_enrich_post(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EnrichApi->api_documents_summary_document_enrich_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SummaryDocument**](SummaryDocument.md)|  | [optional] 

### Return type

[**SummaryDocumentOutputModel**](SummaryDocumentOutputModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **api_documents_voided_document_enrich_post**
> VoidedDocumentOutputModel api_documents_voided_document_enrich_post(body=body)

Enriches the input

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EnrichApi()
body = swagger_client.VoidedDocument() # VoidedDocument |  (optional)

try:
    # Enriches the input
    api_response = api_instance.api_documents_voided_document_enrich_post(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EnrichApi->api_documents_voided_document_enrich_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**VoidedDocument**](VoidedDocument.md)|  | [optional] 

### Return type

[**VoidedDocumentOutputModel**](VoidedDocumentOutputModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

