<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Yeteneklerim.aspx.cs" Inherits="CVEntityProje.Hakkımda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table class="table table-bordered" style="margin-left: 20px">
        <tr>
            <th>ID</th>
            <th>YETENEK</th>
            <th>DERECE</th>
            <th>SİL</th>
            <th>GÜNCELLE</th>
        </tr>

        <asp:Repeater ID="Repeater1" runat="server">

            <ItemTemplate>
                <tr>
                    <td><%#Eval("ID") %></td>
                    <td><%#Eval("YETENEK") %></td>
                    <td><%#Eval("DERECE") %></td>
                    <td><asp:HyperLink ID="HyperLink1" runat="server" CssClass="btn btn-danger" NavigateUrl='<%# "YetenekSil.aspx?ID=" + Eval("ID") %>'>SİL</asp:HyperLink></td>
                   <td><asp:HyperLink ID="HyperLink2" CssClass="btn btn-warning" runat="server" NavigateUrl='<%#"YetenekGüncelle.aspx?ID=" + Eval("ID") %>'>GÜNCELLE</asp:HyperLink></td>
                </tr>
            </ItemTemplate>

        </asp:Repeater>

    </table>

    <a href="YeniYetenek.Aspx" class="btn btn-primary">Yeni Yetenek Ekle</a>

</asp:Content>
