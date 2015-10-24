Namespace DAO
    Public Class Cliente
        Private mclie As New Model.Cliente
        Private con As New Conexion
        Sub New()

        End Sub
        Sub New(ByVal mc As Model.Cliente)
            Me.mclie = mc
        End Sub
        Sub add()
            con.query = "insert into cliente values('" + mclie.cedula + "','" + mclie.nombres_apellidos + "','" + mclie.telefono + "','" + mclie.celular1 + "','" + mclie.celular2 + "','" + mclie.direccion + "');"
            If con.execQuery() > 0 Then
                MsgBox("Cliente agregado exitosamente.", MsgBoxStyle.Information)
            Else
                MsgBox("error, no pudo ser agregado, revise los datos.", MsgBoxStyle.Critical)
            End If
        End Sub
        Sub edit()
            con.query = "update cliente set cedula='" + mclie.cedula + "',nombres_apellidos='" + mclie.nombres_apellidos + "',telefono='" + mclie.telefono + "',celular='" + mclie.celular1 + "',celular2='" + mclie.celular2 + "',direccion='" + mclie.direccion + "' where idcliente=" + mclie.idcliente.ToString
            If con.execQuery() > 0 Then
                MsgBox("Cliente editado con exito.", MsgBoxStyle.Information)
            Else
                MsgBox("error, no pudo ser editado, revise los datos.", MsgBoxStyle.Critical)
            End If
        End Sub
        Function getCliente() As Model.Cliente
            con.query = "select idcliente,cedula,nombres_apellidos,telefono,celular,celular2,direccion from cliente where idcliente=" + mclie.idcliente.ToString
            Dim datos As DataTable = con.getData
            mclie.idcliente = datos.Rows(0)("idcliente").ToString
            mclie.cedula = datos.Rows(0)("cedula").ToString
            mclie.nombres_apellidos = datos.Rows(0)("nombres_apellidos").ToString
            mclie.telefono = datos.Rows(0)("telefono").ToString
            mclie.celular1 = datos.Rows(0)("celular").ToString
            mclie.celular2 = datos.Rows(0)("celular2").ToString
            mclie.direccion = datos.Rows(0)("direccion").ToString
            Return Me.mclie
        End Function

        Function getAll(ByVal value As String) As DataTable
            con.query = "select idcliente as 'Num',Cedula,nombres_apellidos as 'Cliente',Telefono,Celular,Celular2,Direccion from cliente where idcliente!=1 and (cedula like '%" + value + "%' or nombres_apellidos like '%" + value + "%') order by nombres_apellidos"
            Return con.getData
        End Function
    End Class
End Namespace

