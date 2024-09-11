<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="adminEducationUpdate.aspx.cs" Inherits="CVBlog.adminEducationUpdate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="Form1" runat="server">
        <div class="form-group">
            <div>
                <asp:Label ID="Label6" runat="server" Text="ID:"></asp:Label>
                <asp:TextBox ID="txtID" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label ID="Label1" runat="server" Text="Topic:"></asp:Label>
                <asp:TextBox ID="txtTopic" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label ID="Label2" runat="server" Text="Subtitle:"></asp:Label>
                <asp:TextBox ID="txtSubtitle" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label ID="Label3" runat="server" Text="Description:"></asp:Label>
                <asp:TextBox ID="txtDesc" runat="server" CssClass="form-control" Height="75px" TextMode="MultiLine"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label ID="Label5" runat="server" Text="GPA:"></asp:Label>
                <asp:TextBox ID="txtGpa" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label ID="Label4" runat="server" Text="Date:"></asp:Label>
                <asp:TextBox ID="txtDate" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            
            <asp:Button ID="btn_Save" runat="server" Text="SAVE" CssClass="btn btn-success" OnClick="btn_Save_Click" />
        </div>
    </form>
</asp:Content>
