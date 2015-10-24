Namespace DAO
    Public Class Venta
        Private mvta As New Model.Venta
        Private con As New Conexion

        Sub New()

        End Sub
        Sub New(ByVal mvt As Model.Venta)
            Me.mvta = mvt
        End Sub
        Function getNumFact() As String
            con.query = "select count(*)+1 as 'count' from venta"
            Dim datos As DataTable = con.getData
            Dim cant As Integer = Integer.parse(datos.Rows(0)("count").ToString)
            Dim codefact As String = ""
            If cant < 10 Then
                codefact = "000000" + cant.tostring
            ElseIf cant < 100 Then
                codefact = "00000" + cant.tostring
            ElseIf cant < 1000 Then
                codefact = "0000" + cant.tostring
            ElseIf cant < 10000 Then
                codefact = "000" + cant.tostring
            ElseIf cant < 100000 Then
                codefact = "00" + cant.tostring
            ElseIf cant < 1000000 Then
                codefact = "0" + cant.tostring
            Else
                codefact = cant.tostring
            End If
            Return codefact
        End Function
        Sub addDetail(ByVal i As Integer)
            con.query = "insert into detalle_venta values('" + mvta.factura + "','" +
                                                               mvta.detalleCodigos(i) + "'," +
                                                               mvta.detalleCants(i).ToString + "," +
                                                               mvta.detallePrecios(i).ToString + "," +
                                                               mvta.detalleDesctos(i).ToString + ");"
            con.execQuery()
        End Sub
        Sub add()
            con.query = "insert into venta values('" + mvta.factura + "','" +
                                                       mvta.fecha.ToString("yyyy-MM-dd") + "'," +
                                                       mvta.idcliente.ToString + ",'" +
                                                       mvta.tipo + "','" +
                                                       mvta.idusuario + "','" +
                                                       mvta.estado + "');"
            If con.execQuery() > 0 Then
                For i As Integer = 0 To mvta.detalleCodigos.Count - 1
                    addDetail(i)
                Next
            Else
                MsgBox("error, no pudo ser agregado, revise los datos.", MsgBoxStyle.Critical)
            End If
        End Sub
        Sub suspend()
            con.query = "update venta set estado='ANL' where numfactura='" + mvta.factura + "'"
            If con.execQuery() > 0 Then
                MsgBox("Venta Anulada con exito.")
            Else
                MsgBox("error, no pudo ser anulada.", MsgBoxStyle.Critical)
            End If
        End Sub

        Sub reportFactura()
            Try
                con.query = "select v.numfactura as 'factura',v.tipo,v.idusuario as 'usuario',c.nombres_apellidos as 'cliente',v.fecha,dv.cantidad as 'cant',dv.codigo,p.nombre_comercial+'*'+p.udmedida+'*'+p.laboratorio+'*'+p.descripcion as 'producto',dv.precio-dv.descuento as 'precio',dv.descuento*-1 as 'descuento',dv.cantidad*(dv.precio-dv.descuento) as 'total' from venta v inner join detalle_venta dv on v.numfactura=dv.numfactura inner join cliente c on v.idcliente=c.idcliente inner join producto p on dv.codigo=p.codigo where v.numfactura='" + mvta.factura + "' order by producto"
                Dim datafact As New Factura
                con.fillData(datafact, "Factura")
                Dim vistaFact As New frmFactura
                vistaFact.FacturaBindingSource.DataSource = datafact
                vistaFact.ReportViewer1.RefreshReport()
                vistaFact.ShowDialog()
            Catch ex As Exception

            End Try
        End Sub

        Function resumeDay() As DataTable
            con.query = "select v.numfactura as 'Factura',v.Tipo,v.idusuario as 'Usuario',c.nombres_apellidos as 'Cliente'," +
                        "v.Fecha,(select round(sum(cantidad*(precio-descuento)),2) from detalle_venta where numfactura=v.numfactura) as 'Total'," +
                        "v.Estado from venta v inner join cliente c on v.idcliente=c.idcliente " +
                        "where fecha='" + mvta.fecha.ToString("yyyy-MM-dd") + "' " +
                        "and (v.numfactura like '%" + mvta.factura + "%' or c.nombres_apellidos like '%" + mvta.factura + "%') " +
                        "order by v.numfactura"
            Return con.getData
        End Function

        Function getTotalByStatus(ByVal stat As String) As Double
            Dim total = 0
            Try
                con.query = "select round(sum(coalesce(cantidad*(precio-descuento),0)),2) as 'Total' from detalle_venta dv " +
                            "inner join venta v on v.numfactura=dv.numfactura " +
                            "where v.fecha='" + mvta.fecha.ToString("yyyy-MM-dd") + "' and v.estado='" + stat + "'"
                total = Double.Parse(con.getData.Rows(0)("Total").ToString)
            Catch ex As Exception
                total = 0
            End Try
            Return total
        End Function

    End Class
End Namespace

