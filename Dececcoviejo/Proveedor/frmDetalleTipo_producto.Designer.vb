<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleTipo_producto
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleTipo_producto))
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtnombre_tipo_producto = New System.Windows.Forms.TextBox()
        Me.etiquetanombre_tipo_producto = New System.Windows.Forms.Label()
        Me.lblid_grupo_producto = New System.Windows.Forms.Label()
        Me.btnBuscagrupo_producto = New System.Windows.Forms.Button()
        Me.cmbgrupo_producto = New System.Windows.Forms.ComboBox()
        Me.etiquetaid_grupo_producto = New System.Windows.Forms.Label()
        Me.chktilde = New System.Windows.Forms.CheckBox()
        Me.etiquetatilde = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.Black
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(499, 217)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(81, 69)
        Me.btnSalir.TabIndex = 21
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.Black
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardar.Location = New System.Drawing.Point(392, 217)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(78, 69)
        Me.btnGuardar.TabIndex = 20
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(12, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(568, 177)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtnombre_tipo_producto
        '
        Me.txtnombre_tipo_producto.BackColor = System.Drawing.Color.White
        Me.txtnombre_tipo_producto.Location = New System.Drawing.Point(161, 48)
        Me.txtnombre_tipo_producto.MaxLength = 50
        Me.txtnombre_tipo_producto.Name = "txtnombre_tipo_producto"
        Me.txtnombre_tipo_producto.Size = New System.Drawing.Size(385, 20)
        Me.txtnombre_tipo_producto.TabIndex = 4
        '
        'etiquetanombre_tipo_producto
        '
        Me.etiquetanombre_tipo_producto.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetanombre_tipo_producto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetanombre_tipo_producto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetanombre_tipo_producto.ForeColor = System.Drawing.Color.Black
        Me.etiquetanombre_tipo_producto.Location = New System.Drawing.Point(28, 48)
        Me.etiquetanombre_tipo_producto.Name = "etiquetanombre_tipo_producto"
        Me.etiquetanombre_tipo_producto.Size = New System.Drawing.Size(127, 21)
        Me.etiquetanombre_tipo_producto.TabIndex = 500
        Me.etiquetanombre_tipo_producto.Text = "Nombre"
        Me.etiquetanombre_tipo_producto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_grupo_producto
        '
        Me.lblid_grupo_producto.AutoSize = True
        Me.lblid_grupo_producto.BackColor = System.Drawing.Color.Red
        Me.lblid_grupo_producto.Location = New System.Drawing.Point(370, 91)
        Me.lblid_grupo_producto.Name = "lblid_grupo_producto"
        Me.lblid_grupo_producto.Size = New System.Drawing.Size(13, 13)
        Me.lblid_grupo_producto.TabIndex = 501
        Me.lblid_grupo_producto.Text = "0"
        Me.lblid_grupo_producto.Visible = False
        '
        'btnBuscagrupo_producto
        '
        Me.btnBuscagrupo_producto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscagrupo_producto.Image = CType(resources.GetObject("btnBuscagrupo_producto.Image"), System.Drawing.Image)
        Me.btnBuscagrupo_producto.Location = New System.Drawing.Point(505, 91)
        Me.btnBuscagrupo_producto.Name = "btnBuscagrupo_producto"
        Me.btnBuscagrupo_producto.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscagrupo_producto.TabIndex = 30
        Me.btnBuscagrupo_producto.UseVisualStyleBackColor = True
        '
        'cmbgrupo_producto
        '
        Me.cmbgrupo_producto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbgrupo_producto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbgrupo_producto.FormattingEnabled = True
        Me.cmbgrupo_producto.Location = New System.Drawing.Point(161, 91)
        Me.cmbgrupo_producto.Name = "cmbgrupo_producto"
        Me.cmbgrupo_producto.Size = New System.Drawing.Size(329, 21)
        Me.cmbgrupo_producto.TabIndex = 5
        '
        'etiquetaid_grupo_producto
        '
        Me.etiquetaid_grupo_producto.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaid_grupo_producto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_grupo_producto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_grupo_producto.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_grupo_producto.Location = New System.Drawing.Point(28, 91)
        Me.etiquetaid_grupo_producto.Name = "etiquetaid_grupo_producto"
        Me.etiquetaid_grupo_producto.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaid_grupo_producto.TabIndex = 502
        Me.etiquetaid_grupo_producto.Text = "Grupo_producto"
        Me.etiquetaid_grupo_producto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chktilde
        '
        Me.chktilde.AutoSize = True
        Me.chktilde.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chktilde.Location = New System.Drawing.Point(161, 134)
        Me.chktilde.Name = "chktilde"
        Me.chktilde.Size = New System.Drawing.Size(15, 14)
        Me.chktilde.TabIndex = 6
        '
        'etiquetatilde
        '
        Me.etiquetatilde.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetatilde.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetatilde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetatilde.ForeColor = System.Drawing.Color.Black
        Me.etiquetatilde.Location = New System.Drawing.Point(28, 134)
        Me.etiquetatilde.Name = "etiquetatilde"
        Me.etiquetatilde.Size = New System.Drawing.Size(127, 21)
        Me.etiquetatilde.TabIndex = 503
        Me.etiquetatilde.Text = "Deshabilitado"
        Me.etiquetatilde.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmDetalleTipo_producto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 297)
        Me.Controls.Add(Me.txtnombre_tipo_producto)
        Me.Controls.Add(Me.etiquetanombre_tipo_producto)
        Me.Controls.Add(Me.lblid_grupo_producto)
        Me.Controls.Add(Me.btnBuscagrupo_producto)
        Me.Controls.Add(Me.cmbgrupo_producto)
        Me.Controls.Add(Me.etiquetaid_grupo_producto)
        Me.Controls.Add(Me.chktilde)
        Me.Controls.Add(Me.etiquetatilde)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDetalleTipo_producto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDetalleTipo_producto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Protected WithEvents txtnombre_tipo_producto As System.Windows.Forms.TextBox
   Friend WithEvents etiquetanombre_tipo_producto As System.Windows.Forms.Label
   Friend WithEvents lblid_grupo_producto As System.Windows.Forms.Label
   Friend WithEvents btnBuscagrupo_producto As System.Windows.Forms.Button
   Friend WithEvents cmbgrupo_producto As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_grupo_producto As System.Windows.Forms.Label
   Protected WithEvents chktilde As System.Windows.Forms.CheckBox
   Friend WithEvents etiquetatilde As System.Windows.Forms.Label
   Protected WithEvents btnSalir As System.Windows.Forms.Button
   Protected WithEvents btnGuardar As System.Windows.Forms.Button
   Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
   Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
End Class

