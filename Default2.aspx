<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<%@ Register Src="~/UserControl1.ascx" TagPrefix="uc1" TagName="UserControl1" %>
<%@ Register Src="~/UserControl2.ascx" TagPrefix="uc1" TagName="UserControl2" %>
<%@ Register Src="~/UserControl3.ascx" TagPrefix="uc1" TagName="UserControl3" %>




<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:UserControl1 runat="server" id="UserControl1" />

            <uc1:UserControl2 runat="server" id="UserControl2" />

            <uc1:UserControl3 runat="server" id="UserControl3" />

        </div>
    </form>
</body>
</html>
