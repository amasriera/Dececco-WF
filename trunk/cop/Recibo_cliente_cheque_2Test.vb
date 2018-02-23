Imports System.Data

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports Dececco



'''<summary>
'''Se trata de una clase de prueba para Recibo_cliente_cheque_2_entTest y se pretende que
'''contenga todas las pruebas unitarias Recibo_cliente_cheque_2_entTest. 
'''</summary>
<TestClass()> _
Public Class Recibo_cliente_cheque_2Test


   Private testContextInstance As TestContext

   '''<summary>
   '''Obtiene o establece el contexto de la prueba que proporciona
   '''la informaci�n y funcionalidad para la ejecuci�n de pruebas actual. 
   '''</summary>
   Public Property TestContext() As TestContext
       Get
           Return testContextInstance
       End Get
       Set(ByVal value As TestContext) 
           testContextInstance = value
       End Set
   End Property

#Region "Atributos de prueba adicionales"
   '
   'Puede utilizar los siguientes atributos adicionales mientras escribe sus pruebas: 
   '
   'Use ClassInitialize para ejecutar c�digo antes de ejecutar la primera prueba en la clase 
   '<ClassInitialize()>  _
   'Public Shared Sub MyClassInitialize(ByVal testContext As TestContext) 
   'End Sub
   '
   'Use ClassCleanup para ejecutar c�digo despu�s de haber ejecutado todas las pruebas en una clase
   '<ClassCleanup()>  _
   'Public Shared Sub MyClassCleanup()
   'End Sub
   '
   'Use TestInitialize para ejecutar c�digo antes de ejecutar cada prueba
   '<TestInitialize()>  _
   'Public Sub MyTestInitialize()
   'End Sub
   '
   'Use TestCleanup para ejecutar c�digo despu�s de que se hayan ejecutado todas las pruebas
   '<TestCleanup()>  _
   'Public Sub MyTestCleanup()
   'End Sub
   '
#End Region


   '''<summary>
    '''Una prueba de Modificar
    '''</summary>
   <TestMethod()> _
   Public Sub ModificarRecibo_cliente_cheque_2Test()
       Dim target As Recibo_cliente_cheque_2_ent = New Recibo_cliente_cheque_2_ent ' TODO: Inicializar en un valor adecuado
       Dim expected As DataTable = Nothing ' TODO: Inicializar en un valor adecuado
       target.Truncate()
       target.InsertOne()
       target.Cargar()
       target.Modificar(1) 
       target.nombre_Recibo_cliente_cheque_2 = "modificado"
       target.Guardar()

       Dim dt As DataTable = New DataTable
       dt = target.ConsultarTodo
       Assert.IsTrue(CBool(dt.Rows(0).Item("nombre_Recibo_cliente_cheque_2").ToString = "modificado"),"no: " & dt.Rows(0).Item("nombre_Recibo_cliente_cheque_2").ToString)
   End Sub

   '''<summary>
   '''Una prueba de Insertar
   '''</summary>
   <TestMethod()> _
   Public Sub InsertarRecibo_cliente_cheque_2Test()
       Dim target As Recibo_cliente_cheque_2_ent = New Recibo_cliente_cheque_2_ent ' TODO: Inicializar en un valor adecuado

       target.Truncate()
       target.InsertOne()
       target.Cargar()
       target.Insertar()
       target.nombre_Recibo_cliente_cheque_2 = "prueba"
       target.Guardar()

       Dim dt As DataTable = New DataTable
       dt = target.ConsultarTodo

       Assert.IsTrue(dt.Rows.Count = 2, "son: " & dt.Rows.Count & " registros")
   End Sub

   '''<summary>
   '''Una prueba de GetOne
   '''</summary>
   <TestMethod()> _
   Public Sub GetOneRecibo_cliente_cheque_2Test()
       Dim target As Recibo_cliente_cheque_2_ent = New Recibo_cliente_cheque_2_ent ' TODO: Inicializar en un valor adecuado
       Dim id_Recibo_cliente_cheque_2 As Integer = 1 ' TODO: Inicializar en un valor adecuado
       Dim expected As DataTable = Nothing ' TODO: Inicializar en un valor adecuado
       Dim actual As DataTable

       target.Truncate()
       target.InsertOne()

       actual = target.GetOne(id_Recibo_cliente_cheque_2)

       Assert.IsTrue(actual.Rows.Count = 1, "son: " & actual.Rows.Count & " registros")
   End Sub

   '''<summary>
   '''Una prueba de GetCmb
   '''</summary>
   <TestMethod()> _
   Public Sub GetCmbRecibo_cliente_cheque_2Test()
       Dim target As Recibo_cliente_cheque_2_ent = New Recibo_cliente_cheque_2_ent ' TODO: Inicializar en un valor adecuado
       Dim expected As DataTable = Nothing ' TODO: Inicializar en un valor adecuado
       Dim actual As DataTable

       target.Truncate()
       target.InsertOne()

       actual = target.GetCmb

       Assert.IsTrue(actual.Rows.Count = 1, "son: " & actual.Rows.Count & " registros")
   End Sub

   '''<summary>
   '''Una prueba de Exist
   '''</summary>
   <TestMethod()> _
   Public Sub ExistRecibo_cliente_cheque_2Test()
       Dim target As Recibo_cliente_cheque_2_ent = New Recibo_cliente_cheque_2_ent ' TODO: Inicializar en un valor adecuado
       Dim expected As Boolean = False ' TODO: Inicializar en un valor adecuado
       Dim actual As Boolean

       target.Truncate()
       target.InsertOne()

       target.Modificar(1) 
       target.nombre_Recibo_cliente_cheque_2 = "prueba"
       target.Guardar()

       actual = target.Exist

       Assert.IsTrue(actual = True, "no: " & actual) 
   End Sub

   '''<summary>
   '''Una prueba de ConsultarTodo
   '''</summary>
   <TestMethod()> _
   Public Sub ConsultarTodoRecibo_cliente_cheque_2Test()
       Dim target As Recibo_cliente_cheque_2_ent = New Recibo_cliente_cheque_2_ent ' TODO: Inicializar en un valor adecuado
       Dim expected As DataTable = Nothing ' TODO: Inicializar en un valor adecuado
       Dim actual As DataTable

       target.Truncate()
       target.InsertOne()
       target.Cargar()
       target.Insertar()
       target.nombre_Recibo_cliente_cheque_2 = "prueba"
       target.Guardar()

       actual = target.ConsultarTodo

       Assert.IsTrue(actual.Rows.Count = 2, "son: " & actual.Rows.Count & " registros")
   End Sub

   '''<summary>
   '''Una prueba de Buscar
   '''</summary>
   <TestMethod()> _
   Public Sub BuscarRecibo_cliente_cheque_2Test()
       Dim target As Recibo_cliente_cheque_2_ent = New Recibo_cliente_cheque_2_ent ' TODO: Inicializar en un valor adecuado
       Dim Nombre As String = "pru" ' TODO: Inicializar en un valor adecuado
       Dim expected As DataTable = Nothing ' TODO: Inicializar en un valor adecuado
       Dim actual As DataTable

       target.Truncate()
       target.InsertOne()
       target.Cargar()
       target.Insertar()
       target.nombre_Recibo_cliente_cheque_2 = "prueba"
       target.Guardar()

       target.Insertar()
       target.nombre_Recibo_cliente_cheque_2 = "prudente"
       target.Guardar()

       actual = target.Buscar(Nombre) 

       Assert.IsTrue(actual.Rows.Count = 2, "son: " & actual.Rows.Count & " registros")
   End Sub

   '''<summary>
   '''Una prueba de Borrar
   '''</summary>
   <TestMethod()> _
   Public Sub BorrarRecibo_cliente_cheque_2Test()
       Dim target As Recibo_cliente_cheque_2_ent = New Recibo_cliente_cheque_2_ent ' TODO: Inicializar en un valor adecuado
       Dim id_Recibo_cliente_cheque_2 As Integer = 1 ' TODO: Inicializar en un valor adecuado
       Dim expected As DataTable = Nothing ' TODO: Inicializar en un valor adecuado
       'Dim actual As DataTable

       target.Truncate()
       target.InsertOne()
       target.Borrar(id_Recibo_cliente_cheque_2) 

       Dim dt As DataTable = New DataTable
       dt = target.GetOne(id_Recibo_cliente_cheque_2) 

       Assert.IsTrue(dt.Rows.Count = 0, "son: " & dt.Rows.Count & " registros")
   End Sub
End Class
