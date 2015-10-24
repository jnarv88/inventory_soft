Namespace DAO
    Public Class laboratorio
        Private con As New Conexion
        Private mlab As New Model.Laboratorio

        Sub New()

        End Sub
        Sub New(ByVal mlabt As Model.Laboratorio)
            Me.mlab = mlabt
        End Sub
        Sub add()
            con.query = "insert into laboratorio values('" + mlab.Nombre + "');"
            If con.execQuery() > 0 Then
                MsgBox("Laboratorio ingresado con exito.")
            Else
                MsgBox("error, no pudo ser agregado, revise los datos.", MsgBoxStyle.Critical)
            End If
        End Sub
        Function getAll() As DataTable
            con.query = "select * from laboratorio order by nombre"
            Return con.getData
        End Function
    End Class
End Namespace

