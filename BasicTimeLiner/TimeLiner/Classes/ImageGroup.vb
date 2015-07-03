<Serializable()> Public Class ImageGroup
  Public Sub New()

  End Sub

#Region "Properties"
  Private _nom As String
  Public Property Nom() As String
    Get
      Return _nom
    End Get
    Set(ByVal value As String)
      _nom = value
    End Set
  End Property

  Private _groupDate As Date
  Public Property GroupDate() As Date
    Get
      Return _groupDate
    End Get
    Set(ByVal value As Date)
      _groupDate = value
    End Set
  End Property

  Private _visible As Boolean = False
  Public Property Visible() As Boolean
    Get
      Return _visible
    End Get
    Set(ByVal value As Boolean)
      _visible = value
    End Set
  End Property

  Private _images As New List(Of ImageInfo)
    Public Property Images() As List(Of ImageInfo)
        Get
            Return _images
        End Get
        Set(ByVal value As List(Of ImageInfo))
            _images = value
        End Set
    End Property

    Public ReadOnly Property ImageCount As Integer
        Get
            Return _images.Count
        End Get
    End Property
#End Region

End Class
