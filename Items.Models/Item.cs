using System;

namespace Items.Models
{
    /// <summary>
    /// A canonical data entity class for demonstrating data related UI and CRUD implementations.
    /// </summary>
    /// <remarks>
    /// For SQLite persistence decorate "ID" property with [Key] attribute.
    /// For SQLite persistence decorate "ID" property with [Key] attribute
    /// </remarks> 


    public class Item
    {
        /// <summary>
        /// Entity identifier as string encoded GUID which is suitable for both SQL and NoSQL implementations
        /// </summary>
        public string Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
    }
}