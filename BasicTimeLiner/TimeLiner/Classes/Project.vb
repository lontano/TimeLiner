<Serializable()> Public Class TimeLine
  Public Sub New()

  End Sub

#Region "Properties"
  Private _nom As String = "undefined"
  Public Property Nom() As String
    Get
      Return _nom
    End Get
    Set(ByVal value As String)
      _nom = value
    End Set
  End Property

  Private _path As String = ""
  Public Property Path() As String
    Get
      Return _path
    End Get
    Set(ByVal value As String)
      _path = value
    End Set
  End Property

    Private _subjects As New List(Of Subject)
    Public Property Subjects() As List(Of Subject)
        Get
            Return _subjects
        End Get
        Set(ByVal value As List(Of Subject))
            _subjects = value
        End Set
    End Property

#End Region
End Class
