<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ShopWebForms._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h3>News</h3>
        <p class="lead">Demo</p>        
    </div>
      <div class="jumbotron">
        <h3>News</h3>
        <p class="lead">Demo</p>        
    </div>
      <div class="jumbotron">
        <h3>News</h3>
        <p class="lead">Demo</p>        
    </div>
      <div class="jumbotron">
        <h3>News</h3>
        <p class="lead">Demo</p>        
    </div>
    <div class="row">
        <div class="col-md-12">
            <h2>General Info</h2>
            <div id="default-general-info">
                
            </div>
            <p>
                <a class="btn btn-default" runat="server" href="~/About.aspx">Learn more</a>
            </p>
        </div>
    </div>  
    <script src="Scripts/defaultInfLoad.js"></script>
</asp:Content>

