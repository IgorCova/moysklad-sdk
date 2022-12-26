﻿namespace Confiti.MoySklad.Remap.Entities
{
    /// <summary>
    /// Represents an product metadata.
    /// </summary>
    public class ProductMetadata : MetaEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the attributes.
        /// </summary>
        /// <value>The attributes.</value>
        public PagedEntities<AttributeDefinition> Attributes { get; set; }

        #endregion Properties
    }
}