Imports System.Data.SqlClient
Public Class PersonaDB
    Private db As New DbHelper()
    'Crear Persona
    Public Function CrearPersona(ByVal pPersona As Models.Persona) As Boolean
        'Lógica para crear una nueva persona en la base de datos
        Using db.GetConnection()
            Dim query As String = "INSERT INTO Personas (TipoDocumento, Documento, Nombre, Apellidos, FechaNac, Correo) 
            VALUES (@TipoDocumento, @Documento, @Nombre, @Apellidos, @FechaNac, @Correo)"


            Dim parameters As New Dictionary(Of String, Object) From {
              {"@Nombre", pPersona.Nombre},
              {"@FechaNac", pPersona.FechaNacimiento},
              {"@Correo", pPersona.Correo}
            }

            'recuerda guardar en git

            db.ExecuteNonQuery(query, parameters)
        End Using
        Return True
    End Function
End Class
