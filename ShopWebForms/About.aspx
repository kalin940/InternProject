<%@ Page Title="About us" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="ShopWebForms.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>:</h2>
    <h3>Our description page.</h3>
    <div id="about-us-all-info"></div>
    <h2>Our Work:</h2>
    <div id="about-us-our-work">          
       <table>
            <thead>
                <tr>
                    <td>Name</td>
                    <td>Info</td>
                    <td>Site</td>
                    <td>Logo</td>
                </tr>                
            </thead>
            <tbody data-bind="foreach: info">
                <tr>
                    <td><span data-bind="text: Title"></span></td>
                    <td><span class="info-short" data-bind="text: Info"></span></td>  
                    <td><a data-bind="attr: { href: Site, title: Site }, text: Site"></a></td> 
                  <%--<td><span data-bind="text: Logo"></span></td>--%>
                   <td><img data-bind="attr: { src:Logo }" width="150" height="100"/></td>   
                </tr>
            </tbody>
         </table>    
    </div>

     <h2>Contacts:</h2>
     <address id="about-us-address">
        One Microsoft Way<br />
        Redmond, WA 98052-6399<br /> 
    </address>
    <p id="about-us-phone"></p>
    <div id="about-us-email"></div>
    <address>
        <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@example.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@example.com</a>
    </address>    
    <script src="Scripts/jquery.shorten.1.0.js"></script>
    <script src="Scripts/aboutUsInfoLoad.js"></script>

</asp:Content>
