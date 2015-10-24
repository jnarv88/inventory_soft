Namespace DAO
    Public Class Compra
        Private mcomp As New Model.Compra
        Private con As New Conexion
        Sub New()

        End Sub
        Sub New(ByVal mcm As Model.Compra)
            Me.mcomp = mcm
        End Sub
        Sub addDetail(ByVal i As Integer)
            con.query = " insert into detalle_compra(codfactura,codigo,cantidad,bonificacion,costo,descuento,iva,total,sugerido) " +
                        " values('" + mcomp.factura + "','" +
                                      mcomp.detalleCodigos(i) + "'," +
                                      mcomp.detalleCants(i).ToString + "," +
                                      mcomp.detalleBonifs(i).ToString + "," +
                                      mcomp.detalleCostos(i).ToString + "," +
                                      mcomp.detalleDesctos(i).ToString + "," +
                                      mcomp.detalleIva(i).ToString + ", " +
                                      mcomp.detalleTotales(i).ToString + ", " +
                                      mcomp.detalleSugeridos(i).ToString + ");"
            con.execQuery()
        End Sub
        Sub add()
            con.query = " insert into compra(codfactura,fecha,fechavence,idproveedor,tipo,idusuario,estado)" +
                        " values('" + mcomp.factura + "','" +
                                      mcomp.fecha.ToString("yyyy-MM-dd") + "','" +
                                      mcomp.fecha_vencimiento.ToString("yyyy-MM-dd") + "'," +
                                      mcomp.idproveedor.ToString + ",'" +
                                      mcomp.tipo + "','" +
                                      mcomp.idusuario + "','" +
                                      mcomp.estado + "');"
            If con.execQuery() > 0 Then
                For i As Integer = 0 To mcomp.detalleCodigos.Count - 1
                    addDetail(i)
                Next
            Else
                MsgBox("error, no pudo ser agregado, revise los datos.", MsgBoxStyle.Critical)
            End If
        End Sub
        Sub suspend()
            con.query = "update Compra set estado='ANL' where codfactura='" + mcomp.factura + "'"
            If con.execQuery() > 0 Then
                MsgBox("Compra Anulada con exito.")
            Else
                MsgBox("error, no pudo ser anulada.", MsgBoxStyle.Critical)
            End If
        End Sub
        Function getComprasByFiltro(ByVal incluirDate As Boolean, ByVal fechaInicial As DateTime, ByVal fechaFinal As DateTime) As DataTable
            Dim fieldVence As String = ""
            Dim fieldCancel As String = ""
            Dim whereFactura As String = ""
            Dim whereEstatus As String = ""
            Dim whereProveedor As String = ""
            Dim whereFechaBetween As String = ""

            'CONDICIONES QUE PUEDE TENER LA CONSULTA
            If Not mcomp.factura.Equals("") Then
                whereFactura = " and c.codfactura like '%" + mcomp.factura.Trim + "%' "
            End If

            If Not mcomp.estado.Equals("") Then

                'CAMPOS QUE SE PUEDEN AÑADIR
                If mcomp.estado.Equals("VNC") Then
                    fieldVence = " fechavence as 'F. Vencimiento', "
                End If
                If mcomp.estado.Equals("CNCL") Then
                    fieldCancel = " coalesce(CONVERT(Char(10), fechacancela,126),'') as 'F. Cancel.', "
                End If

                whereEstatus = " and c.estado = '" + mcomp.estado.Trim + "' "
            End If
            'usaremos el idusuario, simulando al nombre del proveedor
            If Not mcomp.idusuario.Equals("") Then
                whereProveedor = " and pr.nombre = '" + mcomp.idusuario + "' "
            End If
            'si se filtraron fechas
            If incluirDate Then
                Dim rango As String = "'" + fechaInicial.ToString("yyyy-MM-dd") + "' and '" + fechaFinal.ToString("yyyy-MM-dd") + "') "
                If mcomp.estado.Equals("VNC") Then
                    whereFechaBetween = " and (c.fechavence between " + rango
                ElseIf mcomp.estado.Equals("CNCL") Then
                    whereFechaBetween = " and (c.fechacancela between " + rango
                Else
                    whereFechaBetween = " and (c.fecha between " + rango
                End If
            End If
            'CONSULTA ARMADA

            con.query = "select	c.codfactura as 'Código'," +
                        "       fecha as 'Fecha', " +
                                fieldVence +
                                fieldCancel +
                        "       pr.nombre as 'Proveedor', " +
                        "       tipo as 'Tipo Pago', " +
                        "       round(SUM(dc.costo),4) as 'SubTotal', " +
                        "       round(SUM(dc.descuento),4) as 'Descuento', " +
                        "       round(SUM(dc.iva),4) as 'IVA', " +
                        "       round(SUM(dc.total),4) as 'Monto', " +
                        "       idusuario as 'Usuario'	" +
                        "from compra c " +
                        "   inner join proveedor pr on c.idproveedor = pr.idproveedor " +
                        "   inner join detalle_compra dc on c.codfactura = dc.codfactura " +
                        "where(1 = 1) " +
                            whereFactura +
                            whereEstatus +
                            whereProveedor +
                            whereFechaBetween +
                        "group by c.codfactura,fecha,fechavence,fechacancela,pr.nombre,tipo,idusuario"
            'MsgBox(con.query)
            Return con.getData
        End Function
                Function getComprasProximasVencerse()
            con.query = "select	c.codfactura as 'Código'," +
                        "       fecha as 'Fecha', " +
                        "       fechavence as 'F. Vencimiento'," +
                        "       pr.nombre as 'Proveedor', " +
                        "       tipo as 'Tipo Pago', " +
                        "       round(SUM(dc.costo),4) as 'SubTotal', " +
                        "       round(SUM(dc.descuento),4) as 'Descuento', " +
                        "       round(SUM(dc.iva),4) as 'IVA', " +
                        "       round(SUM(dc.total),4) as 'Monto', " +
                        "       idusuario as 'Usuario'	" +
                        "from compra c " +
                        "   inner join proveedor pr on c.idproveedor = pr.idproveedor " +
                        "   inner join detalle_compra dc on c.codfactura = dc.codfactura " +
                        "where tipo = 'Credito' and estado = 'PND' and fechavence BETWEEN (GETDATE()-1) AND (GETDATE()+3) " +
                        "group by c.codfactura,fecha,fechavence,fechacancela,pr.nombre,tipo,idusuario " +
                        "order by fechavence,pr.nombre  "
            'MsgBox(con.query)
            Return con.getData
        End Function
        Function getProductosCompra() As DataTable
            con.query = "select	cantidad as 'Cantidad',bonificacion as 'Bonificación',p.codigo as 'Código', p.codigoBarra as 'Barra', " +
                        "(p.nombre_comercial + ' * ' + p.udmedida + ' * ' + p.laboratorio) as 'Producto', dc.costo as 'Costo Unit', " +
                        "dc.descuento as 'Descuento', dc.iva as 'IVA', dc.total as 'Total', dc.sugerido as 'Prec. Sugerido' " +
                        "from detalle_compra dc " +
                        "inner join producto p on dc.codigo = p.codigo " +
                        "where dc.codfactura = '" + mcomp.factura + "' " +
                        "order by (p.nombre_comercial + ' * ' + p.udmedida + ' * ' + p.laboratorio) "
            'MsgBox(con.query)
            Return con.getData
        End Function
    End Class
End Namespace
