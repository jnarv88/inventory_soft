Public Class frmClientesView
    Private mclie As New Model.Cliente
    Private clie As New DAO.Cliente
    Private source As Integer
    Private frmfact As frmFacturacion
    Private frmClie As frmCliente
    Sub New(ByVal frm As frmFacturacion, ByVal sourc As Integer)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.frmfact = frm
        Me.source = sourc
    End Sub
    Private Sub frmClientesView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadGrid()
    End Sub
    Private Sub DataClientes_RowHeaderMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataClientes.RowHeaderMouseDoubleClick
        goEdit()
    End Sub
    Private Sub DataClientes_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataClientes.CellDoubleClick
        goEdit()
    End Sub
    Private Sub DataClientes_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataClientes.KeyDown
        If e.KeyCode = Keys.Space Then
            goEdit()
        End If
    End Sub
    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        addCliente()
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub txtValue_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtValue.TextChanged
        loadGrid()
    End Sub
    '--------------------------------------------------------------------------------------------------------------------
    Sub loadGrid()
        Me.DataClientes.DataSource = clie.getAll(Me.txtValue.Text)
        Dim conf As New util.Config
        conf.configGrid(Me.DataClientes)
        Me.DataClientes.Refresh()
        Me.lblCant.Text = Me.DataClientes.RowCount.ToString + " Registrados."
    End Sub
    Sub goEdit()
        If Me.source = 0 Then
            Dim cod As Integer = Integer.Parse(Me.DataClientes.CurrentRow.Cells(0).Value.ToString)
            frmClie = New frmCliente(Me, cod)
            frmClie.ShowDialog()
        Else
            Dim mclie As New Model.Cliente
            mclie.idcliente = Integer.Parse(Me.DataClientes.CurrentRow.Cells(0).Value.ToString)
            clie = New DAO.Cliente(mclie)
            mclie = clie.getCliente()
            frmfact.txtCodClie.Text = mclie.idcliente.ToString
            frmfact.txtClient.Text = mclie.cedula + " " + mclie.nombres_apellidos
            Me.Close()
            frmfact.txtCodClie.Focus()
        End If
    End Sub
    Sub addCliente()
        frmClie = New frmCliente(Me, 0)
        frmClie.ShowDialog()
    End Sub
    
End Class