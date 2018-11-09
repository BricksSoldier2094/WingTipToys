using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WingTip_Toys.Models
{
    public class CategoryModel
    {
        /// <summary>
        /// O identificar único de uma instancia de categoria.
        /// </summary>
        [Key,ScaffoldColumn(false)]
        public int CategoryID { get; set; }

        /// <summary>
        /// O nome da categoria.
        /// </summary>
        [Required, StringLength(100), Display(Name = "Name")]
        public string CategoryName { get; set; }

        /// <summary>
        /// A descrição da categoria.
        /// </summary>
        [Display(Name = "ProductDescription")]
        public string Description { get; set; }

        /// <summary>
        /// Uma lista de produtos pertencentes a uma dada categoria.
        /// </summary>
        public virtual ICollection<ProductModel> Products { get; set; }
    }
}