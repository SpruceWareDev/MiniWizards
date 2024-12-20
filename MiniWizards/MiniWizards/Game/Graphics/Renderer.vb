Public Class Renderer

    Private Shared INSTANCE As Renderer

    Private _form As GameForm
    Private _graphics As Graphics
    Private _renderSurface As Bitmap
    Private _pictureBox As PictureBox

    Public Sub Initialize(form As GameForm)
        _form = form
        ' Create picture box
        _pictureBox = New PictureBox()
        With _pictureBox
            .Dock = DockStyle.Fill
            .Size = _form.Size
        End With
        _form.Controls.Add(_pictureBox)

        ' Create render surface
        _renderSurface = New Bitmap(_pictureBox.Width, _pictureBox.Height)

        ' Create graphics
        _graphics = Graphics.FromImage(_renderSurface)
    End Sub

    Public Sub Render()
        _graphics.Clear(Color.Black)
        _graphics.FillRectangle(Brushes.Red, 0, 0, 100, 100)
        _pictureBox.Image = _renderSurface
    End Sub

    Public Sub OnResize()
        _pictureBox.Size = _form.Size
        _renderSurface = New Bitmap(_pictureBox.Width, _pictureBox.Height)
        _graphics = Graphics.FromImage(_renderSurface)
    End Sub

    Public Shared Function GetInstance() As Renderer
        If INSTANCE Is Nothing Then
            INSTANCE = New Renderer()
        End If
        Return INSTANCE
    End Function
End Class
