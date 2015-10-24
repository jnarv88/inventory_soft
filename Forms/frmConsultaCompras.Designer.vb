<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaCompras
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.cbRangoFechas = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbProveedor = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodFactura = New System.Windows.Forms.TextBox()
        Me.rbPersonalizada = New System.Windows.Forms.RadioButton()
        Me.rbCodFactura = New System.Windows.Forms.RadioButton()
        Me.tabsResultados = New System.Windows.Forms.TabControl()
        Me.tabCompras = New System.Windows.Forms.TabPage()
        Me.dataFacturas = New System.Windows.Forms.DataGridView()
        Me.tabProductos = New System.Windows.Forms.TabPage()
        Me.dataProductos = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtTotal = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblItems = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.tabsResultados.SuspendLayout()
        Me.tabCompras.SuspendLayout()
        CType(Me.dataFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabProductos.SuspendLayout()
        CType(Me.dataProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSalir)
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.cbRangoFechas)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.cmbProveedor)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbEstado)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtCodFactura)
        Me.GroupBox1.Controls.Add(Me.rbPersonalizada)
        Me.GroupBox1.Controls.Add(Me.rbCodFactura)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(281, 393)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Búsqueda"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(6, 341)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(129, 37)
        Me.btnSalir.TabIndex = 10
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(6, 298)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(129, 37)
        Me.btnLimpiar.TabIndex = 9
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(6, 255)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(129, 37)
        Me.btnBuscar.TabIndex = 8
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'cbRangoFechas
        '
        Me.cbRangoFechas.AutoSize = True
        Me.cbRangoFechas.Location = New System.Drawing.Point(26, 155)
        Me.cbRangoFechas.Name = "cbRangoFechas"
        Me.cbRangoFechas.Size = New System.Drawing.Size(142, 17)
        Me.cbRangoFechas.TabIndex = 7
        Me.cbRangoFechas.Text = "Incluir Rango de Fechas"
        Me.cbRangoFechas.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtFechaFin)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtFechaInicio)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(26, 174)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(246, 75)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'txtFechaFin
        '
        Me.txtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFechaFin.Location = New System.Drawing.Point(86, 43)
        Me.txtFechaFin.Name = "txtFechaFin"
        Me.txtFechaFin.Size = New System.Drawing.Size(138, 20)
        Me.txtFechaFin.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Hasta:"
        '
        'txtFechaInicio
        '
        Me.txtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFechaInicio.Location = New System.Drawing.Point(86, 17)
        Me.txtFechaInicio.Name = "txtFechaInicio"
        Me.txtFechaInicio.Size = New System.Drawing.Size(138, 20)
        Me.txtFechaInicio.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Desde:"
        '
        'cmbProveedor
        '
        Me.cmbProveedor.FormattingEnabled = True
        Me.cmbProveedor.Location = New System.Drawing.Point(100, 127)
        Me.cmbProveedor.Name = "cmbProveedor"
        Me.cmbProveedor.Size = New System.Drawing.Size(172, 21)
        Me.cmbProveedor.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Proveedor:"
        '
        'cmbEstado
        '
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Items.AddRange(New Object() {"PND", "VNC", "CNCL", "R", "ANL"})
        Me.cmbEstado.Location = New System.Drawing.Point(100, 100)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(172, 21)
        Me.cmbEstado.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Estado:"
        '
        'txtCodFactura
        '
        Me.txtCodFactura.Location = New System.Drawing.Point(26, 40)
        Me.txtCodFactura.Name = "txtCodFactura"
        Me.txtCodFactura.Size = New System.Drawing.Size(154, 20)
        Me.txtCodFactura.TabIndex = 2
        '
        'rbPersonalizada
        '
        Me.rbPersonalizada.AutoSize = True
        Me.rbPersonalizada.Location = New System.Drawing.Point(6, 79)
        Me.rbPersonalizada.Name = "rbPersonalizada"
        Me.rbPersonalizada.Size = New System.Drawing.Size(91, 17)
        Me.rbPersonalizada.TabIndex = 1
        Me.rbPersonalizada.Text = "Personalizada"
        Me.rbPersonalizada.UseVisualStyleBackColor = True
        '
        'rbCodFactura
        '
        Me.rbCodFactura.AutoSize = True
        Me.rbCodFactura.Checked = True
        Me.rbCodFactura.Location = New System.Drawing.Point(6, 17)
        Me.rbCodFactura.Name = "rbCodFactura"
        Me.rbCodFactura.Size = New System.Drawing.Size(112, 17)
        Me.rbCodFactura.TabIndex = 0
        Me.rbCodFactura.TabStop = True
        Me.rbCodFactura.Text = "Código de Factura"
        Me.rbCodFactura.UseVisualStyleBackColor = True
        '
        'tabsResultados
        '
        Me.tabsResultados.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.tabsResultados.Controls.Add(Me.tabCompras)
        Me.tabsResultados.Controls.Add(Me.tabProductos)
        Me.tabsResultados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabsResultados.Location = New System.Drawing.Point(290, 1)
        Me.tabsResultados.Name = "tabsResultados"
        Me.tabsResultados.SelectedIndex = 0
        Me.tabsResultados.Size = New System.Drawing.Size(909, 545)
        Me.tabsResultados.TabIndex = 1
        '
        'tabCompras
        '
        Me.tabCompras.Controls.Add(Me.dataFacturas)
        Me.tabCompras.Location = New System.Drawing.Point(4, 4)
        Me.tabCompras.Name = "tabCompras"
        Me.tabCompras.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCompras.Size = New System.Drawing.Size(901, 517)
        Me.tabCompras.TabIndex = 0
        Me.tabCompras.Text = "Compras Registradas"
        Me.tabCompras.UseVisualStyleBackColor = True
        '
        'dataFacturas
        '
        Me.dataFacturas.AllowUserToAddRows = False
        Me.dataFacturas.AllowUserToDeleteRows = False
        Me.dataFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataFacturas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataFacturas.Location = New System.Drawing.Point(3, 3)
        Me.dataFacturas.Name = "dataFacturas"
        Me.dataFacturas.ReadOnly = True
        Me.dataFacturas.Size = New System.Drawing.Size(895, 511)
        Me.dataFacturas.TabIndex = 0
        '
        'tabProductos
        '
        Me.tabProductos.Controls.Add(Me.dataProductos)
        Me.tabProductos.Location = New System.Drawing.Point(4, 4)
        Me.tabProductos.Name = "tabProductos"
        Me.tabProductos.Padding = New System.Windows.Forms.Padding(3)
        Me.tabProductos.Size = New System.Drawing.Size(901, 517)
        Me.tabProductos.TabIndex = 1
        Me.tabProductos.Text = "Productos Facturados"
        Me.tabProductos.UseVisualStyleBackColor = True
        '
        'dataProductos
        '
        Me.dataProductos.AllowUserToAddRows = False
        Me.dataProductos.AllowUserToDeleteRows = False
        Me.dataProductos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dataProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataProductos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataProductos.Location = New System.Drawing.Point(3, 3)
        Me.dataProductos.Name = "dataProductos"
        Me.dataProductos.ReadOnly = True
        Me.dataProductos.Size = New System.Drawing.Size(895, 511)
        Me.dataProductos.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtTotal)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.lblItems)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 401)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(281, 124)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Totales"
        '
        'txtTotal
        '
        Me.txtTotal.DecimalPlaces = 4
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTotal.Location = New System.Drawing.Point(6, 86)
        Me.txtTotal.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(266, 23)
        Me.txtTotal.TabIndex = 24
        Me.txtTotal.ThousandsSeparator = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 15)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Total Facturado"
        '
        'lblItems
        '
        Me.lblItems.AutoSize = True
        Me.lblItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItems.Location = New System.Drawing.Point(23, 33)
        Me.lblItems.Name = "lblItems"
        Me.lblItems.Size = New System.Drawing.Size(156, 17)
        Me.lblItems.TabIndex = 0
        Me.lblItems.Text = "0 Items Encontrados"
        '
        'frmConsultaCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1211, 558)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.tabsResultados)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmConsultaCompras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Compras"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.tabsResultados.ResumeLayout(False)
        Me.tabCompras.ResumeLayout(False)
        CType(Me.dataFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabProductos.ResumeLayout(False)
        CType(Me.dataProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbPersonalizada As System.Windows.Forms.RadioButton
    Friend WithEvents rbCodFactura As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbEstado As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCodFactura As System.Windows.Forms.TextBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents cbRangoFechas As System.Windows.Forms.CheckBox
    Friend WithEvents txtFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents tabsResultados As System.Windows.Forms.TabControl
    Friend WithEvents tabCompras As System.Windows.Forms.TabPage
    Friend WithEvents tabProductos As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblItems As System.Windows.Forms.Label
    Friend WithEvents dataFacturas As System.Windows.Forms.DataGridView
    Friend WithEvents dataProductos As System.Windows.Forms.DataGridView
    Public WithEvents txtTotal As System.Windows.Forms.NumericUpDown
End Class
