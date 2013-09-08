using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _03.TextBoxValueExchange
{
    public partial class Defalut : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string inputText = Server.HtmlEncode(this.inputBox.Text.ToString());
            this.outputBox.Text = inputText;
            this.outputLabel.Text = inputText;
            this.outputLiteral.Text = inputText;
        }
    }
}