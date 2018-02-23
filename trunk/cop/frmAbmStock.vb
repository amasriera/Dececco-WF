Public Class frmAbmStock

   Dim odt As DataTable
   Dim BanderaConsultaStock As Integer

   Private Sub frmAbmStock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       Me.ttGeneral.SetToolTip(Me.btnAgregar, "Incorporar Nuevo Stock")
       Me.ttGeneral.SetToolTip(Me.btnBorrar, "Borrar un  Stock Existente")
       Me.ttGeneral.SetToolTip(Me.btnModificar, "Modificar  un Stock Existente")
       'Me.ttGeneral.SetToolTip(Me.btnConsultar, "Consultar Datos del  Stock Existente")

       Dim odt As DataTable
       odt = oStock.Cargar()

       RefrescarGrilla()
       Me.txtBuscar.Focus()
       Me.lblTitulo.Text = "Stock"
       Me.Text = "Stock" & vgNombreFormulario
       Me.CancelButton = Me.btnSalir
       Me.BackColor = Color.Gainsboro
       Me.StartPosition = FormStartPosition.CenterScreen
       Me.MinimizeBox = False
       Me.MaximizeBox = False
       
       'control de acceso y de permisos
       Dim odtUser As New DataTable
       odtUser = oUsuario.GetPermiso(vgNombreUsuario, Me.Name)
       If odtUser.Rows.Count = 0 OrElse CDbl(odtUser.Rows(0).Item("habilitado")) = 0 Then
           Me.btnAgregar.Enabled = False
           Me.btnBorrar.Enabled = False
           Me.btnModificar.Enabled = False
       End If
       Me.btnAyuda.Visible = False
       
   End Sub

   Public Sub RefrescarGrilla()
       Dim odt As DataTable

       odt = oStock.ConsultarTodo()
       Me.dgv1.DataSource = odt
       Me.dgv1.Columns(0).Visible = False
   End Sub

   Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscar.KeyPress
       If e.KeyChar.ToString = vbCr Then
           Me.btnModificar.Focus()
       End If
   End Sub

   Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
       If Me.txtBuscar.Text = "" Then
           Me.txtBuscar.Text = " "
       End If
       odt = oStock.Buscar(Me.txtBuscar.Text)
       Me.dgv1.DataSource = odt
   End Sub

   Private Sub dgv1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv1.CurrentCellChanged
       Try
           Me.lblid_pk.Text = CStr(Me.dgv1.Item(0, Me.dgv1.CurrentRow.Index).Value)
       Catch ex As Exception
       End Try
   End Sub

   Private Sub Botones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click, btnAyuda.Click, btnBorrar.Click, btnModificar.Click, btnSalir.Click
       Dim btnTemp As New Button
       Dim frmDetalle As New frmDetalleStock
       btnTemp = CType(sender, Button)
       Try
           Select Case btnTemp.Name
               Case "btnAgregar"
                   BanderaStock = 1
                   Me.AddOwnedForm(frmDetalle)
                   oStock.Insertar()
                   frmDetalle.CargarCombos()
                   frmDetalle.ShowDialog()
               Case "btnModificar"
                   If Not IsNumeric(Me.lblid_pk.Text) Then
                       Exit Sub
                   End If
                   BanderaStock = 2
                   Me.AddOwnedForm(frmDetalle)
                   oStock.Modificar(CInt(Me.lblid_pk.Text))
                   frmDetalle.CargarCombos()
                   frmDetalle.ShowDialog()
                   RefrescarGrilla()
               Case "btnBorrar"
                   If Not IsNumeric(Me.lblid_pk.Text) Then
                       Exit Sub
                   End If

                   If MessageBox.Show("Desea Realmente Eliminar el Registro ", "BORRAR", _
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                   = Windows.Forms.DialogResult.No Then
                       Exit Sub
                   End If

                   oStock.Borrar(CInt(Me.lblid_pk.Text))
                   RefrescarGrilla()
               Case "btnAyuda"
                   'Process.Start(PathAyuda + "frmAbmStock.avi")
               Case "btnSalir"
                   Me.Close()
           End Select
           Me.txtBuscar.Text = ""
           Me.txtBuscar.Focus()
       Catch ex As Exception
       MessageBox.Show(ex.Message)
       End Try
   End Sub

   End Class
