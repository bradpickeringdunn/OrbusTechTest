﻿using System;
using System.Web.Mvc;
using OrbusDevTest.DataAccess.Models;
using OrbusDevTest.DataAccess;
using System.Threading.Tasks;
using RestSharp;

namespace OrbusDevTest.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository _productRepository;

        // TODO: Implement IProductRepository to interact with the repository
        public ProductController(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }
        //
        // GET: /Product/
        public ActionResult Index()
        {
            var products = _productRepository.GetProducts();
            // TODO: Get products (This view already exists)
            return View(products);
        }

        //
        // GET: /Product/Details/5
        public ActionResult Details(int id)
        {
            var products = _productRepository.GetProducts();

            // TODO: Get product (Create details view)
            return View();
        }
        
        //
        // GET: /Product/Edit/5
        public ActionResult Edit(int id)
        {
            var product = _productRepository.GetProducts();

            // TODO: Get productto update (Create edit view)
            return View();
        }

        //
        // POST: /Product/Edit/5
        [HttpPost]
        public ActionResult Edit(Product product)
        {
            try
            {
                // TODO: Update product to OAServer
                var updatedProduct = _productRepository.UpdateProduct(product);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Product list
        public ActionResult GetProductListBySubCategory(int subCategoryId)
        {
            var product = _productRepository.GetProductsBySubCateogoryId(subCategoryId);

            return View(product);
            // TODO: Get filtered products list
        }
    }
}
