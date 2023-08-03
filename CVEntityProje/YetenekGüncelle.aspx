<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="YetenekGüncelle.aspx.cs" Inherits="CVEntityProje.YetenekGüncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h4 style="text-align: center; color: red;"> YETENEK GÜNCELLE SAYFASI</h4>

    <br />

    <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeholder="Yetenek"></asp:TextBox>

    <br />

    <center>  
        <asp:Button ID="Button1" runat="server" Text="GÜNCELLE"  CssClass="btn btn-info" Width="300px" OnClick="Button1_Click"  />
    </center>
</asp:Content>
