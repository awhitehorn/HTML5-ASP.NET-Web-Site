<%@ Page Title="" Language="C#" MasterPageFile="~/main.master" AutoEventWireup="true" CodeFile="Error.aspx.cs" Inherits="Error" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentHolder" Runat="Server">
	<h3><asp:Label ID="lblTitle" runat="server" Text="Unexpected Error" /></h3>
	<br />
	<asp:Label runat="server" ID="lblError" Text="The server encountered an unexpected condition which prevented it from fulfilling the request. Please try again later." />
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="scriptHolder" runat="server">
</asp:Content>

