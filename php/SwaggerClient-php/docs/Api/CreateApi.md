# Swagger\Client\CreateApi

All URIs are relative to *http://xml-builder-project-openubl.apps.us-west-1.starter.openshift-online.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**apiDocumentsCreditNoteCreatePost**](CreateApi.md#apidocumentscreditnotecreatepost) | **POST** /api/documents/credit-note/create | Create a XML file from the input
[**apiDocumentsDebitNoteCreatePost**](CreateApi.md#apidocumentsdebitnotecreatepost) | **POST** /api/documents/debit-note/create | Create a XML file from the input
[**apiDocumentsInvoiceCreatePost**](CreateApi.md#apidocumentsinvoicecreatepost) | **POST** /api/documents/invoice/create | Create a XML file from the input
[**apiDocumentsSummaryDocumentCreatePost**](CreateApi.md#apidocumentssummarydocumentcreatepost) | **POST** /api/documents/summary-document/create | Create a XML file from the input
[**apiDocumentsVoidedDocumentCreatePost**](CreateApi.md#apidocumentsvoideddocumentcreatepost) | **POST** /api/documents/voided-document/create | Create a XML file from the input

# **apiDocumentsCreditNoteCreatePost**
> string apiDocumentsCreditNoteCreatePost($body)

Create a XML file from the input

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\CreateApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$body = new \Swagger\Client\Model\CreditNote(); // \Swagger\Client\Model\CreditNote | 

try {
    $result = $apiInstance->apiDocumentsCreditNoteCreatePost($body);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CreateApi->apiDocumentsCreditNoteCreatePost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\CreditNote**](../Model/CreditNote.md)|  | [optional]

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/xml

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiDocumentsDebitNoteCreatePost**
> string apiDocumentsDebitNoteCreatePost($body)

Create a XML file from the input

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\CreateApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$body = new \Swagger\Client\Model\DebitNote(); // \Swagger\Client\Model\DebitNote | 

try {
    $result = $apiInstance->apiDocumentsDebitNoteCreatePost($body);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CreateApi->apiDocumentsDebitNoteCreatePost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\DebitNote**](../Model/DebitNote.md)|  | [optional]

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/xml

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiDocumentsInvoiceCreatePost**
> string apiDocumentsInvoiceCreatePost($body)

Create a XML file from the input

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\CreateApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$body = new \Swagger\Client\Model\Invoice(); // \Swagger\Client\Model\Invoice | 

try {
    $result = $apiInstance->apiDocumentsInvoiceCreatePost($body);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CreateApi->apiDocumentsInvoiceCreatePost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\Invoice**](../Model/Invoice.md)|  | [optional]

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/xml

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiDocumentsSummaryDocumentCreatePost**
> string apiDocumentsSummaryDocumentCreatePost($body)

Create a XML file from the input

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\CreateApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$body = new \Swagger\Client\Model\SummaryDocument(); // \Swagger\Client\Model\SummaryDocument | 

try {
    $result = $apiInstance->apiDocumentsSummaryDocumentCreatePost($body);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CreateApi->apiDocumentsSummaryDocumentCreatePost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\SummaryDocument**](../Model/SummaryDocument.md)|  | [optional]

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/xml

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apiDocumentsVoidedDocumentCreatePost**
> string apiDocumentsVoidedDocumentCreatePost($body)

Create a XML file from the input

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\CreateApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$body = new \Swagger\Client\Model\VoidedDocument(); // \Swagger\Client\Model\VoidedDocument | 

try {
    $result = $apiInstance->apiDocumentsVoidedDocumentCreatePost($body);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CreateApi->apiDocumentsVoidedDocumentCreatePost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\VoidedDocument**](../Model/VoidedDocument.md)|  | [optional]

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/xml

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

