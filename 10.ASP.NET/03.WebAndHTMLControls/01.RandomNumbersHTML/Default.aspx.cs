using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _01.RandomNumbersHTML
{
    public partial class Default : System.Web.UI.Page
    {
        private Random rand = new Random();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void onButtonClick(object sender, EventArgs e)
        {
            int minNum = int.Parse(this.minNumber.Value);
            int maxNum = int.Parse(this.maxNumber.Value);

            int outputNum = (rand.Next(minNum, maxNum));
            this.output.Value = outputNum.ToString();
        }
    }
}