Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Persona
    Inherits Persona_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Persona As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Persona", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_persona", SqlDbType.Int, 4, "id_persona")
        oda.SelectCommand.Parameters("@id_persona").Value = id_Persona

        oda.Fill(odt)
        Return odt
    End Function

End Class
