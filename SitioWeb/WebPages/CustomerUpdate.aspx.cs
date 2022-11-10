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
    public partial class CustomerUpdate : System.Web.UI.Page
    {

        string customerID = string.Empty;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["customerID"] != "")
                customerID = Request.QueryString["customerID"];
            else
                Response.Redirect("CustomerList.aspx");

            if (!IsPostBack)
            {
                ObtenerDatos();
            }
        }

        private void ObtenerDatos()
        {
            var customerBLL = new CustomerBLL();
            var customer = customerBLL.GetOne(customerID);

            TxtCustomerID.Text = customer.CustomerID;
            TxtCompanyName.Text = customer.CompanyName;
            TxtContactName.Text = customer.ContactName;
            TxtContactTitle.Text = customer.ContactTitle;
            TxtAddress.Text = customer.Address;
            TxtCity.Text = customer.City;
            TxtRegion.Text = customer.Region;
            TxtPostalCode.Text = customer.PostalCode;
            TxtCountry.Text = customer.Country;
            TxtPhone.Text = customer.Phone;
            TxtFax.Text = customer.Fax;
        }

        protected void BtnCancelar_Click(object sender, EventArgs e)
        {     
                Response.Redirect("CustomerList.aspx");    
        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            var customerBLL = new CustomerBLL();
            var customer = new Customer {

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
                Fax = TxtFax.Text,
            };

            customerBLL.Update(customer);
            Response.Redirect("CustomerList.aspx");
        }
    }
}