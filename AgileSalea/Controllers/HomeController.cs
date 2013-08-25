using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AgileSalea.Models;

namespace AgileSalea.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        private HomeModel GetHomeModelFromSession()
        {
            HomeModel hModel = (HomeModel)Session["Contents"];
            
            if (hModel == null)
            {
                hModel = new HomeModel();
                Session["Contents"] = hModel;
            }

            return hModel;
        }

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

        public ActionResult Category(string id)
        {
            CategoriesModel cModel = GetCategoriesModelFromSession();
            ProductModel pModel = GetProductModelFromSession();
            CartModel cartModel = GetCartModelFromSession();
            ViewData["Cart"] = cartModel.GetCarts();
            ViewData["Categories"] = cModel.GetCategories();
            ViewData["Products"] = pModel.GetProductsByCategory(id);
            return View();
        }
        public ActionResult Catalog()
        {
            CategoriesModel cModel = GetCategoriesModelFromSession();
            ProductModel pModel = GetProductModelFromSession();
            CartModel cartModel = GetCartModelFromSession();
            ViewData["Cart"] = cartModel.GetCarts();
            ViewData["Categories"] = cModel.GetCategories();
            //ViewData["Products"] = pModel.GetCatalog();
            return View();
        }

        public ActionResult Index()
        {
            //Brings Index Sales Schema
            //HomeModel hModel = GetHomeModelFromSession();

            //Brings all Products data
            ProductModel pModel = GetProductModelFromSession();

            //Brings Category data
            CategoriesModel cModel = GetCategoriesModelFromSession();

            //Brings Carts data
            CartModel cartModel = GetCartModelFromSession();


            //ViewData["Contents"] = hModel.GetContents();
            ViewData["OnSale"] = pModel.GetProductsOnSale();
            ViewData["MainSale"] = pModel.GetMainSales();
            ViewData["Categories"] = cModel.GetCategories();
            ViewData["Cart"] = cartModel.GetCarts();

            return View();
        }

    }
}
