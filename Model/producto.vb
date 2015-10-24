Namespace Model
    Public Class producto
        Private cod, ex As Integer
        Private barra, nom, um, desc, lab As String
        Private cto, prec, descto As Double

        Sub New()

        End Sub
        Property codigo As Integer
            Get
                Return Me.cod
            End Get
            Set(ByVal value As Integer)
                Me.cod = value
            End Set
        End Property
        Property existencia As Integer
            Get
                Return Me.ex
            End Get
            Set(ByVal value As Integer)
                Me.ex = value
            End Set
        End Property
        Property codigo_barra As String
            Get
                Return Me.barra
            End Get
            Set(ByVal value As String)
                Me.barra = value
            End Set
        End Property
        Property nombre_comercial As String
            Get
                Return Me.nom
            End Get
            Set(ByVal value As String)
                Me.nom = value
            End Set
        End Property
        Property unidad_medida As String
            Get
                Return Me.um
            End Get
            Set(ByVal value As String)
                Me.um = value
            End Set
        End Property
        Property descripcion As String
            Get
                Return Me.desc
            End Get
            Set(ByVal value As String)
                Me.desc = value
            End Set
        End Property
        Property laboratorio As String
            Get
                Return Me.lab
            End Get
            Set(ByVal value As String)
                Me.lab = value
            End Set
        End Property
        Property costo As Double
            Get
                Return Me.cto
            End Get
            Set(ByVal value As Double)
                Me.cto = value
            End Set
        End Property
        Property precio As Double
            Get
                Return Me.prec
            End Get
            Set(ByVal value As Double)
                Me.prec = value
            End Set
        End Property
    End Class
    'cosi no digas nada del diseño 
End Namespace


