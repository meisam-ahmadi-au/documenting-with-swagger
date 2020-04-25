using System;

namespace Library.API.Models
{
    /// <summary>
    /// Author Type
    /// </summary>
    public class Author
    {
        /// <summary>
        /// The id
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// FirstName
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// LastName
        /// </summary>
        public string LastName { get; set; }
    }
}
