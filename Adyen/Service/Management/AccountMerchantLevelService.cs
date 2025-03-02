/*
* Management API
*
*
* The version of the OpenAPI document: 1
* Contact: developer-experience@adyen.com
*
* NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
* https://openapi-generator.tech
* Do not edit the class manually.
*/

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Constants;
using Adyen.Model;
using Adyen.Service.Resource;
using Adyen.Model.Management;

namespace Adyen.Service.Management
{
    /// <summary>
    /// AccountMerchantLevelService Interface
    /// </summary>
    public interface IAccountMerchantLevelService
    {
        /// <summary>
        /// Get a list of merchant accounts
        /// </summary>
        /// <param name="pageNumber"><see cref="int?"/> - The number of the page to fetch.</param>
        /// <param name="pageSize"><see cref="int?"/> - The number of items to have on a page, maximum 100. The default is 10 items on a page.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="ListMerchantResponse"/>.</returns>
        ListMerchantResponse ListMerchantAccounts(int? pageNumber = default, int? pageSize = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get a list of merchant accounts
        /// </summary>
        /// <param name="pageNumber"><see cref="int?"/> - The number of the page to fetch.</param>
        /// <param name="pageSize"><see cref="int?"/> - The number of items to have on a page, maximum 100. The default is 10 items on a page.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="ListMerchantResponse"/>.</returns>
        Task<ListMerchantResponse> ListMerchantAccountsAsync(int? pageNumber = default, int? pageSize = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Get a merchant account
        /// </summary>
        /// <param name="merchantId"><see cref="string"/> - The unique identifier of the merchant account.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="Merchant"/>.</returns>
        Merchant GetMerchantAccount(string merchantId, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get a merchant account
        /// </summary>
        /// <param name="merchantId"><see cref="string"/> - The unique identifier of the merchant account.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="Merchant"/>.</returns>
        Task<Merchant> GetMerchantAccountAsync(string merchantId, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Create a merchant account
        /// </summary>
        /// <param name="createMerchantRequest"><see cref="CreateMerchantRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="CreateMerchantResponse"/>.</returns>
        CreateMerchantResponse CreateMerchantAccount(CreateMerchantRequest createMerchantRequest, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Create a merchant account
        /// </summary>
        /// <param name="createMerchantRequest"><see cref="CreateMerchantRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="CreateMerchantResponse"/>.</returns>
        Task<CreateMerchantResponse> CreateMerchantAccountAsync(CreateMerchantRequest createMerchantRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Request to activate a merchant account
        /// </summary>
        /// <param name="merchantId"><see cref="string"/> - The unique identifier of the merchant account.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="RequestActivationResponse"/>.</returns>
        RequestActivationResponse RequestToActivateMerchantAccount(string merchantId, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Request to activate a merchant account
        /// </summary>
        /// <param name="merchantId"><see cref="string"/> - The unique identifier of the merchant account.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="RequestActivationResponse"/>.</returns>
        Task<RequestActivationResponse> RequestToActivateMerchantAccountAsync(string merchantId, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
    }
    
    /// <summary>
    /// Represents a collection of functions to interact with the AccountMerchantLevelService API endpoints
    /// </summary>
    public class AccountMerchantLevelService : AbstractService, IAccountMerchantLevelService
    {
        private readonly string _baseUrl;
        
        public AccountMerchantLevelService(Client client) : base(client)
        {
            _baseUrl = CreateBaseUrl("https://management-test.adyen.com/v1");
        }
        
        public ListMerchantResponse ListMerchantAccounts(int? pageNumber = default, int? pageSize = default, RequestOptions requestOptions = default)
        {
            return ListMerchantAccountsAsync(pageNumber, pageSize, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<ListMerchantResponse> ListMerchantAccountsAsync(int? pageNumber = default, int? pageSize = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            // Build the query string
            var queryParams = new Dictionary<string, string>();
            if (pageNumber != null) queryParams.Add("pageNumber", pageNumber.ToString());
            if (pageSize != null) queryParams.Add("pageSize", pageSize.ToString());
            var endpoint = _baseUrl + "/merchants" + ToQueryString(queryParams);
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<ListMerchantResponse>(null, requestOptions, new HttpMethod("GET"), cancellationToken).ConfigureAwait(false);
        }
        
        public Merchant GetMerchantAccount(string merchantId, RequestOptions requestOptions = default)
        {
            return GetMerchantAccountAsync(merchantId, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Merchant> GetMerchantAccountAsync(string merchantId, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/merchants/{merchantId}";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Merchant>(null, requestOptions, new HttpMethod("GET"), cancellationToken).ConfigureAwait(false);
        }
        
        public CreateMerchantResponse CreateMerchantAccount(CreateMerchantRequest createMerchantRequest, RequestOptions requestOptions = default)
        {
            return CreateMerchantAccountAsync(createMerchantRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<CreateMerchantResponse> CreateMerchantAccountAsync(CreateMerchantRequest createMerchantRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/merchants";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<CreateMerchantResponse>(createMerchantRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
        
        public RequestActivationResponse RequestToActivateMerchantAccount(string merchantId, RequestOptions requestOptions = default)
        {
            return RequestToActivateMerchantAccountAsync(merchantId, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<RequestActivationResponse> RequestToActivateMerchantAccountAsync(string merchantId, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/merchants/{merchantId}/activate";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<RequestActivationResponse>(null, requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
    }
}