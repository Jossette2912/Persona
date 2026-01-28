<%@ Page Title="Persona" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Persona.aspx.vb" Inherits="Persona.Persona" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    

    <div class="form-group">
        <asp:Label ID="lblTipoDoc" runat="server" Text="Tipo de Documento" CssClass="control-label"></asp:Label>

        <asp:DropDownList ID="ddlTipoDocumento" runat="server" CssClass="form-control">
            <asp:ListItem Text="Seleccione un tipo de documento" />
            <asp:ListItem Text="Cédula Fisica" Value="1"></asp:ListItem>
            <asp:ListItem Text="Cédula Jurídica" Value="2" />
            <asp:ListItem Text="Pasaporte" Value="3" />
        </asp:DropDownList>


    </div>

    <div class="form-group">
        <asp:Label ID="lblNumDoc" runat="server" Text="Documento" CssClass="control-label"></asp:Label>
        <asp:TextBox ID="txtDocumento" runat="server" placeholder="" CssClass="form-control"></asp:TextBox>
    </div>

    <div class="form-group">
        <asp:Label ID="lblNombre" runat="server" Text="Nombre" CssClass="control-label"></asp:Label>
        <asp:TextBox ID="txtNombre" runat="server" placeholder="Jossette" CssClass="form-control"></asp:TextBox>
    </div>

    <div class="form-group">
        <asp:Label ID="lblApellidos" runat="server" Text="Apellidos" CssClass="control-label"></asp:Label>
        <asp:TextBox ID="txtApellidos" runat="server" placeholder="Garcia Gaitan" CssClass="form-control"></asp:TextBox>
    </div>

    <div class="form-group">
        <asp:Label ID="lblFechaNac" runat="server" Text="Fecha Nacimiento" CssClass="control-label"></asp:Label>
        <asp:TextBox ID="txtFechaNac" runat="server" placeholder="29/12/96" CssClass="form-control" TextMode="Date"></asp:TextBox>
    </div>

    <div class="form-group">
        <asp:Label ID="lblCorreo" runat="server" Text="Correo" CssClass="control-label"></asp:Label>
        <asp:TextBox ID="txtCorreo" runat="server" placeholder="jkgarciag@edu.uc.ac.cr" CssClass="form-control" ></asp:TextBox>
    </div>

    <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="btn btn-primary my-2" OnClick="btnGuardar_Click" />
    <asp:Label ID="lblResultado" runat="server" Text="" CssClass="control-label"></asp:Label>
</asp:Content>
