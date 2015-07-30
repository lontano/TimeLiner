Imports System.IO
Imports System.Text

<Serializable()> Public Class ImageInfo
  Public Sub New()

  End Sub

  Public Sub New(path As String)
    _path = path
    GetFileInfo()
  End Sub

  Private Sub GetFileInfo()
    Try
      If System.IO.File.Exists(_path) Then
        Me.ImageDate = System.IO.File.GetLastWriteTime(_path)

        'Create an Image object. 
        Dim image As Bitmap = New Bitmap(_path)
        Dim pic_time As Imaging.PropertyItem
        Dim Str_pic_time As String


        'Get the PropertyItems property from image. 
        Dim propItems As Imaging.PropertyItem() = image.PropertyItems
        pic_time = image.GetPropertyItem(36867)
        Str_pic_time = Encoding.ASCII.GetString(pic_time.Value, 0, pic_time.Len - 1)
        Str_pic_time = Str_pic_time.Replace(" ", ":")
        Dim asAux() As String = Str_pic_time.Split(":")
        Me.ImageDate = New Date(asAux(0), asAux(1), asAux(2), asAux(3), asAux(4), asAux(5))

      End If
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
        If _bitmap.Width > 0 And _bitmap.Height > 0 Then
          _thumbnail = New Bitmap(64, 64)
          Dim g As Graphics = Graphics.FromImage(_thumbnail)
          g.DrawImage(_bitmap, 0, 0, 64, 64)
          g.Dispose()
        End If
      End If
      Return _bitmap
    End Get
  End Property

  Private _thumbnail As New Bitmap(64, 64)
  Public Property Thumbnail As Bitmap
    Get
      Return _thumbnail
    End Get
    Set(value As Bitmap)
      _thumbnail = value
    End Set
  End Property
#End Region
End Class
