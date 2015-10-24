Public Class frmResumenDia
    Private mvta As New Model.Venta
    Private vta As DAO.Venta
    Private Sub frmResumenDia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadData()
    End Sub
    Private Sub txtFactura_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFactura.TextChanged
        loadData()
    End Sub
    Private Sub txtFecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFecha.ValueChanged
        loadData()
    End Sub
    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        imprimir()
    End Sub
    Private Sub btnAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnular.Click
        anular()
    End Sub
    '-----------------------------------------------------------------------------
    Sub loadData()
        Try
            mvta.fecha = txtFecha.Text
            mvta.factura = txtFactura.Text.Trim
            vta = New DAO.Venta(mvta)
            Me.DataFacturas.DataSource = vta.resumeDay
            Dim conf As New util.Config
            conf.configGrid(Me.DataFacturas)
            Me.DataFacturas.Refresh()
            Me.lblContado.Text = "Total Efectivo: " + vta.getTotalByStatus("R").ToString
            Me.lblCredito.Text = "Total Credito: " + vta.getTotalByStatus("PND").ToString
            Me.lblAnulado.Text = "Total Anulado: " + vta.getTotalByStatus("ANL").ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub imprimir()
        Try
            Dim fact As String = DataFacturas.CurrentRow.Cells(0).Value.ToString
            mvta.factura = fact
            vta = New DAO.Venta(mvta)
            vta.reportFactura()
        Catch ex As Exception
        End Try
    End Sub
    Sub anular()
        Try
            Dim fact As String = DataFacturas.CurrentRow.Cells(0).Value.ToString
            mvta.factura = fact
            vta = New DAO.Venta(mvta)
            vta.suspend()
            loadData()
        Catch ex As Exception
        End Try
    End Sub
End Class