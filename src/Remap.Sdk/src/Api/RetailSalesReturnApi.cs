﻿using Confiti.MoySklad.Remap.Client;
using Confiti.MoySklad.Remap.Entities;
using Confiti.MoySklad.Remap.Models;
using System.Net.Http;
using System.Threading.Tasks;

namespace Confiti.MoySklad.Remap.Api
{
    /// <summary>
    /// Represents the API to interact with the retail sales return endpoint.
    /// </summary>
    public class RetailSalesReturnApi : ApiAccessor
    {
        #region Ctor

        /// <summary>
        /// Creates a new instance of the <see cref="RetailSalesReturnApi" /> class
        /// with MoySklad credentials if specified and the HTTP client if specified (or use default).
        /// </summary>
        /// <param name="credentials">The MoySklad credentials.</param>
        /// <param name="httpClient">The HTTP client.</param>
        public RetailSalesReturnApi(MoySkladCredentials credentials = null, HttpClient httpClient = null)
            : base("/api/remap/1.2/entity/retailsalesreturn", credentials, httpClient)
        {
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets the retail sales return.
        /// </summary>
        /// <param name="request">The retail sales return request.</param>
        /// <returns>The <see cref="Task"/> containing the API response with <see cref="RetailSalesReturn"/>.</returns>
        public virtual Task<ApiResponse<RetailSalesReturn>> GetAsync(GetRetailSalesReturnRequest request) => GetByIdAsync<RetailSalesReturn>(request.Id, request.Query);

        #endregion
    }
}
