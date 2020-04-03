# EnrichApi

All URIs are relative to *http://xml-builder-project-openubl.apps.ca-central-1.starter.openshift-online.com/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**apiDocumentsCreditNoteEnrichPost**](EnrichApi.md#apiDocumentsCreditNoteEnrichPost) | **POST** /api/documents/credit-note/enrich | Enriches the input
[**apiDocumentsDebitNoteEnrichPost**](EnrichApi.md#apiDocumentsDebitNoteEnrichPost) | **POST** /api/documents/debit-note/enrich | Enriches the input
[**apiDocumentsInvoiceEnrichPost**](EnrichApi.md#apiDocumentsInvoiceEnrichPost) | **POST** /api/documents/invoice/enrich | Enriches the input
[**apiDocumentsSummaryDocumentEnrichPost**](EnrichApi.md#apiDocumentsSummaryDocumentEnrichPost) | **POST** /api/documents/summary-document/enrich | Enriches the input
[**apiDocumentsVoidedDocumentEnrichPost**](EnrichApi.md#apiDocumentsVoidedDocumentEnrichPost) | **POST** /api/documents/voided-document/enrich | Enriches the input

<a name="apiDocumentsCreditNoteEnrichPost"></a>
# **apiDocumentsCreditNoteEnrichPost**
> CreditNoteOutputModel apiDocumentsCreditNoteEnrichPost(body)

Enriches the input

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.EnrichApi;


EnrichApi apiInstance = new EnrichApi();
CreditNote body = new CreditNote(); // CreditNote | 
try {
    CreditNoteOutputModel result = apiInstance.apiDocumentsCreditNoteEnrichPost(body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling EnrichApi#apiDocumentsCreditNoteEnrichPost");
    e.printStackTrace();
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

<a name="apiDocumentsDebitNoteEnrichPost"></a>
# **apiDocumentsDebitNoteEnrichPost**
> DebitNoteOutputModel apiDocumentsDebitNoteEnrichPost(body)

Enriches the input

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.EnrichApi;


EnrichApi apiInstance = new EnrichApi();
DebitNote body = new DebitNote(); // DebitNote | 
try {
    DebitNoteOutputModel result = apiInstance.apiDocumentsDebitNoteEnrichPost(body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling EnrichApi#apiDocumentsDebitNoteEnrichPost");
    e.printStackTrace();
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

<a name="apiDocumentsInvoiceEnrichPost"></a>
# **apiDocumentsInvoiceEnrichPost**
> InvoiceOutputModel apiDocumentsInvoiceEnrichPost(body)

Enriches the input

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.EnrichApi;


EnrichApi apiInstance = new EnrichApi();
Invoice body = new Invoice(); // Invoice | 
try {
    InvoiceOutputModel result = apiInstance.apiDocumentsInvoiceEnrichPost(body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling EnrichApi#apiDocumentsInvoiceEnrichPost");
    e.printStackTrace();
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

<a name="apiDocumentsSummaryDocumentEnrichPost"></a>
# **apiDocumentsSummaryDocumentEnrichPost**
> SummaryDocumentOutputModel apiDocumentsSummaryDocumentEnrichPost(body)

Enriches the input

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.EnrichApi;


EnrichApi apiInstance = new EnrichApi();
SummaryDocument body = new SummaryDocument(); // SummaryDocument | 
try {
    SummaryDocumentOutputModel result = apiInstance.apiDocumentsSummaryDocumentEnrichPost(body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling EnrichApi#apiDocumentsSummaryDocumentEnrichPost");
    e.printStackTrace();
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

<a name="apiDocumentsVoidedDocumentEnrichPost"></a>
# **apiDocumentsVoidedDocumentEnrichPost**
> VoidedDocumentOutputModel apiDocumentsVoidedDocumentEnrichPost(body)

Enriches the input

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.EnrichApi;


EnrichApi apiInstance = new EnrichApi();
VoidedDocument body = new VoidedDocument(); // VoidedDocument | 
try {
    VoidedDocumentOutputModel result = apiInstance.apiDocumentsVoidedDocumentEnrichPost(body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling EnrichApi#apiDocumentsVoidedDocumentEnrichPost");
    e.printStackTrace();
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

