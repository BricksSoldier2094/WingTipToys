using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WingTip_Toys.Models;
using System.Web.ModelBinding;

namespace WingTip_Toys
{
    public partial class ProductList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Limita os resultados da busca a uma categoria específica no banco de dados.
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public IQueryable<ProductModel> GetProducts([QueryString("id")]int? categoryId)
        {
            var _db = new ProductContext { };
            IQueryable<ProductModel> query = _db.Products;

            if(categoryId.HasValue && categoryId > 0)
            {
                query = query.Where(p => p.CategoryID == categoryId);
            }

            return query;

        }
    }
}