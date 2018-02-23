﻿Public Class frmReportePagoProveedorEntreFechaAgrupado

    Private Sub frmReportePagoProveedorEntreFechaAgrupado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim paramList As New List(Of Microsoft.Reporting.WinForms.ReportParameter)
        Dim param_fecha_inicio As New Microsoft.Reporting.WinForms.ReportParameter("parametro_fecha_inicio", parametro_fecha_inicio.ToString())
        Dim param_fecha_fin As New Microsoft.Reporting.WinForms.ReportParameter("parametro_fecha_fin", parametro_fecha_fin.ToString())

        paramList.Add(param_fecha_inicio)
        paramList.Add(param_fecha_fin)

        ReportViewer1.LocalReport.SetParameters(paramList)

        Me.cop_Recibo_proveedor_GetAll_4TableAdapter.Fill(Me.PymenDataSet.cop_Recibo_proveedor_GetAll_4, parametro_fecha_inicio, parametro_fecha_fin)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class