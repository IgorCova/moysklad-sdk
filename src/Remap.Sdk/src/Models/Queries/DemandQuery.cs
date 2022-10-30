﻿using Confiti.MoySklad.Remap.Client;
using Confiti.MoySklad.Remap.Entities;

namespace Confiti.MoySklad.Remap.Models
{
    /// <summary>
    /// Represents a <see cref="Demand"/> query.
    /// </summary>
    public class DemandQuery
    {
        #region Properties

        /// <summary>
        /// Gets or sets the customer order.
        /// Note: 'expand' is allowed.
        /// </summary>
        /// <value>The customer order.</value>
        [AllowExpand]
        [Parameter("customerOrder")]
        public CustomerOrderQuery CustomerOrder { get; set; }

        /// <summary>
        /// Gets or sets the positions.
        /// Note: 'expand' is allowed.
        /// </summary>
        /// <value>The positions.</value>
        [AllowExpand]
        [Parameter("positions")]
        public PagedMetaEntities<DemandPosition> Positions { get; set; }

        #endregion Properties
    }
}