﻿<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="adminSkillsAdd.aspx.cs" Inherits="CVBlog.adminSkillsAdd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="Form1" runat="server">
    <div class="form-group">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Skill:"></asp:Label>
            <asp:TextBox ID="txtSkill" runat="server" CssClass="form-control"  autocomplete="off"></asp:TextBox>
        </div>
        <br />
       

        <asp:Button ID="btnSave" runat="server" Text="SAVE" CssClass="btn btn-success" OnClick="btnSave_Click"  />
    </div>
</form>
</asp:Content>
