<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="YeniYetenek.aspx.cs" Inherits="CVEntityProje.YeniYetenek" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h4 style="text-align: center; color: red;">YENİ YETENEK EKLEME SAYFASI</h4>

    <br />

    <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeholder="Yetenek"></asp:TextBox>
    
    <br />

    <center>  
        <asp:Button ID="Button1" runat="server" Text="Kaydet"  CssClass="btn btn-info" Width="300px" OnClick="Button1_Click" />
    </center>

</asp:Content>
