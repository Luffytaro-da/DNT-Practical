using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pr4
{
    public partial class Practical_4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Disable unobtrusive validation to avoid jQuery dependency errors usually seen in new VS projects
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                // Retrieve the inputted data
                string participantName = txtName.Text;
                string selectedEvent = ddlEvent.SelectedItem.Text;

                // Read the date from the calendar. If no date is selected, provide a fallback.
                string eventDate = "Not Selected";
                if (calEventDate.SelectedDate != DateTime.MinValue)
                {
                    eventDate = calEventDate.SelectedDate.ToShortDateString();
                }

                // Display success message
                lblResult.Text = $"Registration Successful! Participant: {participantName} | Event: {selectedEvent} | Date: {eventDate}";
            }
        }
    }
}