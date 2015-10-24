Namespace Model
    Public Class Compra
        Private fact As String
        Private fech As DateTime
        Private fechv As DateTime
        Private fechc As DateTime
        Private idpr As Integer
        Private tip As String
        Private idus As String
        Private est As String
        Private dcode As List(Of String)
        Private dcant As List(Of Integer)
        Private dbonif As List(Of Integer)
        Private dcost As List(Of Double)
        Private ddesc As List(Of Double)
        Private diva As List(Of Double)
        Private dsuger As List(Of Double)
        Private dtotal As List(Of Double)

        Property factura As String
            Get
                Return Me.fact
            End Get
            Set(ByVal value As String)
                Me.fact = value
            End Set
        End Property
        Property fecha As DateTime
            Get
                Return Me.fech
            End Get
            Set(ByVal value As DateTime)
                Me.fech = value
            End Set
        End Property
        Property fecha_vencimiento As DateTime
            Get
                Return Me.fechv
            End Get
            Set(ByVal value As DateTime)
                Me.fechv = value
            End Set
        End Property
        Property fecha_cancelacion As DateTime
            Get
                Return Me.fechc
            End Get
            Set(ByVal value As DateTime)
                Me.fechc = value
            End Set
        End Property
        Property idproveedor As Integer
            Get
                Return Me.idpr
            End Get
            Set(ByVal value As Integer)
                Me.idpr = value
            End Set
        End Property
        Property tipo As String
            Get
                Return Me.tip
            End Get
            Set(ByVal value As String)
                Me.tip = value
            End Set
        End Property
        Property idusuario As String
            Get
                Return Me.idus
            End Get
            Set(ByVal value As String)
                Me.idus = value
            End Set
        End Property
        Property estado As String
            Get
                Return Me.est
            End Get
            Set(ByVal value As String)
                Me.est = value
            End Set
        End Property
        Property detalleCodigos As List(Of String)
            Get
                Return Me.dcode
            End Get
            Set(ByVal value As List(Of String))
                Me.dcode = value
            End Set
        End Property
        Property detalleCants As List(Of Integer)
            Get
                Return Me.dcant
            End Get
            Set(ByVal value As List(Of Integer))
                Me.dcant = value
            End Set
        End Property
        Property detalleBonifs As List(Of Integer)
            Get
                Return Me.dbonif
            End Get
            Set(ByVal value As List(Of Integer))
                Me.dbonif = value
            End Set
        End Property
        Property detalleCostos As List(Of Double)
            Get
                Return Me.dcost
            End Get
            Set(ByVal value As List(Of Double))
                Me.dcost = value
            End Set
        End Property
        Property detalleDesctos As List(Of Double)
            Get
                Return Me.ddesc
            End Get
            Set(ByVal value As List(Of Double))
                Me.ddesc = value
            End Set
        End Property
        Property detalleIva As List(Of Double)
            Get
                Return Me.diva
            End Get
            Set(ByVal value As List(Of Double))
                Me.diva = value
            End Set
        End Property
        Property detalleSugeridos As List(Of Double)
            Get
                Return Me.dsuger
            End Get
            Set(ByVal value As List(Of Double))
                Me.dsuger = value
            End Set
        End Property
        Property detalleTotales As List(Of Double)
            Get
                Return Me.dtotal
            End Get
            Set(ByVal value As List(Of Double))
                Me.dtotal = value
            End Set
        End Property
    End Class
End Namespace


