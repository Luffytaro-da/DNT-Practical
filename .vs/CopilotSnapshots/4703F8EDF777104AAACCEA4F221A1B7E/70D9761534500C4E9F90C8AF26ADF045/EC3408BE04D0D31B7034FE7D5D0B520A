<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Practical_4.aspx.cs" Inherits="Pr4.Practical_4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Event Registration</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Online Event Registration Portal</h2>
            <asp:ValidationSummary ID="vsSummary" runat="server" ForeColor="Red" />
            <br />
            <table border="1" cellpadding="5" cellspacing="0">
                <tr>
                    <td>Participant Name:</td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txtName" ErrorMessage="Name is required" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Email:</td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="Email is required" ForeColor="Red">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="Invalid Email format" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>Phone Number:</td>
                    <td>
                        <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvPhone" runat="server" ControlToValidate="txtPhone" ErrorMessage="Phone Number is required" ForeColor="Red">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="revPhone" runat="server" ControlToValidate="txtPhone" ErrorMessage="Invalid Phone Number (10 digits expected)" ForeColor="Red" ValidationExpression="\d{10}">*</asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>Select Event:</td>
                    <td>
                        <asp:DropDownList ID="ddlEvent" runat="server">
                            <asp:ListItem Value="0">--Select Event--</asp:ListItem>
                            <asp:ListItem Value="Workshop">Workshop</asp:ListItem>
                            <asp:ListItem Value="Seminar">Seminar</asp:ListItem>
                            <asp:ListItem Value="Hackathon">Hackathon</asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="rfvEvent" runat="server" ControlToValidate="ddlEvent" ErrorMessage="Please select an event" ForeColor="Red" InitialValue="0">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Gender:</td>
                    <td>
                        <asp:RadioButtonList ID="rblGender" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                            <asp:ListItem Value="Male">Male</asp:ListItem>
                            <asp:ListItem Value="Female">Female</asp:ListItem>
                        </asp:RadioButtonList>
                        <asp:RequiredFieldValidator ID="rfvGender" runat="server" ControlToValidate="rblGender" ErrorMessage="Please select a gender" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Interests:</td>
                    <td>
                        <asp:CheckBoxList ID="cblInterests" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                            <asp:ListItem Value="Coding">Coding</asp:ListItem>
                            <asp:ListItem Value="Design">Design</asp:ListItem>
                            <asp:ListItem Value="Networking">Networking</asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                </tr>
                <tr>
                    <td valign="top">Event Date:</td>
                    <td>
                        <asp:Calendar ID="calEventDate" runat="server"></asp:Calendar>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />
                    </td>
                </tr>
            </table>
            <br />
            <asp:Label ID="lblResult" runat="server" Font-Bold="true" ForeColor="Green"></asp:Label>
        </div>
    </form>
</body>
</html>
