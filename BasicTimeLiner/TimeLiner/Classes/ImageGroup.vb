<Serializable()> Public Class ImageGroup
  Implements IComparable

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

  Public Property SubjectName As String

  Public Property Index As Integer

  Public Property Days As Integer

#End Region

#Region "Images"
  Public Function GetImage(height As Integer) As Bitmap
    Dim res As New Bitmap(height, height)

    Try
      Dim scale As Double = 1
      If _images.Count > 0 Then
        scale = _images(0).Bitmap.Width / _images(0).Bitmap.Height
      End If
      Dim width As Integer = scale * height
      res = New Bitmap(width, height)
      Dim g As Graphics = Graphics.FromImage(res)
      g.Clear(Color.Red)
      'només la primera

      Dim rows As Double = Math.Ceiling(Math.Sqrt(_images.Count))
      Dim _width As Double = width / rows
      Dim _height As Double = height / rows

      If rows = 1 Then
        Dim bmp As Bitmap = _images(0).Bitmap
        g.DrawImage(bmp, New Rectangle(0, 0, _width, _height))
      Else
        For index As Integer = 0 To _images.Count - 1
          Dim bmp As Bitmap = _images(index).Bitmap
          Dim row As Integer = index Mod rows
          Dim col As Integer = index \ rows

          g.DrawImage(bmp, New Rectangle(row * _width, col * _height, _width, _height))
        Next
      End If
      g.DrawString(Me.Days & " " & Me.GroupDate.Day & "-" & Me.GroupDate.Month & "-" & Me.GroupDate.Year, New Font("Verdana", 10), Brushes.Red, New PointF(0, 0))
      g.Dispose()


    Catch ex As Exception

    End Try
    Return res
  End Function

  Public Function CompareTo(obj As Object) As Integer Implements IComparable.CompareTo
    Dim res As Integer = 0
    Try
      Dim aux As ImageGroup = CType(obj, ImageGroup)
      If aux.Days > Me.Days Then
        res = -1
      Else
        res = 1
      End If
    Catch ex As Exception

    End Try
    Return res
    'Throw New NotImplementedException()
  End Function
#End Region


End Class
