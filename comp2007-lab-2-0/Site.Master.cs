using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace comp2007_lab_2_0
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            addActiveClass();
        }
         
        /** This function add active class to the links in the header
         * 
         * @return page.title gives the page title to active
         *
         * */

        private string addActiveClass()
        { 
            switch(Page.Title)
            {
                case "Home Page":
                    Home.Attributes.Add("class", "active");
                    break;
                case "Products":
                    Product.Attributes.Add("class", "active");
                    break;
                case "Contact":
                    Contact.Attributes.Add("class", "active");
                    break;
                case "About":
                    About.Attributes.Add("class", "active");
                    break;
                case "Services":
                    Services.Attributes.Add("class", "active");
                    break;
            }
            return Page.Title;
        }
    }
}