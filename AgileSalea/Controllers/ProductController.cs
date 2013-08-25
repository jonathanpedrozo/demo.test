using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AgileSalea.Models;

namespace AgileSalea.Controllers
{
    public class ProductController : Controller
    {
        //
        // GET: /Product/

        private ProductModel GetProductModelFromSession()
        {
            ProductModel pModel = (ProductModel)Session["Products"];

            if (pModel == null)
            {
                pModel = new ProductModel();
                Session["Products"] = pModel;
            }

            return pModel;
        }

        private CategoriesModel GetCategoriesModelFromSession()
        {
            CategoriesModel cModel = (CategoriesModel)Session["Categories"];

            if (cModel == null)
            {
                cModel = new CategoriesModel();
                Session["Categories"] = cModel;
            }

            return cModel;
        }

        private CartModel GetCartModelFromSession()
        {
            CartModel cModel = (CartModel)Session["Cart"];

            if (cModel == null)
            {
                cModel = new CartModel();
                Session["Cart"] = cModel;
            }

            return cModel;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(string ID)
        {
            //Brings all Products data
            ProductModel pModel = GetProductModelFromSession();

            //Brings Category data
            CategoriesModel cModel = GetCategoriesModelFromSession();

            //Brings Carts data
            CartModel cartModel = GetCartModelFromSession();

            ViewData["Categories"] = cModel.GetCategories();
            ViewData["Cart"] = cartModel.GetCarts();
            ViewData["Product"] = pModel.GetProductByID(Convert.ToInt32(ID));

            return View();
        }

    }
}
