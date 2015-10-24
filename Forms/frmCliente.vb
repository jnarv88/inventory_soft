Public Class frmCliente
    Private mclie As New Model.Cliente
    Private clie As New DAO.Cliente
    Private source As Integer = 0
    Private frmC As frmClientesView
    Sub New(ByVal frm As frmClientesView, ByVal sourc As Integer)
        Me.source = sourc
        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.frmC = frm
    End Sub
    Private Sub frmCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.source > 0 Then
            Me.loadCliente()
        End If
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            mclie.cedula = txtCedula.Text.Trim
            mclie.nombres_apellidos = txtNomape.Text.Trim
            mclie.direccion = txtDireccion.Text.Trim
            mclie.telefono = txtTelef.Text.Trim
            mclie.celular1 = txtCel1.Text.Trim
            mclie.celular2 = txtCel2.Text.Trim
            If Me.source = 0 Then
                clie = New DAO.Cliente(mclie)
                clie.add()
            Else
                mclie.idcliente = Integer.Parse(Me.txtIdcliente.Text.ToString)
                clie = New DAO.Cliente(mclie)
                clie.edit()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        frmC.loadGrid()
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    '--------------------------------------------------------------------------------------------------------------------------
    Sub loadCliente()
        mclie.idcliente = source
        clie = New DAO.Cliente(mclie)
        mclie = clie.getCliente
        Me.txtIdcliente.Text = mclie.idcliente.ToString
        Me.txtCedula.Text = mclie.cedula
        Me.txtNomape.Text = mclie.nombres_apellidos
        Me.txtDireccion.Text = mclie.direccion
        Me.txtTelef.Text = mclie.telefono
        Me.txtCel1.Text = mclie.celular1
        Me.txtCel2.Text = mclie.celular2
    End Sub

End Class