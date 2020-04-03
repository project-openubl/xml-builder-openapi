# IO.Swagger.Api.CreateApi

All URIs are relative to *http://xml-builder-project-openubl.apps.ca-central-1.starter.openshift-online.com/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiDocumentsCreditNoteCreatePost**](CreateApi.md#apidocumentscreditnotecreatepost) | **POST** /api/documents/credit-note/create | Create a XML file from the input
[**ApiDocumentsDebitNoteCreatePost**](CreateApi.md#apidocumentsdebitnotecreatepost) | **POST** /api/documents/debit-note/create | Create a XML file from the input
[**ApiDocumentsInvoiceCreatePost**](CreateApi.md#apidocumentsinvoicecreatepost) | **POST** /api/documents/invoice/create | Create a XML file from the input
[**ApiDocumentsSummaryDocumentCreatePost**](CreateApi.md#apidocumentssummarydocumentcreatepost) | **POST** /api/documents/summary-document/create | Create a XML file from the input
[**ApiDocumentsVoidedDocumentCreatePost**](CreateApi.md#apidocumentsvoideddocumentcreatepost) | **POST** /api/documents/voided-document/create | Create a XML file from the input

<a name="apidocumentscreditnotecreatepost"></a>
# **ApiDocumentsCreditNoteCreatePost**
> string ApiDocumentsCreditNoteCreatePost (CreditNote body = null)

Create a XML file from the input

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiDocumentsCreditNoteCreatePostExample
    {
        public void main()
        {
            var apiInstance = new CreateApi();
            var body = new CreditNote(); // CreditNote |  (optional) 

            try
            {
                // Create a XML file from the input
                string result = apiInstance.ApiDocumentsCreditNoteCreatePost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CreateApi.ApiDocumentsCreditNoteCreatePost: " + e.Message );
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

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apidocumentsdebitnotecreatepost"></a>
# **ApiDocumentsDebitNoteCreatePost**
> string ApiDocumentsDebitNoteCreatePost (DebitNote body = null)

Create a XML file from the input

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiDocumentsDebitNoteCreatePostExample
    {
        public void main()
        {
            var apiInstance = new CreateApi();
            var body = new DebitNote(); // DebitNote |  (optional) 

            try
            {
                // Create a XML file from the input
                string result = apiInstance.ApiDocumentsDebitNoteCreatePost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CreateApi.ApiDocumentsDebitNoteCreatePost: " + e.Message );
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

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apidocumentsinvoicecreatepost"></a>
# **ApiDocumentsInvoiceCreatePost**
> string ApiDocumentsInvoiceCreatePost (Invoice body = null)

Create a XML file from the input

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiDocumentsInvoiceCreatePostExample
    {
        public void main()
        {
            var apiInstance = new CreateApi();
            var body = new Invoice(); // Invoice |  (optional) 

            try
            {
                // Create a XML file from the input
                string result = apiInstance.ApiDocumentsInvoiceCreatePost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CreateApi.ApiDocumentsInvoiceCreatePost: " + e.Message );
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

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apidocumentssummarydocumentcreatepost"></a>
# **ApiDocumentsSummaryDocumentCreatePost**
> string ApiDocumentsSummaryDocumentCreatePost (SummaryDocument body = null)

Create a XML file from the input

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiDocumentsSummaryDocumentCreatePostExample
    {
        public void main()
        {
            var apiInstance = new CreateApi();
            var body = new SummaryDocument(); // SummaryDocument |  (optional) 

            try
            {
                // Create a XML file from the input
                string result = apiInstance.ApiDocumentsSummaryDocumentCreatePost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CreateApi.ApiDocumentsSummaryDocumentCreatePost: " + e.Message );
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

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apidocumentsvoideddocumentcreatepost"></a>
# **ApiDocumentsVoidedDocumentCreatePost**
> string ApiDocumentsVoidedDocumentCreatePost (VoidedDocument body = null)

Create a XML file from the input

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiDocumentsVoidedDocumentCreatePostExample
    {
        public void main()
        {
            var apiInstance = new CreateApi();
            var body = new VoidedDocument(); // VoidedDocument |  (optional) 

            try
            {
                // Create a XML file from the input
                string result = apiInstance.ApiDocumentsVoidedDocumentCreatePost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CreateApi.ApiDocumentsVoidedDocumentCreatePost: " + e.Message );
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

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
