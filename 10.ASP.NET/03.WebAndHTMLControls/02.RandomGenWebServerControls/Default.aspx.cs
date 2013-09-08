using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _02.RandomGenWebServerControls
{
    public partial class Default : System.Web.UI.Page
    {
        private Random rand = new Random();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int minNum = int.Parse(this.minNumber.Text.ToString());
            int maxNum = int.Parse(this.maxNumber.Text.ToString());

            int outputNum = (rand.Next(minNum, maxNum));
            this.output.Text = outputNum.ToString();
        }
    }
}