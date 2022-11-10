using BLL;
using ObjetosDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb.WebPages
{
    public partial class CustomerInsert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            var customerBLL = new CustomerBLL();
            var customer = new Customer
            {
                CustomerID = TxtCustomerID.Text,
                CompanyName = TxtCompanyName.Text,
                ContactName = TxtContactName.Text,
                ContactTitle = TxtContactTitle.Text,
                Address = TxtAddress.Text,
                City = TxtCity.Text,
                Region = TxtRegion.Text,
                PostalCode = TxtPostalCode.Text,
                Country = TxtCountry.Text,
                Phone = TxtPhone.Text,
                Fax = TxtFax.Text
            };

            customerBLL.Insert(customer);
            Response.Redirect("CustomerList.aspx");
        }

        protected void BtnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("CustomerList.aspx");
        }
    }
}