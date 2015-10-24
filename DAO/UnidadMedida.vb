Namespace DAO
    Public Class UnidadMedida
        Private con As New Conexion
        Private mUM As New Model.UnidadMedida
        Sub New()

        End Sub
        Sub New(ByVal mUMd As Model.UnidadMedida)
            Me.mUM = mUMd
        End Sub
        Sub add()
            con.query = "insert into unidad_medida values('" + mUM.Nombre + "');"
            If con.execQuery() > 0 Then
                MsgBox("Unidad ingresado con exito.")
            Else
                MsgBox("error, no pudo ser agregado, revise los datos.", MsgBoxStyle.Critical)
            End If
        End Sub
        Function getAll() As DataTable
            con.query = "select * from unidad_medida order by nombre"
            Return con.getData
        End Function
    End Class
End Namespace

