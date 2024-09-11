<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="adminHobby.aspx.cs" Inherits="CVBlog.adminHobby" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
            <form id="form2" runat="server">
 
    <table class="table table-bordered" >
        <tr>
            <th>ID</th>
            <th>HOBBY</th>
            <th>UPDATE/DELETE</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <th style=" word-break: normal;"><%# Eval("ID") %></th>
                        <td style=" word-break: normal;"><%# Eval("HOBBY") %></td>
                        <td style="white-space: nowrap;">
                            <asp:HyperLink ID="btnDelete" NavigateUrl='<%# "adminHobbyDelete.aspx?ID=" + Eval("ID") %>' runat="server" CssClass="btn btn-danger ">Delete</asp:HyperLink>
                            <asp:HyperLink ID="btnUpdate" NavigateUrl='<%# "adminHobbyUpdate.aspx?ID=" + Eval("ID") %>' runat="server" CssClass="btn btn-info">Update</asp:HyperLink>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
            <asp:HyperLink ID="btn_add" NavigateUrl="~/adminHobbyAdd.aspx" runat="server" CssClass="btn btn-success">+ ADD</asp:HyperLink>
</form>
</asp:Content>
