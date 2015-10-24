<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProducto
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCod = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.nudCosto = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnAddLab = New System.Windows.Forms.Button()
        Me.btnAddUdPres = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.nudPrecio = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.nudExist = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbxLab = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbxUd = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNomCom = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodBarra = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nudCosto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudExist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo:"
        '
        'txtCod
        '
        Me.txtCod.Enabled = False
        Me.txtCod.Location = New System.Drawing.Point(80, 23)
        Me.txtCod.Name = "txtCod"
        Me.txtCod.Size = New System.Drawing.Size(71, 20)
        Me.txtCod.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.nudCosto)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.btnAddLab)
        Me.GroupBox1.Controls.Add(Me.btnAddUdPres)
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Controls.Add(Me.nudPrecio)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.nudExist)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtDesc)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cbxLab)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cbxUd)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtNomCom)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtCodBarra)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCod)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(473, 255)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'nudCosto
        '
        Me.nudCosto.DecimalPlaces = 4
        Me.nudCosto.Location = New System.Drawing.Point(80, 191)
        Me.nudCosto.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.nudCosto.Name = "nudCosto"
        Me.nudCosto.ReadOnly = True
        Me.nudCosto.Size = New System.Drawing.Size(154, 20)
        Me.nudCosto.TabIndex = 21
        Me.nudCosto.ThousandsSeparator = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 193)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Costo Unit:"
        '
        'btnAddLab
        '
        Me.btnAddLab.Location = New System.Drawing.Point(252, 110)
        Me.btnAddLab.Name = "btnAddLab"
        Me.btnAddLab.Size = New System.Drawing.Size(147, 23)
        Me.btnAddLab.TabIndex = 19
        Me.btnAddLab.Text = "Agregar Laboratorio"
        Me.btnAddLab.UseVisualStyleBackColor = True
        '
        'btnAddUdPres
        '
        Me.btnAddUdPres.Location = New System.Drawing.Point(252, 81)
        Me.btnAddUdPres.Name = "btnAddUdPres"
        Me.btnAddUdPres.Size = New System.Drawing.Size(147, 23)
        Me.btnAddUdPres.TabIndex = 18
        Me.btnAddUdPres.Text = "Agregar Ud. Presentacion"
        Me.btnAddUdPres.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(372, 213)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 25)
        Me.btnCancel.TabIndex = 17
        Me.btnCancel.Text = "Cancelar (Esc)"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(291, 213)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 25)
        Me.btnGuardar.TabIndex = 16
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'nudPrecio
        '
        Me.nudPrecio.DecimalPlaces = 4
        Me.nudPrecio.Location = New System.Drawing.Point(80, 217)
        Me.nudPrecio.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.nudPrecio.Name = "nudPrecio"
        Me.nudPrecio.ReadOnly = True
        Me.nudPrecio.Size = New System.Drawing.Size(154, 20)
        Me.nudPrecio.TabIndex = 15
        Me.nudPrecio.ThousandsSeparator = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 219)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Precio Unit:"
        '
        'nudExist
        '
        Me.nudExist.Location = New System.Drawing.Point(80, 163)
        Me.nudExist.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.nudExist.Name = "nudExist"
        Me.nudExist.ReadOnly = True
        Me.nudExist.Size = New System.Drawing.Size(154, 20)
        Me.nudExist.TabIndex = 13
        Me.nudExist.ThousandsSeparator = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 165)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Existencia:"
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(80, 137)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(380, 20)
        Me.txtDesc.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 140)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Descripcion:"
        '
        'cbxLab
        '
        Me.cbxLab.FormattingEnabled = True
        Me.cbxLab.Location = New System.Drawing.Point(80, 110)
        Me.cbxLab.Name = "cbxLab"
        Me.cbxLab.Size = New System.Drawing.Size(155, 21)
        Me.cbxLab.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Laboratorio:"
        '
        'cbxUd
        '
        Me.cbxUd.FormattingEnabled = True
        Me.cbxUd.Location = New System.Drawing.Point(80, 83)
        Me.cbxUd.Name = "cbxUd"
        Me.cbxUd.Size = New System.Drawing.Size(154, 21)
        Me.cbxUd.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Unidad:"
        '
        'txtNomCom
        '
        Me.txtNomCom.Location = New System.Drawing.Point(80, 57)
        Me.txtNomCom.Name = "txtNomCom"
        Me.txtNomCom.Size = New System.Drawing.Size(380, 20)
        Me.txtNomCom.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Producto:"
        '
        'txtCodBarra
        '
        Me.txtCodBarra.Location = New System.Drawing.Point(240, 23)
        Me.txtCodBarra.Name = "txtCodBarra"
        Me.txtCodBarra.Size = New System.Drawing.Size(220, 20)
        Me.txtCodBarra.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(163, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Codigo Barra:"
        '
        'frmProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 308)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Producto"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.nudCosto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudExist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCod As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents nudPrecio As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents nudExist As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbxLab As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbxUd As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNomCom As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCodBarra As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAddLab As System.Windows.Forms.Button
    Friend WithEvents btnAddUdPres As System.Windows.Forms.Button
    Friend WithEvents nudCosto As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
