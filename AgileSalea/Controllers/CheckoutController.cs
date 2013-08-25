using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using AgileSalea.Entities;
using AgileSalea.Models;

namespace AgileSalea.Controllers
{
    public class CheckoutController : Controller
    {
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
        private ProductModel GetProductModelFromSession()
        {
            ProductModel pModel = (ProductModel)Session["Product"];

            if (pModel == null)
            {
                pModel = new ProductModel();
                Session["Product"] = pModel;
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
        //
        // GET: /Checkout/

        public ActionResult Index()
        {
            string total = Request.Form["total"];
            CartModel cartModel = GetCartModelFromSession();
            ProductModel pModel = GetProductModelFromSession();
            CategoriesModel cModel = GetCategoriesModelFromSession();
            ViewData["Cart"] = cartModel.GetCarts();
            ViewData["Categories"] = cModel.GetCategories();
            return View();
        }
        //
        // GET: /Checkout/Cart

        public ActionResult Cart(string id)
        {
            CartModel cartModel = GetCartModelFromSession();
            ProductModel pModel = GetProductModelFromSession();
            CategoriesModel cModel = GetCategoriesModelFromSession();
            cartModel.AddCart(pModel.GetProductByID(Convert.ToInt32(id)), 1);
            ViewData["Categories"] = cModel.GetCategories();
            ViewData["Cart"] = cartModel.GetCarts();
            ViewData["Notification"] = "<strong style=\"color:Red\">Product has been succesfully added to the Shopping cart</strong>";
            return View("Details");
        }

        //
        // GET: /Checkout/Details/5

        public ActionResult Details()
        {
            CartModel cartModel = GetCartModelFromSession();
            ProductModel pModel = GetProductModelFromSession();
            CategoriesModel cModel = GetCategoriesModelFromSession();
            ViewData["Cart"] = cartModel.GetCarts();
            ViewData["Categories"] = cModel.GetCategories();
            return View();
        }

        //
        // GET: /Checkout/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Checkout/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Checkout/Edit/5
 
        public ActionResult Edit()
        {
            string id = Request.Form["txtID"];
            string qty = Request.Form["txtQty"];
            CartModel cartModel = GetCartModelFromSession();
            ProductModel pModel = GetProductModelFromSession();
            CategoriesModel cModel = GetCategoriesModelFromSession();
            cartModel.EditCart(Convert.ToInt32(id), Convert.ToInt32(qty));
            ViewData["Cart"] = cartModel.GetCarts();
            ViewData["Categories"] = cModel.GetCategories();
            return View("Details");
        }

        //
        // POST: /Checkout/Edit/5


        //
        // GET: /Checkout/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Checkout/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
