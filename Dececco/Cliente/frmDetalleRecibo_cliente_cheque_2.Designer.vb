<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleRecibo_cliente_cheque_2
   Inherits System.Windows.Forms.Form

   'Form reemplaza a Dispose para limpiar la lista de componentes.
   <System.Diagnostics.DebuggerNonUserCode()> _
   Protected Overrides Sub Dispose(ByVal disposing As Boolean)
       If disposing AndAlso components IsNot Nothing Then
           components.Dispose()
       End If
       MyBase.Dispose(disposing)
   End Sub

   'Requerido por el Dise�ador de Windows Forms
   Private components As System.ComponentModel.IContainer

   'NOTA: el Dise�ador de Windows Forms necesita el siguiente procedimiento
   'Se puede modificar usando el Dise�ador de Windows Forms.
   'No lo modifique con el editor de c�digo.
   <System.Diagnostics.DebuggerStepThrough()> _
   Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleRecibo_cliente_cheque_2))
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblid_pago_cliente = New System.Windows.Forms.Label
        Me.lblid_cheque_recibo = New System.Windows.Forms.Label
        Me.btnBuscacheque_recibo = New System.Windows.Forms.Button
        Me.cmbcheque_recibo = New System.Windows.Forms.ComboBox
        Me.etiquetaid_cheque_recibo = New System.Windows.Forms.Label
        Me.chkcontrol = New System.Windows.Forms.CheckBox
        Me.etiquetacontrol = New System.Windows.Forms.Label
        Me.lblid_cliente = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.Black
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(499, 217)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(81, 61)
        Me.btnSalir.TabIndex = 51
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.Black
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardar.Location = New System.Drawing.Point(392, 217)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(81, 61)
        Me.btnGuardar.TabIndex = 50
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblid_cliente)
        Me.GroupBox1.Controls.Add(Me.cmbcheque_recibo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(568, 177)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'lblid_pago_cliente
        '
        Me.lblid_pago_cliente.AutoSize = True
        Me.lblid_pago_cliente.BackColor = System.Drawing.Color.Red
        Me.lblid_pago_cliente.Location = New System.Drawing.Point(370, 48)
        Me.lblid_pago_cliente.Name = "lblid_pago_cliente"
        Me.lblid_pago_cliente.Size = New System.Drawing.Size(13, 13)
        Me.lblid_pago_cliente.TabIndex = 500
        Me.lblid_pago_cliente.Text = "0"
        Me.lblid_pago_cliente.Visible = False
        '
        'lblid_cheque_recibo
        '
        Me.lblid_cheque_recibo.AutoSize = True
        Me.lblid_cheque_recibo.BackColor = System.Drawing.Color.Red
        Me.lblid_cheque_recibo.Location = New System.Drawing.Point(370, 91)
        Me.lblid_cheque_recibo.Name = "lblid_cheque_recibo"
        Me.lblid_cheque_recibo.Size = New System.Drawing.Size(13, 13)
        Me.lblid_cheque_recibo.TabIndex = 502
        Me.lblid_cheque_recibo.Text = "0"
        Me.lblid_cheque_recibo.Visible = False
        '
        'btnBuscacheque_recibo
        '
        Me.btnBuscacheque_recibo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscacheque_recibo.Image = CType(resources.GetObject("btnBuscacheque_recibo.Image"), System.Drawing.Image)
        Me.btnBuscacheque_recibo.Location = New System.Drawing.Point(505, 91)
        Me.btnBuscacheque_recibo.Name = "btnBuscacheque_recibo"
        Me.btnBuscacheque_recibo.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscacheque_recibo.TabIndex = 61
        Me.btnBuscacheque_recibo.UseVisualStyleBackColor = True
        '
        'cmbcheque_recibo
        '
        Me.cmbcheque_recibo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbcheque_recibo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbcheque_recibo.FormattingEnabled = True
        Me.cmbcheque_recibo.Location = New System.Drawing.Point(132, 71)
        Me.cmbcheque_recibo.Name = "cmbcheque_recibo"
        Me.cmbcheque_recibo.Size = New System.Drawing.Size(329, 21)
        Me.cmbcheque_recibo.TabIndex = 5
        '
        'etiquetaid_cheque_recibo
        '
        Me.etiquetaid_cheque_recibo.AutoSize = True
        Me.etiquetaid_cheque_recibo.BackColor = System.Drawing.Color.Transparent
        Me.etiquetaid_cheque_recibo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_cheque_recibo.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_cheque_recibo.Location = New System.Drawing.Point(28, 91)
        Me.etiquetaid_cheque_recibo.Name = "etiquetaid_cheque_recibo"
        Me.etiquetaid_cheque_recibo.Size = New System.Drawing.Size(87, 15)
        Me.etiquetaid_cheque_recibo.TabIndex = 503
        Me.etiquetaid_cheque_recibo.Text = "Cheque recibo"
        Me.etiquetaid_cheque_recibo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkcontrol
        '
        Me.chkcontrol.AutoSize = True
        Me.chkcontrol.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkcontrol.Location = New System.Drawing.Point(161, 134)
        Me.chkcontrol.Name = "chkcontrol"
        Me.chkcontrol.Size = New System.Drawing.Size(70, 21)
        Me.chkcontrol.TabIndex = 6
        Me.chkcontrol.Text = "control"
        '
        'etiquetacontrol
        '
        Me.etiquetacontrol.AutoSize = True
        Me.etiquetacontrol.BackColor = System.Drawing.Color.Transparent
        Me.etiquetacontrol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetacontrol.ForeColor = System.Drawing.Color.Black
        Me.etiquetacontrol.Location = New System.Drawing.Point(28, 134)
        Me.etiquetacontrol.Name = "etiquetacontrol"
        Me.etiquetacontrol.Size = New System.Drawing.Size(46, 15)
        Me.etiquetacontrol.TabIndex = 504
        Me.etiquetacontrol.Text = "Control"
        Me.etiquetacontrol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_cliente
        '
        Me.lblid_cliente.AutoSize = True
        Me.lblid_cliente.BackColor = System.Drawing.Color.Red
        Me.lblid_cliente.Location = New System.Drawing.Point(258, 31)
        Me.lblid_cliente.Name = "lblid_cliente"
        Me.lblid_cliente.Size = New System.Drawing.Size(13, 13)
        Me.lblid_cliente.TabIndex = 501
        Me.lblid_cliente.Text = "0"
        Me.lblid_cliente.Visible = False
        '
        'frmDetalleRecibo_cliente_cheque_2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 297)
        Me.Controls.Add(Me.lblid_pago_cliente)
        Me.Controls.Add(Me.lblid_cheque_recibo)
        Me.Controls.Add(Me.btnBuscacheque_recibo)
        Me.Controls.Add(Me.etiquetaid_cheque_recibo)
        Me.Controls.Add(Me.chkcontrol)
        Me.Controls.Add(Me.etiquetacontrol)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDetalleRecibo_cliente_cheque_2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDetalleRecibo_cliente_cheque_2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Friend WithEvents lblid_pago_cliente As System.Windows.Forms.Label
    Friend WithEvents lblid_cheque_recibo As System.Windows.Forms.Label
   Friend WithEvents btnBuscacheque_recibo As System.Windows.Forms.Button
   Friend WithEvents cmbcheque_recibo As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_cheque_recibo As System.Windows.Forms.Label
   Protected WithEvents chkcontrol As System.Windows.Forms.CheckBox
   Friend WithEvents etiquetacontrol As System.Windows.Forms.Label
   Protected WithEvents btnSalir As System.Windows.Forms.Button
   Protected WithEvents btnGuardar As System.Windows.Forms.Button
   Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
    Friend WithEvents lblid_cliente As System.Windows.Forms.Label
End Class

