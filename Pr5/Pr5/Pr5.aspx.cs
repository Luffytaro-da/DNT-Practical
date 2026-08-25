using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pr5
{
    public partial class Pr5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["LeaveDate"] != null)
                {
                    lblDateValue.Text = Session["LeaveDate"].ToString();
                }
                else
                {
                    lblDateValue.Text = DateTime.Now.ToString("dd-MM-yyyy");
                }

                if (Request.Cookies["EmployeeName"] != null)
                {
                    txtEmployeeName.Text = Request.Cookies["EmployeeName"].Value;
                    chkRememberName.Checked = true;
                }
            }
        }

        protected void lnkSelectDate_Click(object sender, EventArgs e)
        {
            // Save state before leaving
            Session["EmployeeName"] = txtEmployeeName.Text;
            Session["LeaveType"] = ddlLeaveType.SelectedValue;
            Session["Reason"] = txtReason.Text;

            Response.Redirect("Calendar.aspx");
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Session["EmployeeName"] = txtEmployeeName.Text;
            Session["LeaveType"] = ddlLeaveType.SelectedValue;
            Session["Reason"] = txtReason.Text;

            if (chkRememberName.Checked)
            {
                HttpCookie nameCookie = new HttpCookie("EmployeeName");
                nameCookie.Value = txtEmployeeName.Text;
                nameCookie.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Add(nameCookie);
            }
            else
            {
                if (Request.Cookies["EmployeeName"] != null)
                {
                    HttpCookie nameCookie = new HttpCookie("EmployeeName");
                    nameCookie.Expires = DateTime.Now.AddDays(-1);
                    Response.Cookies.Add(nameCookie);
                }
            }

            lblResult.Text = $"<b>Leave Application Submitted:</b><br />" +
                             $"Employee Name: {Session["EmployeeName"]}<br />" +
                             $"Leave Date: {lblDateValue.Text}<br />" +
                             $"Leave Type: {Session["LeaveType"]}<br />" +
                             $"Reason: {Session["Reason"]}";
        }

        protected void ddlLeaveType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}