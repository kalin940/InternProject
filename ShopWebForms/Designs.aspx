<%@ Page Title="Site Designs" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Designs.aspx.cs" Inherits="ShopWebForms.Designs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Designs:</h3>
    <asp:Repeater ID="DesignsListRepeater" runat="server" OnItemCommand="DesignsListRepeater_ItemCommand">
         <HeaderTemplate>
                <table border="1">
                    <thead>
                        <tr>
                            <th>Name</th>
                            <th>Info</th>
                            <th>Img</th>
                            <th>Date added</th>    
                            <th>Price</th>   
                            <th>Buy</th>                      
                        </tr>
                    </thead>                   
            </HeaderTemplate>
         <ItemTemplate>
                <tr>                   
                    <td>
                        <%--<asp:Label runat="server" ID="lblTitle" Text='<%# Eval("Title") %>'></asp:Label> --%>
                        <asp:HyperLink ID="HyperLink1" runat="server" Text='<%# Eval("Title") %>' NavigateUrl="~/DisplayProduct.aspx"> </asp:HyperLink>
                    </td>  
                    <td>
                        <asp:Label runat="server" ID="lblInfo" Text='<%# Eval("Info") %>'></asp:Label>         
                    </td>    
                    <td>
                        <img runat="server" src='<%# Eval("ImgStr") %>' width="150" height="100"/>
                        <%--<asp:Label runat="server" ID="Label2" Text='<%# Eval("Img") %>'></asp:Label> --%>                           
                    </td>  
                    <td>
                        <asp:Label runat="server" ID="Label3" Text='<%# Eval("Date") %>'></asp:Label>            
                    </td>       
                    <td>
                        <asp:Label runat="server" ID="Label4" Text='<%# Eval("Price") %>'></asp:Label>     
                         
                    </td>   
                    <td>
                        <asp:Button ID="ButtonBuy" runat="server" Text="Buy" OnClick="ButtonBuy_Click" />
                    </td>
                </tr>
            </ItemTemplate>
            <FooterTemplate>
                </tbody>
                </table>
            </FooterTemplate>
    </asp:Repeater>
</asp:Content>
