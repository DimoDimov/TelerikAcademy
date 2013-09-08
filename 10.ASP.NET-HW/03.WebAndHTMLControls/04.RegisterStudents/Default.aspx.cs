using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _04.RegisterStudents
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string inputFNameStr = Server.HtmlEncode(this.inputFirstName.Value);
            string inputLNameStr = Server.HtmlEncode(this.inputLastName.Value);
            string inputFacultyNumStr = Server.HtmlEncode(this.inputFacultyNumber.Value);
            string inputUnivercitiesStr = Server.HtmlEncode(this.inputUniversity.SelectedItem.Text);
            string inputSpecialtyStr = Server.HtmlEncode(this.inputSpecialty.SelectedItem.Text);
            var inputCoursesAll = this.inputCourses.Items;

            var sb = new StringBuilder();

            for (int i = 0; i < inputCoursesAll.Count; i++)
            {
                if (inputCoursesAll[i].Selected)
                {
                    sb.Append(inputCoursesAll[i].Text);
                    sb.Append(", ");
                }
            }

            sb.Length = sb.Length - 2;
           
            string inputCoursesSelectedStr = sb.ToString();

            this.outputFName.Value = inputFNameStr;
            this.outputLName.Value = inputLNameStr;
            this.outputFaculty.Value = inputFacultyNumStr;
            this.outputUniversity.Value = inputUnivercitiesStr;
            this.outputSpecialty.Value = inputSpecialtyStr;
            this.outputCourses.Value = inputCoursesSelectedStr;
            
        }

    }
}