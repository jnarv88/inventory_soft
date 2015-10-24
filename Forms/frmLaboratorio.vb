Public Class frmLaboratorio
    Private mLab As New Model.Laboratorio
    Private Lab As DAO.laboratorio
    Private frmProd As frmProducto
    Sub New(ByVal frmprodt As frmProducto)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.frmProd = frmprodt
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Not Me.txtNombre.Text.Trim = Nothing Then
            mLab.Nombre = Me.txtNombre.Text
            Lab = New DAO.laboratorio(mLab)
            Lab.add()
        Else
            MsgBox("Ingrese el Nombre")
        End If
        frmProd.loadLab()
        Me.Dispose()
    End Sub
End Class