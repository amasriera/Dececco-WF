Public Class frmDetalleCuerpo_remito

    Private Sub frmDetalleCuerpo_remito_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ttGeneral.SetToolTip(Me.btnBuscaItem, "Buscar Nuevo Item")
        '  Me.ttGeneral.SetToolTip(Me.btnBuscaUsuario, "Buscar Nuevo Usuario")
        Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Cuerpo_remito")
        Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
        Try
            ObtenerDatos()

            Me.cmbItem.Text = oItem.GetOne(CInt(Me.lblid_Item.Text)).Rows(0).Item("nombre_Item").ToString.Trim
            ' Me.cmbUsuario.Text = oUsuario.GetOne(CInt(Me.lblid_Usuario.Text)).Rows(0).Item("nombre_Usuario").ToString.Trim
        Catch ex As Exception
            '    MessageBox.Show(ex.Message)
        End Try

        Me.lblid_remito.Text = CType(Me.Owner, frmDetalleremito).lblid_remito.Text

        If BanderaCuerpo_remito = 1 Then
            Me.LimpiarControles()
        End If
        Me.Text = "Cuerpo_remito"
        Me.CancelButton = Me.btnSalir
        Me.BackColor = Color.Gainsboro
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MinimizeBox = False
        Me.MaximizeBox = False

        Me.lblid_usuario.Text = CStr(vgCodigoUsuario)
    End Sub

    Sub CargarCombos()
        Me.CargarItem()
        ' Me.CargarUsuario
    End Sub

    Sub CargarItem()
        Dim odt As New DataTable

        odt = oItem.GetCmb
        With Me.cmbItem
            .DataSource = odt
            .DisplayMember = "nombre_Item"
            .ValueMember = "id_Item"
        End With
        If Me.cmbItem.SelectedIndex >= 0 Then
            cmbItem.SelectedIndex = 0
            Me.lblid_Item.Text = cmbItem.SelectedValue.ToString
        End If
    End Sub

    'Sub CargarUsuario()
    '    Dim odt As New DataTable

    '    odt = oUsuario.GetCmb
    '    With Me.cmbUsuario
    '        .DataSource = odt
    '        .DisplayMember = "nombre_Usuario"
    '        .ValueMember = "id_Usuario"
    '    End With
    '    If Me.cmbUsuario.SelectedIndex >= 0 Then
    '        cmbUsuario.SelectedIndex = 0
    '        Me.lblid_Usuario.Text = cmbUsuario.SelectedValue.ToString
    '    End If
    'End Sub

    Sub LimpiarControles()
        'Me.lblid_remito.Text = "0"
        'Me.cmbID_Remito.Text =  ""
        Me.lblid_item.Text = "0"
        Me.cmbItem.Text = ""
        Me.txtcantidad.Text = ""
        'Me.lblid_usuario.Text = "0"
        'Me.cmbUsuario.Text =  ""
    End Sub

    Private Sub ObtenerDatos()
        'Me.lblid_remito.Text = oCuerpo_remito.id_remito.ToString
        Me.lblid_item.Text = oCuerpo_remito.id_item.ToString
        Me.txtcantidad.Text = oCuerpo_remito.cantidad.ToString.Trim
        ' Me.lblid_usuario.Text = oCuerpo_remito.id_usuario.ToString
    End Sub

    Private Sub AsignarDatos()
        oCuerpo_remito.id_remito = CInt(Me.lblid_remito.Text)
        oCuerpo_remito.id_item = CInt(Me.lblid_item.Text)
        oCuerpo_remito.cantidad = CDec(Me.txtcantidad.Text)
        oCuerpo_remito.id_usuario = CInt(Me.lblid_usuario.Text)
    End Sub

    Public Sub SoloLectura()
        'Me.cmbRemito.Enabled = False
        'Me.btnBuscaRemito.Enabled = False
        Me.cmbItem.Enabled = False
        Me.btnBuscaItem.Enabled = False
        Me.txtcantidad.Enabled = False
        'Me.cmbUsuario.Enabled = False
        'Me.btnBuscaUsuario.Enabled = False
        Me.btnGuardar.Visible = False
    End Sub

    Private Sub Guardar()
        Try
            Me.AsignarDatos()
            If oCuerpo_remito.Exist() Then
                If BanderaCuerpo_remito = 1 Then
                    MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
                    Exit Sub
                ElseIf BanderaCuerpo_remito = 2 Then
                    If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen �Desea Reemplazarlos?", "MODIFICAR", _
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                        = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If
                End If
            End If
            Select Case BanderaCuerpo_remito
                Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                    oCuerpo_remito.Guardar()
                    CType(Me.Owner, frmDetalleremito).RefrescarGrilla()
                    Me.CargarCombos()
                    oCuerpo_remito.Insertar()
                    Me.ObtenerDatos()
                    Me.LimpiarControles()
                    Me.cmbitem.Focus()
                Case 2 'GUARDA Y SALE (MODIFICAR)
                    oCuerpo_remito.Guardar()
                    Me.Close()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function ChequearVacios() As Boolean
        Dim bandera As Boolean
        If Me.txtcantidad.Text = "" Then
            bandera = False
        Else
            bandera = True
        End If
        Return bandera
    End Function

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim blnVacios As Boolean

        'If CDbl(Me.lblid_remito.Text) = 0 Then
        'MessageBox.Show("Debe Seleccionar un Dato del Combo de remito")
        'Exit Sub
        'End If
        If CDbl(Me.lblid_item.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de item")
            Exit Sub
        End If
        If CDbl(Me.lblid_usuario.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de usuario")
            Exit Sub
        End If

        blnVacios = Me.ChequearVacios
        If blnVacios = False Then
            MessageBox.Show("Debe Llenar los Campos Obligatorios")
            Exit Sub
        Else
            If BanderaCuerpo_remito = 1 Then
                Me.Guardar()
            Else
                Me.Guardar()
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub cmbItem_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbitem.SelectedIndexChanged
        If Me.cmbItem.SelectedIndex >= 0 Then
            Me.lblid_item.Text = cmbItem.SelectedValue.ToString
        End If
    End Sub

    Private Sub btnBuscaItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaitem.Click
        Dim frmTemporal As New FrmAbmItem
        frmTemporal.ShowDialog()
        Me.CargarItem()
        Me.cmbItem.Focus()
        Me.cmbItem.Text = ""
        Me.lblid_Item.Text = "0"
    End Sub

    'Private Sub cmbUsuario_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbUsuario.SelectedIndexChanged
    '    If Me.cmbUsuario.SelectedIndex >= 0 Then
    '        Me.lblid_usuario.Text = cmbUsuario.SelectedValue.ToString
    '    End If
    'End Sub

    'Private Sub btnBuscaUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaUsuario.Click
    '    Dim frmTemporal As New FrmAbmUsuario
    '    frmTemporal.ShowDialog()
    '    Me.CargarUsuario()
    '    Me.cmbUsuario.Focus()
    '    Me.cmbUsuario.Text = ""
    '    Me.lblid_Usuario.Text = "0"
    'End Sub

    Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    'Handles 
        If e.KeyChar.ToString = vbCr Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
    Handles cmbitem.KeyDown
        If CDbl(e.KeyValue.ToString) = 13 Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub Decimales(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles txtcantidad.KeyPress
        Dim txtTemp As TextBox
        txtTemp = CType(sender, TextBox)

        If e.KeyChar.ToString = vbCr Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
        If e.KeyChar.ToString = "." Or e.KeyChar.ToString = "," Then
            If InStr(txtTemp.Text, ",") <> 0 Then
                e.Handled = True
            Else
                e.KeyChar = CChar(",")
            End If
        End If

        Dim Largo As Integer = InStr(txtTemp.Text, ",")

        If txtTemp.Text.Length > Largo + 2 And Largo <> 0 And e.KeyChar.ToString <> vbBack Then
            e.Handled = True
        End If

        If (e.KeyChar.ToString >= "0" And e.KeyChar.ToString <= "9") Or e.KeyChar.ToString = "," Or e.KeyChar = vbBack Then
            '  e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

End Class
