﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PRN292_Project.dal;

namespace PRN292_Project
{
    public partial class dskynangsong : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataList2.DataSource = BookDAO.getLifeStyleBooks();
            DataList2.DataBind();
        }
    }
}