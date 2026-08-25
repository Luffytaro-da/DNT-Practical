<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pr5.aspx.cs" Inherits="Pr5.Pr5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 309px;
        }
        .auto-style2 {
            height: 60px;
            font-size: x-large;
        }
        .auto-style3 {
            width: 189px;
        }
    </style>
</head>
<body style="height: 411px; width: 517px">
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2" colspan="2"><strong>Leave Application</strong></td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label1" runat="server" Text="Employee Name:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtEmployeeName" runat="server" Width="200px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label2" runat="server" Text="Leave Date:"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lblDateValue" runat="server"></asp:Label>
                        <asp:LinkButton ID="lnkSelectDate" runat="server" OnClick="lnkSelectDate_Click">Select Date</asp:LinkButton>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label3" runat="server" Text="Leave Type:"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlLeaveType" runat="server" OnSelectedIndexChanged="ddlLeaveType_SelectedIndexChanged">
                            <asp:ListItem>Select Leave Type</asp:ListItem>
                            <asp:ListItem>Sick Leave</asp:ListItem>
                            <asp:ListItem>Casual Leave</asp:ListItem>
                            <asp:ListItem>Function leave</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3" style="vertical-align: top;">
                        <asp:Label ID="Label4" runat="server" Text="Reason:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtReason" runat="server" TextMode="MultiLine" Height="60px" Width="250px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label5" runat="server" Text="Remember Name:"></asp:Label>
                    </td>
                    <td>
                        <asp:CheckBox ID="chkRememberName" runat="server" Text="Remember my name" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td>
                        <asp:Button ID="btnSubmit" runat="server" Text="Submit Leave" OnClick="btnSubmit_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <br />
                        <asp:Label ID="lblResult" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
