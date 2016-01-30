<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Image_Sharing_Site._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        <asp:FileUpload ID="fileUpload" runat="server"/>
        <asp:Button ID="btUpload" Text="Upload" runat="server" OnClick="btUpload_Click" />
    
    </div>
    </form>
</body>
</html>
