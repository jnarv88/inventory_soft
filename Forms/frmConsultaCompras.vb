Public Class frmConsultaCompras
    Private comp As DAO.Compra
    Private Sub frmConsultaCompras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadProveedores()
    End Sub
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        loadData()
    End Sub
    Private Sub rbCodFactura_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCodFactura.CheckedChanged, btnLimpiar.Click
        If Me.rbCodFactura.Checked = True Then
            cleanBusqueda()
            Me.txtCodFactura.Focus()
        Else
            cleanBusqueda()
            Me.cmbEstado.Focus()
        End If
    End Sub
    Private Sub dataFacturas_RowHeaderMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dataFacturas.RowHeaderMouseDoubleClick
        loadProductos()
    End Sub
    Private Sub dataFacturas_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dataFacturas.KeyDown
        If e.KeyCode = Keys.Space Then
            loadProductos()
        End If
    End Sub
    Private Sub dataFacturas_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataFacturas.CellDoubleClick
        loadProductos()
    End Sub
    '
    Sub loadData()
        Try
            Dim mcomp As New Model.Compra
            Dim fechaInicio As String = Date.Now.ToString
            Dim fechaFin As String = Date.Now.ToString

            If rbCodFactura.Checked Then
                mcomp.factura = txtCodFactura.Text.Trim
                mcomp.estado = ""
                mcomp.idusuario = ""
            End If

            If rbPersonalizada.Checked Then
                mcomp.factura = ""
                If cmbEstado.SelectedIndex > -1 Then
                    mcomp.estado = cmbEstado.SelectedItem.ToString
                Else
                    mcomp.estado = ""
                End If
                If cmbProveedor.SelectedIndex > -1 Then
                    mcomp.idusuario = cmbProveedor.SelectedItem.ToString
                Else
                    mcomp.idusuario = ""
                End If
                fechaInicio = txtFechaInicio.Text
                fechaFin = txtFechaFin.Text
            End If
            comp = New DAO.Compra(mcomp)
            Me.dataFacturas.DataSource = comp.getComprasByFiltro(cbRangoFechas.Checked, fechaInicio, fechaFin)
            Dim conf As New util.Config
            conf.configGrid(Me.dataFacturas)
            Me.dataFacturas.Refresh()
            verTotales()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Sub loadProximasVencerse()
        comp = New DAO.Compra()
        Me.dataFacturas.DataSource = comp.getComprasProximasVencerse
        Dim conf As New util.Config
        conf.configGrid(Me.dataFacturas)
        Me.dataFacturas.Refresh()
        verTotales()
    End Sub
    Sub verTotales()
        Dim filas As Integer = Me.dataFacturas.Rows.Count
        Me.lblItems.Text = filas.ToString + " Facturas Encontradas."
        Dim total As Double = 0
        For i As Integer = 0 To filas - 1
            total += Double.Parse(Me.dataFacturas.Item(Me.dataFacturas.Columns.Count - 2, i).Value.ToString)
        Next
        Me.txtTotal.Value = total
    End Sub
    Sub loadProveedores()
        Dim pr As New DAO.Proveedor
        Dim datos As DataTable = pr.getAll("")
        Me.cmbProveedor.Items.Clear()
        For i As Integer = 0 To datos.Rows.Count - 1
            Me.cmbProveedor.Items.Add(datos.Rows(i)(1).ToString)
        Next
    End Sub
    Sub loadProductos()
        Try
            Dim mcomp As New Model.Compra
            mcomp.factura = Me.dataFacturas.CurrentRow.Cells(0).Value.ToString
            comp = New DAO.Compra(mcomp)
            Me.dataProductos.DataSource = comp.getProductosCompra
            Dim conf As New util.Config
            conf.configGrid(Me.dataProductos)
            Me.tabProductos.Text = "Productos de la Factura: " + mcomp.factura.ToUpper + ", Items: " + Me.dataProductos.Rows.Count.ToString
            Me.dataProductos.Refresh()
            Me.tabsResultados.SelectedTab = tabProductos
        Catch ex As Exception

        End Try
    End Sub
    Sub cleanBusqueda()
        Me.txtCodFactura.Text = ""
        Me.cmbEstado.SelectedIndex = -1
        Me.cmbProveedor.SelectedIndex = -1
        Me.cbRangoFechas.Checked = False
    End Sub

End Class