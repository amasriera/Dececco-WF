Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Temp_actividad_proyecto_ent

    'defino las variables
    Friend dt As DataTable
    Friend dr As DataRow
    Friend da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_temp_actividad_proyecto As Int32
    Public ReadOnly Property id_temp_actividad_proyecto() As Int32
        Get
            _id_temp_actividad_proyecto = CInt(dr("id_temp_actividad_proyecto"))
            Return _id_temp_actividad_proyecto
        End Get
    end property

    Private _id_actividad As Int32
    Public Property id_actividad() As Int32
        Get
            _id_actividad = CInt(dr("id_actividad"))
            Return _id_actividad
        End Get
        Set(ByVal Value As Int32)
            dr("id_actividad") = Value
        End Set
    end property

    Private _id_proyecto As Int32
    Public Property id_proyecto() As Int32
        Get
            _id_proyecto = CInt(dr("id_proyecto"))
            Return _id_proyecto
        End Get
        Set(ByVal Value As Int32)
            dr("id_proyecto") = Value
        End Set
    end property

    Private _id_actividad_proyecto As Int32
    Public Property id_actividad_proyecto() As Int32
        Get
            _id_actividad_proyecto = CInt(dr("id_actividad_proyecto"))
            Return _id_actividad_proyecto
        End Get
        Set(ByVal Value As Int32)
            dr("id_actividad_proyecto") = Value
        End Set
    end property

    Private _id_usuario As Int32
    Public Property id_usuario() As Int32
        Get
            _id_usuario = CInt(dr("id_usuario"))
            Return _id_usuario
        End Get
        Set(ByVal Value As Int32)
            dr("id_usuario") = Value
        End Set
    end property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Temp_actividad_proyecto")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Temp_actividad_proyecto_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_temp_actividad_proyecto", SqlDbType.int, 0, "id_temp_actividad_proyecto")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@id_actividad", SqlDbType.int, 4, "id_actividad")
        da.InsertCommand.Parameters.Add("@id_proyecto", SqlDbType.int, 4, "id_proyecto")
        da.InsertCommand.Parameters.Add("@id_actividad_proyecto", SqlDbType.int, 4, "id_actividad_proyecto")
        da.InsertCommand.Parameters.Add("@id_usuario", SqlDbType.int, 4, "id_usuario")

        dr = dt.NewRow()
        dr("id_actividad") = 0
        dr("id_proyecto") = 0
        dr("id_actividad_proyecto") = 0
        dr("id_usuario") = 0
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idTemp_actividad_proyecto As Integer)
        dt = New DataTable("Temp_actividad_proyecto")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Temp_actividad_proyecto WHERE id_temp_actividad_proyecto = @id_Temp_actividad_proyecto", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Temp_actividad_proyecto", idTemp_actividad_proyecto)
        da.Fill(dt)
        Me.AsignarTipos()
        If dt.Rows.Count = 0 Then
            Throw New Exception("No se a encontrado el Registro")
        Else
            dr = dt.Rows(0)
        End If
        CrearComandoUpdate()
    End Sub

    'procedimiento borrar
    Public Sub Borrar(ByVal idTemp_actividad_proyecto As Integer)
        dt = New DataTable("Temp_actividad_proyecto")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Temp_actividad_proyecto WHERE id_temp_actividad_proyecto = " & _
        idTemp_actividad_proyecto, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Temp_actividad_proyecto_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_temp_actividad_proyecto", SqlDbType.Int, 4, "id_temp_actividad_proyecto")
            dt.Rows(0).Delete()
            CrearComandoUpdate()
            Guardar()
        Catch ex As Exception
            If Err.Number = 5 Then
            End If
        End Try
    End Sub

    'asigno el tipo de datos a los parametros
    Private Sub AsignarTipos()
        For Each dc As DataColumn In dt.Columns
            Select Case dc.ColumnName
               Case "id_temp_actividad_proyecto"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_actividad"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_proyecto"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_actividad_proyecto"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_usuario"
                  dc.DataType = Type.GetType("System.Int32")
            End Select
        Next
    End Sub

    'creo el commandbuilder
    Private Sub CrearComandoUpdate()
        Dim cmd As New SqlCommandBuilder(da)
        da.UpdateCommand = cmd.GetUpdateCommand
    End Sub

    'cancelo los cambios del datatable
    Public Sub Cancelar()
        dt.Clear()
    End Sub

    'asigno el datatable
    Public Function DataTable() As DataTable
        Return dt
    End Function

    'actualizo la base de datos
    Public Sub Guardar()
        da.Update(dt)
    End Sub

    'funcion que carga el datatable
    Public Function Cargar() As DataTable
        dt = New DataTable("Temp_actividad_proyecto")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Temp_actividad_proyecto WHERE id_temp_actividad_proyecto = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Temp_actividad_proyecto_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Temp_actividad_proyecto_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Temp_actividad_proyecto_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Temp_actividad_proyecto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Temp_actividad_proyecto_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_temp_actividad_proyecto", SqlDbType.Int, 4, "id_temp_actividad_proyecto")
        oda.SelectCommand.Parameters("@id_temp_actividad_proyecto").Value = id_Temp_actividad_proyecto

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Temp_actividad_proyecto_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_actividad", SqlDbType.int, 4, "id_actividad")
        oda.SelectCommand.Parameters("@id_actividad").Value = Me.id_actividad
        oda.SelectCommand.Parameters.Add("@id_proyecto", SqlDbType.int, 4, "id_proyecto")
        oda.SelectCommand.Parameters("@id_proyecto").Value = Me.id_proyecto
        oda.SelectCommand.Parameters.Add("@id_actividad_proyecto", SqlDbType.int, 4, "id_actividad_proyecto")
        oda.SelectCommand.Parameters("@id_actividad_proyecto").Value = Me.id_actividad_proyecto
        oda.SelectCommand.Parameters.Add("@id_usuario", SqlDbType.int, 4, "id_usuario")
        oda.SelectCommand.Parameters("@id_usuario").Value = Me.id_usuario

        oda.Fill(odt)
        Total = CInt(odt.Rows(0).Item("Total").ToString)
        If Total = 0 Then
            Return False  'NO EXISTE
        Else
            Return True 'SI EXISTE
        End If
    End Function

    'borra todos los datos de la tabla
    Public Sub BorrarTodo()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "DELETE FROM Temp_actividad_proyecto"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Temp_actividad_proyecto"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Temp_actividad_proyecto_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campa�a desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Temp_actividad_proyecto")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Temp_actividad_proyecto.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
