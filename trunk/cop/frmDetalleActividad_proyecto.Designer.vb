<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleActividad_proyecto
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
       Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleActividad_proyecto))
       Me.btnSalir = New System.Windows.Forms.Button
       Me.btnGuardar = New System.Windows.Forms.Button
       Me.GroupBox1 = New System.Windows.Forms.GroupBox
       Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
       Me.lblid_proyecto = New System.Windows.Forms.Label
       Me.btnBuscaproyecto = New System.Windows.Forms.Button
       Me.cmbproyecto = New System.Windows.Forms.ComboBox
       Me.etiquetaid_proyecto = New System.Windows.Forms.Label
       Me.lblid_actividad = New System.Windows.Forms.Label
       Me.btnBuscaactividad = New System.Windows.Forms.Button
       Me.cmbactividad = New System.Windows.Forms.ComboBox
       Me.etiquetaid_actividad = New System.Windows.Forms.Label
       Me.dtpfecha_inicio = New System.Windows.Forms.DateTimePicker
       Me.etiquetafecha_inicio = New System.Windows.Forms.Label
       Me.dtpfecha_fin_previsto = New System.Windows.Forms.DateTimePicker
       Me.etiquetafecha_fin_previsto = New System.Windows.Forms.Label
       Me.dtpfecha_fin_real = New System.Windows.Forms.DateTimePicker
       Me.etiquetafecha_fin_real = New System.Windows.Forms.Label
       Me.txtcantidad_hora = New System.Windows.Forms.TextBox
       Me.etiquetacantidad_hora = New System.Windows.Forms.Label
       Me.txtobjetivo = New System.Windows.Forms.TextBox
       Me.etiquetaobjetivo = New System.Windows.Forms.Label
       Me.txtprioridad = New System.Windows.Forms.TextBox
       Me.etiquetaprioridad = New System.Windows.Forms.Label
       Me.txtcomplejidad = New System.Windows.Forms.TextBox
       Me.etiquetacomplejidad = New System.Windows.Forms.Label
       Me.txtavance = New System.Windows.Forms.TextBox
       Me.etiquetaavance = New System.Windows.Forms.Label
       Me.txtobservacion = New System.Windows.Forms.TextBox
       Me.etiquetaobservacion = New System.Windows.Forms.Label
       Me.txtorden = New System.Windows.Forms.TextBox
       Me.etiquetaorden = New System.Windows.Forms.Label
       Me.lblid_controlador_1 = New System.Windows.Forms.Label
       Me.btnBuscacontrolador_1 = New System.Windows.Forms.Button
       Me.cmbcontrolador_1 = New System.Windows.Forms.ComboBox
       Me.etiquetaid_controlador_1 = New System.Windows.Forms.Label
       Me.lblid_controlador_2 = New System.Windows.Forms.Label
       Me.btnBuscacontrolador_2 = New System.Windows.Forms.Button
       Me.cmbcontrolador_2 = New System.Windows.Forms.ComboBox
       Me.etiquetaid_controlador_2 = New System.Windows.Forms.Label
       Me.lblnro = New System.Windows.Forms.Label
       Me.btnBusca = New System.Windows.Forms.Button
       Me.cmb = New System.Windows.Forms.ComboBox
       Me.etiquetanro = New System.Windows.Forms.Label
       Me.SuspendLayout()
       '
       'lblid_proyecto
       '
       Me.lblid_proyecto.AutoSize = True
       Me.lblid_proyecto.BackColor = System.Drawing.Color.Red
       Me.lblid_proyecto.Location = New System.Drawing.Point(370, 48)
       Me.lblid_proyecto.Name = "lblid_proyecto"
       Me.lblid_proyecto.Size = New System.Drawing.Size(13, 13)
       Me.lblid_proyecto.TabIndex = 500
       Me.lblid_proyecto.Text = "0"
       Me.lblid_proyecto.Visible = False
       '
       'btnBuscaproyecto
       '
       Me.btnBuscaproyecto.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBuscaproyecto.Image = CType(Resources.GetObject("btnBuscarChico.Image"), System.Drawing.Image)
       Me.btnBuscaproyecto.Location = New System.Drawing.Point(505, 48)
       Me.btnBuscaproyecto.Name = "btnBuscaproyecto"
       Me.btnBuscaproyecto.Size = New System.Drawing.Size(30, 21)
       Me.btnBuscaproyecto.TabIndex = 60
       Me.btnBuscaproyecto.UseVisualStyleBackColor = True
       '
       'cmbproyecto
       '
       Me.cmbproyecto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
       Me.cmbproyecto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
       Me.cmbproyecto.FormattingEnabled = True
       Me.cmbproyecto.Location = New System.Drawing.Point(161, 48)
       Me.cmbproyecto.Size = New System.Drawing.Size(329, 21)
       Me.cmbproyecto.Name = "cmbproyecto"
       Me.cmbproyecto.TabIndex = 4
       '
       'etiquietaid_proyecto
       '
       Me.etiquetaid_proyecto.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaid_proyecto.AutoSize = True
       Me.etiquetaid_proyecto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaid_proyecto.ForeColor = System.Drawing.Color.Black
       Me.etiquetaid_proyecto.Location = New System.Drawing.Point(28, 48)
       Me.etiquetaid_proyecto.Name = "etiquetaid_proyecto"
       Me.etiquetaid_proyecto.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaid_proyecto.TabIndex = 501
       Me.etiquetaid_proyecto.Text = "Proyecto"
       Me.etiquetaid_proyecto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'lblid_actividad
       '
       Me.lblid_actividad.AutoSize = True
       Me.lblid_actividad.BackColor = System.Drawing.Color.Red
       Me.lblid_actividad.Location = New System.Drawing.Point(370, 91)
       Me.lblid_actividad.Name = "lblid_actividad"
       Me.lblid_actividad.Size = New System.Drawing.Size(13, 13)
       Me.lblid_actividad.TabIndex = 502
       Me.lblid_actividad.Text = "0"
       Me.lblid_actividad.Visible = False
       '
       'btnBuscaactividad
       '
       Me.btnBuscaactividad.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBuscaactividad.Image = CType(Resources.GetObject("btnBuscarChico.Image"), System.Drawing.Image)
       Me.btnBuscaactividad.Location = New System.Drawing.Point(505, 91)
       Me.btnBuscaactividad.Name = "btnBuscaactividad"
       Me.btnBuscaactividad.Size = New System.Drawing.Size(30, 21)
       Me.btnBuscaactividad.TabIndex = 61
       Me.btnBuscaactividad.UseVisualStyleBackColor = True
       '
       'cmbactividad
       '
       Me.cmbactividad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
       Me.cmbactividad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
       Me.cmbactividad.FormattingEnabled = True
       Me.cmbactividad.Location = New System.Drawing.Point(161, 91)
       Me.cmbactividad.Size = New System.Drawing.Size(329, 21)
       Me.cmbactividad.Name = "cmbactividad"
       Me.cmbactividad.TabIndex = 5
       '
       'etiquietaid_actividad
       '
       Me.etiquetaid_actividad.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaid_actividad.AutoSize = True
       Me.etiquetaid_actividad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaid_actividad.ForeColor = System.Drawing.Color.Black
       Me.etiquetaid_actividad.Location = New System.Drawing.Point(28, 91)
       Me.etiquetaid_actividad.Name = "etiquetaid_actividad"
       Me.etiquetaid_actividad.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaid_actividad.TabIndex = 503
       Me.etiquetaid_actividad.Text = "Actividad"
       Me.etiquetaid_actividad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'dtpfecha_inicio
       '
       Me.dtpfecha_inicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
       Me.dtpfecha_inicio.Location = New System.Drawing.Point(161, 134)
       Me.dtpfecha_inicio.Name = "cmbfecha_inicio"
       Me.dtpfecha_inicio.Size = New System.Drawing.Size(93, 20)
       Me.dtpfecha_inicio.TabIndex = 6
       '
       'etiquietafecha_inicio
       '
       Me.etiquetafecha_inicio.BackColor = System.Drawing.Color.Transparent
       Me.etiquetafecha_inicio.AutoSize = True
       Me.etiquetafecha_inicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetafecha_inicio.ForeColor = System.Drawing.Color.Black
       Me.etiquetafecha_inicio.Location = New System.Drawing.Point(28, 134)
       Me.etiquetafecha_inicio.Name = "etiquetafecha_inicio"
       Me.etiquetafecha_inicio.Size = New System.Drawing.Size(127, 21)
       Me.etiquetafecha_inicio.TabIndex = 504
       Me.etiquetafecha_inicio.Text = "Fecha inicio"
       Me.etiquetafecha_inicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'dtpfecha_fin_previsto
       '
       Me.dtpfecha_fin_previsto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
       Me.dtpfecha_fin_previsto.Location = New System.Drawing.Point(161, 177)
       Me.dtpfecha_fin_previsto.Name = "cmbfecha_fin_previsto"
       Me.dtpfecha_fin_previsto.Size = New System.Drawing.Size(93, 20)
       Me.dtpfecha_fin_previsto.TabIndex = 7
       '
       'etiquietafecha_fin_previsto
       '
       Me.etiquetafecha_fin_previsto.BackColor = System.Drawing.Color.Transparent
       Me.etiquetafecha_fin_previsto.AutoSize = True
       Me.etiquetafecha_fin_previsto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetafecha_fin_previsto.ForeColor = System.Drawing.Color.Black
       Me.etiquetafecha_fin_previsto.Location = New System.Drawing.Point(28, 177)
       Me.etiquetafecha_fin_previsto.Name = "etiquetafecha_fin_previsto"
       Me.etiquetafecha_fin_previsto.Size = New System.Drawing.Size(127, 21)
       Me.etiquetafecha_fin_previsto.TabIndex = 505
       Me.etiquetafecha_fin_previsto.Text = "Fecha fin previsto"
       Me.etiquetafecha_fin_previsto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'dtpfecha_fin_real
       '
       Me.dtpfecha_fin_real.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
       Me.dtpfecha_fin_real.Location = New System.Drawing.Point(161, 220)
       Me.dtpfecha_fin_real.Name = "cmbfecha_fin_real"
       Me.dtpfecha_fin_real.Size = New System.Drawing.Size(93, 20)
       Me.dtpfecha_fin_real.TabIndex = 8
       '
       'etiquietafecha_fin_real
       '
       Me.etiquetafecha_fin_real.BackColor = System.Drawing.Color.Transparent
       Me.etiquetafecha_fin_real.AutoSize = True
       Me.etiquetafecha_fin_real.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetafecha_fin_real.ForeColor = System.Drawing.Color.Black
       Me.etiquetafecha_fin_real.Location = New System.Drawing.Point(28, 220)
       Me.etiquetafecha_fin_real.Name = "etiquetafecha_fin_real"
       Me.etiquetafecha_fin_real.Size = New System.Drawing.Size(127, 21)
       Me.etiquetafecha_fin_real.TabIndex = 506
       Me.etiquetafecha_fin_real.Text = "Fecha fin real"
       Me.etiquetafecha_fin_real.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtcantidad_hora
       '
       Me.txtcantidad_hora.BackColor = System.Drawing.Color.White
       Me.txtcantidad_hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.txtcantidad_hora.ForeColor = System.Drawing.Color.Blue
       Me.txtcantidad_hora.Location = New System.Drawing.Point(161, 263)
       Me.txtcantidad_hora.MaxLength = 50
       Me.txtcantidad_hora.Name = "txtcantidad_hora"
       Me.txtcantidad_hora.Size = New System.Drawing.Size(222, 31)
       Me.txtcantidad_hora.TabIndex = 9
       Me.txtcantidad_hora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
       '
       'etiquietacantidad_hora
       '
       Me.etiquetacantidad_hora.BackColor = System.Drawing.Color.Transparent
       Me.etiquetacantidad_hora.AutoSize = True
       Me.etiquetacantidad_hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetacantidad_hora.ForeColor = System.Drawing.Color.Black
       Me.etiquetacantidad_hora.Location = New System.Drawing.Point(28, 263)
       Me.etiquetacantidad_hora.Name = "etiquetacantidad_hora"
       Me.etiquetacantidad_hora.Size = New System.Drawing.Size(127, 21)
       Me.etiquetacantidad_hora.TabIndex = 507
       Me.etiquetacantidad_hora.Text = "Cantidad hora"
       Me.etiquetacantidad_hora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtobjetivo
       '
       Me.txtobjetivo.BackColor = System.Drawing.Color.White
       Me.txtobjetivo.Location = New System.Drawing.Point(161, 316)
       Me.txtobjetivo.Size = New System.Drawing.Size(385, 20)
       Me.txtobjetivo.MaxLength = 200
       Me.txtobjetivo.Name = "txtobjetivo"
       Me.txtobjetivo.TabIndex = 10
       '
       'etiquietaobjetivo
       '
       Me.etiquetaobjetivo.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaobjetivo.AutoSize = True
       Me.etiquetaobjetivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaobjetivo.ForeColor = System.Drawing.Color.Black
       Me.etiquetaobjetivo.Location = New System.Drawing.Point(28, 316)
       Me.etiquetaobjetivo.Name = "etiquetaobjetivo"
       Me.etiquetaobjetivo.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaobjetivo.TabIndex = 508
       Me.etiquetaobjetivo.Text = "Objetivo"
       Me.etiquetaobjetivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtprioridad
       '
       Me.txtprioridad.BackColor = System.Drawing.Color.White
       Me.txtprioridad.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.txtprioridad.ForeColor = System.Drawing.Color.Blue
       Me.txtprioridad.Location = New System.Drawing.Point(161, 359)
       Me.txtprioridad.MaxLength = 50
       Me.txtprioridad.Name = "txtprioridad"
       Me.txtprioridad.Size = New System.Drawing.Size(222, 31)
       Me.txtprioridad.TabIndex = 11
       Me.txtprioridad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
       '
       'etiquietaprioridad
       '
       Me.etiquetaprioridad.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaprioridad.AutoSize = True
       Me.etiquetaprioridad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaprioridad.ForeColor = System.Drawing.Color.Black
       Me.etiquetaprioridad.Location = New System.Drawing.Point(28, 359)
       Me.etiquetaprioridad.Name = "etiquetaprioridad"
       Me.etiquetaprioridad.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaprioridad.TabIndex = 509
       Me.etiquetaprioridad.Text = "Prioridad"
       Me.etiquetaprioridad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtcomplejidad
       '
       Me.txtcomplejidad.BackColor = System.Drawing.Color.White
       Me.txtcomplejidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.txtcomplejidad.ForeColor = System.Drawing.Color.Blue
       Me.txtcomplejidad.Location = New System.Drawing.Point(161, 412)
       Me.txtcomplejidad.MaxLength = 50
       Me.txtcomplejidad.Name = "txtcomplejidad"
       Me.txtcomplejidad.Size = New System.Drawing.Size(222, 31)
       Me.txtcomplejidad.TabIndex = 12
       Me.txtcomplejidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
       '
       'etiquietacomplejidad
       '
       Me.etiquetacomplejidad.BackColor = System.Drawing.Color.Transparent
       Me.etiquetacomplejidad.AutoSize = True
       Me.etiquetacomplejidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetacomplejidad.ForeColor = System.Drawing.Color.Black
       Me.etiquetacomplejidad.Location = New System.Drawing.Point(28, 412)
       Me.etiquetacomplejidad.Name = "etiquetacomplejidad"
       Me.etiquetacomplejidad.Size = New System.Drawing.Size(127, 21)
       Me.etiquetacomplejidad.TabIndex = 510
       Me.etiquetacomplejidad.Text = "Complejidad"
       Me.etiquetacomplejidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtavance
       '
       Me.txtavance.BackColor = System.Drawing.Color.White
       Me.txtavance.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.txtavance.ForeColor = System.Drawing.Color.Blue
       Me.txtavance.Location = New System.Drawing.Point(161, 465)
       Me.txtavance.MaxLength = 50
       Me.txtavance.Name = "txtavance"
       Me.txtavance.Size = New System.Drawing.Size(222, 31)
       Me.txtavance.TabIndex = 13
       Me.txtavance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
       '
       'etiquietaavance
       '
       Me.etiquetaavance.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaavance.AutoSize = True
       Me.etiquetaavance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaavance.ForeColor = System.Drawing.Color.Black
       Me.etiquetaavance.Location = New System.Drawing.Point(28, 465)
       Me.etiquetaavance.Name = "etiquetaavance"
       Me.etiquetaavance.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaavance.TabIndex = 511
       Me.etiquetaavance.Text = "Avance"
       Me.etiquetaavance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtobservacion
       '
       Me.txtobservacion.BackColor = System.Drawing.Color.White
       Me.txtobservacion.Location = New System.Drawing.Point(161, 518)
       Me.txtobservacion.Size = New System.Drawing.Size(385, 20)
       Me.txtobservacion.MaxLength = 500
       Me.txtobservacion.Name = "txtobservacion"
       Me.txtobservacion.TabIndex = 14
       '
       'etiquietaobservacion
       '
       Me.etiquetaobservacion.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaobservacion.AutoSize = True
       Me.etiquetaobservacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaobservacion.ForeColor = System.Drawing.Color.Black
       Me.etiquetaobservacion.Location = New System.Drawing.Point(28, 518)
       Me.etiquetaobservacion.Name = "etiquetaobservacion"
       Me.etiquetaobservacion.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaobservacion.TabIndex = 512
       Me.etiquetaobservacion.Text = "Observacion"
       Me.etiquetaobservacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtorden
       '
       Me.txtorden.BackColor = System.Drawing.Color.White
       Me.txtorden.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.txtorden.ForeColor = System.Drawing.Color.Blue
       Me.txtorden.Location = New System.Drawing.Point(161, 561)
       Me.txtorden.MaxLength = 50
       Me.txtorden.Name = "txtorden"
       Me.txtorden.Size = New System.Drawing.Size(222, 31)
       Me.txtorden.TabIndex = 15
       Me.txtorden.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
       '
       'etiquietaorden
       '
       Me.etiquetaorden.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaorden.AutoSize = True
       Me.etiquetaorden.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaorden.ForeColor = System.Drawing.Color.Black
       Me.etiquetaorden.Location = New System.Drawing.Point(28, 561)
       Me.etiquetaorden.Name = "etiquetaorden"
       Me.etiquetaorden.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaorden.TabIndex = 513
       Me.etiquetaorden.Text = "Orden"
       Me.etiquetaorden.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'lblid_controlador_1
       '
       Me.lblid_controlador_1.AutoSize = True
       Me.lblid_controlador_1.BackColor = System.Drawing.Color.Red
       Me.lblid_controlador_1.Location = New System.Drawing.Point(800, 48)
       Me.lblid_controlador_1.Name = "lblid_controlador_1"
       Me.lblid_controlador_1.Size = New System.Drawing.Size(13, 13)
       Me.lblid_controlador_1.TabIndex = 514
       Me.lblid_controlador_1.Text = "0"
       Me.lblid_controlador_1.Visible = False
       '
       'btnBuscacontrolador_1
       '
       Me.btnBuscacontrolador_1.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBuscacontrolador_1.Image = CType(Resources.GetObject("btnBuscarChico.Image"), System.Drawing.Image)
       Me.btnBuscacontrolador_1.Location = New System.Drawing.Point(964, 48)
       Me.btnBuscacontrolador_1.Name = "btnBuscacontrolador_1"
       Me.btnBuscacontrolador_1.Size = New System.Drawing.Size(30, 21)
       Me.btnBuscacontrolador_1.TabIndex = 62
       Me.btnBuscacontrolador_1.UseVisualStyleBackColor = True
       '
       'cmbcontrolador_1
       '
       Me.cmbcontrolador_1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
       Me.cmbcontrolador_1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
       Me.cmbcontrolador_1.FormattingEnabled = True
       Me.cmbcontrolador_1.Location = New System.Drawing.Point(656, 48)
       Me.cmbcontrolador_1.Size = New System.Drawing.Size(286, 21)
       Me.cmbcontrolador_1.Name = "cmbcontrolador_1"
       Me.cmbcontrolador_1.TabIndex = 16
       '
       'etiquietaid_controlador_1
       '
       Me.etiquetaid_controlador_1.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaid_controlador_1.AutoSize = True
       Me.etiquetaid_controlador_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaid_controlador_1.ForeColor = System.Drawing.Color.Black
       Me.etiquetaid_controlador_1.Location = New System.Drawing.Point(583, 48)
       Me.etiquetaid_controlador_1.Name = "etiquetaid_controlador_1"
       Me.etiquetaid_controlador_1.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaid_controlador_1.TabIndex = 515
       Me.etiquetaid_controlador_1.Text = "Controlador 1"
       Me.etiquetaid_controlador_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'lblid_controlador_2
       '
       Me.lblid_controlador_2.AutoSize = True
       Me.lblid_controlador_2.BackColor = System.Drawing.Color.Red
       Me.lblid_controlador_2.Location = New System.Drawing.Point(800, 91)
       Me.lblid_controlador_2.Name = "lblid_controlador_2"
       Me.lblid_controlador_2.Size = New System.Drawing.Size(13, 13)
       Me.lblid_controlador_2.TabIndex = 516
       Me.lblid_controlador_2.Text = "0"
       Me.lblid_controlador_2.Visible = False
       '
       'btnBuscacontrolador_2
       '
       Me.btnBuscacontrolador_2.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBuscacontrolador_2.Image = CType(Resources.GetObject("btnBuscarChico.Image"), System.Drawing.Image)
       Me.btnBuscacontrolador_2.Location = New System.Drawing.Point(964, 91)
       Me.btnBuscacontrolador_2.Name = "btnBuscacontrolador_2"
       Me.btnBuscacontrolador_2.Size = New System.Drawing.Size(30, 21)
       Me.btnBuscacontrolador_2.TabIndex = 63
       Me.btnBuscacontrolador_2.UseVisualStyleBackColor = True
       '
       'cmbcontrolador_2
       '
       Me.cmbcontrolador_2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
       Me.cmbcontrolador_2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
       Me.cmbcontrolador_2.FormattingEnabled = True
       Me.cmbcontrolador_2.Location = New System.Drawing.Point(656, 91)
       Me.cmbcontrolador_2.Size = New System.Drawing.Size(286, 21)
       Me.cmbcontrolador_2.Name = "cmbcontrolador_2"
       Me.cmbcontrolador_2.TabIndex = 17
       '
       'etiquietaid_controlador_2
       '
       Me.etiquetaid_controlador_2.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaid_controlador_2.AutoSize = True
       Me.etiquetaid_controlador_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaid_controlador_2.ForeColor = System.Drawing.Color.Black
       Me.etiquetaid_controlador_2.Location = New System.Drawing.Point(583, 91)
       Me.etiquetaid_controlador_2.Name = "etiquetaid_controlador_2"
       Me.etiquetaid_controlador_2.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaid_controlador_2.TabIndex = 517
       Me.etiquetaid_controlador_2.Text = "Controlador 2"
       Me.etiquetaid_controlador_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'lblnro
       '
       Me.lblnro.AutoSize = True
       Me.lblnro.BackColor = System.Drawing.Color.Red
       Me.lblnro.Location = New System.Drawing.Point(800, 134)
       Me.lblnro.Name = "lblnro"
       Me.lblnro.Size = New System.Drawing.Size(13, 13)
       Me.lblnro.TabIndex = 518
       Me.lblnro.Text = "0"
       Me.lblnro.Visible = False
       '
       'btnBusca
       '
       Me.btnBusca.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBusca.Image = CType(Resources.GetObject("btnBuscarChico.Image"), System.Drawing.Image)
       Me.btnBusca.Location = New System.Drawing.Point(964, 134)
       Me.btnBusca.Name = "btnBusca"
       Me.btnBusca.Size = New System.Drawing.Size(30, 21)
       Me.btnBusca.TabIndex = 64
       Me.btnBusca.UseVisualStyleBackColor = True
       '
       'cmb
       '
       Me.cmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
       Me.cmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
       Me.cmb.FormattingEnabled = True
       Me.cmb.Location = New System.Drawing.Point(656, 134)
       Me.cmb.Size = New System.Drawing.Size(286, 21)
       Me.cmb.Name = "cmb"
       Me.cmb.TabIndex = 18
       '
       'etiquietanro
       '
       Me.etiquetanro.BackColor = System.Drawing.Color.Transparent
       Me.etiquetanro.AutoSize = True
       Me.etiquetanro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetanro.ForeColor = System.Drawing.Color.Black
       Me.etiquetanro.Location = New System.Drawing.Point(583, 134)
       Me.etiquetanro.Name = "etiquetanro"
       Me.etiquetanro.Size = New System.Drawing.Size(127, 21)
       Me.etiquetanro.TabIndex = 519
       Me.etiquetanro.Text = ""
       Me.etiquetanro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'btnSalir
       '
       Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
       Me.btnSalir.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.btnSalir.ForeColor = System.Drawing.Color.Black
       Me.btnSalir.Image = CType(Resources.GetObject("btnSalir.Image"), System.Drawing.Image)
       Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
       Me.btnSalir.Location = New System.Drawing.Point(931, 647)
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
       Me.btnGuardar.Image = CType(Resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
       Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
       Me.btnGuardar.Location = New System.Drawing.Point(831, 647)
       Me.btnGuardar.Name = "btnGuardar"
       Me.btnGuardar.Size = New System.Drawing.Size(81, 61)
       Me.btnGuardar.TabIndex = 50
       Me.btnGuardar.Text = "&Guardar"
       Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
       Me.btnGuardar.UseVisualStyleBackColor = True
       '
       'GroupBox1
       '
       Me.GroupBox1.Location = New System.Drawing.Point(12, 17)
       Me.GroupBox1.Name = "GroupBox1"
       Me.GroupBox1.Size = New System.Drawing.Size(1000, 606)
       Me.GroupBox1.TabIndex = 0
       Me.GroupBox1.TabStop = False
       '
       'frmDetalleActividad_proyecto
       '
       Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
       Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
       Me.ClientSize = New System.Drawing.Size(1024, 768)
       Me.Controls.Add(Me.lblid_proyecto)
       Me.Controls.Add(Me.btnBuscaproyecto)
       Me.Controls.Add(Me.cmbproyecto)
       Me.Controls.Add(Me.etiquetaid_proyecto)
       Me.Controls.Add(Me.lblid_actividad)
       Me.Controls.Add(Me.btnBuscaactividad)
       Me.Controls.Add(Me.cmbactividad)
       Me.Controls.Add(Me.etiquetaid_actividad)
       Me.Controls.Add(Me.dtpfecha_inicio)
       Me.Controls.Add(Me.etiquetafecha_inicio)
       Me.Controls.Add(Me.dtpfecha_fin_previsto)
       Me.Controls.Add(Me.etiquetafecha_fin_previsto)
       Me.Controls.Add(Me.dtpfecha_fin_real)
       Me.Controls.Add(Me.etiquetafecha_fin_real)
       Me.Controls.Add(Me.txtcantidad_hora)
       Me.Controls.Add(Me.etiquetacantidad_hora)
       Me.Controls.Add(Me.txtobjetivo)
       Me.Controls.Add(Me.etiquetaobjetivo)
       Me.Controls.Add(Me.txtprioridad)
       Me.Controls.Add(Me.etiquetaprioridad)
       Me.Controls.Add(Me.txtcomplejidad)
       Me.Controls.Add(Me.etiquetacomplejidad)
       Me.Controls.Add(Me.txtavance)
       Me.Controls.Add(Me.etiquetaavance)
       Me.Controls.Add(Me.txtobservacion)
       Me.Controls.Add(Me.etiquetaobservacion)
       Me.Controls.Add(Me.txtorden)
       Me.Controls.Add(Me.etiquetaorden)
       Me.Controls.Add(Me.lblid_controlador_1)
       Me.Controls.Add(Me.btnBuscacontrolador_1)
       Me.Controls.Add(Me.cmbcontrolador_1)
       Me.Controls.Add(Me.etiquetaid_controlador_1)
       Me.Controls.Add(Me.lblid_controlador_2)
       Me.Controls.Add(Me.btnBuscacontrolador_2)
       Me.Controls.Add(Me.cmbcontrolador_2)
       Me.Controls.Add(Me.etiquetaid_controlador_2)
       Me.Controls.Add(Me.lblnro)
       Me.Controls.Add(Me.btnBusca)
       Me.Controls.Add(Me.cmb)
       Me.Controls.Add(Me.etiquetanro)
       Me.Controls.Add(Me.btnSalir)
       Me.Controls.Add(Me.btnGuardar)
       Me.Controls.Add(Me.GroupBox1)
       Me.Name = "frmDetalleActividad_proyecto"
       Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
       Me.Text = "frmDetalleActividad_proyecto" & vgNombreFormulario
       Me.ResumeLayout(False)
       Me.PerformLayout()

   End Sub
   Friend WithEvents lblid_proyecto As System.Windows.Forms.Label
   Friend WithEvents btnBuscaproyecto As System.Windows.Forms.Button
   Friend WithEvents cmbproyecto As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_proyecto As System.Windows.Forms.Label
   Friend WithEvents lblid_actividad As System.Windows.Forms.Label
   Friend WithEvents btnBuscaactividad As System.Windows.Forms.Button
   Friend WithEvents cmbactividad As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_actividad As System.Windows.Forms.Label
   Protected WithEvents dtpfecha_inicio As System.Windows.Forms.DateTimePicker
   Friend WithEvents etiquetafecha_inicio As System.Windows.Forms.Label
   Protected WithEvents dtpfecha_fin_previsto As System.Windows.Forms.DateTimePicker
   Friend WithEvents etiquetafecha_fin_previsto As System.Windows.Forms.Label
   Protected WithEvents dtpfecha_fin_real As System.Windows.Forms.DateTimePicker
   Friend WithEvents etiquetafecha_fin_real As System.Windows.Forms.Label
   Protected WithEvents txtcantidad_hora As System.Windows.Forms.TextBox
   Friend WithEvents etiquetacantidad_hora As System.Windows.Forms.Label
   Protected WithEvents txtobjetivo As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaobjetivo As System.Windows.Forms.Label
   Protected WithEvents txtprioridad As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaprioridad As System.Windows.Forms.Label
   Protected WithEvents txtcomplejidad As System.Windows.Forms.TextBox
   Friend WithEvents etiquetacomplejidad As System.Windows.Forms.Label
   Protected WithEvents txtavance As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaavance As System.Windows.Forms.Label
   Protected WithEvents txtobservacion As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaobservacion As System.Windows.Forms.Label
   Protected WithEvents txtorden As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaorden As System.Windows.Forms.Label
   Friend WithEvents lblid_controlador_1 As System.Windows.Forms.Label
   Friend WithEvents btnBuscacontrolador_1 As System.Windows.Forms.Button
   Friend WithEvents cmbcontrolador_1 As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_controlador_1 As System.Windows.Forms.Label
   Friend WithEvents lblid_controlador_2 As System.Windows.Forms.Label
   Friend WithEvents btnBuscacontrolador_2 As System.Windows.Forms.Button
   Friend WithEvents cmbcontrolador_2 As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_controlador_2 As System.Windows.Forms.Label
   Friend WithEvents lblnro As System.Windows.Forms.Label
   Friend WithEvents btnBusca As System.Windows.Forms.Button
   Friend WithEvents cmb As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetanro As System.Windows.Forms.Label
   Protected WithEvents btnSalir As System.Windows.Forms.Button
   Protected WithEvents btnGuardar As System.Windows.Forms.Button
   Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
   Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
End Class

