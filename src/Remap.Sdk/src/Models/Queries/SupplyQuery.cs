﻿using Confiti.MoySklad.Remap.Client;
using Confiti.MoySklad.Remap.Entities;

namespace Confiti.MoySklad.Remap.Models
{
    /// <summary>
    /// Represents a <see cref="Supply"/> query.
    /// </summary>
    public class SupplyQuery
    {
        #region Properties

        /// <summary>
        /// Gets or sets the positions.
        /// Note: 'expand' is allowed.
        /// </summary>
        /// <value>The positions.</value>
        [AllowExpand]
        [Parameter("positions")]
        public PagedMetaEntities<SupplyPosition> Positions { get; set; }

        #endregion Properties
    }
}