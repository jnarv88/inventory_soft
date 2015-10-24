Public Class frmCompra
    Private mcomp As New Model.Compra
    Private comp As New DAO.Compra
    Private prod As New DAO.producto
    Private mprod As New Model.producto
    Private prov As New DAO.Proveedor
    Private conf As New util.Config
    Private Sub frmFacturacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.txtBarra.Text = ""
        Me.txtBarra.Focus()
    End Sub
    Private Sub txtCodProv_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodProv.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                cargarProveedoresPorNum()
            Catch ex As Exception

            End Try
        End If
    End Sub
    Private Sub txtNumProd_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNumProd.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                cargarProdsPorCodigo()
            Catch ex As Exception

            End Try
        End If
    End Sub
    Private Sub txtBarra_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBarra.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                cargarProdsPorbarra()
            Catch ex As Exception

            End Try
        End If
    End Sub
    Private Sub frmFacturacion_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp, txtBarra.KeyUp, txtNumProd.KeyUp, DataProductos.KeyUp, btnAdd.KeyUp, btnFindProd.KeyUp, txtPrecio.KeyUp, txtCant.KeyUp, txtFecha.KeyUp, txtFechaVence.KeyUp, txtBonifs.KeyUp, txtDescuento.KeyUp, txtCostoUnit.KeyUp, cbIVA.KeyUp, txtCodProv.KeyUp, rbCred.KeyUp, rbCont.KeyUp, btnFindProv.KeyUp, btnFacturar.KeyUp, btnCancel.KeyUp
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        ElseIf e.KeyCode = Keys.F2 Then
            viewProveedores()
        ElseIf e.KeyCode = Keys.F3 Then
            viewProds()
        ElseIf e.KeyCode = Keys.F5 Then
            facturar()
        End If
    End Sub
    Private Sub txtCant_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCant.KeyDown, txtBonifs.KeyDown, txtCostoUnit.KeyDown, txtDescuento.KeyDown, txtPrecio.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                addRowProd()
            Catch ex As Exception
            End Try
        End If
    End Sub
    Private Sub btnFindClie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindProv.Click
        viewProveedores()
    End Sub
    Private Sub btnFindProd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindProd.Click
        viewProds()
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        addRowProd()
    End Sub
    Private Sub DataProductos_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataProductos.KeyDown
        If e.KeyCode = Keys.Back Then
            Me.DataProductos.Rows.RemoveAt(Me.DataProductos.CurrentRow.Index)
            Me.verTotales()
        End If
    End Sub
    Private Sub btnFacturar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFacturar.Click
        facturar()
    End Sub
    Private Sub rbCred_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCred.CheckedChanged
        Me.txtCodProv.Focus()
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub
    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        cleanProdAdding()
    End Sub
    '--------------------------------------------------------------------------------------------------------'
    Sub cargarProveedoresPorNum()
        Dim mprov As New Model.Proveedor
        mprov.idProveedor = Integer.Parse(Me.txtCodProv.Text.Trim)
        prov = New DAO.Proveedor(mprov)
        mprov = prov.getProveedor
        Me.txtProveedor.Text = mprov.nombre_comercial
        Me.txtBarra.Focus()
    End Sub
    Function getInstanceProdByCode() As Model.producto
        mprod.codigo = Integer.Parse(Me.txtNumProd.Text.Trim)
        prod = New DAO.producto(mprod)
        Return prod.getProductoByCode()
    End Function
    Sub cargarProdsPorCodigo()
        mprod = getInstanceProdByCode()
        asignarFields()
    End Sub
    Sub cargarProdsPorbarra()
        mprod.codigo_barra = Me.txtBarra.Text
        prod = New DAO.producto(mprod)
        mprod = prod.getProductoByBarCode()
        asignarFields()
    End Sub
    Sub asignarFields()
        Me.txtBarra.Text = mprod.codigo_barra
        Me.txtProd.Text = mprod.nombre_comercial + " * " + mprod.unidad_medida + " * " + mprod.laboratorio + " * " + mprod.descripcion
        Me.txtDisponibles.Value = mprod.existencia
        Me.txtCostoUnit.Value = mprod.costo
        Me.txtPrecio.Value = mprod.precio
        Me.txtCant.Value = 0
        Me.txtBonifs.Value = 0
        Me.txtDescuento.Value = 0
        Me.cbIVA.Checked = False
        Me.txtCant.Focus()
    End Sub
    Sub viewProds()
        Dim frmprod As New Form1(Me, 2)
        frmprod.ShowDialog()
    End Sub
    Sub viewProveedores()
        Dim frmp As New frmProveedoresView(Me, 1)
        frmp.ShowDialog()
    End Sub
    Sub addRowProd()
        If Me.txtNumProd.Text <> Nothing And Me.txtCant.Value > 0 And Me.txtCostoUnit.Value > 0 And Me.txtPrecio.Value > 0 And Me.txtProd.Text <> Nothing Then
            Dim cantidad As Integer = Integer.Parse(Me.txtCant.Value)
            Dim bonif As Double = Double.Parse(txtBonifs.Value.ToString)
            Dim costo As Double = Double.Parse(txtCostoUnit.Value.ToString)
            Dim descto As Double = Double.Parse(txtDescuento.Value.ToString)
            Dim iva As Double = 0
            If cbIVA.Checked Then
                iva = (costo - descto) * 0.15
            End If
            Dim total As Double = cantidad * (costo - descto + iva)
            Dim precio As Double = Double.Parse(txtPrecio.Value.ToString)
            If costo < precio Then
                If descto < costo Then
                    Me.DataProductos.Rows.Add()
                    Dim ultimafila As Integer = Me.DataProductos.Rows.Count - 1
                    Me.DataProductos.Item(0, ultimafila).Value = cantidad
                    Me.DataProductos.Item(1, ultimafila).Value = bonif
                    Me.DataProductos.Item(2, ultimafila).Value = Me.txtNumProd.Text
                    Me.DataProductos.Item(3, ultimafila).Value = Me.txtBarra.Text
                    Me.DataProductos.Item(4, ultimafila).Value = Me.txtProd.Text
                    Me.DataProductos.Item(5, ultimafila).Value = costo
                    Me.DataProductos.Item(6, ultimafila).Value = descto
                    Me.DataProductos.Item(7, ultimafila).Value = iva
                    Me.DataProductos.Item(8, ultimafila).Value = total
                    Me.DataProductos.Item(9, ultimafila).Value = precio
                    cleanProdAdding()
                    conf.configGrid(Me.DataProductos)
                    verTotales()
                Else
                    MsgBox("El descuento unitario no debe ser mayor que el costo.", MsgBoxStyle.Critical)
                End If
            Else
                MsgBox("El costo unitario no debe ser mayor que el precio sugerido.", MsgBoxStyle.Critical)
            End If
        Else
            MsgBox("Verifique que sus datos sean correctos antes de agregarlos.", MsgBoxStyle.Critical)
        End If
    End Sub
    Sub cleanProdAdding()
        Me.txtNumProd.Text = ""
        Me.txtBarra.Text = ""
        Me.txtProd.Text = ""
        Me.txtDisponibles.Value = 0
        Me.txtCant.Value = 0
        Me.txtBonifs.Value = 0
        Me.txtCostoUnit.Value = 0
        Me.txtDescuento.Value = 0
        Me.txtPrecio.Value = 0
        Me.cbIVA.Checked = False
        Me.txtBarra.Focus()
    End Sub
    Sub verTotales()
        Dim filas As Integer = Me.DataProductos.Rows.Count
        Me.lblItems.Text = filas.ToString + " Items."
        Dim subtotal As Double = 0
        Dim descto As Double = 0
        Dim iva As Double = 0
        Dim total As Double = 0
        For i As Integer = 0 To filas - 1
            Dim cant As Integer = Integer.Parse(Me.DataProductos.Item(0, i).Value.ToString)
            subtotal += Double.Parse(Me.DataProductos.Item(5, i).Value.ToString) * cant
            descto += Double.Parse(Me.DataProductos.Item(6, i).Value.ToString) * cant
            iva += Double.Parse(Me.DataProductos.Item(7, i).Value.ToString) * cant
            total += Double.Parse(Me.DataProductos.Item(8, i).Value.ToString)
        Next
        Me.txtSubTotal.Value = subtotal
        Me.txtDescuentoTot.Value = descto
        Me.txtIVA.Value = iva
        Me.txtTotal.Value = total
    End Sub
    Sub facturar()
        Try
            If Me.txtNumfact.Text.Trim = Nothing Then
                MsgBox("Por favor, Ingrese el codigo de la factura.", MsgBoxStyle.Critical)
            Else
                Dim estatus As String = ""
                Dim tipo As String = ""
                If Me.rbCont.Checked Then
                    estatus = "R"
                    tipo = "Contado"
                Else
                    estatus = "PND"
                    tipo = "Credito"
                End If
                mcomp.factura = Me.txtNumfact.Text
                mcomp.fecha = txtFecha.Text
                mcomp.fecha_vencimiento = txtFechaVence.Text
                mcomp.idproveedor = Integer.Parse(Me.txtCodProv.Text.Trim)
                mcomp.tipo = tipo
                mcomp.idusuario = "mherreraz"
                mcomp.estado = estatus
                Dim listacant As New List(Of Integer)
                Dim listabonifs As New List(Of Integer)
                Dim listacod As New List(Of String)
                Dim listacost As New List(Of Double)
                Dim listadesc As New List(Of Double)
                Dim listaiva As New List(Of Double)
                Dim listatot As New List(Of Double)
                Dim listaprec As New List(Of Double)
                For i As Integer = 0 To Me.DataProductos.Rows.Count - 1
                    listacant.Add(Integer.Parse(Me.DataProductos.Item(0, i).Value.ToString))
                    listabonifs.Add(Integer.Parse(Me.DataProductos.Item(1, i).Value.ToString))
                    listacod.Add(Me.DataProductos.Item(2, i).Value.ToString)
                    listacost.Add(Double.Parse(Me.DataProductos.Item(5, i).Value.ToString))
                    listadesc.Add(Double.Parse(Me.DataProductos.Item(6, i).Value.ToString))
                    listaiva.Add(Double.Parse(Me.DataProductos.Item(7, i).Value.ToString))
                    listatot.Add(Double.Parse(Me.DataProductos.Item(8, i).Value.ToString))
                    listaprec.Add(Double.Parse(Me.DataProductos.Item(9, i).Value.ToString))
                Next
                mcomp.detalleCants = listacant
                mcomp.detalleBonifs = listabonifs
                mcomp.detalleCodigos = listacod
                mcomp.detalleCostos = listacost
                mcomp.detalleDesctos = listadesc
                mcomp.detalleIva = listaiva
                mcomp.detalleTotales = listatot
                mcomp.detalleSugeridos = listaprec
                comp = New DAO.Compra(mcomp)
                comp.add()
                Me.Close()
                'comp.reportFactura()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class