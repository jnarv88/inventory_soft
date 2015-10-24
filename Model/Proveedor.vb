Namespace Model
    Public Class Proveedor

        Private idpr As Integer
        Private nom As String
        Private dir As String
        Private tel As String
        Private cel As String
        Private nomct1 As String
        Private celct1 As String
        Private nomct2 As String
        Private celct2 As String

        Property idProveedor As Integer
            Get
                Return Me.idpr
            End Get
            Set(ByVal value As Integer)
                Me.idpr = value
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
        Property direccion As String
            Get
                Return Me.dir
            End Get
            Set(ByVal value As String)
                Me.dir = value
            End Set
        End Property
        Property telefono As String
            Get
                Return Me.tel
            End Get
            Set(ByVal value As String)
                Me.tel = value
            End Set
        End Property
        Property celular As String
            Get
                Return Me.cel
            End Get
            Set(ByVal value As String)
                Me.cel = value
            End Set
        End Property
        Property contacto1 As String
            Get
                Return Me.nomct1
            End Get
            Set(ByVal value As String)
                Me.nomct1 = value
            End Set
        End Property
        Property celular_contacto1 As String
            Get
                Return Me.celct1
            End Get
            Set(ByVal value As String)
                Me.celct1 = value
            End Set
        End Property
        Property contacto2 As String
            Get
                Return Me.nomct2
            End Get
            Set(ByVal value As String)
                Me.nomct2 = value
            End Set
        End Property
        Property celular_contacto2 As String
            Get
                Return Me.celct2
            End Get
            Set(ByVal value As String)
                Me.celct2 = value
            End Set
        End Property
    End Class
End Namespace
