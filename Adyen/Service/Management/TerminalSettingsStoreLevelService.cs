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
    /// TerminalSettingsStoreLevelService Interface
    /// </summary>
    public interface ITerminalSettingsStoreLevelService
    {
        /// <summary>
        /// Get the terminal logo
        /// </summary>
        /// <param name="merchantId"><see cref="string"/> - The unique identifier of the merchant account.</param>
        /// <param name="reference"><see cref="string"/> - The reference that identifies the store.</param>
        /// <param name="model"><see cref="string"/> - The terminal model. Possible values: E355, VX675WIFIBT, VX680, VX690, VX700, VX820, M400, MX925, P400Plus, UX300, UX410, V200cPlus, V240mPlus, V400cPlus, V400m, e280, e285, e285p, S1E, S1EL, S1F2, S1L, S1U, S7T.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="Logo"/>.</returns>
        Logo GetTerminalLogo(string merchantId, string reference, string model, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get the terminal logo
        /// </summary>
        /// <param name="merchantId"><see cref="string"/> - The unique identifier of the merchant account.</param>
        /// <param name="reference"><see cref="string"/> - The reference that identifies the store.</param>
        /// <param name="model"><see cref="string"/> - The terminal model. Possible values: E355, VX675WIFIBT, VX680, VX690, VX700, VX820, M400, MX925, P400Plus, UX300, UX410, V200cPlus, V240mPlus, V400cPlus, V400m, e280, e285, e285p, S1E, S1EL, S1F2, S1L, S1U, S7T.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="Logo"/>.</returns>
        Task<Logo> GetTerminalLogoAsync(string merchantId, string reference, string model, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Get terminal settings
        /// </summary>
        /// <param name="merchantId"><see cref="string"/> - The unique identifier of the merchant account.</param>
        /// <param name="reference"><see cref="string"/> - The reference that identifies the store.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="TerminalSettings"/>.</returns>
        TerminalSettings GetTerminalSettings(string merchantId, string reference, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get terminal settings
        /// </summary>
        /// <param name="merchantId"><see cref="string"/> - The unique identifier of the merchant account.</param>
        /// <param name="reference"><see cref="string"/> - The reference that identifies the store.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="TerminalSettings"/>.</returns>
        Task<TerminalSettings> GetTerminalSettingsAsync(string merchantId, string reference, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Get the terminal logo
        /// </summary>
        /// <param name="storeId"><see cref="string"/> - The unique identifier of the store.</param>
        /// <param name="model"><see cref="string"/> - The terminal model. Possible values: E355, VX675WIFIBT, VX680, VX690, VX700, VX820, M400, MX925, P400Plus, UX300, UX410, V200cPlus, V240mPlus, V400cPlus, V400m, e280, e285, e285p, S1E, S1EL, S1F2, S1L, S1U, S7T.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="Logo"/>.</returns>
        Logo GetTerminalLogoByStoreId(string storeId, string model, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get the terminal logo
        /// </summary>
        /// <param name="storeId"><see cref="string"/> - The unique identifier of the store.</param>
        /// <param name="model"><see cref="string"/> - The terminal model. Possible values: E355, VX675WIFIBT, VX680, VX690, VX700, VX820, M400, MX925, P400Plus, UX300, UX410, V200cPlus, V240mPlus, V400cPlus, V400m, e280, e285, e285p, S1E, S1EL, S1F2, S1L, S1U, S7T.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="Logo"/>.</returns>
        Task<Logo> GetTerminalLogoByStoreIdAsync(string storeId, string model, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Get terminal settings
        /// </summary>
        /// <param name="storeId"><see cref="string"/> - The unique identifier of the store.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="TerminalSettings"/>.</returns>
        TerminalSettings GetTerminalSettingsByStoreId(string storeId, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get terminal settings
        /// </summary>
        /// <param name="storeId"><see cref="string"/> - The unique identifier of the store.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="TerminalSettings"/>.</returns>
        Task<TerminalSettings> GetTerminalSettingsByStoreIdAsync(string storeId, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Update the terminal logo
        /// </summary>
        /// <param name="merchantId"><see cref="string"/> - The unique identifier of the merchant account.</param>
        /// <param name="reference"><see cref="string"/> - The reference that identifies the store.</param>
        /// <param name="logo"><see cref="Logo"/> - </param>
        /// <param name="model"><see cref="string"/> - The terminal model. Possible values: E355, VX675WIFIBT, VX680, VX690, VX700, VX820, M400, MX925, P400Plus, UX300, UX410, V200cPlus, V240mPlus, V400cPlus, V400m, e280, e285, e285p, S1E, S1EL, S1F2, S1L, S1U, S7T</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="Logo"/>.</returns>
        Logo UpdateTerminalLogo(string merchantId, string reference, Logo logo, string model, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Update the terminal logo
        /// </summary>
        /// <param name="merchantId"><see cref="string"/> - The unique identifier of the merchant account.</param>
        /// <param name="reference"><see cref="string"/> - The reference that identifies the store.</param>
        /// <param name="logo"><see cref="Logo"/> - </param>
        /// <param name="model"><see cref="string"/> - The terminal model. Possible values: E355, VX675WIFIBT, VX680, VX690, VX700, VX820, M400, MX925, P400Plus, UX300, UX410, V200cPlus, V240mPlus, V400cPlus, V400m, e280, e285, e285p, S1E, S1EL, S1F2, S1L, S1U, S7T</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="Logo"/>.</returns>
        Task<Logo> UpdateTerminalLogoAsync(string merchantId, string reference, Logo logo, string model, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Update terminal settings
        /// </summary>
        /// <param name="merchantId"><see cref="string"/> - The unique identifier of the merchant account.</param>
        /// <param name="reference"><see cref="string"/> - The reference that identifies the store.</param>
        /// <param name="terminalSettings"><see cref="TerminalSettings"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="TerminalSettings"/>.</returns>
        TerminalSettings UpdateTerminalSettings(string merchantId, string reference, TerminalSettings terminalSettings, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Update terminal settings
        /// </summary>
        /// <param name="merchantId"><see cref="string"/> - The unique identifier of the merchant account.</param>
        /// <param name="reference"><see cref="string"/> - The reference that identifies the store.</param>
        /// <param name="terminalSettings"><see cref="TerminalSettings"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="TerminalSettings"/>.</returns>
        Task<TerminalSettings> UpdateTerminalSettingsAsync(string merchantId, string reference, TerminalSettings terminalSettings, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Update the terminal logo
        /// </summary>
        /// <param name="storeId"><see cref="string"/> - The unique identifier of the store.</param>
        /// <param name="logo"><see cref="Logo"/> - </param>
        /// <param name="model"><see cref="string"/> - The terminal model. Possible values: E355, VX675WIFIBT, VX680, VX690, VX700, VX820, M400, MX925, P400Plus, UX300, UX410, V200cPlus, V240mPlus, V400cPlus, V400m, e280, e285, e285p, S1E, S1EL, S1F2, S1L, S1U, S7T.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="Logo"/>.</returns>
        Logo UpdateTerminalLogoByStoreId(string storeId, Logo logo, string model, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Update the terminal logo
        /// </summary>
        /// <param name="storeId"><see cref="string"/> - The unique identifier of the store.</param>
        /// <param name="logo"><see cref="Logo"/> - </param>
        /// <param name="model"><see cref="string"/> - The terminal model. Possible values: E355, VX675WIFIBT, VX680, VX690, VX700, VX820, M400, MX925, P400Plus, UX300, UX410, V200cPlus, V240mPlus, V400cPlus, V400m, e280, e285, e285p, S1E, S1EL, S1F2, S1L, S1U, S7T.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="Logo"/>.</returns>
        Task<Logo> UpdateTerminalLogoByStoreIdAsync(string storeId, Logo logo, string model, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Update terminal settings
        /// </summary>
        /// <param name="storeId"><see cref="string"/> - The unique identifier of the store.</param>
        /// <param name="terminalSettings"><see cref="TerminalSettings"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="TerminalSettings"/>.</returns>
        TerminalSettings UpdateTerminalSettingsByStoreId(string storeId, TerminalSettings terminalSettings, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Update terminal settings
        /// </summary>
        /// <param name="storeId"><see cref="string"/> - The unique identifier of the store.</param>
        /// <param name="terminalSettings"><see cref="TerminalSettings"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="TerminalSettings"/>.</returns>
        Task<TerminalSettings> UpdateTerminalSettingsByStoreIdAsync(string storeId, TerminalSettings terminalSettings, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
    }
    
    /// <summary>
    /// Represents a collection of functions to interact with the TerminalSettingsStoreLevelService API endpoints
    /// </summary>
    public class TerminalSettingsStoreLevelService : AbstractService, ITerminalSettingsStoreLevelService
    {
        private readonly string _baseUrl;
        
        public TerminalSettingsStoreLevelService(Client client) : base(client)
        {
            _baseUrl = CreateBaseUrl("https://management-test.adyen.com/v1");
        }
        
        public Logo GetTerminalLogo(string merchantId, string reference, string model, RequestOptions requestOptions = default)
        {
            return GetTerminalLogoAsync(merchantId, reference, model, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Logo> GetTerminalLogoAsync(string merchantId, string reference, string model, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            // Build the query string
            var queryParams = new Dictionary<string, string>();
            if (model != null) queryParams.Add("model", model);
            var endpoint = _baseUrl + $"/merchants/{merchantId}/stores/{reference}/terminalLogos" + ToQueryString(queryParams);
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Logo>(null, requestOptions, new HttpMethod("GET"), cancellationToken).ConfigureAwait(false);
        }
        
        public TerminalSettings GetTerminalSettings(string merchantId, string reference, RequestOptions requestOptions = default)
        {
            return GetTerminalSettingsAsync(merchantId, reference, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<TerminalSettings> GetTerminalSettingsAsync(string merchantId, string reference, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/merchants/{merchantId}/stores/{reference}/terminalSettings";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<TerminalSettings>(null, requestOptions, new HttpMethod("GET"), cancellationToken).ConfigureAwait(false);
        }
        
        public Logo GetTerminalLogoByStoreId(string storeId, string model, RequestOptions requestOptions = default)
        {
            return GetTerminalLogoByStoreIdAsync(storeId, model, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Logo> GetTerminalLogoByStoreIdAsync(string storeId, string model, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            // Build the query string
            var queryParams = new Dictionary<string, string>();
            if (model != null) queryParams.Add("model", model);
            var endpoint = _baseUrl + $"/stores/{storeId}/terminalLogos" + ToQueryString(queryParams);
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Logo>(null, requestOptions, new HttpMethod("GET"), cancellationToken).ConfigureAwait(false);
        }
        
        public TerminalSettings GetTerminalSettingsByStoreId(string storeId, RequestOptions requestOptions = default)
        {
            return GetTerminalSettingsByStoreIdAsync(storeId, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<TerminalSettings> GetTerminalSettingsByStoreIdAsync(string storeId, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/stores/{storeId}/terminalSettings";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<TerminalSettings>(null, requestOptions, new HttpMethod("GET"), cancellationToken).ConfigureAwait(false);
        }
        
        public Logo UpdateTerminalLogo(string merchantId, string reference, Logo logo, string model, RequestOptions requestOptions = default)
        {
            return UpdateTerminalLogoAsync(merchantId, reference, logo, model, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Logo> UpdateTerminalLogoAsync(string merchantId, string reference, Logo logo, string model, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            // Build the query string
            var queryParams = new Dictionary<string, string>();
            if (model != null) queryParams.Add("model", model);
            var endpoint = _baseUrl + $"/merchants/{merchantId}/stores/{reference}/terminalLogos" + ToQueryString(queryParams);
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Logo>(logo.ToJson(), requestOptions, new HttpMethod("PATCH"), cancellationToken).ConfigureAwait(false);
        }
        
        public TerminalSettings UpdateTerminalSettings(string merchantId, string reference, TerminalSettings terminalSettings, RequestOptions requestOptions = default)
        {
            return UpdateTerminalSettingsAsync(merchantId, reference, terminalSettings, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<TerminalSettings> UpdateTerminalSettingsAsync(string merchantId, string reference, TerminalSettings terminalSettings, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/merchants/{merchantId}/stores/{reference}/terminalSettings";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<TerminalSettings>(terminalSettings.ToJson(), requestOptions, new HttpMethod("PATCH"), cancellationToken).ConfigureAwait(false);
        }
        
        public Logo UpdateTerminalLogoByStoreId(string storeId, Logo logo, string model, RequestOptions requestOptions = default)
        {
            return UpdateTerminalLogoByStoreIdAsync(storeId, logo, model, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Logo> UpdateTerminalLogoByStoreIdAsync(string storeId, Logo logo, string model, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            // Build the query string
            var queryParams = new Dictionary<string, string>();
            if (model != null) queryParams.Add("model", model);
            var endpoint = _baseUrl + $"/stores/{storeId}/terminalLogos" + ToQueryString(queryParams);
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Logo>(logo.ToJson(), requestOptions, new HttpMethod("PATCH"), cancellationToken).ConfigureAwait(false);
        }
        
        public TerminalSettings UpdateTerminalSettingsByStoreId(string storeId, TerminalSettings terminalSettings, RequestOptions requestOptions = default)
        {
            return UpdateTerminalSettingsByStoreIdAsync(storeId, terminalSettings, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<TerminalSettings> UpdateTerminalSettingsByStoreIdAsync(string storeId, TerminalSettings terminalSettings, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/stores/{storeId}/terminalSettings";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<TerminalSettings>(terminalSettings.ToJson(), requestOptions, new HttpMethod("PATCH"), cancellationToken).ConfigureAwait(false);
        }
    }
}