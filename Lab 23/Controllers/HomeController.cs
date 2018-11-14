using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab_23.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult RegistrationPage()
        {
            return View();
        }

        public ActionResult WelcomeUser(AddMember newUser)
        {
            if (ModelState.IsValid)
            {
                ViewBag.ConfirmMessage = "Welcome! " + newUser.FirstName;
                return View("Confirm");  //GO HERE DANG IT!!!
            }
            else
            {
                return View("Error"); //So it goes to the Error page fine but it won't go to the confirm page.
            }
        }
        public ActionResult ShoppingList(Item itemName)
        {

        }
        public ActionResult ShoppingList()
        {
            return View();
        }
        public ActionResult AddUser(User userInfo)
        {
            CoffeeShopDBEntities dataBase = new CoffeeShopDBEntities();
            dataBase.Users.Add(userInfo); //Not sure why it's Users instead of the class name User
            dataBase.SaveChanges();
            ViewBag.UserAdded = "Welcome to the Coffee Jungle";
            return View("WelcomeUser");

        }
    }
}