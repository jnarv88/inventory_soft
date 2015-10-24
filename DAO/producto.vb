Namespace DAO
    Public Class producto
        Private mprod As New Model.producto
        Private con As New Conexion

        Sub New()

        End Sub
        Sub New(ByVal mprodt As Model.producto)
            Me.mprod = mprodt
        End Sub

        Sub add()
            con.query = "insert into producto values('" + mprod.codigo_barra + "','" +
                                                          mprod.nombre_comercial + "','" +
                                                          mprod.unidad_medida + "','" +
                                                          mprod.laboratorio + "','" +
                                                          mprod.descripcion + "'," +
                                                          mprod.existencia.ToString + "," +
                                                          mprod.precio.ToString + "," +
                                                          mprod.costo.ToString + ");"
            If con.execQuery() > 0 Then
                MsgBox("Producto ingresado con exito.", MsgBoxStyle.Information)
            Else
                MsgBox("error, no pudo ser agregado, revise los datos.", MsgBoxStyle.Critical)
            End If
        End Sub
        Sub edit()
            con.query = "update producto set codigoBarra='" + mprod.codigo_barra +
                                            "',nombre_comercial='" + mprod.nombre_comercial +
                                            "',udMedida='" + mprod.unidad_medida +
                                            "',descripcion='" + mprod.descripcion +
                                            "',laboratorio='" + mprod.laboratorio +
                                            "',existencia=" + mprod.existencia.ToString +
                        " where codigo=" + mprod.codigo.ToString
            If con.execQuery() > 0 Then
                MsgBox("Producto editado con exito.", MsgBoxStyle.Information)
            Else
                MsgBox("error, no pudo ser editado, revise los datos.", MsgBoxStyle.Critical)
            End If
        End Sub
        Sub delete()
            con.query = "delete from producto where codigo=" + mprod.codigo.ToString
            If con.execQuery() > 0 Then
                MsgBox("Producto eliminado con exito.")
            Else
                MsgBox("error, no pudo ser eliminado, revise los datos.", MsgBoxStyle.Critical)
            End If
        End Sub
        Function getProductoByCode() As Model.producto
            con.query = "select codigo,codigoBarra,nombre_comercial,udmedida,descripcion,laboratorio,existencia,ROUND(precio,4) as precio,ROUND(costo,4) as costo from producto where codigo=" + mprod.codigo.ToString
            Dim datos As DataTable = con.getData
            mprod.codigo = datos.Rows(0)("codigo").ToString
            mprod.codigo_barra = datos.Rows(0)("codigoBarra").ToString
            mprod.nombre_comercial = datos.Rows(0)("nombre_comercial").ToString
            mprod.unidad_medida = datos.Rows(0)("udmedida").ToString
            mprod.descripcion = datos.Rows(0)("descripcion").ToString
            mprod.laboratorio = datos.Rows(0)("laboratorio").ToString
            mprod.existencia = datos.Rows(0)("existencia").ToString
            mprod.precio = datos.Rows(0)("precio").ToString
            mprod.costo = datos.Rows(0)("costo").ToString
            Return Me.mprod
        End Function
        Function getProductoByBarCode() As Model.producto
            con.query = "select codigo,codigoBarra,nombre_comercial,udmedida,descripcion,laboratorio,existencia,ROUND(precio,4) as precio,ROUND(costo,4) as costo from producto where codigoBarra='" + mprod.codigo_barra.ToString() + "'"
            Dim datos As DataTable = con.getData
            mprod.codigo = datos.Rows(0)("codigo").ToString
            mprod.codigo_barra = datos.Rows(0)("codigoBarra").ToString
            mprod.nombre_comercial = datos.Rows(0)("nombre_comercial").ToString
            mprod.unidad_medida = datos.Rows(0)("udmedida").ToString
            mprod.descripcion = datos.Rows(0)("descripcion").ToString
            mprod.laboratorio = datos.Rows(0)("laboratorio").ToString
            mprod.existencia = datos.Rows(0)("existencia").ToString
            mprod.precio = datos.Rows(0)("precio").ToString
            mprod.costo = datos.Rows(0)("costo").ToString
            Return Me.mprod
        End Function
        Function getAll(ByVal campo As String, ByVal value As String) As DataTable
            con.query = "select codigo,codigoBarra,nombre_comercial As 'producto',udmedida as 'unidad',laboratorio,descripcion,existencia,ROUND(costo,4) as 'Costo Unit.',ROUND(precio,4) as 'Precio Unit.' from producto where " + campo + " like '%" + value + "%' order by nombre_comercial,laboratorio"
            Return con.getData
        End Function
    End Class
End Namespace
