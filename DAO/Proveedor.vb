Namespace DAO
    Public Class Proveedor
        Private mpr As New Model.Proveedor
        Private con As New Conexion
        Sub New()

        End Sub
        Sub New(ByVal mp As Model.Proveedor)
            Me.mpr = mp
        End Sub
        Sub add()
            con.query = " insert into proveedor (nombre, direccion, telefono, celular, contacto1, celularcontacto1, contacto2, celularcontacto2) " +
                        " values('" + mpr.nombre_comercial + "','" + mpr.direccion + "','" + mpr.telefono + "','" + mpr.celular + "','" + mpr.contacto1 + "','" + mpr.celular_contacto1 + "','" + mpr.contacto2 + "','" + mpr.celular_contacto2 + "');"
            If con.execQuery() > 0 Then
                MsgBox("Proveedor agregado exitosamente.", MsgBoxStyle.Information)
            Else
                MsgBox("error, no pudo ser agregado, revise los datos.", MsgBoxStyle.Critical)
            End If
        End Sub
        Sub edit()
            con.query = " update proveedor set nombre='" + mpr.nombre_comercial + "', direccion='" + mpr.direccion + "', telefono='" + mpr.telefono + "', celular='" + mpr.celular +
                        "', contacto1='" + mpr.contacto1 + "', celularcontacto1='" + mpr.celular_contacto1 + "', contacto2='" + mpr.contacto2 + "', celularcontacto2='" + mpr.celular_contacto2 +
                        "' where idproveedor=" + mpr.idProveedor.ToString()
            If con.execQuery() > 0 Then
                MsgBox("Proveedor editado con exito.", MsgBoxStyle.Information)
            Else
                MsgBox("error, no pudo ser editado, revise los datos.", MsgBoxStyle.Critical)
            End If
        End Sub
        Function getProveedor() As Model.Proveedor
            con.query = "select idproveedor,nombre, direccion, telefono, celular, contacto1, celularcontacto1, contacto2, celularcontacto2 from proveedor where idproveedor=" + mpr.idProveedor.ToString
            Dim datos As DataTable = con.getData
            mpr.idProveedor = datos.Rows(0)("idproveedor").ToString
            mpr.nombre_comercial = datos.Rows(0)("nombre").ToString
            mpr.direccion = datos.Rows(0)("direccion").ToString
            mpr.telefono = datos.Rows(0)("telefono").ToString
            mpr.celular = datos.Rows(0)("celular").ToString
            mpr.contacto1 = datos.Rows(0)("contacto1").ToString
            mpr.celular_contacto1 = datos.Rows(0)("celularcontacto1").ToString
            mpr.contacto2 = datos.Rows(0)("contacto2").ToString
            mpr.celular_contacto2 = datos.Rows(0)("celularcontacto2").ToString
            Return Me.mpr
        End Function

        Function getAll(ByVal value As String) As DataTable
            con.query = "select idproveedor as 'Num',nombre as Proveedor, direccion, telefono, celular, contacto1, celularcontacto1, contacto2, celularcontacto2 from proveedor where  (nombre like '%" + value + "%' or contacto1 like '%" + value + "%' or contacto2 like '%" + value + "%') order by nombre"
            Return con.getData
        End Function
    End Class
End Namespace

