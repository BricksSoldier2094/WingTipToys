using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WingTip_Toys.Models
{
    public class ProductModel
    {
        /// <summary>
        /// O identificador único para uma instancia de produto.
        /// </summary>
        [Key,ScaffoldColumn(false)]
        public int ProductID { get; set; }

        /// <summary>
        /// O nome do produto.
        /// </summary>
        [Required, StringLength(100), Display(Name ="Name")]
        public string ProductName { get; set; }

        /// <summary>
        /// A descrição do produto.
        /// </summary>
        [Required, StringLength(1000), Display(Name ="ProductDescription"), DataType(DataType.MultilineText)]
        public string Description { get; set; }

        /// <summary>
        /// O caminho da imagem que representa um produto.
        /// </summary>
        public string ImagePath { get; set; }

        /// <summary>
        /// O valor do produto.
        /// </summary>
        [Display(Name ="Price")]
        public double? UnitPrice { get; set; }

        /// <summary>
        /// O ID da categoria cujo um produto pertence.
        /// </summary>
        public int? CategoryID { get; set; }

        /// <summary>
        /// A descrição da categoria cujo ID referencia.
        /// </summary>
        public virtual CategoryModel Category { get; set; }

    }
}