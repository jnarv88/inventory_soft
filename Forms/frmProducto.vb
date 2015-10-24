Public Class frmProducto
    Private mprod As New Model.producto
    Private prod As New DAO.producto
    Private source As Integer = 0
    Private frmP As Form1

    Sub New(ByVal frm As Form1, ByVal sourc As Integer)
        Me.source = sourc
        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.frmP = frm
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            mprod.codigo_barra = Me.txtCodBarra.Text
            mprod.nombre_comercial = Me.txtNomCom.Text
            mprod.unidad_medida = Me.cbxUd.SelectedItem
            mprod.laboratorio = Me.cbxLab.SelectedItem
            mprod.descripcion = Me.txtDesc.Text
            If Me.source = 0 Then
                prod = New DAO.producto(mprod)
                prod.add()
            Else
                mprod.codigo = Integer.Parse(Me.txtCod.Text.ToString)
                prod = New DAO.producto(mprod)
                prod.edit()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        frmP.loadGrid()
        Me.Dispose()
    End Sub
    Private Sub frmProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.loadUM()
        Me.loadLab()
        If Me.source > 0 Then
            Me.loadProducto()
        End If
    End Sub
    Private Sub btnAddUdPres_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddUdPres.Click
        Dim frmaddpres As New frmUM(Me)
        frmaddpres.ShowDialog()
    End Sub
    Private Sub btnAddLab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddLab.Click
        Dim frmlab As New frmLaboratorio(Me)
        frmlab.ShowDialog()
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.escape()
    End Sub
    Private Sub frmProducto_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp, btnAddLab.KeyUp, btnAddUdPres.KeyUp, btnCancel.KeyUp, btnGuardar.KeyUp, cbxLab.KeyUp, cbxUd.KeyUp, GroupBox1.KeyUp, txtCod.KeyUp, txtCodBarra.KeyUp, txtDesc.KeyUp, txtNomCom.KeyUp, nudExist.KeyUp, nudPrecio.KeyUp
        If e.KeyCode = Keys.Escape Then
            Me.escape()
        End If
    End Sub
    '-----------------------------------------------------------------------------------------------------
    Sub loadUM()
        Dim um As New DAO.UnidadMedida
        Dim datos As DataTable = um.getAll
        Me.cbxUd.Items.Clear()
        For i As Integer = 0 To datos.Rows.Count - 1
            Me.cbxUd.Items.Add(datos.Rows(i)(0).ToString)
        Next
    End Sub
    Sub loadLab()
        Dim lab As New DAO.laboratorio
        Dim datos As DataTable = lab.getAll
        Me.cbxLab.Items.Clear()
        For i As Integer = 0 To datos.Rows.Count - 1
            Me.cbxLab.Items.Add(datos.Rows(i)(0).ToString)
        Next
    End Sub
    Sub loadProducto()
        mprod.codigo = source
        prod = New DAO.producto(mprod)
        mprod = prod.getProductoByCode
        Me.txtCod.Text = mprod.codigo.ToString
        Me.txtCodBarra.Text = mprod.codigo_barra
        Me.txtNomCom.Text = mprod.nombre_comercial
        Me.cbxUd.SelectedItem = mprod.unidad_medida
        Me.cbxLab.SelectedItem = mprod.laboratorio
        Me.txtDesc.Text = mprod.descripcion
        Me.nudExist.Value = mprod.existencia.ToString
        Me.nudPrecio.Value = mprod.precio.ToString
        Me.nudCosto.Value = mprod.costo.ToString
    End Sub
    Sub escape()
        Me.Dispose()
    End Sub
End Class