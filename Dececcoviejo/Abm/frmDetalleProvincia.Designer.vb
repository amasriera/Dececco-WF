<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleProvincia
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
       Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleProvincia))
       Me.btnSalir = New System.Windows.Forms.Button
       Me.btnGuardar = New System.Windows.Forms.Button
       Me.GroupBox1 = New System.Windows.Forms.GroupBox
       Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
       Me.txtnombre_provincia = New System.Windows.Forms.TextBox
       Me.etiquetanombre_provincia = New System.Windows.Forms.Label
       Me.SuspendLayout()
       '
       'txtnombre_provincia
       '
       Me.txtnombre_provincia.BackColor = System.Drawing.Color.White
       Me.txtnombre_provincia.Location = New System.Drawing.Point(161, 48)
       Me.txtnombre_provincia.MaxLength = 50
       Me.txtnombre_provincia.Name = "txtnombre_provincia"
       Me.txtnombre_provincia.Size = New System.Drawing.Size(385, 20)
       Me.txtnombre_provincia.TabIndex = 4
       '
       'etiquietanombre_provincia
       '
        Me.etiquetanombre_provincia.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
       Me.etiquetanombre_provincia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
       Me.etiquetanombre_provincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetanombre_provincia.ForeColor = System.Drawing.Color.Black
       Me.etiquetanombre_provincia.Location = New System.Drawing.Point(28, 48)
       Me.etiquetanombre_provincia.Name = "etiquetanombre_provincia"
       Me.etiquetanombre_provincia.Size = New System.Drawing.Size(127, 21)
       Me.etiquetanombre_provincia.TabIndex = 500
       Me.etiquetanombre_provincia.Text = "Nombre_provincia"
       Me.etiquetanombre_provincia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'btnSalir
       '
       Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
       Me.btnSalir.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.btnSalir.ForeColor = System.Drawing.Color.Black
       Me.btnSalir.Image = CType(Resources.GetObject("btnSalir.Image"), System.Drawing.Image)
       Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
       Me.btnSalir.Location = New System.Drawing.Point(499, 131)
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
       Me.btnGuardar.Image = CType(Resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
       Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
       Me.btnGuardar.Location = New System.Drawing.Point(392,131)
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
       Me.GroupBox1.Size = New System.Drawing.Size(568, 91)
       Me.GroupBox1.TabIndex = 0
       Me.GroupBox1.TabStop = False
       '
       'frmDetalleProvincia
       '
       Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
       Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
       Me.ClientSize = New System.Drawing.Size(600, 211)
       Me.Controls.Add(Me.txtnombre_provincia)
       Me.Controls.Add(Me.etiquetanombre_provincia)
       Me.Controls.Add(Me.btnSalir)
       Me.Controls.Add(Me.btnGuardar)
       Me.Controls.Add(Me.GroupBox1)
       Me.Name = "frmDetalleProvincia"
       Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDetalleProvincia" & vgNombreFormulario
       Me.ResumeLayout(False)
       Me.PerformLayout()

   End Sub
   Protected WithEvents txtnombre_provincia As System.Windows.Forms.TextBox
   Friend WithEvents etiquetanombre_provincia As System.Windows.Forms.Label
   Protected WithEvents btnSalir As System.Windows.Forms.Button
   Protected WithEvents btnGuardar As System.Windows.Forms.Button
   Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
   Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
End Class

