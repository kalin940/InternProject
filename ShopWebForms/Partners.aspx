<%@ Page Title="Our Partners" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Partners.aspx.cs" Inherits="ShopWebForms.Partners" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <div id="partners">
         <table>
            <thead>
                <tr>
                    <td>Name</td>
                    <td>Country</td>
                    <td>Info</td>
                    <td>Site</td>
                    <td>Logo</td>
                </tr>                
            </thead>
            <tbody data-bind="foreach: info">
                <tr>
                    <td><span data-bind="text: Name"></span></td>
                    <td><span data-bind="text: Country"></span></td> 
                    <td><span class="info-short" data-bind="text: Info"></span></td>   
                    <td><a data-bind="attr: { href: Site, title: Site }, text: Site"></a></td> 
                  <%--<td><span data-bind="text: Logo"></span></td>--%>
                   <td><img data-bind="attr: { src:Logo }" width="150" height="100"/></td>   
                </tr>
            </tbody>
         </table>   
    </div>
    <script src="Scripts/jquery.shorten.1.0.js"></script>
    <script src="Scripts/partnersInfoLoad.js"></script>
</asp:Content>
