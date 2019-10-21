<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebUi.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

 <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/1.12.4/jquery.js"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/jquery.mask/1.14.0/jquery.mask.js"></script>


    <script>
 
$(document).ready(function(){
$('.para').mask('000.000.000.000.000.00');
});
 
</script>

</head>
<body>
    <form id="form1" runat="server" >
        <div>
            <asp:TextBox ID="txtsayi" runat="server" class="para" ></asp:TextBox>
        </div>
    </form>
</body>
</html>

