Public Class frmAbmRemito

    Dim odt As DataTable
    Dim BanderaConsultaRemito As Integer

    Private Sub frmAbmRemito_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ttGeneral.SetToolTip(Me.btnAgregar, "Incorporar Nuevo Remito")
        Me.ttGeneral.SetToolTip(Me.btnBorrar, "Borrar un  Remito Existente")
        Me.ttGeneral.SetToolTip(Me.btnModificar, "Modificar  un Remito Existente")
        'Me.ttGeneral.SetToolTip(Me.btnConsultar, "Consultar Datos del  Remito Existente")

        Dim odt As DataTable
        odt = oRemito.Cargar()

        RefrescarGrilla()
        Me.txtBuscar.Focus()
        Me.lblTitulo.Text = "Remito"
        Me.Text = "Remito"
        Me.CancelButton = Me.btnSalir
        Me.BackColor = Color.Teal
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MinimizeBox = False
        Me.MaximizeBox = False
    End Sub

    Public Sub RefrescarGrilla()
        Dim odt As DataTable

        odt = oRemito.GetAll_2
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
        odt = oRemito.Buscar_2(Me.txtBuscar.Text)
        Me.dgv1.DataSource = odt
    End Sub

    Private Sub dgv1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv1.CurrentCellChanged
        Try
            Me.lblid_pk.Text = Me.dgv1.Item(0, Me.dgv1.CurrentRow.Index).Value
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Botones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click, btnAyuda.Click, btnBorrar.Click, btnModificar.Click, btnSalir.Click
        Dim btnTemp As New Button
        Dim frmDetalle As New frmDetalleRemito
        btnTemp = sender
        Try
            Select Case btnTemp.Name
                Case "btnAgregar"
                    BanderaRemito = 1
                    Me.AddOwnedForm(frmDetalle)
                    oRemito.Insertar()
                    frmDetalle.CargarCombos()
                    frmDetalle.ShowDialog()
                Case "btnModificar"
                    If Not IsNumeric(Me.lblid_pk.Text) Then
                        Exit Sub
                    End If
                    BanderaRemito = 2
                    oRemito.Modificar(Me.lblid_pk.Text)
                    frmDetalle.CargarCombos()
                    frmDetalle.ShowDialog()
                    RefrescarGrilla()
                Case "btnBorrar"
                    If Not IsNumeric(Me.lblid_pk.Text) Then
                        Exit Sub
                    End If
                    oRemito.Borrar(Me.lblid_pk.Text)
                    RefrescarGrilla()
                Case "btnAyuda"
                    'Process.Start(PathAyuda + "frmAbmRemito.avi")
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