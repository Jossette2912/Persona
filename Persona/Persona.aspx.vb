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
        Dim errorMessage As String = ""
        Dim resultado = db.CrearPersona(persona, errorMessage)

        If resultado Then
            SwalUtils.ShowSwal(Me, "Persona creada exitosamente.")
            gvPersonas.DataBind()
        Else
            SwalUtils.ShowSwalError(Me, errorMessage)
        End If
    End Sub

    Protected Sub gvPersonas_RowDeleting(sender As Object, e As GridViewDeleteEventArgs)
        e.Cancel = True ' Cancelar la eliminación predeterminada del GridView
        Dim id As Integer = Convert.ToInt32(gvPersonas.DataKeys(e.RowIndex).Value)
        Dim errorMessage As String = ""
        Dim resultado = db.EliminarPersona(id, errorMessage)
        If resultado Then
            SwalUtils.ShowSwal(Me, "Persona eliminada exitosamente.")
            gvPersonas.DataBind() ' Refrescar el GridView después de eliminar
        Else
            SwalUtils.ShowSwalError(Me, errorMessage)
        End If
    End Sub

    Protected Sub gvPersonas_RowEditing(sender As Object, e As GridViewEditEventArgs)

    End Sub

    Protected Sub gvPersonas_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim selectedRow As GridViewRow = gvPersonas.SelectedRow
        txtDocumento.Text = selectedRow.Cells(3).Text
        txtNombre.Text = HttpUtility.HtmlDecode(selectedRow.Cells(4).Text)
        txtApellidos.Text = selectedRow.Cells(5).Text
        ddlTipoDocumento.SelectedValue = selectedRow.Cells(2).Text
    End Sub
End Class