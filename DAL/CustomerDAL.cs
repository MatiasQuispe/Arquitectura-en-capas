using ObjetosDeNegocio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CustomerDAL
    {

        // LinkQ consulta
        public List<Customer> GetAll()
        {
            using (var contexto = new NorthwindEntities())
            {
                var query = from c in contexto.Customers
                             select c;
                return query.ToList();
            }
        }

        // LinkQ lamda
        public Customer GetOne( string customerID)
        {
            using (var contexto = new NorthwindEntities())
            {
                var customer = contexto.Customers
                    .FirstOrDefault(c => c.CustomerID == customerID);
                return customer;
            }
        }

        public void Insert(Customer insCustomer)
        {
            using (var contexto = new NorthwindEntities())
            { 
                contexto.Customers.Add(insCustomer);
                contexto.SaveChanges();
            }
        }

        public void Update(Customer updCustomer)
        {
            using (var contexto = new NorthwindEntities())
            {
                var customer = contexto.Customers
                    .FirstOrDefault(c => c.CustomerID == updCustomer.CustomerID);
                contexto.Entry(customer).State = EntityState.Modified;
                contexto.Entry(customer).CurrentValues.SetValues(updCustomer);
                contexto.SaveChanges();
            }
        }

        public void Delete(string customerID)
        {
            using (var contexto = new NorthwindEntities())
            {
                var customer = contexto.Customers
                   .FirstOrDefault(c => c.CustomerID == customerID);
                contexto.Entry(customer).State = EntityState.Deleted;
                contexto.SaveChanges();
            }
        }

    }
}
