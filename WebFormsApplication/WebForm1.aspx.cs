using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                ltMessage.Text = "Welcome to the Support Form";
            }
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstname.Text;
          //string lastName = txtLastName.Text;
            string email = txtEmail.Text;
         // string description = txtDescription.Text;

            if (!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(email))
            {
                ltMessage.Text = "Your support message has been sent";
              //Page_Load(sender, e);
            } else
            {
                ltMessage.Text = "Please fill out name and email";
            }
        }
    }
}