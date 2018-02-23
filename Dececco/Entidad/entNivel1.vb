Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Nivel1_ent

    'defino las variables
    Private dt As DataTable
    Private dr As DataRow
    Private da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_nivel1 As Int32
    Public ReadOnly Property id_nivel1() As Int32
        Get
            _id_nivel1 = CInt(dr("id_nivel1"))
            Return _id_nivel1
        End Get
    end property

    Private _nombre_nivel1 As String
    Public Property nombre_nivel1() As String
        Get
            _nombre_nivel1 = CStr(dr("nombre_nivel1"))
            Return _nombre_nivel1
        End Get
        Set(ByVal Value As String)
            dr("nombre_nivel1") = Value
        End Set
    end property

    Private _saldo_nivel1 As Decimal
    Public Property saldo_nivel1() As Decimal
        Get
            _saldo_nivel1 = CDec(dr("saldo_nivel1"))
            Return _saldo_nivel1
        End Get
        Set(ByVal Value As Decimal)
            dr("saldo_nivel1") = Value
        End Set
    end property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Nivel1")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Nivel1_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_nivel1", SqlDbType.int, 0, "id_nivel1")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@nombre_nivel1", SqlDbType.varchar, 50, "nombre_nivel1")
        da.InsertCommand.Parameters.Add("@saldo_nivel1", SqlDbType.decimal, 9, "saldo_nivel1")

        dr = dt.NewRow()
        dr("nombre_nivel1") = ""
        dr("saldo_nivel1") = 0
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idNivel1 As Integer)
        dt = New DataTable("Nivel1")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Nivel1 WHERE id_nivel1 = @id_Nivel1", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Nivel1", idNivel1)
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
    Public Sub Borrar(ByVal idNivel1 As Integer)
        dt = New DataTable("Nivel1")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Nivel1 WHERE id_nivel1 = " & _
        idNivel1, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Nivel1_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_nivel1", SqlDbType.Int, 4, "id_nivel1")
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
               Case "id_nivel1"
                  dc.DataType = Type.GetType("System.Int32")
               Case "nombre_nivel1"
                  dc.DataType = Type.GetType("System.String")
               Case "saldo_nivel1"
                  dc.DataType = Type.GetType("System.Decimal")
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
        dt = New DataTable("Nivel1")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Nivel1 WHERE id_nivel1 = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Nivel1_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Nivel1_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Nivel1_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Nivel1 As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Nivel1_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_nivel1", SqlDbType.Int, 4, "id_nivel1")
        oda.SelectCommand.Parameters("@id_nivel1").Value = id_Nivel1

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Nivel1_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre_nivel1", SqlDbType.varchar, 50, "nombre_nivel1")
        oda.SelectCommand.Parameters("@nombre_nivel1").Value = Me.nombre_nivel1
        oda.SelectCommand.Parameters.Add("@saldo_nivel1", SqlDbType.decimal, 9, "saldo_nivel1")
        oda.SelectCommand.Parameters("@saldo_nivel1").Value = Me.saldo_nivel1

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
        Command.CommandText = "DELETE FROM Nivel1"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Nivel1"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Nivel1_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campa�a desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Nivel1")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Nivel1.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
