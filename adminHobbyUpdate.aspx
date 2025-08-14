<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="adminHobbyUpdate.aspx.cs" Inherits="CVBlog.adminHobbyUpdate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
        <form id="Form1" runat="server">
    <div class="form-group">
        <div>
            <asp:Label ID="Label1" runat="server" Text="ID:"></asp:Label>
            <asp:TextBox ID="txtID" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Label ID="Label2" runat="server" Text="Hobby"></asp:Label>
            <asp:TextBox ID="txtHobby" runat="server" CssClass="form-control"  autocomplete="off"></asp:TextBox>
        </div>
        <br />
        



        <asp:Button ID="btnSave" runat="server" Text="SAVE" CssClass="btn btn-success" OnClick="btnSave_Click"  />
    </div>
</form>
</asp:Content>
