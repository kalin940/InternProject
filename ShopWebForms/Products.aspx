<%@ Page Title="Products" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="ShopWebForms.Products" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-6">
            <a runat="server" href="~/UserControls">
                <img class="products-pic" src="Content/img/ProductsControls.png" />
            </a>
        </div>
         <div class="col-md-6">
            <a runat="server" href="~/Designs">
                <img class="products-pic" src="Content/img/ProductsDesigns.jpg" />
            </a>        
        </div>
    </div>

    <br />

     <div class="row">
        <h3>New Designs</h3>
         <br />
        <div class="col-md-4">
            <asp:HyperLink ID="HyperLink1" runat="server"></asp:HyperLink>
        </div>
         <div class="col-md-4">
            <p>
                <asp:HyperLink ID="HyperLink2" runat="server"></asp:HyperLink>
            </p>         
        </div>
          <div class="col-md-4">
            <p>
                <asp:HyperLink ID="HyperLink3" runat="server"></asp:HyperLink>
            </p>         
        </div>
    </div>
    <%--<div class="row">
        <h3>New Controls</h3>
         <br />
        <div class="col-md-4">
            <asp:HyperLink ID="HyperLink4" runat="server"></asp:HyperLink>
        </div>
         <div class="col-md-4">
            <p>
                <asp:HyperLink ID="HyperLink5" runat="server"></asp:HyperLink>
            </p>         
        </div>
          <div class="col-md-4">
            <p>
                <asp:HyperLink ID="HyperLink6" runat="server"></asp:HyperLink>
            </p>         
        </div>
    </div>--%>
</asp:Content>
