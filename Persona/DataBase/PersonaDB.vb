Imports System.Data.SqlClient
Imports Persona.Utils
Public Class PersonaDB
    Private db As New DbHealper()
    'Crear Persona
    Public Function CrearPersona(ByVal pPersona As Models.Persona) As Boolean
        'Lógica para crear una nueva persona en la base de datos
        Using db.GetConnection()
            Dim query As String = "INSERT INTO Personas (TipoDocumento, Documento, Nombre, Apellidos, FechaNac, Correo) 
            VALUES (@TipoDocumento, @Documento, @Nombre, @Apellidos, @FechaNac, @Correo)"


            Dim parameters As New Dictionary(Of String, Object) From {
              {"@Nombre", pPersona.Nombre},
              {"@FechaNac", pPersona.FechaNacimiento},
              {"@Correo", pPersona.Correo},
              {"@Apellidos", pPersona.Apellidos},
              {"@Documento", pPersona.NumeroDocumento},
              {"@TipoDocumento", pPersona.TipoDocumento}
            }

            'recuerda guardar en git

            Return db.ExecuteNonQuery(query, parameters)
        End Using
        Return True
    End Function
End Class
