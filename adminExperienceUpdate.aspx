<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="adminExperienceUpdate.aspx.cs" Inherits="CVBlog.adminExperienceUpdate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="Form1" runat="server">
        <div class="form-group">
            <div>
                <asp:Label ID="Label5" runat="server" Text="ID:"></asp:Label>
                <asp:TextBox ID="txtId" runat="server" CssClass="form-control"  autocomplete="off"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label ID="Label1" runat="server" Text="Topic:"></asp:Label>
                <asp:TextBox ID="txtTopic" runat="server" CssClass="form-control"  autocomplete="off"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label ID="Label2" runat="server" Text="Subtitle:"></asp:Label>
                <asp:TextBox ID="txtSubtitle" runat="server" CssClass="form-control"  autocomplete="off"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label ID="Label3" runat="server" Text="Description:"></asp:Label>
                <asp:TextBox ID="txtDesc" runat="server" CssClass="form-control" Height="75px" TextMode="MultiLine"  autocomplete="off"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label ID="Label4" runat="server" Text="Date:"></asp:Label>
                <asp:TextBox ID="txtDate" runat="server" CssClass="form-control"  autocomplete="off"></asp:TextBox>
            </div>
            <br />


            <asp:Button ID="btnSave" runat="server" Text="UPDATE" CssClass="btn btn-success" OnClick="btnSave_Click" />
        </div>
    </form>
</asp:Content>
