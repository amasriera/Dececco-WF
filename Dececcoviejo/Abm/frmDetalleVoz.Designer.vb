<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleVoz
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleVoz))
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtnombre_voz = New System.Windows.Forms.TextBox()
        Me.etiquetanombre_voz = New System.Windows.Forms.Label()
        Me.txticono = New System.Windows.Forms.TextBox()
        Me.etiquetaicono = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.etiquetacodigo = New System.Windows.Forms.Label()
        Me.txtcodigo_2 = New System.Windows.Forms.TextBox()
        Me.etiquetacodigo_2 = New System.Windows.Forms.Label()
        Me.txtponderacion = New System.Windows.Forms.TextBox()
        Me.etiquetaponderacion = New System.Windows.Forms.Label()
        Me.txtrandom = New System.Windows.Forms.TextBox()
        Me.etiquetarandom = New System.Windows.Forms.Label()
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
        Me.btnSalir.Location = New System.Drawing.Point(499, 412)
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
        Me.btnGuardar.Location = New System.Drawing.Point(392, 412)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(78, 69)
        Me.btnGuardar.TabIndex = 20
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(568, 378)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtnombre_voz
        '
        Me.txtnombre_voz.BackColor = System.Drawing.Color.White
        Me.txtnombre_voz.Location = New System.Drawing.Point(161, 48)
        Me.txtnombre_voz.MaxLength = 500
        Me.txtnombre_voz.Multiline = True
        Me.txtnombre_voz.Name = "txtnombre_voz"
        Me.txtnombre_voz.Size = New System.Drawing.Size(385, 91)
        Me.txtnombre_voz.TabIndex = 4
        '
        'etiquetanombre_voz
        '
        Me.etiquetanombre_voz.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetanombre_voz.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetanombre_voz.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetanombre_voz.ForeColor = System.Drawing.Color.Black
        Me.etiquetanombre_voz.Location = New System.Drawing.Point(28, 48)
        Me.etiquetanombre_voz.Name = "etiquetanombre_voz"
        Me.etiquetanombre_voz.Size = New System.Drawing.Size(127, 21)
        Me.etiquetanombre_voz.TabIndex = 500
        Me.etiquetanombre_voz.Text = "Nombre_voz"
        Me.etiquetanombre_voz.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txticono
        '
        Me.txticono.BackColor = System.Drawing.Color.White
        Me.txticono.Location = New System.Drawing.Point(161, 159)
        Me.txticono.MaxLength = 50
        Me.txticono.Name = "txticono"
        Me.txticono.Size = New System.Drawing.Size(385, 20)
        Me.txticono.TabIndex = 5
        '
        'etiquetaicono
        '
        Me.etiquetaicono.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaicono.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaicono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaicono.ForeColor = System.Drawing.Color.Black
        Me.etiquetaicono.Location = New System.Drawing.Point(28, 159)
        Me.etiquetaicono.Name = "etiquetaicono"
        Me.etiquetaicono.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaicono.TabIndex = 501
        Me.etiquetaicono.Text = "Icono"
        Me.etiquetaicono.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtcodigo
        '
        Me.txtcodigo.BackColor = System.Drawing.Color.White
        Me.txtcodigo.Location = New System.Drawing.Point(161, 202)
        Me.txtcodigo.MaxLength = 50
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(385, 20)
        Me.txtcodigo.TabIndex = 6
        '
        'etiquetacodigo
        '
        Me.etiquetacodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetacodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetacodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetacodigo.ForeColor = System.Drawing.Color.Black
        Me.etiquetacodigo.Location = New System.Drawing.Point(28, 202)
        Me.etiquetacodigo.Name = "etiquetacodigo"
        Me.etiquetacodigo.Size = New System.Drawing.Size(127, 21)
        Me.etiquetacodigo.TabIndex = 502
        Me.etiquetacodigo.Text = "Codigo"
        Me.etiquetacodigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtcodigo_2
        '
        Me.txtcodigo_2.BackColor = System.Drawing.Color.White
        Me.txtcodigo_2.Location = New System.Drawing.Point(161, 245)
        Me.txtcodigo_2.MaxLength = 50
        Me.txtcodigo_2.Name = "txtcodigo_2"
        Me.txtcodigo_2.Size = New System.Drawing.Size(385, 20)
        Me.txtcodigo_2.TabIndex = 7
        '
        'etiquetacodigo_2
        '
        Me.etiquetacodigo_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetacodigo_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetacodigo_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetacodigo_2.ForeColor = System.Drawing.Color.Black
        Me.etiquetacodigo_2.Location = New System.Drawing.Point(28, 245)
        Me.etiquetacodigo_2.Name = "etiquetacodigo_2"
        Me.etiquetacodigo_2.Size = New System.Drawing.Size(127, 21)
        Me.etiquetacodigo_2.TabIndex = 503
        Me.etiquetacodigo_2.Text = "Codigo_2"
        Me.etiquetacodigo_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtponderacion
        '
        Me.txtponderacion.BackColor = System.Drawing.Color.White
        Me.txtponderacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtponderacion.ForeColor = System.Drawing.Color.Blue
        Me.txtponderacion.Location = New System.Drawing.Point(161, 288)
        Me.txtponderacion.MaxLength = 50
        Me.txtponderacion.Name = "txtponderacion"
        Me.txtponderacion.Size = New System.Drawing.Size(222, 31)
        Me.txtponderacion.TabIndex = 8
        Me.txtponderacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetaponderacion
        '
        Me.etiquetaponderacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaponderacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaponderacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaponderacion.ForeColor = System.Drawing.Color.Black
        Me.etiquetaponderacion.Location = New System.Drawing.Point(28, 288)
        Me.etiquetaponderacion.Name = "etiquetaponderacion"
        Me.etiquetaponderacion.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaponderacion.TabIndex = 504
        Me.etiquetaponderacion.Text = "Ponderacion"
        Me.etiquetaponderacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtrandom
        '
        Me.txtrandom.BackColor = System.Drawing.Color.White
        Me.txtrandom.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrandom.ForeColor = System.Drawing.Color.Blue
        Me.txtrandom.Location = New System.Drawing.Point(161, 341)
        Me.txtrandom.MaxLength = 50
        Me.txtrandom.Name = "txtrandom"
        Me.txtrandom.Size = New System.Drawing.Size(222, 31)
        Me.txtrandom.TabIndex = 9
        Me.txtrandom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetarandom
        '
        Me.etiquetarandom.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetarandom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetarandom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetarandom.ForeColor = System.Drawing.Color.Black
        Me.etiquetarandom.Location = New System.Drawing.Point(28, 341)
        Me.etiquetarandom.Name = "etiquetarandom"
        Me.etiquetarandom.Size = New System.Drawing.Size(127, 21)
        Me.etiquetarandom.TabIndex = 505
        Me.etiquetarandom.Text = "Random"
        Me.etiquetarandom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmDetalleVoz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 493)
        Me.Controls.Add(Me.txtnombre_voz)
        Me.Controls.Add(Me.etiquetanombre_voz)
        Me.Controls.Add(Me.txticono)
        Me.Controls.Add(Me.etiquetaicono)
        Me.Controls.Add(Me.txtcodigo)
        Me.Controls.Add(Me.etiquetacodigo)
        Me.Controls.Add(Me.txtcodigo_2)
        Me.Controls.Add(Me.etiquetacodigo_2)
        Me.Controls.Add(Me.txtponderacion)
        Me.Controls.Add(Me.etiquetaponderacion)
        Me.Controls.Add(Me.txtrandom)
        Me.Controls.Add(Me.etiquetarandom)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDetalleVoz"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDetalleVoz"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Protected WithEvents txtnombre_voz As System.Windows.Forms.TextBox
   Friend WithEvents etiquetanombre_voz As System.Windows.Forms.Label
   Protected WithEvents txticono As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaicono As System.Windows.Forms.Label
   Protected WithEvents txtcodigo As System.Windows.Forms.TextBox
   Friend WithEvents etiquetacodigo As System.Windows.Forms.Label
   Protected WithEvents txtcodigo_2 As System.Windows.Forms.TextBox
   Friend WithEvents etiquetacodigo_2 As System.Windows.Forms.Label
   Protected WithEvents txtponderacion As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaponderacion As System.Windows.Forms.Label
   Protected WithEvents txtrandom As System.Windows.Forms.TextBox
   Friend WithEvents etiquetarandom As System.Windows.Forms.Label
   Protected WithEvents btnSalir As System.Windows.Forms.Button
   Protected WithEvents btnGuardar As System.Windows.Forms.Button
   Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
   Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
End Class

