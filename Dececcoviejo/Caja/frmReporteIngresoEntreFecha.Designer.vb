﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteIngresoEntreFecha
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DececcoDataSet1 = New Dececco.DececcoDataSet1()
        Me.cop_Ingreso_efectivo_GetAllEntreFechaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cop_Ingreso_efectivo_GetAllEntreFechaTableAdapter = New Dececco.DececcoDataSet1TableAdapters.cop_Ingreso_efectivo_GetAllEntreFechaTableAdapter()
        CType(Me.DececcoDataSet1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cop_Ingreso_efectivo_GetAllEntreFechaBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.cop_Ingreso_efectivo_GetAllEntreFechaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Dececco.rptIngresoEfectivoEntreFechas.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(758, 556)
        Me.ReportViewer1.TabIndex = 0
        '
        'DececcoDataSet1
        '
        Me.DececcoDataSet1.DataSetName = "DececcoDataSet1"
        Me.DececcoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cop_Ingreso_efectivo_GetAllEntreFechaBindingSource
        '
        Me.cop_Ingreso_efectivo_GetAllEntreFechaBindingSource.DataMember = "cop_Ingreso_efectivo_GetAllEntreFecha"
        Me.cop_Ingreso_efectivo_GetAllEntreFechaBindingSource.DataSource = Me.DececcoDataSet1
        '
        'cop_Ingreso_efectivo_GetAllEntreFechaTableAdapter
        '
        Me.cop_Ingreso_efectivo_GetAllEntreFechaTableAdapter.ClearBeforeFill = true
        '
        'frmReporteIngresoEntreFecha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 556)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmReporteIngresoEntreFecha"
        Me.Text = "frmReporteIngresoEntreFecha"
        CType(Me.DececcoDataSet1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cop_Ingreso_efectivo_GetAllEntreFechaBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents cop_Ingreso_efectivo_GetAllEntreFechaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DececcoDataSet1 As Dececco.DececcoDataSet1
    Friend WithEvents cop_Ingreso_efectivo_GetAllEntreFechaTableAdapter As Dececco.DececcoDataSet1TableAdapters.cop_Ingreso_efectivo_GetAllEntreFechaTableAdapter
    ' Friend WithEvents PymenDataSet As Pymen.PymenDataSet
    'Friend WithEvents cop_Ingreso_efectivo_GetAllEntreFechaTableAdapter As Pymen.PymenDataSetTableAdapters.cop_Ingreso_efectivo_GetAllEntreFechaTableAdapter
End Class
