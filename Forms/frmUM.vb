Public Class frmUM
    Private mUM As New Model.UnidadMedida
    Private UM As DAO.UnidadMedida
    Private frmProd As frmProducto
    Sub New(ByVal frmProdt As frmProducto)
        InitializeComponent()
        Me.frmProd = frmProdt
    End Sub
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Not Me.txtNombre.Text.Trim = Nothing Then
            mUM.Nombre = Me.txtNombre.Text
            UM = New DAO.UnidadMedida(mUM)
            UM.add()
        Else
            MsgBox("Ingrese el Nombre")
        End If
        frmProd.loadUM()
        Me.Dispose()
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub
End Class