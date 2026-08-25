using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pr5
{
    public partial class Calendar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["LeaveDate"] != null)
                {
                    DateTime selectedDate;
                    if (DateTime.TryParse(Session["LeaveDate"].ToString(), out selectedDate))
                    {
                        calLeaveDate.SelectedDate = selectedDate;
                        calLeaveDate.VisibleDate = selectedDate;
                        lblSelectedDate.Text = selectedDate.ToString("dd-MM-yyyy");
                    }
                }
            }
        }

        protected void calLeaveDate_SelectionChanged(object sender, EventArgs e)
        {
            lblSelectedDate.Text = calLeaveDate.SelectedDate.ToString("dd-MM-yyyy");
        }

        protected void lnkRequestLeave_Click(object sender, EventArgs e)
        {
            if (calLeaveDate.SelectedDate != DateTime.MinValue)
            {
                Session["LeaveDate"] = calLeaveDate.SelectedDate.ToString("dd-MM-yyyy");
                Response.Redirect("Pr5.aspx");
            }
        }
    }
}
