﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuizPortal
{
    public partial class admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] != null && Session["Role"] == "Admin")
            {
                wlcmsg.Text = "Welcome Admin : " + Session["Username"];
            }
        }
    }
}