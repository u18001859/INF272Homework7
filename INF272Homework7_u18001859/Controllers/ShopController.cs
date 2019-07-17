using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;

namespace INF272Homework7_u18001859.Controllers
{
    public class ShopController : Controller
    {
        SqlConnection SQLConnect = new SqlConnection("Data Source=LAPTOP-94Q6TNMB;Initial Catalog=INF272Homework7;Integrated Security=True");
        // GET: Shop
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddItem()
        {
            return View();
        }

        public ActionResult Part2()
        {
            return View();
        }

        public ActionResult InsertData(string txtNameP2, string txtDescriptionP2, double txtPriceP2, int txtQuantityP2)
        {
            try
            {
                SqlCommand InserCommand = new SqlCommand("INSERT INTO CPUINFO (Name, Description, Price, QuantityAvailable) VALUES ('" + txtNameP2 + "','" + txtDescriptionP2 + "','" + txtPriceP2 + "','" + txtQuantityP2 + "')", SQLConnect);
                SQLConnect.Open();

                InserCommand.ExecuteNonQuery();

                ViewBag.Message = "The Insert Was Successful.";
            }
            catch (Exception Error)
            {
                ViewBag.Message = "An Error Took Place: " + Error.Message;
            }
            finally
            {
                SQLConnect.Close();
            }
            return View("Part2");
        }
    }
}