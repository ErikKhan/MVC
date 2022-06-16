using Microsoft.AspNetCore.Mvc;
using MVC_1stLecture.Models;


namespace MVC_1stLecture.Controllers
{
    public class ProductsController : Controller
    {
        MyDbContext Context;
        public ProductsController(MyDbContext context)
        {
            Context = context;
        }
        public IActionResult Index()
        {
           //One way to Send infotmation to View
            ViewData["ProductInfo"] = "***Here you can find information about the Products***";
            //dynamic mymodel = new ExpandoObject();
            //mymodel.Product = GetProduct();
            //return View(mymodel);

            List<Product> AllProducts = Context.Products.ToList();
            return View(AllProducts);
        }
        public IActionResult GetProduct(Product? Product1)
        {
            //var x = new Product { Id = 1, Name = "Brand New Hp Laptop", Price = 1000.00 };
            //return x;
            return View(Product1);
        }
       
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(int id, string name, double price)
        {
            Product Product = new Product();
            //Product.Id = id;
            Product.Name = name;
            Product.Price = Convert.ToDouble(price);
            Context.Products.Add(Product);
            Context.SaveChanges();

            System.Diagnostics.Debug.WriteLine($"ID: {Product.Id} Name: {Product.Name} Price: {Product.Price}");
                return RedirectToAction("Index", Product);
        }
        public IActionResult Edit(int? id)
        {
            Product Product = Context.Products.FirstOrDefault(x => x.Id == id);
            return View(Product);
        }
        [HttpPost]
        public IActionResult Edit(int id, string name, double price)
        {
            Product Product = Context.Products.FirstOrDefault(x => x.Id == id);
            Product.Name = name;
            Product.Price = Convert.ToDouble(price);
            Context.SaveChanges();
            return RedirectToAction("index");
        }
        public IActionResult Delete(int? id)
        {
            Product Product = Context.Products.FirstOrDefault(x => x.Id == id);
            return View(Product);
        }
        [HttpPost]
        public IActionResult DeleteYes(int? id)
        {
            Product Product = Context.Products.FirstOrDefault(x => x.Id == id);
            Context.Remove(Product);
            Context.SaveChanges();
            return RedirectToAction("index");


        }

    }
}
