using System;
using System.Linq;
using _01.UsingEntityFrameworkForNorthwind;

namespace NorthWind.Client
{
    public static class DAO
    {
        //02.Create a DAO class with static methods which provide functionality for 
        //inserting, modifying and deleting customers. Write a testing class.

        public static void InsertCustomer(
            string CustomerID,
            string CompanyName, 
            string ContactName = null,
            string City = null,
            string ContactTitle = null,
            string Address = null,
            string Region = null,
            string PostalCode = null,
            string Country = null,
            string Phone = null,
            string Fax = null
            )
        {
            using (var db = new NORTHWINDEntities()) 
            { 
                var newCustomer = new Customer{
                    CustomerID = CustomerID,
                    CompanyName = CompanyName,
                    City = City,
                    ContactName = ContactName,
                    ContactTitle = ContactTitle,
                    Address = Address,
                    Region = Region,
                    PostalCode = PostalCode,
                    Country = Country,
                    Phone = Phone,
                    Fax = Fax,
                };

                db.Customers.Add(newCustomer);
                db.SaveChanges();
            }
        }

        public static void DeleteCustomer(string customerID)
        {
            using (var db = new NORTHWINDEntities())
            {
                var customerToRemove = db.Customers.Find(customerID);
                db.Customers.Remove(customerToRemove);
                db.SaveChanges();
            }
        }

        public static void ModifyCustomer(string customerID, string companyName)
        {
            using (var db = new NORTHWINDEntities())
            {
                var customerToModify = db.Customers.Find(customerID);
                customerToModify.CompanyName = companyName;
                db.SaveChanges();
            }
        }

        //03. Write a method that finds all customers who have orders made in 1997 and shipped to Canada.

        public static void PrintOrders(string country, int year)
        {
            using (var db = new NORTHWINDEntities())
            {
                var orders = db.Orders.Where(
                    o => o.OrderDate.Value.Year == year &&
                        o.ShipCountry == country).GroupBy(o => o.Customer.ContactName);

                
                int n = 1;

                foreach (var order in orders)
                {
                    Console.WriteLine("{0}. {1}", n, order.Key);
                    n++;
                }
            }
        }

        //04. Implement previous by using native SQL query and executing it through the ObjectContext.

        public static void PrintOrdersWithSQL(int year, string country)
        {
            using (var db = new NORTHWINDEntities())
            {
                string commandStringSQL =
                "SELECT c.CustomerID " +
                "FROM Customers c " +
                "JOIN Orders o " +
                "ON c.CustomerID = o.CustomerID " +
                "WHERE YEAR(o.OrderDate) = {0} " +
                "AND o.ShipCountry = {1} " +
                "group by c.CustomerID";

                object[] parameters = {year, country};
                var customers = db.Database.SqlQuery<string>(commandStringSQL, parameters);

                foreach (var item in customers)
                {
                    Console.WriteLine(item);
                }
            }
        }

        //05.Write a method that finds all the sales by specified region and period (start / end dates).

        public static void PrintSalesByRegionAndPeriod(DateTime startDate, DateTime endDate, string region)
        {
            using (var db = new NORTHWINDEntities())
            {
                var sales = db.Orders.Where(
                    (s => s.ShipRegion == region &&
                    s.OrderDate > startDate &&
                    s.OrderDate < endDate))
                    .Select(s => new {ShipDate2 = s.ShippedDate, Region2 = s.ShipRegion });

                //var sales = db.Orders.Where(
                //    s => s.ShipRegion == region &&
                //    s.OrderDate > startDate &&
                //    s.OrderDate < endDate);

                foreach (var sale in sales)
                {
                    Console.WriteLine("{0} - {1}", sale.ShipDate2, sale.Region2);
                }


            }
        }

        //06.Create a database called NorthwindTwin with the same structure as 
        //Northwind using the features from DbContext. Find for the API for 
        //schema generation in MSDN or in Google.



    }
}
