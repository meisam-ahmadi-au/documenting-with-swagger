using System.ComponentModel.DataAnnotations;

namespace Library.API.Models
{
    public class AuthorForUpdate
    {
        /// <summary>
        /// FirstName Ast
        /// </summary>
        [Required]
        [MaxLength(150)]
        public string FirstName { get; set; }
        /// <summary>
        /// lastname ast
        /// </summary>
        [Required]
        [MaxLength(150)]
        public string LastName { get; set; }
    }
}
