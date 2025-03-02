/*
* Adyen Checkout API
*
*
* The version of the OpenAPI document: 70
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
using Adyen.Model.Checkout;

namespace Adyen.Service.Checkout
{
    /// <summary>
    /// OrdersService Interface
    /// </summary>
    public interface IOrdersService
    {
        /// <summary>
        /// Create an order
        /// </summary>
        /// <param name="checkoutCreateOrderRequest"><see cref="CheckoutCreateOrderRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="CheckoutCreateOrderResponse"/>.</returns>
        CheckoutCreateOrderResponse Orders(CheckoutCreateOrderRequest checkoutCreateOrderRequest, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Create an order
        /// </summary>
        /// <param name="checkoutCreateOrderRequest"><see cref="CheckoutCreateOrderRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="CheckoutCreateOrderResponse"/>.</returns>
        Task<CheckoutCreateOrderResponse> OrdersAsync(CheckoutCreateOrderRequest checkoutCreateOrderRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Cancel an order
        /// </summary>
        /// <param name="checkoutCancelOrderRequest"><see cref="CheckoutCancelOrderRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="CheckoutCancelOrderResponse"/>.</returns>
        CheckoutCancelOrderResponse CancelOrder(CheckoutCancelOrderRequest checkoutCancelOrderRequest, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Cancel an order
        /// </summary>
        /// <param name="checkoutCancelOrderRequest"><see cref="CheckoutCancelOrderRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="CheckoutCancelOrderResponse"/>.</returns>
        Task<CheckoutCancelOrderResponse> CancelOrderAsync(CheckoutCancelOrderRequest checkoutCancelOrderRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Get the balance of a gift card
        /// </summary>
        /// <param name="checkoutBalanceCheckRequest"><see cref="CheckoutBalanceCheckRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="CheckoutBalanceCheckResponse"/>.</returns>
        CheckoutBalanceCheckResponse GetBalanceOfGiftCard(CheckoutBalanceCheckRequest checkoutBalanceCheckRequest, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get the balance of a gift card
        /// </summary>
        /// <param name="checkoutBalanceCheckRequest"><see cref="CheckoutBalanceCheckRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="CheckoutBalanceCheckResponse"/>.</returns>
        Task<CheckoutBalanceCheckResponse> GetBalanceOfGiftCardAsync(CheckoutBalanceCheckRequest checkoutBalanceCheckRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
    }
    
    /// <summary>
    /// Represents a collection of functions to interact with the OrdersService API endpoints
    /// </summary>
    public class OrdersService : AbstractService, IOrdersService
    {
        private readonly string _baseUrl;
        
        public OrdersService(Client client) : base(client)
        {
            _baseUrl = CreateBaseUrl("https://checkout-test.adyen.com/v70");
        }
        
        public CheckoutCreateOrderResponse Orders(CheckoutCreateOrderRequest checkoutCreateOrderRequest, RequestOptions requestOptions = default)
        {
            return OrdersAsync(checkoutCreateOrderRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<CheckoutCreateOrderResponse> OrdersAsync(CheckoutCreateOrderRequest checkoutCreateOrderRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/orders";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<CheckoutCreateOrderResponse>(checkoutCreateOrderRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
        
        public CheckoutCancelOrderResponse CancelOrder(CheckoutCancelOrderRequest checkoutCancelOrderRequest, RequestOptions requestOptions = default)
        {
            return CancelOrderAsync(checkoutCancelOrderRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<CheckoutCancelOrderResponse> CancelOrderAsync(CheckoutCancelOrderRequest checkoutCancelOrderRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/orders/cancel";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<CheckoutCancelOrderResponse>(checkoutCancelOrderRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
        
        public CheckoutBalanceCheckResponse GetBalanceOfGiftCard(CheckoutBalanceCheckRequest checkoutBalanceCheckRequest, RequestOptions requestOptions = default)
        {
            return GetBalanceOfGiftCardAsync(checkoutBalanceCheckRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<CheckoutBalanceCheckResponse> GetBalanceOfGiftCardAsync(CheckoutBalanceCheckRequest checkoutBalanceCheckRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/paymentMethods/balance";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<CheckoutBalanceCheckResponse>(checkoutBalanceCheckRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
    }
}