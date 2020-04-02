# CreateApi

All URIs are relative to *http://xml-builder-project-openubl.apps.us-west-1.starter.openshift-online.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**apiDocumentsCreditNoteCreatePost**](CreateApi.md#apiDocumentsCreditNoteCreatePost) | **POST** /api/documents/credit-note/create | Create a XML file from the input
[**apiDocumentsDebitNoteCreatePost**](CreateApi.md#apiDocumentsDebitNoteCreatePost) | **POST** /api/documents/debit-note/create | Create a XML file from the input
[**apiDocumentsInvoiceCreatePost**](CreateApi.md#apiDocumentsInvoiceCreatePost) | **POST** /api/documents/invoice/create | Create a XML file from the input
[**apiDocumentsSummaryDocumentCreatePost**](CreateApi.md#apiDocumentsSummaryDocumentCreatePost) | **POST** /api/documents/summary-document/create | Create a XML file from the input
[**apiDocumentsVoidedDocumentCreatePost**](CreateApi.md#apiDocumentsVoidedDocumentCreatePost) | **POST** /api/documents/voided-document/create | Create a XML file from the input

<a name="apiDocumentsCreditNoteCreatePost"></a>
# **apiDocumentsCreditNoteCreatePost**
> String apiDocumentsCreditNoteCreatePost(body)

Create a XML file from the input

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.CreateApi;


CreateApi apiInstance = new CreateApi();
CreditNote body = new CreditNote(); // CreditNote | 
try {
    String result = apiInstance.apiDocumentsCreditNoteCreatePost(body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CreateApi#apiDocumentsCreditNoteCreatePost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreditNote**](CreditNote.md)|  | [optional]

### Return type

**String**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/xml

<a name="apiDocumentsDebitNoteCreatePost"></a>
# **apiDocumentsDebitNoteCreatePost**
> String apiDocumentsDebitNoteCreatePost(body)

Create a XML file from the input

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.CreateApi;


CreateApi apiInstance = new CreateApi();
DebitNote body = new DebitNote(); // DebitNote | 
try {
    String result = apiInstance.apiDocumentsDebitNoteCreatePost(body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CreateApi#apiDocumentsDebitNoteCreatePost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DebitNote**](DebitNote.md)|  | [optional]

### Return type

**String**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/xml

<a name="apiDocumentsInvoiceCreatePost"></a>
# **apiDocumentsInvoiceCreatePost**
> String apiDocumentsInvoiceCreatePost(body)

Create a XML file from the input

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.CreateApi;


CreateApi apiInstance = new CreateApi();
Invoice body = new Invoice(); // Invoice | 
try {
    String result = apiInstance.apiDocumentsInvoiceCreatePost(body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CreateApi#apiDocumentsInvoiceCreatePost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Invoice**](Invoice.md)|  | [optional]

### Return type

**String**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/xml

<a name="apiDocumentsSummaryDocumentCreatePost"></a>
# **apiDocumentsSummaryDocumentCreatePost**
> String apiDocumentsSummaryDocumentCreatePost(body)

Create a XML file from the input

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.CreateApi;


CreateApi apiInstance = new CreateApi();
SummaryDocument body = new SummaryDocument(); // SummaryDocument | 
try {
    String result = apiInstance.apiDocumentsSummaryDocumentCreatePost(body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CreateApi#apiDocumentsSummaryDocumentCreatePost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SummaryDocument**](SummaryDocument.md)|  | [optional]

### Return type

**String**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/xml

<a name="apiDocumentsVoidedDocumentCreatePost"></a>
# **apiDocumentsVoidedDocumentCreatePost**
> String apiDocumentsVoidedDocumentCreatePost(body)

Create a XML file from the input

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.CreateApi;


CreateApi apiInstance = new CreateApi();
VoidedDocument body = new VoidedDocument(); // VoidedDocument | 
try {
    String result = apiInstance.apiDocumentsVoidedDocumentCreatePost(body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CreateApi#apiDocumentsVoidedDocumentCreatePost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**VoidedDocument**](VoidedDocument.md)|  | [optional]

### Return type

**String**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/xml

