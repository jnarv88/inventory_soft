Namespace Model
    Public Class Venta
        Private fact As String
        Private fech As DateTime
        Private idclie As Integer
        Private tip As String
        Private idus As String
        Private est As String
        Private dcode As List(Of String)
        Private dcant As List(Of Integer)
        Private dprec As List(Of Double)
        Private ddesc As List(Of Double)

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
        Property idcliente As Integer
            Get
                Return Me.idclie
            End Get
            Set(ByVal value As Integer)
                Me.idclie = value
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
        Property detallePrecios As List(Of Double)
            Get
                Return Me.dprec
            End Get
            Set(ByVal value As List(Of Double))
                Me.dprec = value
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
    End Class
End Namespace

