Public Class frmProveedor
    Private mpr As New Model.Proveedor
    Private prov As New DAO.Proveedor
    Private source As Integer = 0
    Private frmP As frmProveedoresView
    Sub New(ByVal frm As frmProveedoresView, ByVal sourc As Integer)
        Me.source = sourc
        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.frmP = frm
    End Sub
    Private Sub frmProveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.source > 0 Then
            Me.loadProveedor()
        End If
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            mpr.nombre_comercial = txtNomComercial.Text.Trim
            mpr.direccion = txtDireccion.Text.Trim
            mpr.telefono = txtTelef.Text.Trim
            mpr.celular = txtCelular.Text.Trim
            mpr.contacto1 = txtCont1.Text.Trim
            mpr.celular_contacto1 = txtCelCont1.Text.Trim
            mpr.contacto2 = txtCont2.Text.Trim
            mpr.celular_contacto2 = txtCelCont2.Text.Trim
            If Me.source = 0 Then
                prov = New DAO.Proveedor(mpr)
                prov.add()
            Else
                mpr.idProveedor = Integer.Parse(Me.txtIdProveedor.Text.ToString)
                prov = New DAO.Proveedor(mpr)
                prov.edit()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        frmP.loadGrid()
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    '--------------------------------------------------------------------------------------------------------------------------
    Sub loadProveedor()
        mpr.idProveedor = source
        prov = New DAO.Proveedor(mpr)
        mpr = prov.getProveedor
        Me.txtIdProveedor.Text = mpr.idProveedor.ToString
        Me.txtNomComercial.Text = mpr.nombre_comercial
        Me.txtDireccion.Text = mpr.direccion
        Me.txtTelef.Text = mpr.telefono
        Me.txtCelular.Text = mpr.celular
        Me.txtCont1.Text = mpr.contacto1
        Me.txtCelCont1.Text = mpr.celular_contacto1
        Me.txtCont2.Text = mpr.contacto2
        Me.txtCelCont2.Text = mpr.celular_contacto2
    End Sub
End Class