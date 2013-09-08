using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _01.Intro
{
    public partial class DisplayName : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void ButtonDisplayName_Click(object sender, EventArgs e)
        {
            this.LabelDisplayGreeting.Text = "Hello, " + this.TextBoxName.Text;

        }


       
    }
}