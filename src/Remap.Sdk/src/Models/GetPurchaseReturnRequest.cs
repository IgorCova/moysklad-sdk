using System;
using Confiti.MoySklad.Remap.Client;
using Confiti.MoySklad.Remap.Entities;

namespace Confiti.MoySklad.Remap.Models
{
    /// <summary>
    /// Represents a request to get <see cref="PurchaseReturn"/>.
    /// </summary>
    public class GetPurchaseReturnRequest
    {
        #region Properties

        /// <summary>
        /// Gets or sets the purchase return id.
        /// </summary>
        /// <value>The purchase return id.</value>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the API parameter builder to prepare the request query.
        /// </summary>
        /// <returns>The API parameter builder.</returns>
        public ApiParameterBuilder<PurchaseReturnQuery> Query { get; set; } = new ApiParameterBuilder<PurchaseReturnQuery>();

        #endregion
    }
}