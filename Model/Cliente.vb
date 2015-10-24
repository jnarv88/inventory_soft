Namespace Model
    Public Class Cliente
        Private idcl As Integer
        Private cedul As String
        Private nomape As String
        Private tel As String
        Private cel1 As String
        Private cel2 As String
        Private dir As String

        Property idcliente As Integer
            Get
                Return Me.idcl
            End Get
            Set(ByVal value As Integer)
                Me.idcl = value
            End Set
        End Property
        Property cedula As String
            Get
                Return Me.cedul
            End Get
            Set(ByVal value As String)
                Me.cedul = value
            End Set
        End Property
        Property nombres_apellidos As String
            Get
                Return Me.nomape
            End Get
            Set(ByVal value As String)
                Me.nomape = value
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
        Property celular1 As String
            Get
                Return Me.cel1
            End Get
            Set(ByVal value As String)
                Me.cel1 = value
            End Set
        End Property
        Property celular2 As String
            Get
                Return Me.cel2
            End Get
            Set(ByVal value As String)
                Me.cel2 = value
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
    End Class
End Namespace

