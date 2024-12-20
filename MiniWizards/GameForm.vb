Public Class GameForm

    Private _game As Game

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _game = New Game()
        _game.Initialize(Me)
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        _game.OnClose()
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If Not _game Is Nothing Then
            Renderer.GetInstance().OnResize()
        End If
    End Sub
End Class
