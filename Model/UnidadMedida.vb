Namespace Model
    Public Class UnidadMedida
        Private nom As String
        Property Nombre As String
            Get
                Return Me.nom
            End Get
            Set(ByVal value As String)
                Me.nom = value
            End Set
        End Property
    End Class
End Namespace

