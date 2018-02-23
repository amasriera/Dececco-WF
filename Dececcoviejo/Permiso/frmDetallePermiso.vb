Public Class frmDetallePermiso

    Private Sub frmDetallePermiso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ttGuardar.SetToolTip(Me.btnGuardar, "Guardar Datos del Permiso")
        Me.ttSalir.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
        Try
            ObtenerDatos()

        Catch ex As Exception
            '    Errores(ex)
        End Try

        If BanderaPermiso = 1 Then
            Me.LimpiarControles()
        End If
        Me.Text = "Permiso"
        Me.CancelButton = Me.btnSalir
        Me.BackColor = Color.Gainsboro
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MinimizeBox = False
        Me.MaximizeBox = False
    End Sub

    Sub CargarCombos()
    End Sub

    Sub LimpiarControles()
        Me.txtNombre_permiso.Text = ""
        Me.txtFormulario.Text = ""
    End Sub

    Private Sub ObtenerDatos()
        Me.txtNombre_permiso.Text = oPermiso.nombre_permiso.Trim
        Me.txtFormulario.Text = oPermiso.formulario.Trim
    End Sub

    Private Sub AsignarDatos()
        oPermiso.nombre_permiso = Me.txtNombre_permiso.Text
        oPermiso.formulario = Me.txtFormulario.Text
    End Sub

    Public Sub SoloLectura()
        Me.txtNombre_permiso.Enabled = False
        Me.txtFormulario.Enabled = False
        Me.btnGuardar.Visible = False
    End Sub

    Private Sub Guardar()
        Try
            Me.AsignarDatos()
            Select Case BanderaPermiso
                Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                    oPermiso.Guardar()
                    CType(Me.Owner, frmAbmPermiso).RefrescarGrilla()
                    Me.CargarCombos()
                    oPermiso.Insertar()
                    Me.ObtenerDatos()
                    Me.LimpiarControles()
                    Me.txtNombre_permiso.Focus()
                Case 2 'GUARDA Y SALE (MODIFICAR)
                    oPermiso.Guardar()
                    Me.Close()
            End Select
        Catch ex As Exception
            Errores(ex)
        End Try
    End Sub

    Private Function ChequearVacios() As Boolean
        Dim bandera As Boolean
        If Me.txtnombre_permiso.Text = "" Then
            bandera = False
        Else
            bandera = True
        End If
        Return bandera
    End Function

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim blnVacios As Boolean


        blnVacios = Me.ChequearVacios
        If blnVacios = False Then
            MessageBox.Show("Debe Llenar los Campos Obligatorios", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            If BanderaPermiso = 1 Then
                Me.Guardar()
            Else
                Me.Guardar()
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles txtNombre_permiso.KeyPress, txtFormulario.KeyPress
        If e.KeyChar.ToString = vbCr Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
    'Handles 
        If CDbl(e.KeyValue.ToString) = 13 Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub Decimales(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    'Handles 
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