﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddCycle.aspx.cs" Inherits="hospital.Follow.AddCycle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="../Css/add.css" type="text/css" media="screen" />
<link rel="stylesheet" href="../Css/bootstrap.css" type="text/css" media="screen" />
</head>
<body>
    <form id="form1" runat="server">
  <div class="div_from_aoto">
      <div class="control-group">
            <label class="laber_from">疾病</label>
            <div class="controls">
                <asp:Label ID="DiseaseT" runat="server" Text=""  class="input_from" ></asp:Label>
              </div>
        </div>
        <div class="control-group">
            <label class="laber_from">周期名称</label>
            <div class="controls"><asp:TextBox ID="name" placeholder=" 请输入周期" class="input_from" runat="server"></asp:TextBox><p class="help-block"></p></div>
        </div>
       <div class="control-group">
            <label class="laber_from"></label>
            <div class="controls">
                <asp:Button ID="AddBtn" runat="server" class="btn btn-success" Text="确定添加" style="width:120px;" OnClick="AddBtn_Click" /></div>
        </div>
      </div>
    </form>
</body>
</html>

