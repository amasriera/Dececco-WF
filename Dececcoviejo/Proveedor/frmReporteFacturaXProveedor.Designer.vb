﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteFacturaXProveedor
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
        Me.DececcoDataSet = New Dececco.DececcoDataSet()
        Me.cop_Factura_proveedor_GetAll_Entre_FechasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cop_Factura_proveedor_GetAll_Entre_FechasTableAdapter = New Dececco.DececcoDataSetTableAdapters.cop_Factura_proveedor_GetAll_Entre_FechasTableAdapter()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.DececcoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cop_Factura_proveedor_GetAll_Entre_FechasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DececcoDataSet
        '
        Me.DececcoDataSet.DataSetName = "DececcoDataSet"
        Me.DececcoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cop_Factura_proveedor_GetAll_Entre_FechasBindingSource
        '
        Me.cop_Factura_proveedor_GetAll_Entre_FechasBindingSource.DataMember = "cop_Factura_proveedor_GetAll_Entre_Fechas"
        Me.cop_Factura_proveedor_GetAll_Entre_FechasBindingSource.DataSource = Me.DececcoDataSet
        '
        'cop_Factura_proveedor_GetAll_Entre_FechasTableAdapter
        '
        Me.cop_Factura_proveedor_GetAll_Entre_FechasTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.cop_Factura_proveedor_GetAll_Entre_FechasBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Dececco.rptCheque_recibido.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(623, 436)
        Me.ReportViewer1.TabIndex = 0
        '
        'frmReporteFacturaXProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 436)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmReporteFacturaXProveedor"
        Me.Text = "frmReporteFacturaProveedor"
        CType(Me.DececcoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cop_Factura_proveedor_GetAll_Entre_FechasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cop_Factura_proveedor_GetAll_Entre_FechasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DececcoDataSet As Dececco.DececcoDataSet
    Friend WithEvents cop_Factura_proveedor_GetAll_Entre_FechasTableAdapter As Dececco.DececcoDataSetTableAdapters.cop_Factura_proveedor_GetAll_Entre_FechasTableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
