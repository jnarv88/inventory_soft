Public Class frmFacturacion
    Private mvta As New Model.Venta
    Private vta As New DAO.Venta
    Private prod As New DAO.producto
    Private mprod As New Model.producto
    Private clie As New DAO.Cliente
    Private conf As New util.Config
    Private Sub frmFacturacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtNumfact.Text = vta.getNumFact
        Me.txtBarra.Text = "x"
        Me.txtBarra.Text = ""
        Me.txtBarra.Focus()
    End Sub
    Private Sub txtCodClie_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodClie.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                cargarClientePorNum()
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
    Private Sub frmFacturacion_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp, txtBarra.KeyUp, txtNumProd.KeyUp, DataProductos.KeyUp, btnAdd.KeyUp, btnFindProd.KeyUp, txtPrecio.KeyUp, txtCant.KeyUp, txtFecha.KeyUp, txtCodClie.KeyUp, rbCred.KeyUp, rbCont.KeyUp, btnFindClie.KeyUp, btnFacturar.KeyUp, btnCancel.KeyUp
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        ElseIf e.KeyCode = Keys.F2 Then
            viewClientes()
        ElseIf e.KeyCode = Keys.F3 Then
            viewProds()
        ElseIf e.KeyCode = Keys.F5 Then
            facturar()
        End If
    End Sub
    Private Sub txtCant_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCant.KeyDown, txtPrecio.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                addRowProd()
            Catch ex As Exception
            End Try
        End If
    End Sub
    Private Sub btnFindClie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindClie.Click
        viewClientes()
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
        Me.txtCodClie.Focus()
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub
    '--------------------------------------------------------------------------------------------------------'
    Sub cargarClientePorNum()
        Dim mclie As New Model.Cliente
        mclie.idcliente = Integer.Parse(Me.txtCodClie.Text.Trim)
        clie = New DAO.Cliente(mclie)
        mclie = clie.getCliente
        Me.txtClient.Text = mclie.cedula + " " + mclie.nombres_apellidos
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
        Me.txtPrecio.Value = mprod.precio
        Me.txtDisponibles.Value = mprod.existencia
        Me.txtCant.Value = 0
        Me.txtCant.Focus()
    End Sub
    Sub viewProds()
        Dim frmprod As New Form1(Me, 1)
        frmprod.ShowDialog()
    End Sub
    Sub viewClientes()
        Dim frmc As New frmClientesView(Me, 1)
        frmc.ShowDialog()
    End Sub

    Sub addRowProd()
        If Me.txtNumProd.Text <> Nothing And Me.txtCant.Value > 0 And Me.txtPrecio.Value > 0 And Me.txtProd.Text <> Nothing Then
            mprod = getInstanceProdByCode()
            Dim precioreal As Double = mprod.precio
            Dim preciofact As Double = Double.Parse(txtPrecio.Value.ToString)
            Dim dispo As Double = Double.Parse(txtDisponibles.Value.ToString)
            Dim cantfact As Integer = Integer.Parse(Me.txtCant.Value)
            If precioreal >= preciofact Then
                If dispo >= cantfact Then
                    Me.DataProductos.Rows.Add()
                    Dim ultimafila As Integer = Me.DataProductos.Rows.Count - 1
                    Me.DataProductos.Item(0, ultimafila).Value = cantfact
                    Me.DataProductos.Item(1, ultimafila).Value = Me.txtNumProd.Text
                    Me.DataProductos.Item(2, ultimafila).Value = Me.txtBarra.Text
                    Me.DataProductos.Item(3, ultimafila).Value = Me.txtProd.Text
                    Me.DataProductos.Item(4, ultimafila).Value = precioreal
                    Me.DataProductos.Item(5, ultimafila).Value = precioreal - preciofact
                    Me.DataProductos.Item(6, ultimafila).Value = cantfact * preciofact
                    Me.txtNumProd.Text = ""
                    Me.txtBarra.Text = ""
                    Me.txtProd.Text = ""
                    Me.txtCant.Value = 0
                    Me.txtDisponibles.Value = 0
                    Me.txtPrecio.Value = 0
                    Me.txtBarra.Focus()
                    conf.configGrid(Me.DataProductos)
                    verTotales()
                Else
                    MsgBox("No hay existencias suficientes para la transaccion.", MsgBoxStyle.Critical)
                End If
            Else
                MsgBox("El precio excede su autentico valor.", MsgBoxStyle.Critical)
            End If
        Else
            MsgBox("Verifique que sus datos sean correctos antes de agregarlos.", MsgBoxStyle.Critical)
        End If
    End Sub
   
    Sub verTotales()
        Dim filas As Integer = Me.DataProductos.Rows.Count
        Me.lblItems.Text = filas.ToString + " Items."
        Dim subtotal As Double = 0
        Dim descto As Double = 0
        Dim total As Double = 0
        For i As Integer = 0 To filas - 1
            Dim cant As Integer = Integer.Parse(Me.DataProductos.Item(0, i).Value.ToString)
            subtotal += Double.Parse(Me.DataProductos.Item(4, i).Value.ToString) * cant
            descto += Double.Parse(Me.DataProductos.Item(5, i).Value.ToString) * cant
            total += Double.Parse(Me.DataProductos.Item(6, i).Value.ToString)
        Next
        Me.txtSubTotal.Value = subtotal
        Me.txtDescuentoTot.Value = descto
        Me.txtTotal.Value = total
    End Sub

    Sub facturar()
        Try
            Dim estatus As String = ""
            Dim tipo As String = ""
            If Me.rbCont.Checked Then
                estatus = "R"
                tipo = "Contado"
            Else
                estatus = "PND"
                tipo = "Credito"
            End If
            mvta.factura = Me.txtNumfact.Text
            mvta.fecha = txtFecha.Text
            mvta.idcliente = Integer.Parse(Me.txtCodClie.Text.Trim)
            mvta.tipo = tipo
            mvta.idusuario = "mherreraz"
            mvta.estado = estatus
            Dim listacant As New List(Of Integer)
            Dim listacod As New List(Of String)
            Dim listaprec As New List(Of Double)
            Dim listadesc As New List(Of Double)
            For i As Integer = 0 To Me.DataProductos.Rows.Count - 1
                listacant.Add(Integer.Parse(Me.DataProductos.Item(0, i).Value.ToString))
                listacod.Add(Me.DataProductos.Item(1, i).Value.ToString)
                listaprec.Add(Double.Parse(Me.DataProductos.Item(4, i).Value.ToString))
                listadesc.Add(Double.Parse(Me.DataProductos.Item(5, i).Value.ToString))
            Next
            mvta.detalleCants = listacant
            mvta.detalleCodigos = listacod
            mvta.detallePrecios = listaprec
            mvta.detalleDesctos = listadesc
            vta = New DAO.Venta(mvta)
            vta.add()
            Me.Close()
            vta.reportFactura()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class