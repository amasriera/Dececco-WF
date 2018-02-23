Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Cheque_proveedor_ent

    'defino las variables
    Friend dt As DataTable
    Friend dr As DataRow
    Friend da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_cheque_proveedor As Int32
    Public ReadOnly Property id_cheque_proveedor() As Int32
        Get
            _id_cheque_proveedor = CInt(dr("id_cheque_proveedor"))
            Return _id_cheque_proveedor
        End Get
    end property

    Private _id_recibo_proveedor As Int32
    Public Property id_recibo_proveedor() As Int32
        Get
            _id_recibo_proveedor = CInt(dr("id_recibo_proveedor"))
            Return _id_recibo_proveedor
        End Get
        Set(ByVal Value As Int32)
            dr("id_recibo_proveedor") = Value
        End Set
    end property

    Private _id_cheque_librado As Int32
    Public Property id_cheque_librado() As Int32
        Get
            _id_cheque_librado = CInt(dr("id_cheque_librado"))
            Return _id_cheque_librado
        End Get
        Set(ByVal Value As Int32)
            dr("id_cheque_librado") = Value
        End Set
    end property

    Private _control As Boolean
    Public Property control() As Boolean
        Get
            _control = CBool(dr("control"))
            Return _control
        End Get
        Set(ByVal Value As Boolean)
            dr("control") = Value
        End Set
    end property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Cheque_proveedor")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Cheque_proveedor_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_cheque_proveedor", SqlDbType.int, 0, "id_cheque_proveedor")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@id_recibo_proveedor", SqlDbType.int, 4, "id_recibo_proveedor")
        da.InsertCommand.Parameters.Add("@id_cheque_librado", SqlDbType.int, 4, "id_cheque_librado")
        da.InsertCommand.Parameters.Add("@control", SqlDbType.bit, 1, "control")

        dr = dt.NewRow()
        dr("id_recibo_proveedor") = 0
        dr("id_cheque_librado") = 0
        dr("control") = False
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idCheque_proveedor As Integer)
        dt = New DataTable("Cheque_proveedor")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Cheque_proveedor WHERE id_cheque_proveedor = @id_Cheque_proveedor", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Cheque_proveedor", idCheque_proveedor)
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
    Public Sub Borrar(ByVal idCheque_proveedor As Integer)
        dt = New DataTable("Cheque_proveedor")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Cheque_proveedor WHERE id_cheque_proveedor = " & _
        idCheque_proveedor, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Cheque_proveedor_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_cheque_proveedor", SqlDbType.Int, 4, "id_cheque_proveedor")
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
               Case "id_cheque_proveedor"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_recibo_proveedor"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_cheque_librado"
                  dc.DataType = Type.GetType("System.Int32")
               Case "control"
                  dc.DataType = Type.GetType("System.Boolean")
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
        dt = New DataTable("Cheque_proveedor")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Cheque_proveedor WHERE id_cheque_proveedor = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cheque_proveedor_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cheque_proveedor_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cheque_proveedor_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Cheque_proveedor As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cheque_proveedor_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_cheque_proveedor", SqlDbType.Int, 4, "id_cheque_proveedor")
        oda.SelectCommand.Parameters("@id_cheque_proveedor").Value = id_Cheque_proveedor

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cheque_proveedor_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_recibo_proveedor", SqlDbType.int, 4, "id_recibo_proveedor")
        oda.SelectCommand.Parameters("@id_recibo_proveedor").Value = Me.id_recibo_proveedor
        oda.SelectCommand.Parameters.Add("@id_cheque_librado", SqlDbType.int, 4, "id_cheque_librado")
        oda.SelectCommand.Parameters("@id_cheque_librado").Value = Me.id_cheque_librado
        oda.SelectCommand.Parameters.Add("@control", SqlDbType.bit, 1, "control")
        oda.SelectCommand.Parameters("@control").Value = Me.control

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
        Command.CommandText = "DELETE FROM Cheque_proveedor"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Cheque_proveedor"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Cheque_proveedor_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campa�a desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Cheque_proveedor")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Cheque_proveedor.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
