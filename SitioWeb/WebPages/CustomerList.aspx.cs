using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb.WebPages
{
    public partial class CustomerList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            ObtenerDatos();
        }

        private void ObtenerDatos()
        {
            var customerBLL = new CustomerBLL();
            GrdCustomers.DataSource = customerBLL.GetAll();
            GrdCustomers.DataBind();
        }

        protected void GrdCustomers_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes.Add("OnMouseOver", "this.style.cursor='pointer';");
                e.Row.ToolTip = "Click en la fila para seleccionarla";
            }
        }

        protected override void Render(HtmlTextWriter writer)
        {
            foreach (GridViewRow row in GrdCustomers.Rows)
            {
                row.Attributes.Add("onclick", Page.ClientScript.GetPostBackEventReference
                    (GrdCustomers, "Select$" + row.RowIndex.ToString(), true));
            }

            base.Render(writer);
        }

        protected void GrdCustomers_OnPageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GrdCustomers.PageIndex = e.NewPageIndex;
            ObtenerDatos();
        }

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("CustomerInsert.aspx");
        }

        protected void BtnModificar_Click(object sender, EventArgs e)
        {
            string customerID = null;

            if(GrdCustomers.SelectedIndex != -1)
            {
                customerID = GrdCustomers.SelectedRow.Cells[0].Text;
                Response.Redirect("CustomerUpdate.aspx?customerID=" + customerID);
            }
        }

        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            string customerID = null;

            if (GrdCustomers.SelectedIndex != -1)
            {
                customerID = GrdCustomers.SelectedRow.Cells[0].Text;
                Response.Redirect("CustomerDelete.aspx?customerID=" + customerID);
            }
        }
    }
}