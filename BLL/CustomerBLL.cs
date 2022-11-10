using DAL;
using ObjetosDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CustomerBLL
    {

        public List<Customer> GetAll() {
            var customerDAL = new CustomerDAL();
            return customerDAL.GetAll();
        }

        public Customer GetOne(string customerID) { 
            var customerDAL = new CustomerDAL();
            return customerDAL.GetOne(customerID);
        }

        public void Insert(Customer customer)
        {
            var customerDAL = new CustomerDAL();
            customerDAL.Insert(customer);
        }

        public void Update(Customer customer)
        {
            var customerDAL = new CustomerDAL();
            customerDAL.Update(customer);
        }

        public void Delete(string customerID) {
            var customerDAL = new CustomerDAL();
            customerDAL.Delete(customerID);
        }
    }
}
