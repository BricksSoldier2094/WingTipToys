<%@ Page Title="Products" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductList.aspx.cs" Inherits="WingTip_Toys.ProductList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <section>

        <div>
            <hgroup>
                <h2><%#: Page.Title %></h2>
            </hgroup>
           
            <asp:ListView ID="productList" runat="server"
                DataKeyNames="ProductID" GroupItemCount="4"
                ItemType="WingTip_Toys.Models.ProductModel" SelectMethod="GetProducts">
                
                <!--Template usada quando nao há dados a serem exibidos-->
                <EmptyDataTemplate>

                    <table>
                        <tr>
                            <td>Não há dados para serem visualizados</td>
                        </tr>
                    </table>

                </EmptyDataTemplate>

                <!--Template vazia-->
                <EmptyItemTemplate>
                    <td />
                </EmptyItemTemplate>

                <!--Usado para agrupar os items-->
                <GroupTemplate>
                    <br id="itemPlaceholderContainer" runat="server" />
                    <td id="itemPlaceholder" runat="server"></td>
                </GroupTemplate>

                <!--Minimamente, para usar um  ListView, precisamos destes dois itens: -->

                <ItemTemplate>
                    <td runat="server">

                        <table>
                            
                            <tr>
                                <td>

                                    <a href="ProductDetails.aspx?productID=<%#: Item.ProductID%>">
                                        <img src="/Catalog/Images/Thumbs/<%#: Item.ImagePath %>"
                                            width="100" height="75" style="border:solid" />
                                    </a>

                                </td>
                            </tr>

                            <tr>
                                <td>

                                    <a href="ProductDetails.aspx?productID=<%#: Item.ProductID %>">
                                        <span>
                                            <%#: Item.ProductName %>
                                        </span>
                                     </a>

                                    <br />
                                    <span>
                                        <b>Preço:</b><%# String.Format("{0:c}",Item.UnitPrice)%>
                                    </span>
                                    <br />

                                </td>
                            </tr>
                            
                            <tr>
                                <td>$nbsp;</td>
                            </tr>

                            </p>

                        </table>
                        
                    </td>
                </ItemTemplate>

                <LayoutTemplate>
                    <table style="width:100%;">
                        <tbody>
                            <tr>
                                <td>
                                    <table id ="groupPlaceholderContainer" runat="server" style="width:100%">
                                        <tr id="groupPlaceholder"></tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td></td>
                            </tr>
                        </tbody>
                    </table>
                </LayoutTemplate>

            </asp:ListView>
        
        </div>

    </section>

</asp:Content>
