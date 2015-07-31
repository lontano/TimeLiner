Imports System.IO

<Serializable()> Public Class Subject
  Public Sub New()

  End Sub

#Region "Properties"
  Private _nom As String = ""
  Public Property Nom() As String
    Get
      Return _nom
    End Get
    Set(ByVal value As String)
      _nom = value
    End Set
  End Property

  Private _initDate As Date
  Public Property InitDate() As Date
    Get
      Return _initDate
    End Get
    Set(ByVal value As Date)
      _initDate = value
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

  Private _imageGroups As New List(Of ImageGroup)
  Public Property ImageGroups() As List(Of ImageGroup)
    Get
      Return _imageGroups
    End Get
    Set(ByVal value As List(Of ImageGroup))
      _imageGroups = value

    End Set
  End Property

  Private _images As New List(Of ImageInfo)
  Public Property Images() As List(Of ImageInfo)
    Set(value As List(Of ImageInfo))
      _images = value
    End Set
    Get
      Return _images
    End Get
  End Property

  Public ReadOnly Property ImageCount As Integer
    Get
      Dim res As Integer = 0
      For Each imgGroup As ImageGroup In _imageGroups
        res += imgGroup.ImageCount
      Next
      Return res
    End Get
  End Property

#End Region

#Region "Routines"
  Public Function UpdateImages() As Integer
    Try
      If Directory.Exists(_path) Then
        ' This path is a directory.
        ProcessDirectory(_path)
      Else
        Console.WriteLine("{0} is not a valid file or directory.", Path)
      End If
    Catch ex As Exception

    End Try
    Return _imageGroups.Count
  End Function

  Private Sub ProcessDirectory(ByVal targetDirectory As String)
    Dim fileEntries As String() = Directory.GetFiles(targetDirectory)
    ' Process the list of files found in the directory.
    Dim fileName As String
    For Each fileName In fileEntries
      ProcessFile(fileName)
    Next fileName
    Dim subdirectoryEntries As String() = Directory.GetDirectories(targetDirectory)
    ' Recurse into subdirectories of this directory.
    Dim subdirectory As String
    For Each subdirectory In subdirectoryEntries
      ProcessDirectory(subdirectory)
    Next subdirectory

  End Sub 'ProcessDirectory

  Private Sub ProcessFile(targetFile As String)
    Try
      Dim isImage As Boolean = False
      Select Case System.IO.Path.GetExtension(targetFile).ToUpper
        Case ".JPG", ".JPEG", ".PNG"
          isImage = True
      End Select
      If isImage Then
        Dim imgInfo As ImageInfo = Me.GetImageInfo(targetFile)
        'Me.Images.Add(imgInfo)
      End If
    Catch ex As Exception

    End Try
  End Sub
#End Region

#Region "Image functions"
  Public Function GetImageInfo(path As String) As ImageInfo
    Dim res As ImageInfo = Nothing
    For Each imgInfo As ImageInfo In _images
      If imgInfo.Path = path Then
        res = imgInfo
        Exit For
      End If
    Next
    If res Is Nothing Then
      res = New ImageInfo(path)
      _images.Add(res)
      Dim group As ImageGroup = Me.GetImageGroup(res)
      group.Images.Add(res)
    End If
    Return res
  End Function

  Public Function GetImageGroup(imgInfo As ImageInfo, Optional _create As Boolean = True) As ImageGroup
    Dim res As ImageGroup = Nothing
    Try
      res = Me.GetImageGroup(imgInfo.ImageDate, _create)

    Catch ex As Exception

    End Try
    Return res
  End Function


  Public Function GetImageGroup(_date As Date, Optional _create As Boolean = True) As ImageGroup
    Dim res As ImageGroup = Nothing
    Try
      For Each imgGroup As ImageGroup In _imageGroups
        If imgGroup.GroupDate.Year = _date.Year And imgGroup.GroupDate.Month = _date.Month And imgGroup.GroupDate.Day = _date.Day Then
          res = imgGroup
          Exit For
        End If
      Next
      If res Is Nothing AndAlso _create Then
        res = New ImageGroup
        res.GroupDate = _date
        res.Nom = _date.Day & "-" & _date.Month & "-" & _date.Year
        res.Days = _date.Subtract(Me.InitDate).Days
        _imageGroups.Add(res)
      End If
    Catch ex As Exception

    End Try
    Return res
  End Function

  Public Function GetImageGroup(_nom As String, Optional _create As Boolean = True) As ImageGroup
    Dim res As ImageGroup = Nothing
    Try
      For Each imgGroup As ImageGroup In _imageGroups
        If imgGroup.Nom = _nom Then
          res = imgGroup
          Exit For
        End If
      Next
      If res Is Nothing AndAlso _create Then
        res = New ImageGroup
        res.Nom = _nom
        _imageGroups.Add(res)
      End If
    Catch ex As Exception

    End Try
    Return res
  End Function
#End Region
End Class
