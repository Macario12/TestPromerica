<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

	<div class="row">
			<div>
				<h2>Login</h2>
				<asp:Label ID="lblUsername" runat="server" Text="Nombre de Usuario:" AssociatedControlID="txtUsername"></asp:Label>
				<asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
				<asp:RequiredFieldValidator ID="rfvUsername" runat="server"
					ControlToValidate="txtUsername"
					ErrorMessage="El nombre de usuario es requerido."
					ForeColor="Red"
					Display="Dynamic" />
				<br />
				<asp:Label ID="lblPassword" runat="server" Text="Contraseña:" AssociatedControlID="txtPassword"></asp:Label>
				<asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
				<asp:RequiredFieldValidator ID="rfvPassword" runat="server"
					ControlToValidate="txtPassword"
					ErrorMessage="La contraseña es requerida."
					ForeColor="Red"
					Display="Dynamic" />
				<br />
				<asp:Button ID="btnSubmit" runat="server" Text="Enviar" OnClick="btnSubmit_Click" />
			</div>
	</div>

</asp:Content>
