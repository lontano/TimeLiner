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

  Private _initDate As Date = New Date(2010, 07, 15)
  Public Property InitDate As Date
    Get
      Return _initDate
    End Get
    Set(value As Date)
      _initDate = value
    End Set
  End Property
#End Region

#Region "Image"
  Public Function GetImage(width As Integer, height As Integer) As Bitmap
    Dim res As Bitmap

    Try
      Dim groups As New List(Of ImageGroup)

      Dim minHeight As Integer = Integer.MaxValue
      Dim maxDays As Integer = Integer.MinValue
      Dim lastLeft As Double = 0
      Dim daysRight As Double = 0
      Dim dayScale As Double = 1
      Dim lastRight(_subjects.Count) As Double


      For index As Integer = 0 To _subjects.Count - 1
        Dim subject = _subjects(index)
        lastRight(index) = 0
        For Each group As ImageGroup In subject.ImageGroups
          group.SubjectName = subject.Nom
          group.Index = index
          maxDays = Math.Max(group.Days, maxDays)
          groups.Add(group)
          For Each imgInfo As ImageInfo In group.Images
            minHeight = Math.Min(imgInfo.Bitmap.Height, minHeight)
          Next
        Next
      Next

      minHeight = 300

      groups.Sort()
      res = New Bitmap(minHeight * groups.Count, minHeight * _subjects.Count)

      dayScale = (res.Width / maxDays) * 0.75

      Dim g As Graphics = Graphics.FromImage(res)
      g.Clear(Color.White)

      For index As Integer = 0 To groups.Count - 1
        Dim group As ImageGroup = groups(index)
        Dim bmp As Bitmap = group.GetImage(minHeight)

        Dim row As Integer = group.Index ' index Mod rows
        Dim col As Integer = index ' \ rows
        Dim left As Double = col * minHeight

        left = dayScale * group.Days
        left = Math.Max(left, lastRight(group.Index))

        lastLeft = left
        lastRight(group.Index) = left + bmp.Width

        g.DrawImage(bmp, New Rectangle(left, row * minHeight, bmp.Width, bmp.Height))
        bmp.Dispose()
      Next
      g.Dispose()

      If True Then
        Dim grayscale As New Imaging.ColorMatrix(New Single()() _
        {
            New Single() {0.299, 0.299, 0.299, 0, 0},
            New Single() {0.587, 0.587, 0.587, 0, 0},
            New Single() {0.114, 0.114, 0.114, 0, 0},
            New Single() {0, 0, 0, 1, 0},
            New Single() {0, 0, 0, 0, 1}
        })

        Dim bmpAux As New Bitmap(res)
        Dim imgattr As New Imaging.ImageAttributes()
        imgattr.SetColorMatrix(grayscale)
        Using g2 As Graphics = Graphics.FromImage(bmpAux)
          g2.DrawImage(bmpAux, New Rectangle(0, 0, bmpAux.Width, bmpAux.Height),
                    0, 0, bmpAux.Width, bmpAux.Height,
                    GraphicsUnit.Pixel, imgattr)
        End Using
        res = bmpAux
      End If
    Catch ex As Exception

    End Try
    Return res
  End Function
#End Region
End Class
