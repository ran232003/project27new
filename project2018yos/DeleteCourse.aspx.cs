﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project2018yos
{
    public partial class DeleteCourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            Courses l = new Courses(txtDeleteCourse.Text);
            if (l.DeleteHotel())
            {
                lblMSN.Text = "The Course has been delete";
                lblMSN.Visible = true;
            }
            else
            {
                lblMSN.Text = "this is not exsist";
                lblMSN.Visible = true;
            }
        }
    }
}