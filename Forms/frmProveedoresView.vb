Public Class frmProveedoresView
    Private mpr As New Model.Proveedor
    Private prov As New DAO.Proveedor
    Private source As Integer
    Private frmComp As frmCompra
    Private frmProv As frmProveedor
    Sub New(ByVal frm As frmCompra, ByVal sourc As Integer)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.frmComp = frm
        Me.source = sourc
    End Sub
    Private Sub frmProveedoresView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadGrid()
    End Sub
    Private Sub DataProveedores_RowHeaderMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataProveedores.RowHeaderMouseDoubleClick
        goEdit()
    End Sub
    Private Sub DataProveedores_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataProveedores.CellDoubleClick
        goEdit()
    End Sub
    Private Sub DataProveedoress_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataProveedores.KeyDown
        If e.KeyCode = Keys.Space Then
            goEdit()
        End If
    End Sub
    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        addProveedor()
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub txtValue_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtValue.TextChanged
        loadGrid()
    End Sub
    '--------------------------------------------------------------------------------------------------------------------
    Sub loadGrid()
        Me.DataProveedores.DataSource = prov.getAll(Me.txtValue.Text)
        Dim conf As New util.Config
        conf.configGrid(Me.DataProveedores)
        Me.DataProveedores.Refresh()
        Me.lblCant.Text = Me.DataProveedores.RowCount.ToString + " Registrados."
    End Sub
    Sub goEdit()
        If Me.source = 0 Then
            Dim cod As Integer = Integer.Parse(Me.DataProveedores.CurrentRow.Cells(0).Value.ToString)
            frmProv = New frmProveedor(Me, cod)
            frmProv.ShowDialog()
        Else
            Dim mprov As New Model.Proveedor
            mprov.idProveedor = Integer.Parse(Me.DataProveedores.CurrentRow.Cells(0).Value.ToString)
            prov = New DAO.Proveedor(mprov)
            mprov = prov.getProveedor()
            frmComp.txtCodProv.Text = mprov.idProveedor.ToString
            frmComp.txtProveedor.Text = mprov.nombre_comercial
            Me.Close()
            frmComp.txtCodProv.Focus()
        End If
    End Sub
    Sub addProveedor()
        frmProv = New frmProveedor(Me, 0)
        frmProv.ShowDialog()
    End Sub
End Class