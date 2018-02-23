Imports System.Data

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports Dececco



'''<summary>
'''Se trata de una clase de prueba para Temp_actividad_proyecto_entTest y se pretende que
'''contenga todas las pruebas unitarias Temp_actividad_proyecto_entTest. 
'''</summary>
<TestClass()> _
Public Class Temp_actividad_proyectoTest


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
   Public Sub ModificarTemp_actividad_proyectoTest()
       Dim target As Temp_actividad_proyecto_ent = New Temp_actividad_proyecto_ent ' TODO: Inicializar en un valor adecuado
       Dim expected As DataTable = Nothing ' TODO: Inicializar en un valor adecuado
       target.Truncate()
       target.InsertOne()
       target.Cargar()
       target.Modificar(1) 
       target.nombre_Temp_actividad_proyecto = "modificado"
       target.Guardar()

       Dim dt As DataTable = New DataTable
       dt = target.ConsultarTodo
       Assert.IsTrue(CBool(dt.Rows(0).Item("nombre_Temp_actividad_proyecto").ToString = "modificado"),"no: " & dt.Rows(0).Item("nombre_Temp_actividad_proyecto").ToString)
   End Sub

   '''<summary>
   '''Una prueba de Insertar
   '''</summary>
   <TestMethod()> _
   Public Sub InsertarTemp_actividad_proyectoTest()
       Dim target As Temp_actividad_proyecto_ent = New Temp_actividad_proyecto_ent ' TODO: Inicializar en un valor adecuado

       target.Truncate()
       target.InsertOne()
       target.Cargar()
       target.Insertar()
       target.nombre_Temp_actividad_proyecto = "prueba"
       target.Guardar()

       Dim dt As DataTable = New DataTable
       dt = target.ConsultarTodo

       Assert.IsTrue(dt.Rows.Count = 2, "son: " & dt.Rows.Count & " registros")
   End Sub

   '''<summary>
   '''Una prueba de GetOne
   '''</summary>
   <TestMethod()> _
   Public Sub GetOneTemp_actividad_proyectoTest()
       Dim target As Temp_actividad_proyecto_ent = New Temp_actividad_proyecto_ent ' TODO: Inicializar en un valor adecuado
       Dim id_Temp_actividad_proyecto As Integer = 1 ' TODO: Inicializar en un valor adecuado
       Dim expected As DataTable = Nothing ' TODO: Inicializar en un valor adecuado
       Dim actual As DataTable

       target.Truncate()
       target.InsertOne()

       actual = target.GetOne(id_Temp_actividad_proyecto)

       Assert.IsTrue(actual.Rows.Count = 1, "son: " & actual.Rows.Count & " registros")
   End Sub

   '''<summary>
   '''Una prueba de GetCmb
   '''</summary>
   <TestMethod()> _
   Public Sub GetCmbTemp_actividad_proyectoTest()
       Dim target As Temp_actividad_proyecto_ent = New Temp_actividad_proyecto_ent ' TODO: Inicializar en un valor adecuado
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
   Public Sub ExistTemp_actividad_proyectoTest()
       Dim target As Temp_actividad_proyecto_ent = New Temp_actividad_proyecto_ent ' TODO: Inicializar en un valor adecuado
       Dim expected As Boolean = False ' TODO: Inicializar en un valor adecuado
       Dim actual As Boolean

       target.Truncate()
       target.InsertOne()

       target.Modificar(1) 
       target.nombre_Temp_actividad_proyecto = "prueba"
       target.Guardar()

       actual = target.Exist

       Assert.IsTrue(actual = True, "no: " & actual) 
   End Sub

   '''<summary>
   '''Una prueba de ConsultarTodo
   '''</summary>
   <TestMethod()> _
   Public Sub ConsultarTodoTemp_actividad_proyectoTest()
       Dim target As Temp_actividad_proyecto_ent = New Temp_actividad_proyecto_ent ' TODO: Inicializar en un valor adecuado
       Dim expected As DataTable = Nothing ' TODO: Inicializar en un valor adecuado
       Dim actual As DataTable

       target.Truncate()
       target.InsertOne()
       target.Cargar()
       target.Insertar()
       target.nombre_Temp_actividad_proyecto = "prueba"
       target.Guardar()

       actual = target.ConsultarTodo

       Assert.IsTrue(actual.Rows.Count = 2, "son: " & actual.Rows.Count & " registros")
   End Sub

   '''<summary>
   '''Una prueba de Buscar
   '''</summary>
   <TestMethod()> _
   Public Sub BuscarTemp_actividad_proyectoTest()
       Dim target As Temp_actividad_proyecto_ent = New Temp_actividad_proyecto_ent ' TODO: Inicializar en un valor adecuado
       Dim Nombre As String = "pru" ' TODO: Inicializar en un valor adecuado
       Dim expected As DataTable = Nothing ' TODO: Inicializar en un valor adecuado
       Dim actual As DataTable

       target.Truncate()
       target.InsertOne()
       target.Cargar()
       target.Insertar()
       target.nombre_Temp_actividad_proyecto = "prueba"
       target.Guardar()

       target.Insertar()
       target.nombre_Temp_actividad_proyecto = "prudente"
       target.Guardar()

       actual = target.Buscar(Nombre) 

       Assert.IsTrue(actual.Rows.Count = 2, "son: " & actual.Rows.Count & " registros")
   End Sub

   '''<summary>
   '''Una prueba de Borrar
   '''</summary>
   <TestMethod()> _
   Public Sub BorrarTemp_actividad_proyectoTest()
       Dim target As Temp_actividad_proyecto_ent = New Temp_actividad_proyecto_ent ' TODO: Inicializar en un valor adecuado
       Dim id_Temp_actividad_proyecto As Integer = 1 ' TODO: Inicializar en un valor adecuado
       Dim expected As DataTable = Nothing ' TODO: Inicializar en un valor adecuado
       'Dim actual As DataTable

       target.Truncate()
       target.InsertOne()
       target.Borrar(id_Temp_actividad_proyecto) 

       Dim dt As DataTable = New DataTable
       dt = target.GetOne(id_Temp_actividad_proyecto) 

       Assert.IsTrue(dt.Rows.Count = 0, "son: " & dt.Rows.Count & " registros")
   End Sub
End Class
