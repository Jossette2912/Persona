Imports Persona.Utils

Public Class Persona
    Inherits System.Web.UI.Page
    Private db As New PersonaDB()
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnGuardar_Click(sender As Object, e As EventArgs)
        Dim persona As New Models.Persona()

        'Validar campos obligatorios 
        If txtFechaNac.Text = "" Then
            lblResultado.Text = "Por favor, complete todos los campos obligatorios."
            Return
        End If

        persona.Nombre = txtNombre.Text.Trim()
        persona.Apellidos = txtApellidos.Text.Trim()
        persona.FechaNacimiento = txtFechaNac.Text.Trim()
        persona.Correo = txtCorreo.Text.Trim()
        persona.TipoDocumento = ddlTipoDocumento.SelectedItem.Value
        persona.NumeroDocumento = txtDocumento.Text.Trim()

        lblResultado.Text = persona.Resumen()
        Dim resultado = db.CrearPersona(persona)

        If resultado Then
            SwalUtils.ShowSwal(Me, "Persona creada exitosamente.")
            gvPersonas.DataBind()
        Else
            SwalUtils.ShowSwalError(Me, "No se pudo crear persona.")
        End If
    End Sub
End Class