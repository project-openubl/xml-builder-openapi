# Swagger\Client\EnrichApi

All URIs are relative to *http://xml-builder-project-openubl.apps.ca-central-1.starter.openshift-online.com/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**apiDocumentsCreditNoteEnrichPost**](EnrichApi.md#apidocumentscreditnoteenrichpost) | **POST** /api/documents/credit-note/enrich | Enriches the input
[**apiDocumentsDebitNoteEnrichPost**](EnrichApi.md#apidocumentsdebitnoteenrichpost) | **POST** /api/documents/debit-note/enrich | Enriches the input
[**apiDocumentsInvoiceEnrichPost**](EnrichApi.md#apidocumentsinvoiceenrichpost) | **POST** /api/documents/invoice/enrich | Enriches the input
[**apiDocumentsSummaryDocumentEnrichPost**](EnrichApi.md#apidocumentssummarydocumentenrichpost) | **POST** /api/documents/summary-document/enrich | Enriches the input
[**apiDocumentsVoidedDocumentEnrichPost**](EnrichApi.md#apidocumentsvoideddocumentenrichpost) | **POST** /api/documents/voided-document/enrich | Enriches the input

# **apiDocumentsCreditNoteEnrichPost**
> \Swagger\Client\Model\CreditNoteOutputModel apiDocumentsCreditNoteEnrichPost($body)

Enriches the input

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\EnrichApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$body = new \Swagger\Client\Model\CreditNote(); // \Swagger\Client\Model\CreditNote | 

try {
    $result = $apiInstance->apiDocumentsCreditNoteEnrichPost($body);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EnrichApi->apiDocumentsCreditNoteEnrichPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\CreditNote**](../Model/CreditNote.md)|  | [optional]

### Return type

[**\Swagger\Client\Model\CreditNoteOutputModel**](../Model/CreditNoteOutputModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiDocumentsDebitNoteEnrichPost**
> \Swagger\Client\Model\DebitNoteOutputModel apiDocumentsDebitNoteEnrichPost($body)

Enriches the input

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\EnrichApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$body = new \Swagger\Client\Model\DebitNote(); // \Swagger\Client\Model\DebitNote | 

try {
    $result = $apiInstance->apiDocumentsDebitNoteEnrichPost($body);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EnrichApi->apiDocumentsDebitNoteEnrichPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\DebitNote**](../Model/DebitNote.md)|  | [optional]

### Return type

[**\Swagger\Client\Model\DebitNoteOutputModel**](../Model/DebitNoteOutputModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiDocumentsInvoiceEnrichPost**
> \Swagger\Client\Model\InvoiceOutputModel apiDocumentsInvoiceEnrichPost($body)

Enriches the input

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\EnrichApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$body = new \Swagger\Client\Model\Invoice(); // \Swagger\Client\Model\Invoice | 

try {
    $result = $apiInstance->apiDocumentsInvoiceEnrichPost($body);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EnrichApi->apiDocumentsInvoiceEnrichPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\Invoice**](../Model/Invoice.md)|  | [optional]

### Return type

[**\Swagger\Client\Model\InvoiceOutputModel**](../Model/InvoiceOutputModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiDocumentsSummaryDocumentEnrichPost**
> \Swagger\Client\Model\SummaryDocumentOutputModel apiDocumentsSummaryDocumentEnrichPost($body)

Enriches the input

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\EnrichApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$body = new \Swagger\Client\Model\SummaryDocument(); // \Swagger\Client\Model\SummaryDocument | 

try {
    $result = $apiInstance->apiDocumentsSummaryDocumentEnrichPost($body);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EnrichApi->apiDocumentsSummaryDocumentEnrichPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\SummaryDocument**](../Model/SummaryDocument.md)|  | [optional]

### Return type

[**\Swagger\Client\Model\SummaryDocumentOutputModel**](../Model/SummaryDocumentOutputModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiDocumentsVoidedDocumentEnrichPost**
> \Swagger\Client\Model\VoidedDocumentOutputModel apiDocumentsVoidedDocumentEnrichPost($body)

Enriches the input

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\EnrichApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$body = new \Swagger\Client\Model\VoidedDocument(); // \Swagger\Client\Model\VoidedDocument | 

try {
    $result = $apiInstance->apiDocumentsVoidedDocumentEnrichPost($body);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EnrichApi->apiDocumentsVoidedDocumentEnrichPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\VoidedDocument**](../Model/VoidedDocument.md)|  | [optional]

### Return type

[**\Swagger\Client\Model\VoidedDocumentOutputModel**](../Model/VoidedDocumentOutputModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

