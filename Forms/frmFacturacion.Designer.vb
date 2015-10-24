<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFacturacion
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
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbCred = New System.Windows.Forms.RadioButton()
        Me.rbCont = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtClient = New System.Windows.Forms.TextBox()
        Me.btnFindClie = New System.Windows.Forms.Button()
        Me.txtCodClie = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNumfact = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DataProductos = New System.Windows.Forms.DataGridView()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtDisponibles = New System.Windows.Forms.NumericUpDown()
        Me.Disponibles = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtPrecio = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCant = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtProd = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnFindProd = New System.Windows.Forms.Button()
        Me.txtNumProd = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBarra = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnFacturar = New System.Windows.Forms.Button()
        Me.lblItems = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.NumericUpDown()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtDescuentoTot = New System.Windows.Forms.NumericUpDown()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtSubTotal = New System.Windows.Forms.NumericUpDown()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.txtDisponibles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCant, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescuentoTot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSubTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbCred)
        Me.GroupBox1.Controls.Add(Me.rbCont)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.txtFecha)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNumfact)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(775, 106)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'rbCred
        '
        Me.rbCred.AutoSize = True
        Me.rbCred.Location = New System.Drawing.Point(265, 63)
        Me.rbCred.Name = "rbCred"
        Me.rbCred.Size = New System.Drawing.Size(58, 17)
        Me.rbCred.TabIndex = 1
        Me.rbCred.Text = "Credito"
        Me.rbCred.UseVisualStyleBackColor = True
        '
        'rbCont
        '
        Me.rbCont.AutoSize = True
        Me.rbCont.Checked = True
        Me.rbCont.Location = New System.Drawing.Point(265, 40)
        Me.rbCont.Name = "rbCont"
        Me.rbCont.Size = New System.Drawing.Size(65, 17)
        Me.rbCont.TabIndex = 0
        Me.rbCont.TabStop = True
        Me.rbCont.Text = "Contado"
        Me.rbCont.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtClient)
        Me.GroupBox2.Controls.Add(Me.btnFindClie)
        Me.GroupBox2.Controls.Add(Me.txtCodClie)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(336, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(425, 83)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Cliente"
        '
        'txtClient
        '
        Me.txtClient.BackColor = System.Drawing.Color.White
        Me.txtClient.Enabled = False
        Me.txtClient.Location = New System.Drawing.Point(21, 57)
        Me.txtClient.Name = "txtClient"
        Me.txtClient.Size = New System.Drawing.Size(391, 20)
        Me.txtClient.TabIndex = 3
        Me.txtClient.Text = "CLIENTE CONTADO"
        '
        'btnFindClie
        '
        Me.btnFindClie.Location = New System.Drawing.Point(182, 29)
        Me.btnFindClie.Name = "btnFindClie"
        Me.btnFindClie.Size = New System.Drawing.Size(75, 23)
        Me.btnFindClie.TabIndex = 2
        Me.btnFindClie.Text = "Buscar (F2)"
        Me.btnFindClie.UseVisualStyleBackColor = True
        '
        'txtCodClie
        '
        Me.txtCodClie.Location = New System.Drawing.Point(67, 31)
        Me.txtCodClie.Name = "txtCodClie"
        Me.txtCodClie.Size = New System.Drawing.Size(90, 20)
        Me.txtCodClie.TabIndex = 1
        Me.txtCodClie.Text = "1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Codigo:"
        '
        'txtFecha
        '
        Me.txtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFecha.Location = New System.Drawing.Point(52, 70)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(157, 20)
        Me.txtFecha.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha:"
        '
        'txtNumfact
        '
        Me.txtNumfact.BackColor = System.Drawing.Color.White
        Me.txtNumfact.Enabled = False
        Me.txtNumfact.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumfact.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtNumfact.Location = New System.Drawing.Point(9, 35)
        Me.txtNumfact.Name = "txtNumfact"
        Me.txtNumfact.Size = New System.Drawing.Size(200, 22)
        Me.txtNumfact.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Factura:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DataProductos)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 111)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(775, 365)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Detalle de Productos"
        '
        'DataProductos
        '
        Me.DataProductos.AllowUserToAddRows = False
        Me.DataProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column4, Me.Column1, Me.Column2, Me.Column3, Me.Column5, Me.Column6, Me.Column7})
        Me.DataProductos.Location = New System.Drawing.Point(9, 125)
        Me.DataProductos.Name = "DataProductos"
        Me.DataProductos.ReadOnly = True
        Me.DataProductos.Size = New System.Drawing.Size(752, 231)
        Me.DataProductos.TabIndex = 1
        '
        'Column4
        '
        DataGridViewCellStyle17.Format = "N2"
        DataGridViewCellStyle17.NullValue = "0"
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle17
        Me.Column4.HeaderText = "Cantidad"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "Codigo"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Barra"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Producto"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column5
        '
        DataGridViewCellStyle18.Format = "N2"
        DataGridViewCellStyle18.NullValue = "0"
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle18
        Me.Column5.HeaderText = "Precio"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        DataGridViewCellStyle19.Format = "N2"
        DataGridViewCellStyle19.NullValue = "0"
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle19
        Me.Column6.HeaderText = "Descuento"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        DataGridViewCellStyle20.BackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle20.Format = "N2"
        DataGridViewCellStyle20.NullValue = "0"
        Me.Column7.DefaultCellStyle = DataGridViewCellStyle20
        Me.Column7.HeaderText = "Total"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtDisponibles)
        Me.GroupBox4.Controls.Add(Me.Disponibles)
        Me.GroupBox4.Controls.Add(Me.btnAdd)
        Me.GroupBox4.Controls.Add(Me.txtPrecio)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.txtCant)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.txtProd)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.btnFindProd)
        Me.GroupBox4.Controls.Add(Me.txtNumProd)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.txtBarra)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Location = New System.Drawing.Point(9, 13)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(752, 107)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        '
        'txtDisponibles
        '
        Me.txtDisponibles.Location = New System.Drawing.Point(109, 78)
        Me.txtDisponibles.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.txtDisponibles.Name = "txtDisponibles"
        Me.txtDisponibles.ReadOnly = True
        Me.txtDisponibles.Size = New System.Drawing.Size(104, 20)
        Me.txtDisponibles.TabIndex = 15
        Me.txtDisponibles.ThousandsSeparator = True
        '
        'Disponibles
        '
        Me.Disponibles.AutoSize = True
        Me.Disponibles.Location = New System.Drawing.Point(44, 80)
        Me.Disponibles.Name = "Disponibles"
        Me.Disponibles.Size = New System.Drawing.Size(64, 13)
        Me.Disponibles.TabIndex = 14
        Me.Disponibles.Text = "Disponibles:"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(664, 18)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 68)
        Me.btnAdd.TabIndex = 13
        Me.btnAdd.Text = "Agregar"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtPrecio
        '
        Me.txtPrecio.DecimalPlaces = 2
        Me.txtPrecio.Location = New System.Drawing.Point(493, 78)
        Me.txtPrecio.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(133, 20)
        Me.txtPrecio.TabIndex = 12
        Me.txtPrecio.ThousandsSeparator = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(428, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Precio Unit:"
        '
        'txtCant
        '
        Me.txtCant.Location = New System.Drawing.Point(285, 78)
        Me.txtCant.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.txtCant.Name = "txtCant"
        Me.txtCant.Size = New System.Drawing.Size(116, 20)
        Me.txtCant.TabIndex = 10
        Me.txtCant.ThousandsSeparator = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(230, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Cantidad:"
        '
        'txtProd
        '
        Me.txtProd.BackColor = System.Drawing.Color.White
        Me.txtProd.Enabled = False
        Me.txtProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProd.Location = New System.Drawing.Point(312, 17)
        Me.txtProd.Multiline = True
        Me.txtProd.Name = "txtProd"
        Me.txtProd.Size = New System.Drawing.Size(346, 54)
        Me.txtProd.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(253, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Producto:"
        '
        'btnFindProd
        '
        Me.btnFindProd.Location = New System.Drawing.Point(138, 38)
        Me.btnFindProd.Name = "btnFindProd"
        Me.btnFindProd.Size = New System.Drawing.Size(75, 23)
        Me.btnFindProd.TabIndex = 4
        Me.btnFindProd.Text = "Buscar (F3)"
        Me.btnFindProd.UseVisualStyleBackColor = True
        '
        'txtNumProd
        '
        Me.txtNumProd.Location = New System.Drawing.Point(68, 40)
        Me.txtNumProd.Name = "txtNumProd"
        Me.txtNumProd.Size = New System.Drawing.Size(64, 20)
        Me.txtNumProd.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Num Prod."
        '
        'txtBarra
        '
        Me.txtBarra.Location = New System.Drawing.Point(68, 13)
        Me.txtBarra.Name = "txtBarra"
        Me.txtBarra.Size = New System.Drawing.Size(145, 20)
        Me.txtBarra.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Barra:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtTotal)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.txtDescuentoTot)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.txtSubTotal)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.btnCancel)
        Me.GroupBox5.Controls.Add(Me.btnFacturar)
        Me.GroupBox5.Controls.Add(Me.lblItems)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 480)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(775, 103)
        Me.GroupBox5.TabIndex = 14
        Me.GroupBox5.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(627, 65)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(124, 35)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancelar (Esc)"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnFacturar
        '
        Me.btnFacturar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFacturar.Location = New System.Drawing.Point(627, 19)
        Me.btnFacturar.Name = "btnFacturar"
        Me.btnFacturar.Size = New System.Drawing.Size(124, 35)
        Me.btnFacturar.TabIndex = 2
        Me.btnFacturar.Text = "Facturar (F5)"
        Me.btnFacturar.UseVisualStyleBackColor = True
        '
        'lblItems
        '
        Me.lblItems.AutoSize = True
        Me.lblItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItems.Location = New System.Drawing.Point(410, 19)
        Me.lblItems.Name = "lblItems"
        Me.lblItems.Size = New System.Drawing.Size(0, 16)
        Me.lblItems.TabIndex = 0
        '
        'txtTotal
        '
        Me.txtTotal.DecimalPlaces = 4
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTotal.Location = New System.Drawing.Point(101, 73)
        Me.txtTotal.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(190, 23)
        Me.txtTotal.TabIndex = 31
        Me.txtTotal.ThousandsSeparator = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(8, 73)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(50, 17)
        Me.Label16.TabIndex = 30
        Me.Label16.Text = "Total:"
        '
        'txtDescuentoTot
        '
        Me.txtDescuentoTot.DecimalPlaces = 4
        Me.txtDescuentoTot.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescuentoTot.ForeColor = System.Drawing.Color.Black
        Me.txtDescuentoTot.Location = New System.Drawing.Point(101, 43)
        Me.txtDescuentoTot.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.txtDescuentoTot.Name = "txtDescuentoTot"
        Me.txtDescuentoTot.Size = New System.Drawing.Size(190, 23)
        Me.txtDescuentoTot.TabIndex = 27
        Me.txtDescuentoTot.ThousandsSeparator = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(8, 45)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(90, 17)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Descuento:"
        '
        'txtSubTotal
        '
        Me.txtSubTotal.DecimalPlaces = 4
        Me.txtSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTotal.ForeColor = System.Drawing.Color.Black
        Me.txtSubTotal.Location = New System.Drawing.Point(101, 14)
        Me.txtSubTotal.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Size = New System.Drawing.Size(190, 23)
        Me.txtSubTotal.TabIndex = 25
        Me.txtSubTotal.ThousandsSeparator = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(8, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(73, 17)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "SubTotal"
        '
        'frmFacturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 593)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmFacturacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturacion"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.txtDisponibles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCant, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescuentoTot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSubTotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNumfact As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rbCred As System.Windows.Forms.RadioButton
    Friend WithEvents rbCont As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnFindClie As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnFindProd As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCant As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents DataProductos As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnFacturar As System.Windows.Forms.Button
    Friend WithEvents lblItems As System.Windows.Forms.Label
    Public WithEvents txtBarra As System.Windows.Forms.TextBox
    Public WithEvents txtNumProd As System.Windows.Forms.TextBox
    Public WithEvents txtProd As System.Windows.Forms.TextBox
    Public WithEvents txtPrecio As System.Windows.Forms.NumericUpDown
    Public WithEvents txtClient As System.Windows.Forms.TextBox
    Public WithEvents txtCodClie As System.Windows.Forms.TextBox
    Friend WithEvents Disponibles As System.Windows.Forms.Label
    Public WithEvents txtDisponibles As System.Windows.Forms.NumericUpDown
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Public WithEvents txtTotal As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Public WithEvents txtDescuentoTot As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Public WithEvents txtSubTotal As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
