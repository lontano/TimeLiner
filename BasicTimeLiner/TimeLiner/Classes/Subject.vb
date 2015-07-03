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

        Catch ex As Exception

        End Try
        Return _imageGroups.Count
    End Function

#End Region

#Region "Image groups"
    Public Function GetImageGroup(_date As Date, Optional _create As Boolean = True) As ImageGroup
        Dim res As ImageGroup = Nothing
        Try
            For Each imgGroup As ImageGroup In _imageGroups
                If imgGroup.GroupDate.Year = _date.Year And imgGroup.GroupDate.Month = _date.Month & imgGroup.GroupDate.Day = _date.Day Then
                    res = imgGroup
                    Exit For
                End If
            Next
            If res Is Nothing AndAlso _create Then
                res = New ImageGroup
                res.GroupDate = _date
                res.Nom = _date.Day & "-" & _date.Month & "-" & _date.Year
                _imageGroups.Add(res)
            End If
        Catch ex As Exception

        End Try
        Return res
    End Function
#End Region
End Class
