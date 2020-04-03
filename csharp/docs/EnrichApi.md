# IO.Swagger.Api.EnrichApi

All URIs are relative to *http://xml-builder-project-openubl.apps.ca-central-1.starter.openshift-online.com/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiDocumentsCreditNoteEnrichPost**](EnrichApi.md#apidocumentscreditnoteenrichpost) | **POST** /api/documents/credit-note/enrich | Enriches the input
[**ApiDocumentsDebitNoteEnrichPost**](EnrichApi.md#apidocumentsdebitnoteenrichpost) | **POST** /api/documents/debit-note/enrich | Enriches the input
[**ApiDocumentsInvoiceEnrichPost**](EnrichApi.md#apidocumentsinvoiceenrichpost) | **POST** /api/documents/invoice/enrich | Enriches the input
[**ApiDocumentsSummaryDocumentEnrichPost**](EnrichApi.md#apidocumentssummarydocumentenrichpost) | **POST** /api/documents/summary-document/enrich | Enriches the input
[**ApiDocumentsVoidedDocumentEnrichPost**](EnrichApi.md#apidocumentsvoideddocumentenrichpost) | **POST** /api/documents/voided-document/enrich | Enriches the input

<a name="apidocumentscreditnoteenrichpost"></a>
# **ApiDocumentsCreditNoteEnrichPost**
> CreditNoteOutputModel ApiDocumentsCreditNoteEnrichPost (CreditNote body = null)

Enriches the input

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiDocumentsCreditNoteEnrichPostExample
    {
        public void main()
        {
            var apiInstance = new EnrichApi();
            var body = new CreditNote(); // CreditNote |  (optional) 

            try
            {
                // Enriches the input
                CreditNoteOutputModel result = apiInstance.ApiDocumentsCreditNoteEnrichPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnrichApi.ApiDocumentsCreditNoteEnrichPost: " + e.Message );
            }
        }
    }
}
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
<a name="apidocumentsdebitnoteenrichpost"></a>
# **ApiDocumentsDebitNoteEnrichPost**
> DebitNoteOutputModel ApiDocumentsDebitNoteEnrichPost (DebitNote body = null)

Enriches the input

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiDocumentsDebitNoteEnrichPostExample
    {
        public void main()
        {
            var apiInstance = new EnrichApi();
            var body = new DebitNote(); // DebitNote |  (optional) 

            try
            {
                // Enriches the input
                DebitNoteOutputModel result = apiInstance.ApiDocumentsDebitNoteEnrichPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnrichApi.ApiDocumentsDebitNoteEnrichPost: " + e.Message );
            }
        }
    }
}
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
<a name="apidocumentsinvoiceenrichpost"></a>
# **ApiDocumentsInvoiceEnrichPost**
> InvoiceOutputModel ApiDocumentsInvoiceEnrichPost (Invoice body = null)

Enriches the input

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiDocumentsInvoiceEnrichPostExample
    {
        public void main()
        {
            var apiInstance = new EnrichApi();
            var body = new Invoice(); // Invoice |  (optional) 

            try
            {
                // Enriches the input
                InvoiceOutputModel result = apiInstance.ApiDocumentsInvoiceEnrichPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnrichApi.ApiDocumentsInvoiceEnrichPost: " + e.Message );
            }
        }
    }
}
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
<a name="apidocumentssummarydocumentenrichpost"></a>
# **ApiDocumentsSummaryDocumentEnrichPost**
> SummaryDocumentOutputModel ApiDocumentsSummaryDocumentEnrichPost (SummaryDocument body = null)

Enriches the input

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiDocumentsSummaryDocumentEnrichPostExample
    {
        public void main()
        {
            var apiInstance = new EnrichApi();
            var body = new SummaryDocument(); // SummaryDocument |  (optional) 

            try
            {
                // Enriches the input
                SummaryDocumentOutputModel result = apiInstance.ApiDocumentsSummaryDocumentEnrichPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnrichApi.ApiDocumentsSummaryDocumentEnrichPost: " + e.Message );
            }
        }
    }
}
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
<a name="apidocumentsvoideddocumentenrichpost"></a>
# **ApiDocumentsVoidedDocumentEnrichPost**
> VoidedDocumentOutputModel ApiDocumentsVoidedDocumentEnrichPost (VoidedDocument body = null)

Enriches the input

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiDocumentsVoidedDocumentEnrichPostExample
    {
        public void main()
        {
            var apiInstance = new EnrichApi();
            var body = new VoidedDocument(); // VoidedDocument |  (optional) 

            try
            {
                // Enriches the input
                VoidedDocumentOutputModel result = apiInstance.ApiDocumentsVoidedDocumentEnrichPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnrichApi.ApiDocumentsVoidedDocumentEnrichPost: " + e.Message );
            }
        }
    }
}
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
