<Serializable()> Public Class ImageInfo
  Public Sub New()

  End Sub

  Public Sub New(path As String)
    _path = path
    GetFileInfo
  End Sub

  Private Sub GetFileInfo()
    Try

    Catch ex As Exception

    End Try
  End Sub


#Region "Properties"

  Private _path As String
  Public Property Path() As String
    Get
      Return _path
    End Get
    Set(ByVal value As String)
      _path = value
    End Set
  End Property

  Private _nom As String
  Public Property Nom() As String
    Get
      Return _nom
    End Get
    Set(ByVal value As String)
      _nom = value
    End Set
  End Property

  Private _imageDate As Date
  Public Property ImageDate() As Date
    Get
      Return _imageDate
    End Get
    Set(ByVal value As Date)
      _imageDate = value
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

  Private _bitmap As Bitmap
  <Xml.Serialization.XmlIgnoreAttribute()> Public Property Bitmap As Bitmap
    Set(value As Bitmap)
      _bitmap = value
    End Set
    Get
      If _bitmap Is Nothing And System.IO.File.Exists(_path) Then
        _bitmap = New Bitmap(_path)
      End If
      Return _bitmap
    End Get
  End Property
#End Region
End Class
